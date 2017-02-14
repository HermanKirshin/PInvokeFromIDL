using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Win32;

namespace TestApp
{
    internal class MainWindow
    {
        private IUserNotification notification;

        internal unsafe MainWindow()
        {
            IntPtr handle;
            WNDCLASSEX windowClass = new WNDCLASSEX();
            windowClass.cbSize = (uint)WNDCLASSEX.GetSize();

            fixed (char* stringPointer = "WindowClass".ToCharArray())
            {
                windowClass.style = NativeConstants.CS_HREDRAW | NativeConstants.CS_VREDRAW;
                windowClass.lpfnWndProc = (WNDPROC)WndProc;
                windowClass.cbClsExtra = 0;
                windowClass.cbWndExtra = 0;
                windowClass.hInstance = NativeMethods.GetModuleHandle((char*)null);
                windowClass.lpszClassName = stringPointer;
            }
            
            if (NativeMethods.RegisterClassEx(&windowClass) == 0)
                throw new InvalidOperationException();

            RECT rectangle = new RECT
            {
                left = 0,
                top = 0,
                right = 640,
                bottom = 480
            };

            NativeMethods.AdjustWindowRect(&rectangle, NativeConstants.WS_OVERLAPPEDWINDOW, false);

            fixed (char* title = "TestApp".ToCharArray())
            {
                handle = NativeMethods.CreateWindowEx(0, windowClass.lpszClassName, title, NativeConstants.WS_OVERLAPPEDWINDOW,
                    NativeConstants.CW_USEDEFAULT, NativeConstants.CW_USEDEFAULT, rectangle.right - rectangle.left, rectangle.bottom - rectangle.top,
                    IntPtr.Zero, IntPtr.Zero, windowClass.hInstance, null);
            }

            if (handle == IntPtr.Zero)
                throw new InvalidOperationException();

            NativeMethods.ShowWindow(handle, (int)NativeConstants.SW_SHOW);
        }

        private unsafe IntPtr WndProc(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
        {
            switch (uMsg)
            {
                case NativeConstants.WM_CREATE:
                    Guid clsid = new Guid(NativeConstants.CLSID_UserNotification);
                    Guid iid = IUserNotification.IID;
                    IUserNotification notification;

                    int status = NativeMethods.CoCreateInstance(&clsid, null, (uint)CLSCTX.CLSCTX_LOCAL_SERVER, &iid, (void**)&notification);

                    if (status == 0)
                    {
                        this.notification = notification;

                        fixed (char* title = "TestApp")
                        fixed (char* text = "Hello from COM")
                        {
                            notification.SetBalloonInfo(title, text, 0);
                        }

                        notification.Show(null, 0);
                    }

                    break;
                case NativeConstants.WM_PAINT:
                    PAINTSTRUCT paintArguments;
                    IntPtr hdc = NativeMethods.BeginPaint(hWnd, &paintArguments);
                    NativeMethods.EndPaint(hWnd, &paintArguments);
                    break;

                case NativeConstants.WM_DESTROY:
                    
                    (this.notification as IDisposable).Dispose();

                    NativeMethods.PostQuitMessage(0);
                    break;

                default:
                    return NativeMethods.DefWindowProc(hWnd, uMsg, wParam, lParam);
            }

            return IntPtr.Zero;
        }

        private unsafe static void Main()
        {
            MainWindow mainWindow = new MainWindow();
            
            MSG message = new MSG();
            while (message.message != NativeConstants.WM_QUIT)
            {
                if (NativeMethods.PeekMessage(&message, IntPtr.Zero, 0, 0, NativeConstants.PM_REMOVE))
                {
                    NativeMethods.TranslateMessage(&message);
                    NativeMethods.DispatchMessage(&message);
                }
            }
        }
    }
}

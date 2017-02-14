using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace Win32
{
    public unsafe delegate IntPtr _WNDPROC(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

    public enum CLSCTX
    {
        CLSCTX_INPROC_SERVER = 1,
        CLSCTX_INPROC_HANDLER = 2,
        CLSCTX_LOCAL_SERVER = 4,
        CLSCTX_INPROC_SERVER16 = 8,
        CLSCTX_REMOTE_SERVER = 16,
        CLSCTX_INPROC_HANDLER16 = 32,
        CLSCTX_RESERVED1 = 64,
        CLSCTX_RESERVED2 = 128,
        CLSCTX_RESERVED3 = 256,
        CLSCTX_RESERVED4 = 512,
        CLSCTX_NO_CODE_DOWNLOAD = 1024,
        CLSCTX_RESERVED5 = 2048,
        CLSCTX_NO_CUSTOM_MARSHAL = 4096,
        CLSCTX_ENABLE_CODE_DOWNLOAD = 8192,
        CLSCTX_NO_FAILURE_LOG = 16384,
        CLSCTX_DISABLE_AAA = 32768,
        CLSCTX_ENABLE_AAA = 65536,
        CLSCTX_FROM_DEFAULT_CONTEXT = 131072,
        CLSCTX_ACTIVATE_32_BIT_SERVER = 262144,
        CLSCTX_ACTIVATE_64_BIT_SERVER = 524288,
        CLSCTX_ENABLE_CLOAKING = 1048576,
        CLSCTX_ACTIVATE_SBX_SANDBOX = 2097152,
        CLSCTX_APPCONTAINER = 4194304,
        CLSCTX_ACTIVATE_AAA_AS_IU = 8388608,
        CLSCTX_PS_DLL = -2147483648
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct LOGFONTW
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        public unsafe struct Array1D_ushort_32
        {
            private const int length0 = 32;

            private fixed ushort data[32];

            public unsafe ushort this[int index0]
            {
                get
                {
                    fixed (ushort* pointer = data)
                    {
                        return pointer[index0];
                    }
                }
                set
                {
                    fixed (ushort* pointer = data)
                    {
                        pointer[index0] = value;
                    }
                }
            }

            public static unsafe implicit operator ushort[](Array1D_ushort_32 value)
            {
                ushort[] result = new ushort[32];
                ushort* pointer = value.data;
                {
                    for (int i = 0; i < 32; i++)
                        result[i] = pointer[i];
                }
                return result;
            }

            public static unsafe implicit operator Array1D_ushort_32(ushort[] value)
            {
                if (value == null)
                   throw new ArgumentNullException("value");
                Array1D_ushort_32 result = new Array1D_ushort_32();
                ushort* pointer = result.data;
                for (int i = 0; i < ((value.Length < 32) ? value.Length : 32); i++)
                    pointer[i] = value[i];
                return result;
            }
        }

        public int lfHeight;
        public int lfWidth;
        public int lfEscapement;
        public int lfOrientation;
        public int lfWeight;
        public byte lfItalic;
        public byte lfUnderline;
        public byte lfStrikeOut;
        public byte lfCharSet;
        public byte lfOutPrecision;
        public byte lfClipPrecision;
        public byte lfQuality;
        public byte lfPitchAndFamily;
        public Array1D_ushort_32 lfFaceName;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(LOGFONTW));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is LOGFONTW))
                return false;
            fixed (LOGFONTW* address = &this)
            {
                LOGFONTW other = (LOGFONTW)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (LOGFONTW* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(LOGFONTW left, LOGFONTW right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(LOGFONTW left, LOGFONTW right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct MSG
    {
        public IntPtr hwnd;
        public uint message;
        public IntPtr wParam;
        public IntPtr lParam;
        public uint time;
        public POINT pt;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(MSG));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is MSG))
                return false;
            fixed (MSG* address = &this)
            {
                MSG other = (MSG)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (MSG* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(MSG left, MSG right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(MSG left, MSG right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct PAINTSTRUCT
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        public unsafe struct Array1D_byte_32
        {
            private const int length0 = 32;

            private fixed byte data[32];

            public unsafe byte this[int index0]
            {
                get
                {
                    fixed (byte* pointer = data)
                    {
                        return pointer[index0];
                    }
                }
                set
                {
                    fixed (byte* pointer = data)
                    {
                        pointer[index0] = value;
                    }
                }
            }

            public static unsafe implicit operator byte[](Array1D_byte_32 value)
            {
                byte[] result = new byte[32];
                byte* pointer = value.data;
                {
                    for (int i = 0; i < 32; i++)
                        result[i] = pointer[i];
                }
                return result;
            }

            public static unsafe implicit operator Array1D_byte_32(byte[] value)
            {
                if (value == null)
                   throw new ArgumentNullException("value");
                Array1D_byte_32 result = new Array1D_byte_32();
                byte* pointer = result.data;
                for (int i = 0; i < ((value.Length < 32) ? value.Length : 32); i++)
                    pointer[i] = value[i];
                return result;
            }
        }

        public IntPtr hdc;
        public BOOL fErase;
        public RECT rcPaint;
        public BOOL fRestore;
        public BOOL fIncUpdate;
        public Array1D_byte_32 rgbReserved;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(PAINTSTRUCT));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is PAINTSTRUCT))
                return false;
            fixed (PAINTSTRUCT* address = &this)
            {
                PAINTSTRUCT other = (PAINTSTRUCT)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (PAINTSTRUCT* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(PAINTSTRUCT left, PAINTSTRUCT right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(PAINTSTRUCT left, PAINTSTRUCT right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct WNDCLASSEX
    {
        public uint cbSize;
        public uint style;
        public WNDPROC lpfnWndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        public IntPtr hInstance;
        public IntPtr hIcon;
        public IntPtr hCursor;
        public IntPtr hbrBackground;
        public char* lpszMenuName;
        public char* lpszClassName;
        public IntPtr hIconSm;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(WNDCLASSEX));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is WNDCLASSEX))
                return false;
            fixed (WNDCLASSEX* address = &this)
            {
                WNDCLASSEX other = (WNDCLASSEX)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (WNDCLASSEX* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(WNDCLASSEX left, WNDCLASSEX right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(WNDCLASSEX left, WNDCLASSEX right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [ComImport]
    [Guid("7307055c-b24a-486b-9f25-163e597a28a9")]
    public unsafe interface _IQueryContinue : _IUnknown
    {
        [PreserveSig]
        unsafe new int QueryInterface(Guid* riid, IUnknown* ppvObject);

        [PreserveSig]
        unsafe new uint AddRef();

        [PreserveSig]
        unsafe new uint Release();

        [PreserveSig]
        unsafe int QueryContinue();
    }

    [ComImport]
    [Guid("ba9711ba-5893-4787-a7e1-41277151550b")]
    public unsafe interface _IUserNotification : _IUnknown
    {
        [PreserveSig]
        unsafe new int QueryInterface(Guid* riid, IUnknown* ppvObject);

        [PreserveSig]
        unsafe new uint AddRef();

        [PreserveSig]
        unsafe new uint Release();

        [PreserveSig]
        unsafe int SetBalloonInfo(char* pszTitle, char* pszText, uint dwInfoFlags);

        [PreserveSig]
        unsafe int SetBalloonRetry(uint dwShowTime, uint dwInterval, uint cRetryCount);

        [PreserveSig]
        unsafe int SetIconInfo(IntPtr hIcon, char* pszToolTip);

        [PreserveSig]
        unsafe int Show(IQueryContinue pqc, uint dwContinuePollInterval);

        [PreserveSig]
        unsafe int PlaySound(char* pszSoundName);
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public unsafe struct IQueryContinue : _IQueryContinue, _IUnknown, IDisposable
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        private unsafe struct IQueryContinue_vtbl
        {
            internal IntPtr method_0;
            internal IntPtr method_1;
            internal IntPtr method_2;
            internal IntPtr method_3;
        }

        private unsafe delegate int delegate_0(IQueryContinue_vtbl** @this, Guid* riid, IUnknown* ppvObject);
        private unsafe delegate uint delegate_1(IQueryContinue_vtbl** @this);
        private unsafe delegate uint delegate_2(IQueryContinue_vtbl** @this);
        private unsafe delegate int delegate_3(IQueryContinue_vtbl** @this);

        private readonly void* reference;
        private static readonly Guid iid = new Guid("7307055c-b24a-486b-9f25-163e597a28a9");

        public static unsafe Guid IID
        {
            get
            {
                return iid;
            }
        }

        public unsafe int QueryInterface(Guid* riid, IUnknown* ppvObject)
        {
            IQueryContinue_vtbl** @this = (IQueryContinue_vtbl**)reference;
            IQueryContinue_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_0, typeof(delegate_0));
            delegate_0 method = (delegate_0)genericDelegate;
            return method(@this, riid, ppvObject);
        }

        public unsafe uint AddRef()
        {
            IQueryContinue_vtbl** @this = (IQueryContinue_vtbl**)reference;
            IQueryContinue_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_1, typeof(delegate_1));
            delegate_1 method = (delegate_1)genericDelegate;
            return method(@this);
        }

        public unsafe uint Release()
        {
            IQueryContinue_vtbl** @this = (IQueryContinue_vtbl**)reference;
            IQueryContinue_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_2, typeof(delegate_2));
            delegate_2 method = (delegate_2)genericDelegate;
            return method(@this);
        }

        public unsafe int QueryContinue()
        {
            IQueryContinue_vtbl** @this = (IQueryContinue_vtbl**)reference;
            IQueryContinue_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_3, typeof(delegate_3));
            delegate_3 method = (delegate_3)genericDelegate;
            return method(@this);
        }

        void IDisposable.Dispose()
        {
            while ((reference != null) && (Release() > 0))
            {
            }
        }

        public unsafe IQueryContinue(IntPtr value)
        {
            reference = (void*)value;
        }

        public unsafe IQueryContinue(void* value)
        {
            reference = value;
        }

        public static unsafe explicit operator IQueryContinue(IUnknown value)
        {
            return new IQueryContinue(*((void**)(&value)));
        }

        public static unsafe implicit operator IUnknown(IQueryContinue value)
        {
            return new IUnknown(value.reference);
        }

        public static unsafe implicit operator IntPtr(IQueryContinue value)
        {
            return new IntPtr(value.reference);
        }

        public static unsafe implicit operator void*(IQueryContinue value)
        {
            return value.reference;
        }

        public static unsafe implicit operator IQueryContinue(IntPtr value)
        {
            return new IQueryContinue(value);
        }

        public static unsafe implicit operator IQueryContinue(void* value)
        {
            return new IQueryContinue(value);
        }

        public unsafe override bool Equals(object obj)
        {
            IQueryContinue other = (IQueryContinue)obj;
            return reference == other.reference;
        }

        public unsafe override int GetHashCode()
        {
            return new IntPtr(reference).GetHashCode();
        }

        public unsafe static bool operator ==(IQueryContinue left, IQueryContinue right)
        {
            return left.reference == right.reference;
        }

        public unsafe static bool operator !=(IQueryContinue left, IQueryContinue right)
        {
            return left.reference != right.reference;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public unsafe struct IUserNotification : _IUserNotification, _IUnknown, IDisposable
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        private unsafe struct IUserNotification_vtbl
        {
            internal IntPtr method_0;
            internal IntPtr method_1;
            internal IntPtr method_2;
            internal IntPtr method_3;
            internal IntPtr method_4;
            internal IntPtr method_5;
            internal IntPtr method_6;
            internal IntPtr method_7;
        }

        private unsafe delegate int delegate_0(IUserNotification_vtbl** @this, Guid* riid, IUnknown* ppvObject);
        private unsafe delegate uint delegate_1(IUserNotification_vtbl** @this);
        private unsafe delegate uint delegate_2(IUserNotification_vtbl** @this);
        private unsafe delegate int delegate_3(IUserNotification_vtbl** @this, char* pszTitle, char* pszText, uint dwInfoFlags);
        private unsafe delegate int delegate_4(IUserNotification_vtbl** @this, uint dwShowTime, uint dwInterval, uint cRetryCount);
        private unsafe delegate int delegate_5(IUserNotification_vtbl** @this, IntPtr hIcon, char* pszToolTip);
        private unsafe delegate int delegate_6(IUserNotification_vtbl** @this, IQueryContinue pqc, uint dwContinuePollInterval);
        private unsafe delegate int delegate_7(IUserNotification_vtbl** @this, char* pszSoundName);

        private readonly void* reference;
        private static readonly Guid iid = new Guid("ba9711ba-5893-4787-a7e1-41277151550b");

        public static unsafe Guid IID
        {
            get
            {
                return iid;
            }
        }

        public unsafe int QueryInterface(Guid* riid, IUnknown* ppvObject)
        {
            IUserNotification_vtbl** @this = (IUserNotification_vtbl**)reference;
            IUserNotification_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_0, typeof(delegate_0));
            delegate_0 method = (delegate_0)genericDelegate;
            return method(@this, riid, ppvObject);
        }

        public unsafe uint AddRef()
        {
            IUserNotification_vtbl** @this = (IUserNotification_vtbl**)reference;
            IUserNotification_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_1, typeof(delegate_1));
            delegate_1 method = (delegate_1)genericDelegate;
            return method(@this);
        }

        public unsafe uint Release()
        {
            IUserNotification_vtbl** @this = (IUserNotification_vtbl**)reference;
            IUserNotification_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_2, typeof(delegate_2));
            delegate_2 method = (delegate_2)genericDelegate;
            return method(@this);
        }

        public unsafe int SetBalloonInfo(char* pszTitle, char* pszText, uint dwInfoFlags)
        {
            IUserNotification_vtbl** @this = (IUserNotification_vtbl**)reference;
            IUserNotification_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_3, typeof(delegate_3));
            delegate_3 method = (delegate_3)genericDelegate;
            return method(@this, pszTitle, pszText, dwInfoFlags);
        }

        public unsafe int SetBalloonRetry(uint dwShowTime, uint dwInterval, uint cRetryCount)
        {
            IUserNotification_vtbl** @this = (IUserNotification_vtbl**)reference;
            IUserNotification_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_4, typeof(delegate_4));
            delegate_4 method = (delegate_4)genericDelegate;
            return method(@this, dwShowTime, dwInterval, cRetryCount);
        }

        public unsafe int SetIconInfo(IntPtr hIcon, char* pszToolTip)
        {
            IUserNotification_vtbl** @this = (IUserNotification_vtbl**)reference;
            IUserNotification_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_5, typeof(delegate_5));
            delegate_5 method = (delegate_5)genericDelegate;
            return method(@this, hIcon, pszToolTip);
        }

        public unsafe int Show(IQueryContinue pqc, uint dwContinuePollInterval)
        {
            IUserNotification_vtbl** @this = (IUserNotification_vtbl**)reference;
            IUserNotification_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_6, typeof(delegate_6));
            delegate_6 method = (delegate_6)genericDelegate;
            return method(@this, pqc, dwContinuePollInterval);
        }

        public unsafe int PlaySound(char* pszSoundName)
        {
            IUserNotification_vtbl** @this = (IUserNotification_vtbl**)reference;
            IUserNotification_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_7, typeof(delegate_7));
            delegate_7 method = (delegate_7)genericDelegate;
            return method(@this, pszSoundName);
        }

        void IDisposable.Dispose()
        {
            while ((reference != null) && (Release() > 0))
            {
            }
        }

        public unsafe IUserNotification(IntPtr value)
        {
            reference = (void*)value;
        }

        public unsafe IUserNotification(void* value)
        {
            reference = value;
        }

        public static unsafe explicit operator IUserNotification(IUnknown value)
        {
            return new IUserNotification(*((void**)(&value)));
        }

        public static unsafe implicit operator IUnknown(IUserNotification value)
        {
            return new IUnknown(value.reference);
        }

        public static unsafe implicit operator IntPtr(IUserNotification value)
        {
            return new IntPtr(value.reference);
        }

        public static unsafe implicit operator void*(IUserNotification value)
        {
            return value.reference;
        }

        public static unsafe implicit operator IUserNotification(IntPtr value)
        {
            return new IUserNotification(value);
        }

        public static unsafe implicit operator IUserNotification(void* value)
        {
            return new IUserNotification(value);
        }

        public unsafe override bool Equals(object obj)
        {
            IUserNotification other = (IUserNotification)obj;
            return reference == other.reference;
        }

        public unsafe override int GetHashCode()
        {
            return new IntPtr(reference).GetHashCode();
        }

        public unsafe static bool operator ==(IUserNotification left, IUserNotification right)
        {
            return left.reference == right.reference;
        }

        public unsafe static bool operator !=(IUserNotification left, IUserNotification right)
        {
            return left.reference != right.reference;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public unsafe struct WNDPROC : IDisposable
    {
        private static readonly ConcurrentDictionary<IntPtr, _WNDPROC> references = new ConcurrentDictionary<IntPtr, _WNDPROC>();

        private readonly IntPtr reference;

        public unsafe WNDPROC(_WNDPROC value)
            : this()
        {
            IntPtr reference = IntPtr.Zero;
            if (value != null)
            {
                value = new _WNDPROC(value);
                reference = Marshal.GetFunctionPointerForDelegate(value);
                references.TryAdd(reference, value);
            }
            this.reference = reference;
        }

        public unsafe WNDPROC(IntPtr value)
        {
            reference = value;
        }

        public unsafe WNDPROC(void* value)
        {
            reference = new IntPtr(value);
        }

        public static unsafe implicit operator IntPtr(WNDPROC value)
        {
            return value.reference;
        }

        public static unsafe implicit operator void*(WNDPROC value)
        {
            return (void*)value.reference;
        }

        public static unsafe implicit operator WNDPROC(IntPtr value)
        {
            return new WNDPROC(value);
        }

        public static unsafe implicit operator WNDPROC(void* value)
        {
            return new WNDPROC(value);
        }

        public static unsafe implicit operator WNDPROC(_WNDPROC value)
        {
            return new WNDPROC(value);
        }

        public static unsafe implicit operator _WNDPROC(WNDPROC value)
        {
            IntPtr reference = value.reference;
            return (reference == IntPtr.Zero) ? null : (_WNDPROC)Marshal.GetDelegateForFunctionPointer(reference, typeof(_WNDPROC));
        }

        public void Dispose()
        {
            _WNDPROC removedReference;
            references.TryRemove(reference, out removedReference);
        }

        public void RemoveAllReferences()
        {
            references.Clear();
        }

        public unsafe override bool Equals(object obj)
        {
            WNDPROC other = (WNDPROC)obj;
            return reference == other.reference;
        }

        public unsafe override int GetHashCode()
        {
            return reference.GetHashCode();
        }

        public unsafe static bool operator ==(WNDPROC left, WNDPROC right)
        {
            return left.reference == right.reference;
        }

        public unsafe static bool operator !=(WNDPROC left, WNDPROC right)
        {
            return left.reference != right.reference;
        }

        public unsafe IntPtr Invoke(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
        {
            if (reference == IntPtr.Zero)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(reference, typeof(_WNDPROC));
            _WNDPROC method = (_WNDPROC)genericDelegate;
            return method(hWnd, msg, wParam, lParam);
        }
    }

    public unsafe static partial class NativeMethods
    {
        [DllImport("user32.dll", EntryPoint = "AdjustWindowRect", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe BOOL AdjustWindowRect(RECT* lpRect, uint dwStyle, BOOL bMenu);

        [DllImport("user32.dll", EntryPoint = "BeginPaint", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe IntPtr BeginPaint(IntPtr hWnd, PAINTSTRUCT* lpPaint);

        [DllImport("ole32.dll", EntryPoint = "CoCreateInstance", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe int CoCreateInstance(Guid* rclsid, IUnknown pUnkOuter, uint dwClsContext, Guid* riid, void** ppv);

        [DllImport("user32.dll", EntryPoint = "CreateWindowExW", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe IntPtr CreateWindowEx(uint dwExStyle, char* lpClassName, char* lpWindowName, uint dwStyle, int X, int Y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, void* lpParam);

        [DllImport("user32.dll", EntryPoint = "DefWindowProcW", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe IntPtr DefWindowProc(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "DispatchMessageW", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe IntPtr DispatchMessage(MSG* lpMsg);

        [DllImport("user32.dll", EntryPoint = "EndPaint", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe BOOL EndPaint(IntPtr hWnd, PAINTSTRUCT* lpPaint);

        [DllImport("user32.dll", EntryPoint = "PeekMessageW", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe BOOL PeekMessage(MSG* lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);

        [DllImport("user32.dll", EntryPoint = "PostQuitMessage", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe void PostQuitMessage(int nExitCode);

        [DllImport("user32.dll", EntryPoint = "RegisterClassExW", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe ushort RegisterClassEx(WNDCLASSEX* lpwcx);

        [DllImport("user32.dll", EntryPoint = "ShowWindow", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe BOOL ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll", EntryPoint = "TranslateMessage", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe BOOL TranslateMessage(MSG* lpMsg);
    }

    public unsafe static partial class NativeConstants
    {
        public const string CLSID_UserNotification = @"0010890e-8789-413c-adbc-48f5b511b3af";
        public const uint CS_BYTEALIGNCLIENT = 4096;
        public const uint CS_BYTEALIGNWINDOW = 8192;
        public const uint CS_CLASSDC = 64;
        public const uint CS_DBLCLKS = 8;
        public const uint CS_DROPSHADOW = 131072;
        public const uint CS_GLOBALCLASS = 16384;
        public const uint CS_HREDRAW = 2;
        public const uint CS_IME = 65536;
        public const uint CS_NOCLOSE = 512;
        public const uint CS_OWNDC = 32;
        public const uint CS_PARENTDC = 128;
        public const uint CS_SAVEBITS = 2048;
        public const uint CS_VREDRAW = 1;
        public const int CW_USEDEFAULT = -2147483648;
        public const uint PM_NOREMOVE = 0;
        public const uint PM_NOYIELD = 2;
        public const uint PM_QS_INPUT = 470220800;
        public const uint PM_QS_PAINT = 2097152;
        public const uint PM_QS_POSTMESSAGE = 9961472;
        public const uint PM_QS_SENDMESSAGE = 4194304;
        public const uint PM_REMOVE = 1;
        public const uint QS_ALLEVENTS = 7359;
        public const uint QS_ALLINPUT = 7423;
        public const uint QS_ALLPOSTMESSAGE = 256;
        public const uint QS_HOTKEY = 128;
        public const uint QS_INPUT = 7175;
        public const uint QS_KEY = 1;
        public const uint QS_MOUSE = 6;
        public const uint QS_MOUSEBUTTON = 4;
        public const uint QS_MOUSEMOVE = 2;
        public const uint QS_PAINT = 32;
        public const uint QS_POINTER = 4096;
        public const uint QS_POSTMESSAGE = 8;
        public const uint QS_RAWINPUT = 1024;
        public const uint QS_SENDMESSAGE = 64;
        public const uint QS_TIMER = 16;
        public const uint QS_TOUCH = 2048;
        public const uint SW_FORCEMINIMIZE = 11;
        public const uint SW_HIDE = 0;
        public const uint SW_MAX = 11;
        public const uint SW_MAXIMIZE = 3;
        public const uint SW_MINIMIZE = 6;
        public const uint SW_NORMAL = 1;
        public const uint SW_RESTORE = 9;
        public const uint SW_SHOW = 5;
        public const uint SW_SHOWDEFAULT = 10;
        public const uint SW_SHOWMAXIMIZED = 3;
        public const uint SW_SHOWMINIMIZED = 2;
        public const uint SW_SHOWMINNOACTIVE = 7;
        public const uint SW_SHOWNA = 8;
        public const uint SW_SHOWNOACTIVATE = 4;
        public const uint SW_SHOWNORMAL = 1;
        public const uint WA_ACTIVE = 1;
        public const uint WA_CLICKACTIVE = 2;
        public const uint WA_INACTIVE = 0;
        public const uint WM_ACTIVATE = 6;
        public const uint WM_ACTIVATEAPP = 28;
        public const uint WM_CANCELMODE = 31;
        public const uint WM_CHILDACTIVATE = 34;
        public const uint WM_CLOSE = 16;
        public const uint WM_CREATE = 1;
        public const uint WM_DESTROY = 2;
        public const uint WM_DEVMODECHANGE = 27;
        public const uint WM_ENABLE = 10;
        public const uint WM_ENDSESSION = 22;
        public const uint WM_ERASEBKGND = 20;
        public const uint WM_FONTCHANGE = 29;
        public const uint WM_GETMINMAXINFO = 36;
        public const uint WM_GETTEXT = 13;
        public const uint WM_GETTEXTLENGTH = 14;
        public const uint WM_KILLFOCUS = 8;
        public const uint WM_MOUSEACTIVATE = 33;
        public const uint WM_MOVE = 3;
        public const uint WM_NULL = 0;
        public const uint WM_PAINT = 15;
        public const uint WM_QUERYENDSESSION = 17;
        public const uint WM_QUERYOPEN = 19;
        public const uint WM_QUEUESYNC = 35;
        public const uint WM_QUIT = 18;
        public const uint WM_SETCURSOR = 32;
        public const uint WM_SETFOCUS = 7;
        public const uint WM_SETREDRAW = 11;
        public const uint WM_SETTEXT = 12;
        public const uint WM_SETTINGCHANGE = 26;
        public const uint WM_SHOWWINDOW = 24;
        public const uint WM_SIZE = 5;
        public const uint WM_SYSCOLORCHANGE = 21;
        public const uint WM_TIMECHANGE = 30;
        public const uint WM_WININICHANGE = 26;
        public const uint WS_BORDER = 8388608;
        public const uint WS_CAPTION = 12582912;
        public const uint WS_CHILD = 1073741824;
        public const uint WS_CHILDWINDOW = 1073741824;
        public const uint WS_CLIPCHILDREN = 33554432;
        public const uint WS_CLIPSIBLINGS = 67108864;
        public const uint WS_DISABLED = 134217728;
        public const uint WS_DLGFRAME = 4194304;
        public const uint WS_EX_ACCEPTFILES = 16;
        public const uint WS_EX_APPWINDOW = 262144;
        public const uint WS_EX_CLIENTEDGE = 512;
        public const uint WS_EX_COMPOSITED = 33554432;
        public const uint WS_EX_CONTEXTHELP = 1024;
        public const uint WS_EX_CONTROLPARENT = 65536;
        public const uint WS_EX_DLGMODALFRAME = 1;
        public const uint WS_EX_LAYERED = 524288;
        public const uint WS_EX_LAYOUTRTL = 4194304;
        public const uint WS_EX_LEFT = 0;
        public const uint WS_EX_LEFTSCROLLBAR = 16384;
        public const uint WS_EX_LTRREADING = 0;
        public const uint WS_EX_MDICHILD = 64;
        public const uint WS_EX_NOACTIVATE = 134217728;
        public const uint WS_EX_NOINHERITLAYOUT = 1048576;
        public const uint WS_EX_NOPARENTNOTIFY = 4;
        public const uint WS_EX_NOREDIRECTIONBITMAP = 2097152;
        public const uint WS_EX_OVERLAPPEDWINDOW = 768;
        public const uint WS_EX_PALETTEWINDOW = 392;
        public const uint WS_EX_RIGHT = 4096;
        public const uint WS_EX_RIGHTSCROLLBAR = 0;
        public const uint WS_EX_RTLREADING = 8192;
        public const uint WS_EX_STATICEDGE = 131072;
        public const uint WS_EX_TOOLWINDOW = 128;
        public const uint WS_EX_TOPMOST = 8;
        public const uint WS_EX_TRANSPARENT = 32;
        public const uint WS_EX_WINDOWEDGE = 256;
        public const uint WS_GROUP = 131072;
        public const uint WS_HSCROLL = 1048576;
        public const uint WS_ICONIC = 536870912;
        public const uint WS_MAXIMIZE = 16777216;
        public const uint WS_MAXIMIZEBOX = 65536;
        public const uint WS_MINIMIZE = 536870912;
        public const uint WS_MINIMIZEBOX = 131072;
        public const uint WS_OVERLAPPED = 0;
        public const uint WS_OVERLAPPEDWINDOW = 13565952;
        public const uint WS_POPUP = 2147483648;
        public const uint WS_POPUPWINDOW = 2156396544;
        public const uint WS_SIZEBOX = 262144;
        public const uint WS_SYSMENU = 524288;
        public const uint WS_TABSTOP = 65536;
        public const uint WS_THICKFRAME = 262144;
        public const uint WS_TILED = 0;
        public const uint WS_TILEDWINDOW = 13565952;
        public const uint WS_VISIBLE = 268435456;
        public const uint WS_VSCROLL = 2097152;
    }
}
using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace Win32
{
    public unsafe static partial class NativeMethods
    {
        [DllImport("kernel32.dll", EntryPoint = "AddDllDirectory", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe IntPtr AddDllDirectory(char* NewDirectory);

        [DllImport("kernel32.dll", EntryPoint = "DisableThreadLibraryCalls", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe BOOL DisableThreadLibraryCalls(IntPtr hLibModule);

        [DllImport("kernel32.dll", EntryPoint = "FreeLibrary", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe BOOL FreeLibrary(IntPtr hLibModule);

        [DllImport("kernel32.dll", EntryPoint = "FreeLibraryAndExitThread", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe void FreeLibraryAndExitThread(IntPtr hLibModule, uint dwExitCode);

        [DllImport("kernel32.dll", EntryPoint = "GetDllDirectoryA", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe uint GetDllDirectory(uint nBufferLength, sbyte* lpBuffer);

        [DllImport("kernel32.dll", EntryPoint = "GetDllDirectoryW", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe uint GetDllDirectory(uint nBufferLength, char* lpBuffer);

        [DllImport("kernel32.dll", EntryPoint = "GetModuleFileNameW", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe uint GetModuleFileName(IntPtr hModule, char* lpFilename, uint nSize);

        [DllImport("kernel32.dll", EntryPoint = "GetModuleFileNameA", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe uint GetModuleFileName_overloaded000(IntPtr hModule, sbyte* lpFilename, uint nSize);

        [DllImport("psapi.dll", EntryPoint = "GetModuleFileNameExA", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe uint GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, sbyte* lpFilename, uint nSize);

        [DllImport("psapi.dll", EntryPoint = "GetModuleFileNameExW", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe uint GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, char* lpFilename, uint nSize);

        [DllImport("kernel32.dll", EntryPoint = "GetModuleHandleA", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe IntPtr GetModuleHandle(sbyte* lpModuleName);

        [DllImport("kernel32.dll", EntryPoint = "GetModuleHandleW", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe IntPtr GetModuleHandle(char* lpModuleName);

        [DllImport("kernel32.dll", EntryPoint = "GetModuleHandleExW", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe BOOL GetModuleHandleEx(uint dwFlags, char* lpModuleName, IntPtr* phModule);

        [DllImport("kernel32.dll", EntryPoint = "GetModuleHandleExA", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe BOOL GetModuleHandleEx_overloaded000(uint dwFlags, sbyte* lpModuleName, IntPtr* phModule);

        [DllImport("kernel32.dll", EntryPoint = "GetProcAddress", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe FARPROC GetProcAddress(IntPtr hModule, sbyte* lpProcName);

        [DllImport("kernel32.dll", EntryPoint = "LoadLibraryW", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe IntPtr LoadLibrary(char* lpLibFileName);

        [DllImport("kernel32.dll", EntryPoint = "LoadLibraryA", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe IntPtr LoadLibrary_overloaded000(sbyte* lpLibFileName);

        [DllImport("kernel32.dll", EntryPoint = "LoadLibraryExA", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe IntPtr LoadLibraryEx(sbyte* lpLibFileName, IntPtr hFile, uint dwFlags);

        [DllImport("kernel32.dll", EntryPoint = "LoadLibraryExW", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe IntPtr LoadLibraryEx(char* lpLibFileName, IntPtr hFile, uint dwFlags);

        [DllImport("kernel32.dll", EntryPoint = "LoadPackagedLibrary", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe IntPtr LoadPackagedLibrary(char* lpwLibFileName, uint Reserved);

        [DllImport("kernel32.dll", EntryPoint = "RemoveDllDirectory", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe BOOL RemoveDllDirectory(IntPtr Cookie);

        [DllImport("kernel32.dll", EntryPoint = "SetDefaultDllDirectories", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe BOOL SetDefaultDllDirectories(uint DirectoryFlags);

        [DllImport("kernel32.dll", EntryPoint = "SetDllDirectoryA", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe BOOL SetDllDirectory(sbyte* lpPathName);

        [DllImport("kernel32.dll", EntryPoint = "SetDllDirectoryW", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe BOOL SetDllDirectory(char* lpPathName);
    }

    public unsafe static partial class NativeConstants
    {
        public const uint DONT_RESOLVE_DLL_REFERENCES = 1;
        public const uint GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS = 4;
        public const uint GET_MODULE_HANDLE_EX_FLAG_PIN = 1;
        public const uint GET_MODULE_HANDLE_EX_FLAG_UNCHANGED_REFCOUNT = 2;
        public const uint LOAD_IGNORE_CODE_AUTHZ_LEVEL = 16;
        public const uint LOAD_LIBRARY_AS_DATAFILE = 2;
        public const uint LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE = 64;
        public const uint LOAD_LIBRARY_AS_IMAGE_RESOURCE = 32;
        public const uint LOAD_LIBRARY_REQUIRE_SIGNED_TARGET = 128;
        public const uint LOAD_LIBRARY_SEARCH_APPLICATION_DIR = 512;
        public const uint LOAD_LIBRARY_SEARCH_DEFAULT_DIRS = 4096;
        public const uint LOAD_LIBRARY_SEARCH_DLL_LOAD_DIR = 256;
        public const uint LOAD_LIBRARY_SEARCH_SYSTEM32 = 2048;
        public const uint LOAD_LIBRARY_SEARCH_USER_DIRS = 1024;
        public const uint LOAD_WITH_ALTERED_SEARCH_PATH = 8;
    }
}
using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace Win32
{
    public unsafe delegate void _FARPROC();

    public enum CALLCONV
    {
        CC_FASTCALL = 0,
        CC_CDECL = 1,
        CC_MSCPASCAL = 2,
        CC_PASCAL = 2,
        CC_MACPASCAL = 3,
        CC_STDCALL = 4,
        CC_FPFASTCALL = 5,
        CC_SYSCALL = 6,
        CC_MPWCDECL = 7,
        CC_MPWPASCAL = 8,
        CC_MAX = 9
    }

    public enum DESCKIND
    {
        DESCKIND_NONE = 0,
        DESCKIND_FUNCDESC = 1,
        DESCKIND_VARDESC = 2,
        DESCKIND_TYPECOMP = 3,
        DESCKIND_IMPLICITAPPOBJ = 4,
        DESCKIND_MAX = 5
    }

    public enum FUNCKIND
    {
        FUNC_VIRTUAL = 0,
        FUNC_PUREVIRTUAL = 1,
        FUNC_NONVIRTUAL = 2,
        FUNC_STATIC = 3,
        FUNC_DISPATCH = 4
    }

    public enum INVOKEKIND
    {
        INVOKE_FUNC = 1,
        INVOKE_PROPERTYGET = 2,
        INVOKE_PROPERTYPUT = 4,
        INVOKE_PROPERTYPUTREF = 8
    }

    public enum SYSKIND
    {
        SYS_WIN16 = 0,
        SYS_WIN32 = 1,
        SYS_MAC = 2,
        SYS_WIN64 = 3
    }

    public enum TYPEKIND
    {
        TKIND_ENUM = 0,
        TKIND_RECORD = 1,
        TKIND_MODULE = 2,
        TKIND_INTERFACE = 3,
        TKIND_DISPATCH = 4,
        TKIND_COCLASS = 5,
        TKIND_ALIAS = 6,
        TKIND_UNION = 7,
        TKIND_MAX = 8
    }

    public enum VARKIND
    {
        VAR_PERINSTANCE = 0,
        VAR_STATIC = 1,
        VAR_CONST = 2,
        VAR_DISPATCH = 3
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct ARRAYDESC
    {
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public unsafe struct __MIDL___MIDL_itf_Common_0002_0006_0006
        {
            [FieldOffset(0)]
            public TYPEDESC* lptdesc;
            [FieldOffset(0)]
            public ARRAYDESC* lpadesc;
            [FieldOffset(0)]
            public uint hreftype;

            public unsafe static int GetSize()
            {
                return Marshal.SizeOf(typeof(__MIDL___MIDL_itf_Common_0002_0006_0006));
            }

            public unsafe override bool Equals(object obj)
            {
                if (!(obj is __MIDL___MIDL_itf_Common_0002_0006_0006))
                    return false;
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0006* address = &this)
                {
                    __MIDL___MIDL_itf_Common_0002_0006_0006 other = (__MIDL___MIDL_itf_Common_0002_0006_0006)obj;
                    IntPtr size = new IntPtr(GetSize());
                    IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                    return size == equalBytes;
                }
            }

            public unsafe override int GetHashCode()
            {
                int result = 0;
                int size = GetSize();
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0006* address = &this)
                {
                    byte* byteAddress = (byte*)address;
                    for (int i = 0; i < size; i++)
                        result ^= byteAddress[i] << i;
                }
                return result;
            }

            public unsafe static bool operator ==(__MIDL___MIDL_itf_Common_0002_0006_0006 left, __MIDL___MIDL_itf_Common_0002_0006_0006 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size == equalBytes;
            }

            public unsafe static bool operator !=(__MIDL___MIDL_itf_Common_0002_0006_0006 left, __MIDL___MIDL_itf_Common_0002_0006_0006 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size != equalBytes;
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        public unsafe struct Array1D_SAFEARRAYBOUND_1
        {
            private const int length0 = 1;

            private SAFEARRAYBOUND data0;

            public unsafe SAFEARRAYBOUND this[int index0]
            {
                get
                {
                    fixed (SAFEARRAYBOUND* pointer = &data0)
                    {
                        return pointer[index0];
                    }
                }
                set
                {
                    fixed (SAFEARRAYBOUND* pointer = &data0)
                    {
                        pointer[index0] = value;
                    }
                }
            }

            public static unsafe implicit operator SAFEARRAYBOUND[](Array1D_SAFEARRAYBOUND_1 value)
            {
                SAFEARRAYBOUND[] result = new SAFEARRAYBOUND[1];
                SAFEARRAYBOUND* pointer = &value.data0;
                {
                    for (int i = 0; i < 1; i++)
                        result[i] = pointer[i];
                }
                return result;
            }

            public static unsafe implicit operator Array1D_SAFEARRAYBOUND_1(SAFEARRAYBOUND[] value)
            {
                if (value == null)
                   throw new ArgumentNullException("value");
                Array1D_SAFEARRAYBOUND_1 result = new Array1D_SAFEARRAYBOUND_1();
                SAFEARRAYBOUND* pointer = &result.data0;
                for (int i = 0; i < ((value.Length < 1) ? value.Length : 1); i++)
                    pointer[i] = value[i];
                return result;
            }
        }

        public TYPEDESC tdescElem;
        public ushort cDims;
        private short ___padding000;
        public Array1D_SAFEARRAYBOUND_1 rgbounds;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(ARRAYDESC));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is ARRAYDESC))
                return false;
            fixed (ARRAYDESC* address = &this)
            {
                ARRAYDESC other = (ARRAYDESC)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (ARRAYDESC* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(ARRAYDESC left, ARRAYDESC right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(ARRAYDESC left, ARRAYDESC right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct BLOB
    {
        public uint cbSize;
        public byte* pBlobData;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(BLOB));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is BLOB))
                return false;
            fixed (BLOB* address = &this)
            {
                BLOB other = (BLOB)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (BLOB* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(BLOB left, BLOB right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(BLOB left, BLOB right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct BOOL
    {
        private int Value;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(BOOL));
        }

        public static unsafe implicit operator bool(BOOL value)
        {
            return (value.Value != 0);
        }

        public static unsafe implicit operator BOOL(bool value)
        {
            return new BOOL { Value = (byte)(value ? 1 : 0) };
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is BOOL))
                return false;
            fixed (BOOL* address = &this)
            {
                BOOL other = (BOOL)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (BOOL* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(BOOL left, BOOL right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(BOOL left, BOOL right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public unsafe struct BOOLEAN
    {
        private byte Value;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(BOOLEAN));
        }

        public static unsafe implicit operator bool(BOOLEAN value)
        {
            return (value.Value != 0);
        }

        public static unsafe implicit operator BOOLEAN(bool value)
        {
            return new BOOLEAN { Value = (byte)(value ? 1 : 0) };
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is BOOLEAN))
                return false;
            fixed (BOOLEAN* address = &this)
            {
                BOOLEAN other = (BOOLEAN)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (BOOLEAN* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(BOOLEAN left, BOOLEAN right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(BOOLEAN left, BOOLEAN right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct BSTRBLOB
    {
        public uint cbSize;
        public byte* pData;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(BSTRBLOB));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is BSTRBLOB))
                return false;
            fixed (BSTRBLOB* address = &this)
            {
                BSTRBLOB other = (BSTRBLOB)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (BSTRBLOB* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(BSTRBLOB left, BSTRBLOB right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(BSTRBLOB left, BSTRBLOB right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CABOOL
    {
        public uint cElems;
        public bool* pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CABOOL));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CABOOL))
                return false;
            fixed (CABOOL* address = &this)
            {
                CABOOL other = (CABOOL)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CABOOL* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CABOOL left, CABOOL right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CABOOL left, CABOOL right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CABSTR
    {
        public uint cElems;
        public char** pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CABSTR));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CABSTR))
                return false;
            fixed (CABSTR* address = &this)
            {
                CABSTR other = (CABSTR)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CABSTR* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CABSTR left, CABSTR right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CABSTR left, CABSTR right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CABSTRBLOB
    {
        public uint cElems;
        public BSTRBLOB* pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CABSTRBLOB));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CABSTRBLOB))
                return false;
            fixed (CABSTRBLOB* address = &this)
            {
                CABSTRBLOB other = (CABSTRBLOB)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CABSTRBLOB* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CABSTRBLOB left, CABSTRBLOB right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CABSTRBLOB left, CABSTRBLOB right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CAC
    {
        public uint cElems;
        public sbyte* pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CAC));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CAC))
                return false;
            fixed (CAC* address = &this)
            {
                CAC other = (CAC)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CAC* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CAC left, CAC right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CAC left, CAC right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CACLIPDATA
    {
        public uint cElems;
        public CLIPDATA* pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CACLIPDATA));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CACLIPDATA))
                return false;
            fixed (CACLIPDATA* address = &this)
            {
                CACLIPDATA other = (CACLIPDATA)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CACLIPDATA* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CACLIPDATA left, CACLIPDATA right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CACLIPDATA left, CACLIPDATA right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CACLSID
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        public unsafe struct Array1D_byte_8
        {
            private const int length0 = 8;

            private fixed byte data[8];

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

            public static unsafe implicit operator byte[](Array1D_byte_8 value)
            {
                byte[] result = new byte[8];
                byte* pointer = value.data;
                {
                    for (int i = 0; i < 8; i++)
                        result[i] = pointer[i];
                }
                return result;
            }

            public static unsafe implicit operator Array1D_byte_8(byte[] value)
            {
                if (value == null)
                   throw new ArgumentNullException("value");
                Array1D_byte_8 result = new Array1D_byte_8();
                byte* pointer = result.data;
                for (int i = 0; i < ((value.Length < 8) ? value.Length : 8); i++)
                    pointer[i] = value[i];
                return result;
            }
        }

        public uint cElems;
        public Guid* pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CACLSID));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CACLSID))
                return false;
            fixed (CACLSID* address = &this)
            {
                CACLSID other = (CACLSID)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CACLSID* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CACLSID left, CACLSID right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CACLSID left, CACLSID right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CACY
    {
        public uint cElems;
        public long* pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CACY));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CACY))
                return false;
            fixed (CACY* address = &this)
            {
                CACY other = (CACY)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CACY* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CACY left, CACY right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CACY left, CACY right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CADATE
    {
        public uint cElems;
        public double* pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CADATE));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CADATE))
                return false;
            fixed (CADATE* address = &this)
            {
                CADATE other = (CADATE)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CADATE* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CADATE left, CADATE right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CADATE left, CADATE right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CADBL
    {
        public uint cElems;
        public double* pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CADBL));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CADBL))
                return false;
            fixed (CADBL* address = &this)
            {
                CADBL other = (CADBL)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CADBL* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CADBL left, CADBL right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CADBL left, CADBL right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CAFILETIME
    {
        public uint cElems;
        public FILETIME* pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CAFILETIME));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CAFILETIME))
                return false;
            fixed (CAFILETIME* address = &this)
            {
                CAFILETIME other = (CAFILETIME)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CAFILETIME* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CAFILETIME left, CAFILETIME right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CAFILETIME left, CAFILETIME right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CAFLT
    {
        public uint cElems;
        public float* pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CAFLT));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CAFLT))
                return false;
            fixed (CAFLT* address = &this)
            {
                CAFLT other = (CAFLT)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CAFLT* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CAFLT left, CAFLT right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CAFLT left, CAFLT right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CAH
    {
        public uint cElems;
        public long* pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CAH));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CAH))
                return false;
            fixed (CAH* address = &this)
            {
                CAH other = (CAH)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CAH* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CAH left, CAH right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CAH left, CAH right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CAI
    {
        public uint cElems;
        public short* pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CAI));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CAI))
                return false;
            fixed (CAI* address = &this)
            {
                CAI other = (CAI)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CAI* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CAI left, CAI right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CAI left, CAI right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CAL
    {
        public uint cElems;
        public int* pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CAL));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CAL))
                return false;
            fixed (CAL* address = &this)
            {
                CAL other = (CAL)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CAL* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CAL left, CAL right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CAL left, CAL right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CALPSTR
    {
        public uint cElems;
        public sbyte** pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CALPSTR));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CALPSTR))
                return false;
            fixed (CALPSTR* address = &this)
            {
                CALPSTR other = (CALPSTR)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CALPSTR* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CALPSTR left, CALPSTR right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CALPSTR left, CALPSTR right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CALPWSTR
    {
        public uint cElems;
        public char** pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CALPWSTR));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CALPWSTR))
                return false;
            fixed (CALPWSTR* address = &this)
            {
                CALPWSTR other = (CALPWSTR)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CALPWSTR* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CALPWSTR left, CALPWSTR right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CALPWSTR left, CALPWSTR right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CAPROPVARIANT
    {
        public uint cElems;
        public void* pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CAPROPVARIANT));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CAPROPVARIANT))
                return false;
            fixed (CAPROPVARIANT* address = &this)
            {
                CAPROPVARIANT other = (CAPROPVARIANT)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CAPROPVARIANT* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CAPROPVARIANT left, CAPROPVARIANT right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CAPROPVARIANT left, CAPROPVARIANT right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CASCODE
    {
        public uint cElems;
        public int* pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CASCODE));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CASCODE))
                return false;
            fixed (CASCODE* address = &this)
            {
                CASCODE other = (CASCODE)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CASCODE* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CASCODE left, CASCODE right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CASCODE left, CASCODE right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CAUB
    {
        public uint cElems;
        public byte* pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CAUB));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CAUB))
                return false;
            fixed (CAUB* address = &this)
            {
                CAUB other = (CAUB)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CAUB* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CAUB left, CAUB right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CAUB left, CAUB right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CAUH
    {
        public uint cElems;
        public ulong* pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CAUH));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CAUH))
                return false;
            fixed (CAUH* address = &this)
            {
                CAUH other = (CAUH)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CAUH* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CAUH left, CAUH right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CAUH left, CAUH right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CAUI
    {
        public uint cElems;
        public ushort* pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CAUI));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CAUI))
                return false;
            fixed (CAUI* address = &this)
            {
                CAUI other = (CAUI)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CAUI* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CAUI left, CAUI right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CAUI left, CAUI right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CAUL
    {
        public uint cElems;
        public uint* pElems;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CAUL));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CAUL))
                return false;
            fixed (CAUL* address = &this)
            {
                CAUL other = (CAUL)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CAUL* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CAUL left, CAUL right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CAUL left, CAUL right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CLEANLOCALSTORAGE
    {
        public IUnknown pInterface;
        public void* pStorage;
        public uint flags;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CLEANLOCALSTORAGE));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CLEANLOCALSTORAGE))
                return false;
            fixed (CLEANLOCALSTORAGE* address = &this)
            {
                CLEANLOCALSTORAGE other = (CLEANLOCALSTORAGE)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CLEANLOCALSTORAGE* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CLEANLOCALSTORAGE left, CLEANLOCALSTORAGE right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CLEANLOCALSTORAGE left, CLEANLOCALSTORAGE right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CLIPDATA
    {
        public uint cbSize;
        public int ulClipFmt;
        public byte* pClipData;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(CLIPDATA));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is CLIPDATA))
                return false;
            fixed (CLIPDATA* address = &this)
            {
                CLIPDATA other = (CLIPDATA)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (CLIPDATA* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(CLIPDATA left, CLIPDATA right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(CLIPDATA left, CLIPDATA right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct ELEMDESC
    {
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public unsafe struct __MIDL___MIDL_itf_Common_0002_0006_0006
        {
            [FieldOffset(0)]
            public TYPEDESC* lptdesc;
            [FieldOffset(0)]
            public ARRAYDESC* lpadesc;
            [FieldOffset(0)]
            public uint hreftype;

            public unsafe static int GetSize()
            {
                return Marshal.SizeOf(typeof(__MIDL___MIDL_itf_Common_0002_0006_0006));
            }

            public unsafe override bool Equals(object obj)
            {
                if (!(obj is __MIDL___MIDL_itf_Common_0002_0006_0006))
                    return false;
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0006* address = &this)
                {
                    __MIDL___MIDL_itf_Common_0002_0006_0006 other = (__MIDL___MIDL_itf_Common_0002_0006_0006)obj;
                    IntPtr size = new IntPtr(GetSize());
                    IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                    return size == equalBytes;
                }
            }

            public unsafe override int GetHashCode()
            {
                int result = 0;
                int size = GetSize();
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0006* address = &this)
                {
                    byte* byteAddress = (byte*)address;
                    for (int i = 0; i < size; i++)
                        result ^= byteAddress[i] << i;
                }
                return result;
            }

            public unsafe static bool operator ==(__MIDL___MIDL_itf_Common_0002_0006_0006 left, __MIDL___MIDL_itf_Common_0002_0006_0006 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size == equalBytes;
            }

            public unsafe static bool operator !=(__MIDL___MIDL_itf_Common_0002_0006_0006 left, __MIDL___MIDL_itf_Common_0002_0006_0006 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size != equalBytes;
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        public unsafe struct Array1D_SAFEARRAYBOUND_1
        {
            private const int length0 = 1;

            private SAFEARRAYBOUND data0;

            public unsafe SAFEARRAYBOUND this[int index0]
            {
                get
                {
                    fixed (SAFEARRAYBOUND* pointer = &data0)
                    {
                        return pointer[index0];
                    }
                }
                set
                {
                    fixed (SAFEARRAYBOUND* pointer = &data0)
                    {
                        pointer[index0] = value;
                    }
                }
            }

            public static unsafe implicit operator SAFEARRAYBOUND[](Array1D_SAFEARRAYBOUND_1 value)
            {
                SAFEARRAYBOUND[] result = new SAFEARRAYBOUND[1];
                SAFEARRAYBOUND* pointer = &value.data0;
                {
                    for (int i = 0; i < 1; i++)
                        result[i] = pointer[i];
                }
                return result;
            }

            public static unsafe implicit operator Array1D_SAFEARRAYBOUND_1(SAFEARRAYBOUND[] value)
            {
                if (value == null)
                   throw new ArgumentNullException("value");
                Array1D_SAFEARRAYBOUND_1 result = new Array1D_SAFEARRAYBOUND_1();
                SAFEARRAYBOUND* pointer = &result.data0;
                for (int i = 0; i < ((value.Length < 1) ? value.Length : 1); i++)
                    pointer[i] = value[i];
                return result;
            }
        }

        public TYPEDESC tdesc;
        public PARAMDESC paramdesc;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(ELEMDESC));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is ELEMDESC))
                return false;
            fixed (ELEMDESC* address = &this)
            {
                ELEMDESC other = (ELEMDESC)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (ELEMDESC* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(ELEMDESC left, ELEMDESC right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(ELEMDESC left, ELEMDESC right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct EXCEPINFO
    {
        public ushort wCode;
        public ushort wReserved;
        public char* bstrSource;
        public char* bstrDescription;
        public char* bstrHelpFile;
        public uint dwHelpContext;
        public void* pvReserved;
        public void* pfnDeferredFillIn;
        public int scode;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(EXCEPINFO));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is EXCEPINFO))
                return false;
            fixed (EXCEPINFO* address = &this)
            {
                EXCEPINFO other = (EXCEPINFO)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (EXCEPINFO* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(EXCEPINFO left, EXCEPINFO right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(EXCEPINFO left, EXCEPINFO right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct FILETIME
    {
        public uint dwLowDateTime;
        public uint dwHighDateTime;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(FILETIME));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is FILETIME))
                return false;
            fixed (FILETIME* address = &this)
            {
                FILETIME other = (FILETIME)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (FILETIME* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(FILETIME left, FILETIME right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(FILETIME left, FILETIME right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct FUNCDESC
    {
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public unsafe struct __MIDL___MIDL_itf_Common_0002_0006_0006
        {
            [FieldOffset(0)]
            public TYPEDESC* lptdesc;
            [FieldOffset(0)]
            public ARRAYDESC* lpadesc;
            [FieldOffset(0)]
            public uint hreftype;

            public unsafe static int GetSize()
            {
                return Marshal.SizeOf(typeof(__MIDL___MIDL_itf_Common_0002_0006_0006));
            }

            public unsafe override bool Equals(object obj)
            {
                if (!(obj is __MIDL___MIDL_itf_Common_0002_0006_0006))
                    return false;
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0006* address = &this)
                {
                    __MIDL___MIDL_itf_Common_0002_0006_0006 other = (__MIDL___MIDL_itf_Common_0002_0006_0006)obj;
                    IntPtr size = new IntPtr(GetSize());
                    IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                    return size == equalBytes;
                }
            }

            public unsafe override int GetHashCode()
            {
                int result = 0;
                int size = GetSize();
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0006* address = &this)
                {
                    byte* byteAddress = (byte*)address;
                    for (int i = 0; i < size; i++)
                        result ^= byteAddress[i] << i;
                }
                return result;
            }

            public unsafe static bool operator ==(__MIDL___MIDL_itf_Common_0002_0006_0006 left, __MIDL___MIDL_itf_Common_0002_0006_0006 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size == equalBytes;
            }

            public unsafe static bool operator !=(__MIDL___MIDL_itf_Common_0002_0006_0006 left, __MIDL___MIDL_itf_Common_0002_0006_0006 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size != equalBytes;
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        public unsafe struct Array1D_SAFEARRAYBOUND_1
        {
            private const int length0 = 1;

            private SAFEARRAYBOUND data0;

            public unsafe SAFEARRAYBOUND this[int index0]
            {
                get
                {
                    fixed (SAFEARRAYBOUND* pointer = &data0)
                    {
                        return pointer[index0];
                    }
                }
                set
                {
                    fixed (SAFEARRAYBOUND* pointer = &data0)
                    {
                        pointer[index0] = value;
                    }
                }
            }

            public static unsafe implicit operator SAFEARRAYBOUND[](Array1D_SAFEARRAYBOUND_1 value)
            {
                SAFEARRAYBOUND[] result = new SAFEARRAYBOUND[1];
                SAFEARRAYBOUND* pointer = &value.data0;
                {
                    for (int i = 0; i < 1; i++)
                        result[i] = pointer[i];
                }
                return result;
            }

            public static unsafe implicit operator Array1D_SAFEARRAYBOUND_1(SAFEARRAYBOUND[] value)
            {
                if (value == null)
                   throw new ArgumentNullException("value");
                Array1D_SAFEARRAYBOUND_1 result = new Array1D_SAFEARRAYBOUND_1();
                SAFEARRAYBOUND* pointer = &result.data0;
                for (int i = 0; i < ((value.Length < 1) ? value.Length : 1); i++)
                    pointer[i] = value[i];
                return result;
            }
        }

        public int memid;
        public int* lprgscode;
        public ELEMDESC* lprgelemdescParam;
        public FUNCKIND funckind;
        public INVOKEKIND invkind;
        public CALLCONV callconv;
        public short cParams;
        public short cParamsOpt;
        public short oVft;
        public short cScodes;
        public ELEMDESC elemdescFunc;
        public ushort wFuncFlags;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(FUNCDESC));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is FUNCDESC))
                return false;
            fixed (FUNCDESC* address = &this)
            {
                FUNCDESC other = (FUNCDESC)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (FUNCDESC* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(FUNCDESC left, FUNCDESC right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(FUNCDESC left, FUNCDESC right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct IDLDESC
    {
        public void* dwReserved;
        public ushort wIDLFlags;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(IDLDESC));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is IDLDESC))
                return false;
            fixed (IDLDESC* address = &this)
            {
                IDLDESC other = (IDLDESC)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (IDLDESC* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(IDLDESC left, IDLDESC right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(IDLDESC left, IDLDESC right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct LUID
    {
        public uint LowPart;
        public int HighPart;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(LUID));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is LUID))
                return false;
            fixed (LUID* address = &this)
            {
                LUID other = (LUID)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (LUID* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(LUID left, LUID right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(LUID left, LUID right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct PARAMDESC
    {
        public PARAMDESCEX* pparamdescex;
        public ushort wParamFlags;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(PARAMDESC));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is PARAMDESC))
                return false;
            fixed (PARAMDESC* address = &this)
            {
                PARAMDESC other = (PARAMDESC)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (PARAMDESC* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(PARAMDESC left, PARAMDESC right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(PARAMDESC left, PARAMDESC right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct PARAMDESCEX
    {
        public uint cBytes;
        public VARIANT varDefaultValue;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(PARAMDESCEX));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is PARAMDESCEX))
                return false;
            fixed (PARAMDESCEX* address = &this)
            {
                PARAMDESCEX other = (PARAMDESCEX)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (PARAMDESCEX* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(PARAMDESCEX left, PARAMDESCEX right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(PARAMDESCEX left, PARAMDESCEX right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct POINT
    {
        public int x;
        public int y;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(POINT));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is POINT))
                return false;
            fixed (POINT* address = &this)
            {
                POINT other = (POINT)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (POINT* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(POINT left, POINT right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(POINT left, POINT right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct PROPBAG2
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        public unsafe struct Array1D_byte_8
        {
            private const int length0 = 8;

            private fixed byte data[8];

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

            public static unsafe implicit operator byte[](Array1D_byte_8 value)
            {
                byte[] result = new byte[8];
                byte* pointer = value.data;
                {
                    for (int i = 0; i < 8; i++)
                        result[i] = pointer[i];
                }
                return result;
            }

            public static unsafe implicit operator Array1D_byte_8(byte[] value)
            {
                if (value == null)
                   throw new ArgumentNullException("value");
                Array1D_byte_8 result = new Array1D_byte_8();
                byte* pointer = result.data;
                for (int i = 0; i < ((value.Length < 8) ? value.Length : 8); i++)
                    pointer[i] = value[i];
                return result;
            }
        }

        public uint dwType;
        public ushort vt;
        public ushort cfType;
        public uint dwHint;
        public char* pstrName;
        public Guid clsid;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(PROPBAG2));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is PROPBAG2))
                return false;
            fixed (PROPBAG2* address = &this)
            {
                PROPBAG2 other = (PROPBAG2)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (PROPBAG2* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(PROPBAG2 left, PROPBAG2 right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(PROPBAG2 left, PROPBAG2 right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct PROPVARIANT
    {
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public unsafe struct __MIDL___MIDL_itf_Common_0002_0006_0016
        {
            [FieldOffset(0)]
            public __MIDL___MIDL_itf_Common_0002_0006_0017 __MIDL____MIDL_itf_Common_0002_00060010;
            [FieldOffset(0)]
            public decimal decVal;

            public ushort vt
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.vt;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.vt = value;
                }
            }

            public ushort wReserved1
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.wReserved1;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.wReserved1 = value;
                }
            }

            public ushort wReserved2
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.wReserved2;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.wReserved2 = value;
                }
            }

            public ushort wReserved3
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.wReserved3;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.wReserved3 = value;
                }
            }

            public sbyte cVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cVal = value;
                }
            }

            public byte bVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.bVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.bVal = value;
                }
            }

            public short iVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.iVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.iVal = value;
                }
            }

            public ushort uiVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.uiVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.uiVal = value;
                }
            }

            public int lVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.lVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.lVal = value;
                }
            }

            public uint ulVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.ulVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.ulVal = value;
                }
            }

            public int intVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.intVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.intVal = value;
                }
            }

            public uint uintVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.uintVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.uintVal = value;
                }
            }

            public long hVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.hVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.hVal = value;
                }
            }

            public ulong uhVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.uhVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.uhVal = value;
                }
            }

            public float fltVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.fltVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.fltVal = value;
                }
            }

            public double dblVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.dblVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.dblVal = value;
                }
            }

            public bool boolVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.boolVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.boolVal = value;
                }
            }

            public int scode
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.scode;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.scode = value;
                }
            }

            public long cyVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cyVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cyVal = value;
                }
            }

            public double date
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.date;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.date = value;
                }
            }

            public FILETIME filetime
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.filetime;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.filetime = value;
                }
            }

            public Guid* puuid
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.puuid;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.puuid = value;
                }
            }

            public CLIPDATA* pclipdata
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pclipdata;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pclipdata = value;
                }
            }

            public char* bstrVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.bstrVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.bstrVal = value;
                }
            }

            public BSTRBLOB bstrblobVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.bstrblobVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.bstrblobVal = value;
                }
            }

            public BLOB blob
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.blob;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.blob = value;
                }
            }

            public sbyte* pszVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pszVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pszVal = value;
                }
            }

            public char* pwszVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pwszVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pwszVal = value;
                }
            }

            public IUnknown punkVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.punkVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.punkVal = value;
                }
            }

            public void* pdispVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pdispVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pdispVal = value;
                }
            }

            public IStream pStream
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pStream;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pStream = value;
                }
            }

            public IStorage pStorage
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pStorage;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pStorage = value;
                }
            }

            public VERSIONEDSTREAM* pVersionedStream
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pVersionedStream;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pVersionedStream = value;
                }
            }

            public SAFEARRAY* parray
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.parray;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.parray = value;
                }
            }

            public CAC cac
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cac;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cac = value;
                }
            }

            public CAUB caub
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.caub;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.caub = value;
                }
            }

            public CAI cai
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cai;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cai = value;
                }
            }

            public CAUI caui
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.caui;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.caui = value;
                }
            }

            public CAL cal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cal = value;
                }
            }

            public CAUL caul
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.caul;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.caul = value;
                }
            }

            public CAH cah
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cah;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cah = value;
                }
            }

            public CAUH cauh
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cauh;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cauh = value;
                }
            }

            public CAFLT caflt
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.caflt;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.caflt = value;
                }
            }

            public CADBL cadbl
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cadbl;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cadbl = value;
                }
            }

            public CABOOL cabool
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cabool;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cabool = value;
                }
            }

            public CASCODE cascode
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cascode;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cascode = value;
                }
            }

            public CACY cacy
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cacy;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cacy = value;
                }
            }

            public CADATE cadate
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cadate;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cadate = value;
                }
            }

            public CAFILETIME cafiletime
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cafiletime;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cafiletime = value;
                }
            }

            public CACLSID cauuid
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cauuid;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cauuid = value;
                }
            }

            public CACLIPDATA caclipdata
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.caclipdata;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.caclipdata = value;
                }
            }

            public CABSTR cabstr
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cabstr;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cabstr = value;
                }
            }

            public CABSTRBLOB cabstrblob
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cabstrblob;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cabstrblob = value;
                }
            }

            public CALPSTR calpstr
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.calpstr;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.calpstr = value;
                }
            }

            public CALPWSTR calpwstr
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.calpwstr;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.calpwstr = value;
                }
            }

            public CAPROPVARIANT capropvar
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.capropvar;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.capropvar = value;
                }
            }

            public sbyte* pcVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pcVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pcVal = value;
                }
            }

            public byte* pbVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pbVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pbVal = value;
                }
            }

            public short* piVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.piVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.piVal = value;
                }
            }

            public ushort* puiVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.puiVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.puiVal = value;
                }
            }

            public int* plVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.plVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.plVal = value;
                }
            }

            public uint* pulVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pulVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pulVal = value;
                }
            }

            public int* pintVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pintVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pintVal = value;
                }
            }

            public uint* puintVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.puintVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.puintVal = value;
                }
            }

            public float* pfltVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pfltVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pfltVal = value;
                }
            }

            public double* pdblVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pdblVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pdblVal = value;
                }
            }

            public bool* pboolVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pboolVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pboolVal = value;
                }
            }

            public decimal* pdecVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pdecVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pdecVal = value;
                }
            }

            public int* pscode
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pscode;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pscode = value;
                }
            }

            public long* pcyVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pcyVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pcyVal = value;
                }
            }

            public double* pdate
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pdate;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pdate = value;
                }
            }

            public char** pbstrVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pbstrVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pbstrVal = value;
                }
            }

            public IUnknown* ppunkVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.ppunkVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.ppunkVal = value;
                }
            }

            public void** ppdispVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.ppdispVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.ppdispVal = value;
                }
            }

            public SAFEARRAY** pparray
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pparray;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pparray = value;
                }
            }

            public void* pvarVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pvarVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pvarVal = value;
                }
            }

            public unsafe static int GetSize()
            {
                return Marshal.SizeOf(typeof(__MIDL___MIDL_itf_Common_0002_0006_0016));
            }

            public unsafe override bool Equals(object obj)
            {
                if (!(obj is __MIDL___MIDL_itf_Common_0002_0006_0016))
                    return false;
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0016* address = &this)
                {
                    __MIDL___MIDL_itf_Common_0002_0006_0016 other = (__MIDL___MIDL_itf_Common_0002_0006_0016)obj;
                    IntPtr size = new IntPtr(GetSize());
                    IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                    return size == equalBytes;
                }
            }

            public unsafe override int GetHashCode()
            {
                int result = 0;
                int size = GetSize();
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0016* address = &this)
                {
                    byte* byteAddress = (byte*)address;
                    for (int i = 0; i < size; i++)
                        result ^= byteAddress[i] << i;
                }
                return result;
            }

            public unsafe static bool operator ==(__MIDL___MIDL_itf_Common_0002_0006_0016 left, __MIDL___MIDL_itf_Common_0002_0006_0016 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size == equalBytes;
            }

            public unsafe static bool operator !=(__MIDL___MIDL_itf_Common_0002_0006_0016 left, __MIDL___MIDL_itf_Common_0002_0006_0016 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size != equalBytes;
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public unsafe struct __MIDL___MIDL_itf_Common_0002_0006_0017
        {
            public ushort vt;
            public ushort wReserved1;
            public ushort wReserved2;
            public ushort wReserved3;
            public __MIDL___MIDL_itf_Common_0002_0006_0018 __MIDL____MIDL_itf_Common_0002_00060009;

            public sbyte cVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.cVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.cVal = value;
                }
            }

            public byte bVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.bVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.bVal = value;
                }
            }

            public short iVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.iVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.iVal = value;
                }
            }

            public ushort uiVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.uiVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.uiVal = value;
                }
            }

            public int lVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.lVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.lVal = value;
                }
            }

            public uint ulVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.ulVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.ulVal = value;
                }
            }

            public int intVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.intVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.intVal = value;
                }
            }

            public uint uintVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.uintVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.uintVal = value;
                }
            }

            public long hVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.hVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.hVal = value;
                }
            }

            public ulong uhVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.uhVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.uhVal = value;
                }
            }

            public float fltVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.fltVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.fltVal = value;
                }
            }

            public double dblVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.dblVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.dblVal = value;
                }
            }

            public bool boolVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.boolVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.boolVal = value;
                }
            }

            public int scode
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.scode;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.scode = value;
                }
            }

            public long cyVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.cyVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.cyVal = value;
                }
            }

            public double date
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.date;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.date = value;
                }
            }

            public FILETIME filetime
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.filetime;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.filetime = value;
                }
            }

            public Guid* puuid
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.puuid;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.puuid = value;
                }
            }

            public CLIPDATA* pclipdata
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pclipdata;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pclipdata = value;
                }
            }

            public char* bstrVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.bstrVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.bstrVal = value;
                }
            }

            public BSTRBLOB bstrblobVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.bstrblobVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.bstrblobVal = value;
                }
            }

            public BLOB blob
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.blob;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.blob = value;
                }
            }

            public sbyte* pszVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pszVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pszVal = value;
                }
            }

            public char* pwszVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pwszVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pwszVal = value;
                }
            }

            public IUnknown punkVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.punkVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.punkVal = value;
                }
            }

            public void* pdispVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pdispVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pdispVal = value;
                }
            }

            public IStream pStream
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pStream;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pStream = value;
                }
            }

            public IStorage pStorage
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pStorage;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pStorage = value;
                }
            }

            public VERSIONEDSTREAM* pVersionedStream
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pVersionedStream;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pVersionedStream = value;
                }
            }

            public SAFEARRAY* parray
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.parray;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.parray = value;
                }
            }

            public CAC cac
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.cac;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.cac = value;
                }
            }

            public CAUB caub
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.caub;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.caub = value;
                }
            }

            public CAI cai
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.cai;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.cai = value;
                }
            }

            public CAUI caui
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.caui;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.caui = value;
                }
            }

            public CAL cal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.cal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.cal = value;
                }
            }

            public CAUL caul
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.caul;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.caul = value;
                }
            }

            public CAH cah
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.cah;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.cah = value;
                }
            }

            public CAUH cauh
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.cauh;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.cauh = value;
                }
            }

            public CAFLT caflt
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.caflt;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.caflt = value;
                }
            }

            public CADBL cadbl
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.cadbl;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.cadbl = value;
                }
            }

            public CABOOL cabool
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.cabool;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.cabool = value;
                }
            }

            public CASCODE cascode
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.cascode;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.cascode = value;
                }
            }

            public CACY cacy
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.cacy;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.cacy = value;
                }
            }

            public CADATE cadate
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.cadate;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.cadate = value;
                }
            }

            public CAFILETIME cafiletime
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.cafiletime;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.cafiletime = value;
                }
            }

            public CACLSID cauuid
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.cauuid;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.cauuid = value;
                }
            }

            public CACLIPDATA caclipdata
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.caclipdata;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.caclipdata = value;
                }
            }

            public CABSTR cabstr
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.cabstr;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.cabstr = value;
                }
            }

            public CABSTRBLOB cabstrblob
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.cabstrblob;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.cabstrblob = value;
                }
            }

            public CALPSTR calpstr
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.calpstr;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.calpstr = value;
                }
            }

            public CALPWSTR calpwstr
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.calpwstr;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.calpwstr = value;
                }
            }

            public CAPROPVARIANT capropvar
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.capropvar;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.capropvar = value;
                }
            }

            public sbyte* pcVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pcVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pcVal = value;
                }
            }

            public byte* pbVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pbVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pbVal = value;
                }
            }

            public short* piVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.piVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.piVal = value;
                }
            }

            public ushort* puiVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.puiVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.puiVal = value;
                }
            }

            public int* plVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.plVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.plVal = value;
                }
            }

            public uint* pulVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pulVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pulVal = value;
                }
            }

            public int* pintVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pintVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pintVal = value;
                }
            }

            public uint* puintVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.puintVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.puintVal = value;
                }
            }

            public float* pfltVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pfltVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pfltVal = value;
                }
            }

            public double* pdblVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pdblVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pdblVal = value;
                }
            }

            public bool* pboolVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pboolVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pboolVal = value;
                }
            }

            public decimal* pdecVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pdecVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pdecVal = value;
                }
            }

            public int* pscode
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pscode;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pscode = value;
                }
            }

            public long* pcyVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pcyVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pcyVal = value;
                }
            }

            public double* pdate
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pdate;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pdate = value;
                }
            }

            public char** pbstrVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pbstrVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pbstrVal = value;
                }
            }

            public IUnknown* ppunkVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.ppunkVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.ppunkVal = value;
                }
            }

            public void** ppdispVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.ppdispVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.ppdispVal = value;
                }
            }

            public SAFEARRAY** pparray
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pparray;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pparray = value;
                }
            }

            public void* pvarVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060009.pvarVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060009.pvarVal = value;
                }
            }

            public unsafe static int GetSize()
            {
                return Marshal.SizeOf(typeof(__MIDL___MIDL_itf_Common_0002_0006_0017));
            }

            public unsafe override bool Equals(object obj)
            {
                if (!(obj is __MIDL___MIDL_itf_Common_0002_0006_0017))
                    return false;
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0017* address = &this)
                {
                    __MIDL___MIDL_itf_Common_0002_0006_0017 other = (__MIDL___MIDL_itf_Common_0002_0006_0017)obj;
                    IntPtr size = new IntPtr(GetSize());
                    IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                    return size == equalBytes;
                }
            }

            public unsafe override int GetHashCode()
            {
                int result = 0;
                int size = GetSize();
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0017* address = &this)
                {
                    byte* byteAddress = (byte*)address;
                    for (int i = 0; i < size; i++)
                        result ^= byteAddress[i] << i;
                }
                return result;
            }

            public unsafe static bool operator ==(__MIDL___MIDL_itf_Common_0002_0006_0017 left, __MIDL___MIDL_itf_Common_0002_0006_0017 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size == equalBytes;
            }

            public unsafe static bool operator !=(__MIDL___MIDL_itf_Common_0002_0006_0017 left, __MIDL___MIDL_itf_Common_0002_0006_0017 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size != equalBytes;
            }
        }

        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public unsafe struct __MIDL___MIDL_itf_Common_0002_0006_0018
        {
            [FieldOffset(0)]
            public sbyte cVal;
            [FieldOffset(0)]
            public byte bVal;
            [FieldOffset(0)]
            public short iVal;
            [FieldOffset(0)]
            public ushort uiVal;
            [FieldOffset(0)]
            public int lVal;
            [FieldOffset(0)]
            public uint ulVal;
            [FieldOffset(0)]
            public int intVal;
            [FieldOffset(0)]
            public uint uintVal;
            [FieldOffset(0)]
            public long hVal;
            [FieldOffset(0)]
            public ulong uhVal;
            [FieldOffset(0)]
            public float fltVal;
            [FieldOffset(0)]
            public double dblVal;
            [FieldOffset(0)]
            public bool boolVal;
            [FieldOffset(0)]
            public int scode;
            [FieldOffset(0)]
            public long cyVal;
            [FieldOffset(0)]
            public double date;
            [FieldOffset(0)]
            public FILETIME filetime;
            [FieldOffset(0)]
            public Guid* puuid;
            [FieldOffset(0)]
            public CLIPDATA* pclipdata;
            [FieldOffset(0)]
            public char* bstrVal;
            [FieldOffset(0)]
            public BSTRBLOB bstrblobVal;
            [FieldOffset(0)]
            public BLOB blob;
            [FieldOffset(0)]
            public sbyte* pszVal;
            [FieldOffset(0)]
            public char* pwszVal;
            [FieldOffset(0)]
            public IUnknown punkVal;
            [FieldOffset(0)]
            public void* pdispVal;
            [FieldOffset(0)]
            public IStream pStream;
            [FieldOffset(0)]
            public IStorage pStorage;
            [FieldOffset(0)]
            public VERSIONEDSTREAM* pVersionedStream;
            [FieldOffset(0)]
            public SAFEARRAY* parray;
            [FieldOffset(0)]
            public CAC cac;
            [FieldOffset(0)]
            public CAUB caub;
            [FieldOffset(0)]
            public CAI cai;
            [FieldOffset(0)]
            public CAUI caui;
            [FieldOffset(0)]
            public CAL cal;
            [FieldOffset(0)]
            public CAUL caul;
            [FieldOffset(0)]
            public CAH cah;
            [FieldOffset(0)]
            public CAUH cauh;
            [FieldOffset(0)]
            public CAFLT caflt;
            [FieldOffset(0)]
            public CADBL cadbl;
            [FieldOffset(0)]
            public CABOOL cabool;
            [FieldOffset(0)]
            public CASCODE cascode;
            [FieldOffset(0)]
            public CACY cacy;
            [FieldOffset(0)]
            public CADATE cadate;
            [FieldOffset(0)]
            public CAFILETIME cafiletime;
            [FieldOffset(0)]
            public CACLSID cauuid;
            [FieldOffset(0)]
            public CACLIPDATA caclipdata;
            [FieldOffset(0)]
            public CABSTR cabstr;
            [FieldOffset(0)]
            public CABSTRBLOB cabstrblob;
            [FieldOffset(0)]
            public CALPSTR calpstr;
            [FieldOffset(0)]
            public CALPWSTR calpwstr;
            [FieldOffset(0)]
            public CAPROPVARIANT capropvar;
            [FieldOffset(0)]
            public sbyte* pcVal;
            [FieldOffset(0)]
            public byte* pbVal;
            [FieldOffset(0)]
            public short* piVal;
            [FieldOffset(0)]
            public ushort* puiVal;
            [FieldOffset(0)]
            public int* plVal;
            [FieldOffset(0)]
            public uint* pulVal;
            [FieldOffset(0)]
            public int* pintVal;
            [FieldOffset(0)]
            public uint* puintVal;
            [FieldOffset(0)]
            public float* pfltVal;
            [FieldOffset(0)]
            public double* pdblVal;
            [FieldOffset(0)]
            public bool* pboolVal;
            [FieldOffset(0)]
            public decimal* pdecVal;
            [FieldOffset(0)]
            public int* pscode;
            [FieldOffset(0)]
            public long* pcyVal;
            [FieldOffset(0)]
            public double* pdate;
            [FieldOffset(0)]
            public char** pbstrVal;
            [FieldOffset(0)]
            public IUnknown* ppunkVal;
            [FieldOffset(0)]
            public void** ppdispVal;
            [FieldOffset(0)]
            public SAFEARRAY** pparray;
            [FieldOffset(0)]
            public void* pvarVal;

            public unsafe static int GetSize()
            {
                return Marshal.SizeOf(typeof(__MIDL___MIDL_itf_Common_0002_0006_0018));
            }

            public unsafe override bool Equals(object obj)
            {
                if (!(obj is __MIDL___MIDL_itf_Common_0002_0006_0018))
                    return false;
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0018* address = &this)
                {
                    __MIDL___MIDL_itf_Common_0002_0006_0018 other = (__MIDL___MIDL_itf_Common_0002_0006_0018)obj;
                    IntPtr size = new IntPtr(GetSize());
                    IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                    return size == equalBytes;
                }
            }

            public unsafe override int GetHashCode()
            {
                int result = 0;
                int size = GetSize();
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0018* address = &this)
                {
                    byte* byteAddress = (byte*)address;
                    for (int i = 0; i < size; i++)
                        result ^= byteAddress[i] << i;
                }
                return result;
            }

            public unsafe static bool operator ==(__MIDL___MIDL_itf_Common_0002_0006_0018 left, __MIDL___MIDL_itf_Common_0002_0006_0018 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size == equalBytes;
            }

            public unsafe static bool operator !=(__MIDL___MIDL_itf_Common_0002_0006_0018 left, __MIDL___MIDL_itf_Common_0002_0006_0018 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size != equalBytes;
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        public unsafe struct Array1D_byte_8
        {
            private const int length0 = 8;

            private fixed byte data[8];

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

            public static unsafe implicit operator byte[](Array1D_byte_8 value)
            {
                byte[] result = new byte[8];
                byte* pointer = value.data;
                {
                    for (int i = 0; i < 8; i++)
                        result[i] = pointer[i];
                }
                return result;
            }

            public static unsafe implicit operator Array1D_byte_8(byte[] value)
            {
                if (value == null)
                   throw new ArgumentNullException("value");
                Array1D_byte_8 result = new Array1D_byte_8();
                byte* pointer = result.data;
                for (int i = 0; i < ((value.Length < 8) ? value.Length : 8); i++)
                    pointer[i] = value[i];
                return result;
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        public unsafe struct Array1D_SAFEARRAYBOUND_1
        {
            private const int length0 = 1;

            private SAFEARRAYBOUND data0;

            public unsafe SAFEARRAYBOUND this[int index0]
            {
                get
                {
                    fixed (SAFEARRAYBOUND* pointer = &data0)
                    {
                        return pointer[index0];
                    }
                }
                set
                {
                    fixed (SAFEARRAYBOUND* pointer = &data0)
                    {
                        pointer[index0] = value;
                    }
                }
            }

            public static unsafe implicit operator SAFEARRAYBOUND[](Array1D_SAFEARRAYBOUND_1 value)
            {
                SAFEARRAYBOUND[] result = new SAFEARRAYBOUND[1];
                SAFEARRAYBOUND* pointer = &value.data0;
                {
                    for (int i = 0; i < 1; i++)
                        result[i] = pointer[i];
                }
                return result;
            }

            public static unsafe implicit operator Array1D_SAFEARRAYBOUND_1(SAFEARRAYBOUND[] value)
            {
                if (value == null)
                   throw new ArgumentNullException("value");
                Array1D_SAFEARRAYBOUND_1 result = new Array1D_SAFEARRAYBOUND_1();
                SAFEARRAYBOUND* pointer = &result.data0;
                for (int i = 0; i < ((value.Length < 1) ? value.Length : 1); i++)
                    pointer[i] = value[i];
                return result;
            }
        }

        public __MIDL___MIDL_itf_Common_0002_0006_0016 __MIDL____MIDL_itf_Common_0002_00060011;

        public ushort vt
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.vt;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.vt = value;
            }
        }

        public ushort wReserved1
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.wReserved1;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.wReserved1 = value;
            }
        }

        public ushort wReserved2
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.wReserved2;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.wReserved2 = value;
            }
        }

        public ushort wReserved3
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.wReserved3;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.wReserved3 = value;
            }
        }

        public sbyte cVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cVal = value;
            }
        }

        public byte bVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.bVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.bVal = value;
            }
        }

        public short iVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.iVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.iVal = value;
            }
        }

        public ushort uiVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.uiVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.uiVal = value;
            }
        }

        public int lVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.lVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.lVal = value;
            }
        }

        public uint ulVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.ulVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.ulVal = value;
            }
        }

        public int intVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.intVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.intVal = value;
            }
        }

        public uint uintVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.uintVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.uintVal = value;
            }
        }

        public long hVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.hVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.hVal = value;
            }
        }

        public ulong uhVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.uhVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.uhVal = value;
            }
        }

        public float fltVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.fltVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.fltVal = value;
            }
        }

        public double dblVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.dblVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.dblVal = value;
            }
        }

        public bool boolVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.boolVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.boolVal = value;
            }
        }

        public int scode
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.scode;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.scode = value;
            }
        }

        public long cyVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cyVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cyVal = value;
            }
        }

        public double date
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.date;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.date = value;
            }
        }

        public FILETIME filetime
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.filetime;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.filetime = value;
            }
        }

        public Guid* puuid
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.puuid;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.puuid = value;
            }
        }

        public CLIPDATA* pclipdata
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pclipdata;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pclipdata = value;
            }
        }

        public char* bstrVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.bstrVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.bstrVal = value;
            }
        }

        public BSTRBLOB bstrblobVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.bstrblobVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.bstrblobVal = value;
            }
        }

        public BLOB blob
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.blob;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.blob = value;
            }
        }

        public sbyte* pszVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pszVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pszVal = value;
            }
        }

        public char* pwszVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pwszVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pwszVal = value;
            }
        }

        public IUnknown punkVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.punkVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.punkVal = value;
            }
        }

        public void* pdispVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pdispVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pdispVal = value;
            }
        }

        public IStream pStream
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pStream;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pStream = value;
            }
        }

        public IStorage pStorage
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pStorage;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pStorage = value;
            }
        }

        public VERSIONEDSTREAM* pVersionedStream
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pVersionedStream;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pVersionedStream = value;
            }
        }

        public SAFEARRAY* parray
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.parray;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.parray = value;
            }
        }

        public CAC cac
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cac;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cac = value;
            }
        }

        public CAUB caub
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.caub;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.caub = value;
            }
        }

        public CAI cai
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cai;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cai = value;
            }
        }

        public CAUI caui
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.caui;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.caui = value;
            }
        }

        public CAL cal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cal = value;
            }
        }

        public CAUL caul
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.caul;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.caul = value;
            }
        }

        public CAH cah
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cah;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cah = value;
            }
        }

        public CAUH cauh
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cauh;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cauh = value;
            }
        }

        public CAFLT caflt
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.caflt;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.caflt = value;
            }
        }

        public CADBL cadbl
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cadbl;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cadbl = value;
            }
        }

        public CABOOL cabool
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cabool;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cabool = value;
            }
        }

        public CASCODE cascode
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cascode;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cascode = value;
            }
        }

        public CACY cacy
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cacy;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cacy = value;
            }
        }

        public CADATE cadate
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cadate;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cadate = value;
            }
        }

        public CAFILETIME cafiletime
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cafiletime;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cafiletime = value;
            }
        }

        public CACLSID cauuid
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cauuid;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cauuid = value;
            }
        }

        public CACLIPDATA caclipdata
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.caclipdata;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.caclipdata = value;
            }
        }

        public CABSTR cabstr
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cabstr;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cabstr = value;
            }
        }

        public CABSTRBLOB cabstrblob
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cabstrblob;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.cabstrblob = value;
            }
        }

        public CALPSTR calpstr
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.calpstr;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.calpstr = value;
            }
        }

        public CALPWSTR calpwstr
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.calpwstr;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.calpwstr = value;
            }
        }

        public CAPROPVARIANT capropvar
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.capropvar;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.capropvar = value;
            }
        }

        public sbyte* pcVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pcVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pcVal = value;
            }
        }

        public byte* pbVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pbVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pbVal = value;
            }
        }

        public short* piVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.piVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.piVal = value;
            }
        }

        public ushort* puiVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.puiVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.puiVal = value;
            }
        }

        public int* plVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.plVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.plVal = value;
            }
        }

        public uint* pulVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pulVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pulVal = value;
            }
        }

        public int* pintVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pintVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pintVal = value;
            }
        }

        public uint* puintVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.puintVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.puintVal = value;
            }
        }

        public float* pfltVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pfltVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pfltVal = value;
            }
        }

        public double* pdblVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pdblVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pdblVal = value;
            }
        }

        public bool* pboolVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pboolVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pboolVal = value;
            }
        }

        public decimal* pdecVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pdecVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pdecVal = value;
            }
        }

        public int* pscode
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pscode;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pscode = value;
            }
        }

        public long* pcyVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pcyVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pcyVal = value;
            }
        }

        public double* pdate
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pdate;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pdate = value;
            }
        }

        public char** pbstrVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pbstrVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pbstrVal = value;
            }
        }

        public IUnknown* ppunkVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.ppunkVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.ppunkVal = value;
            }
        }

        public void** ppdispVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.ppdispVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.ppdispVal = value;
            }
        }

        public SAFEARRAY** pparray
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pparray;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pparray = value;
            }
        }

        public void* pvarVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pvarVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.__MIDL____MIDL_itf_Common_0002_00060010.__MIDL____MIDL_itf_Common_0002_00060009.pvarVal = value;
            }
        }

        public decimal decVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060011.decVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060011.decVal = value;
            }
        }

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(PROPVARIANT));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is PROPVARIANT))
                return false;
            fixed (PROPVARIANT* address = &this)
            {
                PROPVARIANT other = (PROPVARIANT)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (PROPVARIANT* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(PROPVARIANT left, PROPVARIANT right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(PROPVARIANT left, PROPVARIANT right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct RECT
    {
        public int left;
        public int top;
        public int right;
        public int bottom;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(RECT));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is RECT))
                return false;
            fixed (RECT* address = &this)
            {
                RECT other = (RECT)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (RECT* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(RECT left, RECT right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(RECT left, RECT right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct SAFEARRAY
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        public unsafe struct Array1D_SAFEARRAYBOUND_1
        {
            private const int length0 = 1;

            private SAFEARRAYBOUND data0;

            public unsafe SAFEARRAYBOUND this[int index0]
            {
                get
                {
                    fixed (SAFEARRAYBOUND* pointer = &data0)
                    {
                        return pointer[index0];
                    }
                }
                set
                {
                    fixed (SAFEARRAYBOUND* pointer = &data0)
                    {
                        pointer[index0] = value;
                    }
                }
            }

            public static unsafe implicit operator SAFEARRAYBOUND[](Array1D_SAFEARRAYBOUND_1 value)
            {
                SAFEARRAYBOUND[] result = new SAFEARRAYBOUND[1];
                SAFEARRAYBOUND* pointer = &value.data0;
                {
                    for (int i = 0; i < 1; i++)
                        result[i] = pointer[i];
                }
                return result;
            }

            public static unsafe implicit operator Array1D_SAFEARRAYBOUND_1(SAFEARRAYBOUND[] value)
            {
                if (value == null)
                   throw new ArgumentNullException("value");
                Array1D_SAFEARRAYBOUND_1 result = new Array1D_SAFEARRAYBOUND_1();
                SAFEARRAYBOUND* pointer = &result.data0;
                for (int i = 0; i < ((value.Length < 1) ? value.Length : 1); i++)
                    pointer[i] = value[i];
                return result;
            }
        }

        public ushort cDims;
        public ushort fFeatures;
        public uint cbElements;
        public uint cLocks;
        public void* pvData;
        public Array1D_SAFEARRAYBOUND_1 rgsabound;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(SAFEARRAY));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is SAFEARRAY))
                return false;
            fixed (SAFEARRAY* address = &this)
            {
                SAFEARRAY other = (SAFEARRAY)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (SAFEARRAY* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(SAFEARRAY left, SAFEARRAY right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(SAFEARRAY left, SAFEARRAY right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct SAFEARRAYBOUND
    {
        public uint cElements;
        public int lLbound;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(SAFEARRAYBOUND));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is SAFEARRAYBOUND))
                return false;
            fixed (SAFEARRAYBOUND* address = &this)
            {
                SAFEARRAYBOUND other = (SAFEARRAYBOUND)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (SAFEARRAYBOUND* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(SAFEARRAYBOUND left, SAFEARRAYBOUND right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(SAFEARRAYBOUND left, SAFEARRAYBOUND right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct SECURITY_ATTRIBUTES
    {
        public uint nLength;
        public void* lpSecurityDescriptor;
        public BOOL bInheritHandle;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(SECURITY_ATTRIBUTES));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is SECURITY_ATTRIBUTES))
                return false;
            fixed (SECURITY_ATTRIBUTES* address = &this)
            {
                SECURITY_ATTRIBUTES other = (SECURITY_ATTRIBUTES)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (SECURITY_ATTRIBUTES* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(SECURITY_ATTRIBUTES left, SECURITY_ATTRIBUTES right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(SECURITY_ATTRIBUTES left, SECURITY_ATTRIBUTES right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct SIZE
    {
        public int cx;
        public int cy;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(SIZE));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is SIZE))
                return false;
            fixed (SIZE* address = &this)
            {
                SIZE other = (SIZE)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (SIZE* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(SIZE left, SIZE right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(SIZE left, SIZE right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct STATSTG
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        public unsafe struct Array1D_byte_8
        {
            private const int length0 = 8;

            private fixed byte data[8];

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

            public static unsafe implicit operator byte[](Array1D_byte_8 value)
            {
                byte[] result = new byte[8];
                byte* pointer = value.data;
                {
                    for (int i = 0; i < 8; i++)
                        result[i] = pointer[i];
                }
                return result;
            }

            public static unsafe implicit operator Array1D_byte_8(byte[] value)
            {
                if (value == null)
                   throw new ArgumentNullException("value");
                Array1D_byte_8 result = new Array1D_byte_8();
                byte* pointer = result.data;
                for (int i = 0; i < ((value.Length < 8) ? value.Length : 8); i++)
                    pointer[i] = value[i];
                return result;
            }
        }

        public char* pwcsName;
        public uint type;
        public ulong cbSize;
        public FILETIME mtime;
        public FILETIME ctime;
        public FILETIME atime;
        public uint grfMode;
        public uint grfLocksSupported;
        public Guid clsid;
        public uint grfStateBits;
        public uint reserved;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(STATSTG));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is STATSTG))
                return false;
            fixed (STATSTG* address = &this)
            {
                STATSTG other = (STATSTG)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (STATSTG* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(STATSTG left, STATSTG right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(STATSTG left, STATSTG right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct SYSTEMTIME
    {
        public ushort wYear;
        public ushort wMonth;
        public ushort wDayOfWeek;
        public ushort wDay;
        public ushort wHour;
        public ushort wMinute;
        public ushort wSecond;
        public ushort wMilliseconds;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(SYSTEMTIME));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is SYSTEMTIME))
                return false;
            fixed (SYSTEMTIME* address = &this)
            {
                SYSTEMTIME other = (SYSTEMTIME)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (SYSTEMTIME* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(SYSTEMTIME left, SYSTEMTIME right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(SYSTEMTIME left, SYSTEMTIME right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct TLIBATTR
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        public unsafe struct Array1D_byte_8
        {
            private const int length0 = 8;

            private fixed byte data[8];

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

            public static unsafe implicit operator byte[](Array1D_byte_8 value)
            {
                byte[] result = new byte[8];
                byte* pointer = value.data;
                {
                    for (int i = 0; i < 8; i++)
                        result[i] = pointer[i];
                }
                return result;
            }

            public static unsafe implicit operator Array1D_byte_8(byte[] value)
            {
                if (value == null)
                   throw new ArgumentNullException("value");
                Array1D_byte_8 result = new Array1D_byte_8();
                byte* pointer = result.data;
                for (int i = 0; i < ((value.Length < 8) ? value.Length : 8); i++)
                    pointer[i] = value[i];
                return result;
            }
        }

        public Guid guid;
        public uint lcid;
        public SYSKIND syskind;
        public ushort wMajorVerNum;
        public ushort wMinorVerNum;
        public ushort wLibFlags;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(TLIBATTR));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is TLIBATTR))
                return false;
            fixed (TLIBATTR* address = &this)
            {
                TLIBATTR other = (TLIBATTR)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (TLIBATTR* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(TLIBATTR left, TLIBATTR right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(TLIBATTR left, TLIBATTR right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct TYPEATTR
    {
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public unsafe struct __MIDL___MIDL_itf_Common_0002_0006_0006
        {
            [FieldOffset(0)]
            public TYPEDESC* lptdesc;
            [FieldOffset(0)]
            public ARRAYDESC* lpadesc;
            [FieldOffset(0)]
            public uint hreftype;

            public unsafe static int GetSize()
            {
                return Marshal.SizeOf(typeof(__MIDL___MIDL_itf_Common_0002_0006_0006));
            }

            public unsafe override bool Equals(object obj)
            {
                if (!(obj is __MIDL___MIDL_itf_Common_0002_0006_0006))
                    return false;
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0006* address = &this)
                {
                    __MIDL___MIDL_itf_Common_0002_0006_0006 other = (__MIDL___MIDL_itf_Common_0002_0006_0006)obj;
                    IntPtr size = new IntPtr(GetSize());
                    IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                    return size == equalBytes;
                }
            }

            public unsafe override int GetHashCode()
            {
                int result = 0;
                int size = GetSize();
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0006* address = &this)
                {
                    byte* byteAddress = (byte*)address;
                    for (int i = 0; i < size; i++)
                        result ^= byteAddress[i] << i;
                }
                return result;
            }

            public unsafe static bool operator ==(__MIDL___MIDL_itf_Common_0002_0006_0006 left, __MIDL___MIDL_itf_Common_0002_0006_0006 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size == equalBytes;
            }

            public unsafe static bool operator !=(__MIDL___MIDL_itf_Common_0002_0006_0006 left, __MIDL___MIDL_itf_Common_0002_0006_0006 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size != equalBytes;
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        public unsafe struct Array1D_byte_8
        {
            private const int length0 = 8;

            private fixed byte data[8];

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

            public static unsafe implicit operator byte[](Array1D_byte_8 value)
            {
                byte[] result = new byte[8];
                byte* pointer = value.data;
                {
                    for (int i = 0; i < 8; i++)
                        result[i] = pointer[i];
                }
                return result;
            }

            public static unsafe implicit operator Array1D_byte_8(byte[] value)
            {
                if (value == null)
                   throw new ArgumentNullException("value");
                Array1D_byte_8 result = new Array1D_byte_8();
                byte* pointer = result.data;
                for (int i = 0; i < ((value.Length < 8) ? value.Length : 8); i++)
                    pointer[i] = value[i];
                return result;
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        public unsafe struct Array1D_SAFEARRAYBOUND_1
        {
            private const int length0 = 1;

            private SAFEARRAYBOUND data0;

            public unsafe SAFEARRAYBOUND this[int index0]
            {
                get
                {
                    fixed (SAFEARRAYBOUND* pointer = &data0)
                    {
                        return pointer[index0];
                    }
                }
                set
                {
                    fixed (SAFEARRAYBOUND* pointer = &data0)
                    {
                        pointer[index0] = value;
                    }
                }
            }

            public static unsafe implicit operator SAFEARRAYBOUND[](Array1D_SAFEARRAYBOUND_1 value)
            {
                SAFEARRAYBOUND[] result = new SAFEARRAYBOUND[1];
                SAFEARRAYBOUND* pointer = &value.data0;
                {
                    for (int i = 0; i < 1; i++)
                        result[i] = pointer[i];
                }
                return result;
            }

            public static unsafe implicit operator Array1D_SAFEARRAYBOUND_1(SAFEARRAYBOUND[] value)
            {
                if (value == null)
                   throw new ArgumentNullException("value");
                Array1D_SAFEARRAYBOUND_1 result = new Array1D_SAFEARRAYBOUND_1();
                SAFEARRAYBOUND* pointer = &result.data0;
                for (int i = 0; i < ((value.Length < 1) ? value.Length : 1); i++)
                    pointer[i] = value[i];
                return result;
            }
        }

        public Guid guid;
        public uint lcid;
        public uint dwReserved;
        public int memidConstructor;
        public int memidDestructor;
        public char* lpstrSchema;
        public uint cbSizeInstance;
        public TYPEKIND typekind;
        public ushort cFuncs;
        public ushort cVars;
        public ushort cImplTypes;
        public ushort cbSizeVft;
        public ushort cbAlignment;
        public ushort wTypeFlags;
        public ushort wMajorVerNum;
        public ushort wMinorVerNum;
        public TYPEDESC tdescAlias;
        public IDLDESC idldescType;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(TYPEATTR));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is TYPEATTR))
                return false;
            fixed (TYPEATTR* address = &this)
            {
                TYPEATTR other = (TYPEATTR)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (TYPEATTR* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(TYPEATTR left, TYPEATTR right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(TYPEATTR left, TYPEATTR right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct TYPEDESC
    {
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public unsafe struct __MIDL___MIDL_itf_Common_0002_0006_0006
        {
            [FieldOffset(0)]
            public TYPEDESC* lptdesc;
            [FieldOffset(0)]
            public ARRAYDESC* lpadesc;
            [FieldOffset(0)]
            public uint hreftype;

            public unsafe static int GetSize()
            {
                return Marshal.SizeOf(typeof(__MIDL___MIDL_itf_Common_0002_0006_0006));
            }

            public unsafe override bool Equals(object obj)
            {
                if (!(obj is __MIDL___MIDL_itf_Common_0002_0006_0006))
                    return false;
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0006* address = &this)
                {
                    __MIDL___MIDL_itf_Common_0002_0006_0006 other = (__MIDL___MIDL_itf_Common_0002_0006_0006)obj;
                    IntPtr size = new IntPtr(GetSize());
                    IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                    return size == equalBytes;
                }
            }

            public unsafe override int GetHashCode()
            {
                int result = 0;
                int size = GetSize();
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0006* address = &this)
                {
                    byte* byteAddress = (byte*)address;
                    for (int i = 0; i < size; i++)
                        result ^= byteAddress[i] << i;
                }
                return result;
            }

            public unsafe static bool operator ==(__MIDL___MIDL_itf_Common_0002_0006_0006 left, __MIDL___MIDL_itf_Common_0002_0006_0006 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size == equalBytes;
            }

            public unsafe static bool operator !=(__MIDL___MIDL_itf_Common_0002_0006_0006 left, __MIDL___MIDL_itf_Common_0002_0006_0006 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size != equalBytes;
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        public unsafe struct Array1D_SAFEARRAYBOUND_1
        {
            private const int length0 = 1;

            private SAFEARRAYBOUND data0;

            public unsafe SAFEARRAYBOUND this[int index0]
            {
                get
                {
                    fixed (SAFEARRAYBOUND* pointer = &data0)
                    {
                        return pointer[index0];
                    }
                }
                set
                {
                    fixed (SAFEARRAYBOUND* pointer = &data0)
                    {
                        pointer[index0] = value;
                    }
                }
            }

            public static unsafe implicit operator SAFEARRAYBOUND[](Array1D_SAFEARRAYBOUND_1 value)
            {
                SAFEARRAYBOUND[] result = new SAFEARRAYBOUND[1];
                SAFEARRAYBOUND* pointer = &value.data0;
                {
                    for (int i = 0; i < 1; i++)
                        result[i] = pointer[i];
                }
                return result;
            }

            public static unsafe implicit operator Array1D_SAFEARRAYBOUND_1(SAFEARRAYBOUND[] value)
            {
                if (value == null)
                   throw new ArgumentNullException("value");
                Array1D_SAFEARRAYBOUND_1 result = new Array1D_SAFEARRAYBOUND_1();
                SAFEARRAYBOUND* pointer = &result.data0;
                for (int i = 0; i < ((value.Length < 1) ? value.Length : 1); i++)
                    pointer[i] = value[i];
                return result;
            }
        }

        public __MIDL___MIDL_itf_Common_0002_0006_0006 __MIDL____MIDL_itf_Common_0002_00060007;
        public ushort vt;

        public TYPEDESC* lptdesc
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060007.lptdesc;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060007.lptdesc = value;
            }
        }

        public ARRAYDESC* lpadesc
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060007.lpadesc;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060007.lpadesc = value;
            }
        }

        public uint hreftype
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060007.hreftype;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060007.hreftype = value;
            }
        }

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(TYPEDESC));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is TYPEDESC))
                return false;
            fixed (TYPEDESC* address = &this)
            {
                TYPEDESC other = (TYPEDESC)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (TYPEDESC* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(TYPEDESC left, TYPEDESC right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(TYPEDESC left, TYPEDESC right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct VARDESC
    {
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public unsafe struct __MIDL___MIDL_itf_Common_0002_0006_0007
        {
            [FieldOffset(0)]
            public uint oInst;
            [FieldOffset(0)]
            public VARIANT* lpvarValue;

            public unsafe static int GetSize()
            {
                return Marshal.SizeOf(typeof(__MIDL___MIDL_itf_Common_0002_0006_0007));
            }

            public unsafe override bool Equals(object obj)
            {
                if (!(obj is __MIDL___MIDL_itf_Common_0002_0006_0007))
                    return false;
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0007* address = &this)
                {
                    __MIDL___MIDL_itf_Common_0002_0006_0007 other = (__MIDL___MIDL_itf_Common_0002_0006_0007)obj;
                    IntPtr size = new IntPtr(GetSize());
                    IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                    return size == equalBytes;
                }
            }

            public unsafe override int GetHashCode()
            {
                int result = 0;
                int size = GetSize();
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0007* address = &this)
                {
                    byte* byteAddress = (byte*)address;
                    for (int i = 0; i < size; i++)
                        result ^= byteAddress[i] << i;
                }
                return result;
            }

            public unsafe static bool operator ==(__MIDL___MIDL_itf_Common_0002_0006_0007 left, __MIDL___MIDL_itf_Common_0002_0006_0007 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size == equalBytes;
            }

            public unsafe static bool operator !=(__MIDL___MIDL_itf_Common_0002_0006_0007 left, __MIDL___MIDL_itf_Common_0002_0006_0007 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size != equalBytes;
            }
        }

        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public unsafe struct __MIDL___MIDL_itf_Common_0002_0006_0006
        {
            [FieldOffset(0)]
            public TYPEDESC* lptdesc;
            [FieldOffset(0)]
            public ARRAYDESC* lpadesc;
            [FieldOffset(0)]
            public uint hreftype;

            public unsafe static int GetSize()
            {
                return Marshal.SizeOf(typeof(__MIDL___MIDL_itf_Common_0002_0006_0006));
            }

            public unsafe override bool Equals(object obj)
            {
                if (!(obj is __MIDL___MIDL_itf_Common_0002_0006_0006))
                    return false;
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0006* address = &this)
                {
                    __MIDL___MIDL_itf_Common_0002_0006_0006 other = (__MIDL___MIDL_itf_Common_0002_0006_0006)obj;
                    IntPtr size = new IntPtr(GetSize());
                    IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                    return size == equalBytes;
                }
            }

            public unsafe override int GetHashCode()
            {
                int result = 0;
                int size = GetSize();
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0006* address = &this)
                {
                    byte* byteAddress = (byte*)address;
                    for (int i = 0; i < size; i++)
                        result ^= byteAddress[i] << i;
                }
                return result;
            }

            public unsafe static bool operator ==(__MIDL___MIDL_itf_Common_0002_0006_0006 left, __MIDL___MIDL_itf_Common_0002_0006_0006 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size == equalBytes;
            }

            public unsafe static bool operator !=(__MIDL___MIDL_itf_Common_0002_0006_0006 left, __MIDL___MIDL_itf_Common_0002_0006_0006 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size != equalBytes;
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        public unsafe struct Array1D_SAFEARRAYBOUND_1
        {
            private const int length0 = 1;

            private SAFEARRAYBOUND data0;

            public unsafe SAFEARRAYBOUND this[int index0]
            {
                get
                {
                    fixed (SAFEARRAYBOUND* pointer = &data0)
                    {
                        return pointer[index0];
                    }
                }
                set
                {
                    fixed (SAFEARRAYBOUND* pointer = &data0)
                    {
                        pointer[index0] = value;
                    }
                }
            }

            public static unsafe implicit operator SAFEARRAYBOUND[](Array1D_SAFEARRAYBOUND_1 value)
            {
                SAFEARRAYBOUND[] result = new SAFEARRAYBOUND[1];
                SAFEARRAYBOUND* pointer = &value.data0;
                {
                    for (int i = 0; i < 1; i++)
                        result[i] = pointer[i];
                }
                return result;
            }

            public static unsafe implicit operator Array1D_SAFEARRAYBOUND_1(SAFEARRAYBOUND[] value)
            {
                if (value == null)
                   throw new ArgumentNullException("value");
                Array1D_SAFEARRAYBOUND_1 result = new Array1D_SAFEARRAYBOUND_1();
                SAFEARRAYBOUND* pointer = &result.data0;
                for (int i = 0; i < ((value.Length < 1) ? value.Length : 1); i++)
                    pointer[i] = value[i];
                return result;
            }
        }

        public int memid;
        public char* lpstrSchema;
        public __MIDL___MIDL_itf_Common_0002_0006_0007 __MIDL____MIDL_itf_Common_0002_00060008;
        public ELEMDESC elemdescVar;
        public ushort wVarFlags;
        public VARKIND varkind;

        public uint oInst
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060008.oInst;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060008.oInst = value;
            }
        }

        public VARIANT* lpvarValue
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060008.lpvarValue;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060008.lpvarValue = value;
            }
        }

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(VARDESC));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is VARDESC))
                return false;
            fixed (VARDESC* address = &this)
            {
                VARDESC other = (VARDESC)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (VARDESC* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(VARDESC left, VARDESC right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(VARDESC left, VARDESC right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct VARIANT
    {
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public unsafe struct __MIDL___MIDL_itf_Common_0002_0006_0002
        {
            [FieldOffset(0)]
            public __MIDL___MIDL_itf_Common_0002_0006_0003 __MIDL____MIDL_itf_Common_0002_00060004;
            [FieldOffset(0)]
            public decimal decVal;

            public ushort vt
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.vt;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.vt = value;
                }
            }

            public ushort wReserved1
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.wReserved1;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.wReserved1 = value;
                }
            }

            public ushort wReserved2
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.wReserved2;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.wReserved2 = value;
                }
            }

            public ushort wReserved3
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.wReserved3;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.wReserved3 = value;
                }
            }

            public long llVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.llVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.llVal = value;
                }
            }

            public int lVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.lVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.lVal = value;
                }
            }

            public byte bVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.bVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.bVal = value;
                }
            }

            public short iVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.iVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.iVal = value;
                }
            }

            public float fltVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.fltVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.fltVal = value;
                }
            }

            public double dblVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.dblVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.dblVal = value;
                }
            }

            public bool boolVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.boolVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.boolVal = value;
                }
            }

            public int scode
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.scode;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.scode = value;
                }
            }

            public long cyVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.cyVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.cyVal = value;
                }
            }

            public double date
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.date;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.date = value;
                }
            }

            public char* bstrVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.bstrVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.bstrVal = value;
                }
            }

            public IUnknown punkVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.punkVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.punkVal = value;
                }
            }

            public void* pdispVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pdispVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pdispVal = value;
                }
            }

            public SAFEARRAY* parray
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.parray;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.parray = value;
                }
            }

            public byte* pbVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pbVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pbVal = value;
                }
            }

            public short* piVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.piVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.piVal = value;
                }
            }

            public int* plVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.plVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.plVal = value;
                }
            }

            public long* pllVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pllVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pllVal = value;
                }
            }

            public float* pfltVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pfltVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pfltVal = value;
                }
            }

            public double* pdblVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pdblVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pdblVal = value;
                }
            }

            public bool* pboolVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pboolVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pboolVal = value;
                }
            }

            public int* pscode
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pscode;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pscode = value;
                }
            }

            public long* pcyVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pcyVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pcyVal = value;
                }
            }

            public double* pdate
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pdate;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pdate = value;
                }
            }

            public char** pbstrVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pbstrVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pbstrVal = value;
                }
            }

            public IUnknown* ppunkVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.ppunkVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.ppunkVal = value;
                }
            }

            public void** ppdispVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.ppdispVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.ppdispVal = value;
                }
            }

            public SAFEARRAY** pparray
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pparray;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pparray = value;
                }
            }

            public VARIANT* pvarVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pvarVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pvarVal = value;
                }
            }

            public void* byref
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.byref;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.byref = value;
                }
            }

            public sbyte cVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.cVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.cVal = value;
                }
            }

            public ushort uiVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.uiVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.uiVal = value;
                }
            }

            public uint ulVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.ulVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.ulVal = value;
                }
            }

            public ulong ullVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.ullVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.ullVal = value;
                }
            }

            public int intVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.intVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.intVal = value;
                }
            }

            public uint uintVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.uintVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.uintVal = value;
                }
            }

            public decimal* pdecVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pdecVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pdecVal = value;
                }
            }

            public sbyte* pcVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pcVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pcVal = value;
                }
            }

            public ushort* puiVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.puiVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.puiVal = value;
                }
            }

            public uint* pulVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pulVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pulVal = value;
                }
            }

            public ulong* pullVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pullVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pullVal = value;
                }
            }

            public int* pintVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pintVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pintVal = value;
                }
            }

            public uint* puintVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.puintVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.puintVal = value;
                }
            }

            public void* pvRecord
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.__MIDL____MIDL_itf_Common_0002_00060002.pvRecord;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.__MIDL____MIDL_itf_Common_0002_00060002.pvRecord = value;
                }
            }

            public IRecordInfo pRecInfo
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.__MIDL____MIDL_itf_Common_0002_00060002.pRecInfo;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.__MIDL____MIDL_itf_Common_0002_00060002.pRecInfo = value;
                }
            }

            public unsafe static int GetSize()
            {
                return Marshal.SizeOf(typeof(__MIDL___MIDL_itf_Common_0002_0006_0002));
            }

            public unsafe override bool Equals(object obj)
            {
                if (!(obj is __MIDL___MIDL_itf_Common_0002_0006_0002))
                    return false;
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0002* address = &this)
                {
                    __MIDL___MIDL_itf_Common_0002_0006_0002 other = (__MIDL___MIDL_itf_Common_0002_0006_0002)obj;
                    IntPtr size = new IntPtr(GetSize());
                    IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                    return size == equalBytes;
                }
            }

            public unsafe override int GetHashCode()
            {
                int result = 0;
                int size = GetSize();
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0002* address = &this)
                {
                    byte* byteAddress = (byte*)address;
                    for (int i = 0; i < size; i++)
                        result ^= byteAddress[i] << i;
                }
                return result;
            }

            public unsafe static bool operator ==(__MIDL___MIDL_itf_Common_0002_0006_0002 left, __MIDL___MIDL_itf_Common_0002_0006_0002 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size == equalBytes;
            }

            public unsafe static bool operator !=(__MIDL___MIDL_itf_Common_0002_0006_0002 left, __MIDL___MIDL_itf_Common_0002_0006_0002 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size != equalBytes;
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public unsafe struct __MIDL___MIDL_itf_Common_0002_0006_0003
        {
            public ushort vt;
            public ushort wReserved1;
            public ushort wReserved2;
            public ushort wReserved3;
            public __MIDL___MIDL_itf_Common_0002_0006_0004 __MIDL____MIDL_itf_Common_0002_00060003;

            public long llVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.llVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.llVal = value;
                }
            }

            public int lVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.lVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.lVal = value;
                }
            }

            public byte bVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.bVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.bVal = value;
                }
            }

            public short iVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.iVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.iVal = value;
                }
            }

            public float fltVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.fltVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.fltVal = value;
                }
            }

            public double dblVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.dblVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.dblVal = value;
                }
            }

            public bool boolVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.boolVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.boolVal = value;
                }
            }

            public int scode
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.scode;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.scode = value;
                }
            }

            public long cyVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.cyVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.cyVal = value;
                }
            }

            public double date
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.date;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.date = value;
                }
            }

            public char* bstrVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.bstrVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.bstrVal = value;
                }
            }

            public IUnknown punkVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.punkVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.punkVal = value;
                }
            }

            public void* pdispVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.pdispVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.pdispVal = value;
                }
            }

            public SAFEARRAY* parray
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.parray;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.parray = value;
                }
            }

            public byte* pbVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.pbVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.pbVal = value;
                }
            }

            public short* piVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.piVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.piVal = value;
                }
            }

            public int* plVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.plVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.plVal = value;
                }
            }

            public long* pllVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.pllVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.pllVal = value;
                }
            }

            public float* pfltVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.pfltVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.pfltVal = value;
                }
            }

            public double* pdblVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.pdblVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.pdblVal = value;
                }
            }

            public bool* pboolVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.pboolVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.pboolVal = value;
                }
            }

            public int* pscode
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.pscode;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.pscode = value;
                }
            }

            public long* pcyVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.pcyVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.pcyVal = value;
                }
            }

            public double* pdate
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.pdate;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.pdate = value;
                }
            }

            public char** pbstrVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.pbstrVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.pbstrVal = value;
                }
            }

            public IUnknown* ppunkVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.ppunkVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.ppunkVal = value;
                }
            }

            public void** ppdispVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.ppdispVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.ppdispVal = value;
                }
            }

            public SAFEARRAY** pparray
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.pparray;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.pparray = value;
                }
            }

            public VARIANT* pvarVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.pvarVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.pvarVal = value;
                }
            }

            public void* byref
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.byref;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.byref = value;
                }
            }

            public sbyte cVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.cVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.cVal = value;
                }
            }

            public ushort uiVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.uiVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.uiVal = value;
                }
            }

            public uint ulVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.ulVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.ulVal = value;
                }
            }

            public ulong ullVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.ullVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.ullVal = value;
                }
            }

            public int intVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.intVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.intVal = value;
                }
            }

            public uint uintVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.uintVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.uintVal = value;
                }
            }

            public decimal* pdecVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.pdecVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.pdecVal = value;
                }
            }

            public sbyte* pcVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.pcVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.pcVal = value;
                }
            }

            public ushort* puiVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.puiVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.puiVal = value;
                }
            }

            public uint* pulVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.pulVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.pulVal = value;
                }
            }

            public ulong* pullVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.pullVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.pullVal = value;
                }
            }

            public int* pintVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.pintVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.pintVal = value;
                }
            }

            public uint* puintVal
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.puintVal;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.puintVal = value;
                }
            }

            public void* pvRecord
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.__MIDL____MIDL_itf_Common_0002_00060002.pvRecord;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.__MIDL____MIDL_itf_Common_0002_00060002.pvRecord = value;
                }
            }

            public IRecordInfo pRecInfo
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060003.__MIDL____MIDL_itf_Common_0002_00060002.pRecInfo;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060003.__MIDL____MIDL_itf_Common_0002_00060002.pRecInfo = value;
                }
            }

            public unsafe static int GetSize()
            {
                return Marshal.SizeOf(typeof(__MIDL___MIDL_itf_Common_0002_0006_0003));
            }

            public unsafe override bool Equals(object obj)
            {
                if (!(obj is __MIDL___MIDL_itf_Common_0002_0006_0003))
                    return false;
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0003* address = &this)
                {
                    __MIDL___MIDL_itf_Common_0002_0006_0003 other = (__MIDL___MIDL_itf_Common_0002_0006_0003)obj;
                    IntPtr size = new IntPtr(GetSize());
                    IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                    return size == equalBytes;
                }
            }

            public unsafe override int GetHashCode()
            {
                int result = 0;
                int size = GetSize();
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0003* address = &this)
                {
                    byte* byteAddress = (byte*)address;
                    for (int i = 0; i < size; i++)
                        result ^= byteAddress[i] << i;
                }
                return result;
            }

            public unsafe static bool operator ==(__MIDL___MIDL_itf_Common_0002_0006_0003 left, __MIDL___MIDL_itf_Common_0002_0006_0003 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size == equalBytes;
            }

            public unsafe static bool operator !=(__MIDL___MIDL_itf_Common_0002_0006_0003 left, __MIDL___MIDL_itf_Common_0002_0006_0003 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size != equalBytes;
            }
        }

        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public unsafe struct __MIDL___MIDL_itf_Common_0002_0006_0004
        {
            [FieldOffset(0)]
            public long llVal;
            [FieldOffset(0)]
            public int lVal;
            [FieldOffset(0)]
            public byte bVal;
            [FieldOffset(0)]
            public short iVal;
            [FieldOffset(0)]
            public float fltVal;
            [FieldOffset(0)]
            public double dblVal;
            [FieldOffset(0)]
            public bool boolVal;
            [FieldOffset(0)]
            public int scode;
            [FieldOffset(0)]
            public long cyVal;
            [FieldOffset(0)]
            public double date;
            [FieldOffset(0)]
            public char* bstrVal;
            [FieldOffset(0)]
            public IUnknown punkVal;
            [FieldOffset(0)]
            public void* pdispVal;
            [FieldOffset(0)]
            public SAFEARRAY* parray;
            [FieldOffset(0)]
            public byte* pbVal;
            [FieldOffset(0)]
            public short* piVal;
            [FieldOffset(0)]
            public int* plVal;
            [FieldOffset(0)]
            public long* pllVal;
            [FieldOffset(0)]
            public float* pfltVal;
            [FieldOffset(0)]
            public double* pdblVal;
            [FieldOffset(0)]
            public bool* pboolVal;
            [FieldOffset(0)]
            public int* pscode;
            [FieldOffset(0)]
            public long* pcyVal;
            [FieldOffset(0)]
            public double* pdate;
            [FieldOffset(0)]
            public char** pbstrVal;
            [FieldOffset(0)]
            public IUnknown* ppunkVal;
            [FieldOffset(0)]
            public void** ppdispVal;
            [FieldOffset(0)]
            public SAFEARRAY** pparray;
            [FieldOffset(0)]
            public VARIANT* pvarVal;
            [FieldOffset(0)]
            public void* byref;
            [FieldOffset(0)]
            public sbyte cVal;
            [FieldOffset(0)]
            public ushort uiVal;
            [FieldOffset(0)]
            public uint ulVal;
            [FieldOffset(0)]
            public ulong ullVal;
            [FieldOffset(0)]
            public int intVal;
            [FieldOffset(0)]
            public uint uintVal;
            [FieldOffset(0)]
            public decimal* pdecVal;
            [FieldOffset(0)]
            public sbyte* pcVal;
            [FieldOffset(0)]
            public ushort* puiVal;
            [FieldOffset(0)]
            public uint* pulVal;
            [FieldOffset(0)]
            public ulong* pullVal;
            [FieldOffset(0)]
            public int* pintVal;
            [FieldOffset(0)]
            public uint* puintVal;
            [FieldOffset(0)]
            public __MIDL___MIDL_itf_Common_0002_0006_0005 __MIDL____MIDL_itf_Common_0002_00060002;

            public void* pvRecord
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060002.pvRecord;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060002.pvRecord = value;
                }
            }

            public IRecordInfo pRecInfo
            {
                get
                {
                    return __MIDL____MIDL_itf_Common_0002_00060002.pRecInfo;
                }
                set
                {
                    __MIDL____MIDL_itf_Common_0002_00060002.pRecInfo = value;
                }
            }

            public unsafe static int GetSize()
            {
                return Marshal.SizeOf(typeof(__MIDL___MIDL_itf_Common_0002_0006_0004));
            }

            public unsafe override bool Equals(object obj)
            {
                if (!(obj is __MIDL___MIDL_itf_Common_0002_0006_0004))
                    return false;
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0004* address = &this)
                {
                    __MIDL___MIDL_itf_Common_0002_0006_0004 other = (__MIDL___MIDL_itf_Common_0002_0006_0004)obj;
                    IntPtr size = new IntPtr(GetSize());
                    IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                    return size == equalBytes;
                }
            }

            public unsafe override int GetHashCode()
            {
                int result = 0;
                int size = GetSize();
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0004* address = &this)
                {
                    byte* byteAddress = (byte*)address;
                    for (int i = 0; i < size; i++)
                        result ^= byteAddress[i] << i;
                }
                return result;
            }

            public unsafe static bool operator ==(__MIDL___MIDL_itf_Common_0002_0006_0004 left, __MIDL___MIDL_itf_Common_0002_0006_0004 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size == equalBytes;
            }

            public unsafe static bool operator !=(__MIDL___MIDL_itf_Common_0002_0006_0004 left, __MIDL___MIDL_itf_Common_0002_0006_0004 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size != equalBytes;
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public unsafe struct __MIDL___MIDL_itf_Common_0002_0006_0005
        {
            public void* pvRecord;
            public IRecordInfo pRecInfo;

            public unsafe static int GetSize()
            {
                return Marshal.SizeOf(typeof(__MIDL___MIDL_itf_Common_0002_0006_0005));
            }

            public unsafe override bool Equals(object obj)
            {
                if (!(obj is __MIDL___MIDL_itf_Common_0002_0006_0005))
                    return false;
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0005* address = &this)
                {
                    __MIDL___MIDL_itf_Common_0002_0006_0005 other = (__MIDL___MIDL_itf_Common_0002_0006_0005)obj;
                    IntPtr size = new IntPtr(GetSize());
                    IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                    return size == equalBytes;
                }
            }

            public unsafe override int GetHashCode()
            {
                int result = 0;
                int size = GetSize();
                fixed (__MIDL___MIDL_itf_Common_0002_0006_0005* address = &this)
                {
                    byte* byteAddress = (byte*)address;
                    for (int i = 0; i < size; i++)
                        result ^= byteAddress[i] << i;
                }
                return result;
            }

            public unsafe static bool operator ==(__MIDL___MIDL_itf_Common_0002_0006_0005 left, __MIDL___MIDL_itf_Common_0002_0006_0005 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size == equalBytes;
            }

            public unsafe static bool operator !=(__MIDL___MIDL_itf_Common_0002_0006_0005 left, __MIDL___MIDL_itf_Common_0002_0006_0005 right)
            {
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
                return size != equalBytes;
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        public unsafe struct Array1D_SAFEARRAYBOUND_1
        {
            private const int length0 = 1;

            private SAFEARRAYBOUND data0;

            public unsafe SAFEARRAYBOUND this[int index0]
            {
                get
                {
                    fixed (SAFEARRAYBOUND* pointer = &data0)
                    {
                        return pointer[index0];
                    }
                }
                set
                {
                    fixed (SAFEARRAYBOUND* pointer = &data0)
                    {
                        pointer[index0] = value;
                    }
                }
            }

            public static unsafe implicit operator SAFEARRAYBOUND[](Array1D_SAFEARRAYBOUND_1 value)
            {
                SAFEARRAYBOUND[] result = new SAFEARRAYBOUND[1];
                SAFEARRAYBOUND* pointer = &value.data0;
                {
                    for (int i = 0; i < 1; i++)
                        result[i] = pointer[i];
                }
                return result;
            }

            public static unsafe implicit operator Array1D_SAFEARRAYBOUND_1(SAFEARRAYBOUND[] value)
            {
                if (value == null)
                   throw new ArgumentNullException("value");
                Array1D_SAFEARRAYBOUND_1 result = new Array1D_SAFEARRAYBOUND_1();
                SAFEARRAYBOUND* pointer = &result.data0;
                for (int i = 0; i < ((value.Length < 1) ? value.Length : 1); i++)
                    pointer[i] = value[i];
                return result;
            }
        }

        public __MIDL___MIDL_itf_Common_0002_0006_0002 __MIDL____MIDL_itf_Common_0002_00060005;

        public ushort vt
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.vt;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.vt = value;
            }
        }

        public ushort wReserved1
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.wReserved1;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.wReserved1 = value;
            }
        }

        public ushort wReserved2
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.wReserved2;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.wReserved2 = value;
            }
        }

        public ushort wReserved3
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.wReserved3;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.wReserved3 = value;
            }
        }

        public long llVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.llVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.llVal = value;
            }
        }

        public int lVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.lVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.lVal = value;
            }
        }

        public byte bVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.bVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.bVal = value;
            }
        }

        public short iVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.iVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.iVal = value;
            }
        }

        public float fltVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.fltVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.fltVal = value;
            }
        }

        public double dblVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.dblVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.dblVal = value;
            }
        }

        public bool boolVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.boolVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.boolVal = value;
            }
        }

        public int scode
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.scode;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.scode = value;
            }
        }

        public long cyVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.cyVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.cyVal = value;
            }
        }

        public double date
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.date;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.date = value;
            }
        }

        public char* bstrVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.bstrVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.bstrVal = value;
            }
        }

        public IUnknown punkVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.punkVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.punkVal = value;
            }
        }

        public void* pdispVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pdispVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pdispVal = value;
            }
        }

        public SAFEARRAY* parray
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.parray;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.parray = value;
            }
        }

        public byte* pbVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pbVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pbVal = value;
            }
        }

        public short* piVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.piVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.piVal = value;
            }
        }

        public int* plVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.plVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.plVal = value;
            }
        }

        public long* pllVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pllVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pllVal = value;
            }
        }

        public float* pfltVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pfltVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pfltVal = value;
            }
        }

        public double* pdblVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pdblVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pdblVal = value;
            }
        }

        public bool* pboolVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pboolVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pboolVal = value;
            }
        }

        public int* pscode
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pscode;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pscode = value;
            }
        }

        public long* pcyVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pcyVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pcyVal = value;
            }
        }

        public double* pdate
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pdate;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pdate = value;
            }
        }

        public char** pbstrVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pbstrVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pbstrVal = value;
            }
        }

        public IUnknown* ppunkVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.ppunkVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.ppunkVal = value;
            }
        }

        public void** ppdispVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.ppdispVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.ppdispVal = value;
            }
        }

        public SAFEARRAY** pparray
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pparray;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pparray = value;
            }
        }

        public VARIANT* pvarVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pvarVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pvarVal = value;
            }
        }

        public void* byref
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.byref;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.byref = value;
            }
        }

        public sbyte cVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.cVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.cVal = value;
            }
        }

        public ushort uiVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.uiVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.uiVal = value;
            }
        }

        public uint ulVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.ulVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.ulVal = value;
            }
        }

        public ulong ullVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.ullVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.ullVal = value;
            }
        }

        public int intVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.intVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.intVal = value;
            }
        }

        public uint uintVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.uintVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.uintVal = value;
            }
        }

        public decimal* pdecVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pdecVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pdecVal = value;
            }
        }

        public sbyte* pcVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pcVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pcVal = value;
            }
        }

        public ushort* puiVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.puiVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.puiVal = value;
            }
        }

        public uint* pulVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pulVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pulVal = value;
            }
        }

        public ulong* pullVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pullVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pullVal = value;
            }
        }

        public int* pintVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pintVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.pintVal = value;
            }
        }

        public uint* puintVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.puintVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.puintVal = value;
            }
        }

        public void* pvRecord
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.__MIDL____MIDL_itf_Common_0002_00060002.pvRecord;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.__MIDL____MIDL_itf_Common_0002_00060002.pvRecord = value;
            }
        }

        public IRecordInfo pRecInfo
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.__MIDL____MIDL_itf_Common_0002_00060002.pRecInfo;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.__MIDL____MIDL_itf_Common_0002_00060004.__MIDL____MIDL_itf_Common_0002_00060003.__MIDL____MIDL_itf_Common_0002_00060002.pRecInfo = value;
            }
        }

        public decimal decVal
        {
            get
            {
                return __MIDL____MIDL_itf_Common_0002_00060005.decVal;
            }
            set
            {
                __MIDL____MIDL_itf_Common_0002_00060005.decVal = value;
            }
        }

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(VARIANT));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is VARIANT))
                return false;
            fixed (VARIANT* address = &this)
            {
                VARIANT other = (VARIANT)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (VARIANT* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(VARIANT left, VARIANT right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(VARIANT left, VARIANT right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct VERSIONEDSTREAM
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        public unsafe struct Array1D_byte_8
        {
            private const int length0 = 8;

            private fixed byte data[8];

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

            public static unsafe implicit operator byte[](Array1D_byte_8 value)
            {
                byte[] result = new byte[8];
                byte* pointer = value.data;
                {
                    for (int i = 0; i < 8; i++)
                        result[i] = pointer[i];
                }
                return result;
            }

            public static unsafe implicit operator Array1D_byte_8(byte[] value)
            {
                if (value == null)
                   throw new ArgumentNullException("value");
                Array1D_byte_8 result = new Array1D_byte_8();
                byte* pointer = result.data;
                for (int i = 0; i < ((value.Length < 8) ? value.Length : 8); i++)
                    pointer[i] = value[i];
                return result;
            }
        }

        public Guid guidVersion;
        public IStream pStream;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(VERSIONEDSTREAM));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is VERSIONEDSTREAM))
                return false;
            fixed (VERSIONEDSTREAM* address = &this)
            {
                VERSIONEDSTREAM other = (VERSIONEDSTREAM)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (VERSIONEDSTREAM* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(VERSIONEDSTREAM left, VERSIONEDSTREAM right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(VERSIONEDSTREAM left, VERSIONEDSTREAM right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public unsafe struct WAVEFORMATEX
    {
        public ushort wFormatTag;
        public ushort nChannels;
        public uint nSamplesPerSec;
        public uint nAvgBytesPerSec;
        public ushort nBlockAlign;
        public ushort wBitsPerSample;
        public ushort cbSize;

        public unsafe static int GetSize()
        {
            return Marshal.SizeOf(typeof(WAVEFORMATEX));
        }

        public unsafe override bool Equals(object obj)
        {
            if (!(obj is WAVEFORMATEX))
                return false;
            fixed (WAVEFORMATEX* address = &this)
            {
                WAVEFORMATEX other = (WAVEFORMATEX)obj;
                IntPtr size = new IntPtr(GetSize());
                IntPtr equalBytes = NativeMethods.RtlCompareMemory(address, &other, size);
                return size == equalBytes;
            }
        }

        public unsafe override int GetHashCode()
        {
            int result = 0;
            int size = GetSize();
            fixed (WAVEFORMATEX* address = &this)
            {
                byte* byteAddress = (byte*)address;
                for (int i = 0; i < size; i++)
                    result ^= byteAddress[i] << i;
            }
            return result;
        }

        public unsafe static bool operator ==(WAVEFORMATEX left, WAVEFORMATEX right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size == equalBytes;
        }

        public unsafe static bool operator !=(WAVEFORMATEX left, WAVEFORMATEX right)
        {
            IntPtr size = new IntPtr(GetSize());
            IntPtr equalBytes = NativeMethods.RtlCompareMemory(&left, &right, size);
            return size != equalBytes;
        }
    }

    [ComImport]
    [Guid("0000000d-0000-0000-c000-000000000046")]
    public unsafe interface _IEnumSTATSTG : _IUnknown
    {
        [PreserveSig]
        unsafe new int QueryInterface(Guid* riid, IUnknown* ppvObject);

        [PreserveSig]
        unsafe new uint AddRef();

        [PreserveSig]
        unsafe new uint Release();

        [PreserveSig]
        unsafe int RemoteNext(uint celt, STATSTG* rgelt, uint* pceltFetched);

        [PreserveSig]
        unsafe int Skip(uint celt);

        [PreserveSig]
        unsafe int Reset();

        [PreserveSig]
        unsafe int Clone(IEnumSTATSTG* ppenum);
    }

    [ComImport]
    [Guid("00000101-0000-0000-c000-000000000046")]
    public unsafe interface _IEnumString : _IUnknown
    {
        [PreserveSig]
        unsafe new int QueryInterface(Guid* riid, IUnknown* ppvObject);

        [PreserveSig]
        unsafe new uint AddRef();

        [PreserveSig]
        unsafe new uint Release();

        [PreserveSig]
        unsafe int RemoteNext(uint celt, char** rgelt, uint* pceltFetched);

        [PreserveSig]
        unsafe int Skip(uint celt);

        [PreserveSig]
        unsafe int Reset();

        [PreserveSig]
        unsafe int Clone(IEnumString* ppenum);
    }

    [ComImport]
    [Guid("00000100-0000-0000-c000-000000000046")]
    public unsafe interface _IEnumUnknown : _IUnknown
    {
        [PreserveSig]
        unsafe new int QueryInterface(Guid* riid, IUnknown* ppvObject);

        [PreserveSig]
        unsafe new uint AddRef();

        [PreserveSig]
        unsafe new uint Release();

        [PreserveSig]
        unsafe int RemoteNext(uint celt, IUnknown* rgelt, uint* pceltFetched);

        [PreserveSig]
        unsafe int Skip(uint celt);

        [PreserveSig]
        unsafe int Reset();

        [PreserveSig]
        unsafe int Clone(IEnumUnknown* ppenum);
    }

    [ComImport]
    [Guid("3127ca40-446e-11ce-8135-00aa004bb851")]
    public unsafe interface _IErrorLog : _IUnknown
    {
        [PreserveSig]
        unsafe new int QueryInterface(Guid* riid, IUnknown* ppvObject);

        [PreserveSig]
        unsafe new uint AddRef();

        [PreserveSig]
        unsafe new uint Release();

        [PreserveSig]
        unsafe int AddError(char* pszPropName, EXCEPINFO* pExcepInfo);
    }

    [ComImport]
    [Guid("22f55882-280b-11d0-a8a9-00a0c90c2004")]
    public unsafe interface _IPropertyBag2 : _IUnknown
    {
        [PreserveSig]
        unsafe new int QueryInterface(Guid* riid, IUnknown* ppvObject);

        [PreserveSig]
        unsafe new uint AddRef();

        [PreserveSig]
        unsafe new uint Release();

        [PreserveSig]
        unsafe int Read(uint cProperties, PROPBAG2* pPropBag, IErrorLog pErrLog, VARIANT* pvarValue, int* phrError);

        [PreserveSig]
        unsafe int Write(uint cProperties, PROPBAG2* pPropBag, VARIANT* pvarValue);

        [PreserveSig]
        unsafe int CountProperties(uint* pcProperties);

        [PreserveSig]
        unsafe int GetPropertyInfo(uint iProperty, uint cProperties, PROPBAG2* pPropBag, uint* pcProperties);

        [PreserveSig]
        unsafe int LoadObject(char* pstrName, uint dwHint, IUnknown pUnkObject, IErrorLog pErrLog);
    }

    [ComImport]
    [Guid("0000002f-0000-0000-c000-000000000046")]
    public unsafe interface _IRecordInfo : _IUnknown
    {
        [PreserveSig]
        unsafe new int QueryInterface(Guid* riid, IUnknown* ppvObject);

        [PreserveSig]
        unsafe new uint AddRef();

        [PreserveSig]
        unsafe new uint Release();

        [PreserveSig]
        unsafe int RecordInit(void* pvNew);

        [PreserveSig]
        unsafe int RecordClear(void* pvExisting);

        [PreserveSig]
        unsafe int RecordCopy(void* pvExisting, void* pvNew);

        [PreserveSig]
        unsafe int GetGuid(Guid* pguid);

        [PreserveSig]
        unsafe int GetName(char** pbstrName);

        [PreserveSig]
        unsafe int GetSize(uint* pcbSize);

        [PreserveSig]
        unsafe int GetTypeInfo(ITypeInfo* ppTypeInfo);

        [PreserveSig]
        unsafe int GetField(void* pvData, char* szFieldName, VARIANT* pvarField);

        [PreserveSig]
        unsafe int GetFieldNoCopy(void* pvData, char* szFieldName, VARIANT* pvarField, void** ppvDataCArray);

        [PreserveSig]
        unsafe int PutField(uint wFlags, void* pvData, char* szFieldName, VARIANT* pvarField);

        [PreserveSig]
        unsafe int PutFieldNoCopy(uint wFlags, void* pvData, char* szFieldName, VARIANT* pvarField);

        [PreserveSig]
        unsafe int GetFieldNames(uint* pcNames, char** rgBstrNames);

        [PreserveSig]
        unsafe BOOL IsMatchingType(IRecordInfo pRecordInfo);

        [PreserveSig]
        unsafe void* RecordCreate();

        [PreserveSig]
        unsafe int RecordCreateCopy(void* pvSource, void** ppvDest);

        [PreserveSig]
        unsafe int RecordDestroy(void* pvRecord);
    }

    [ComImport]
    [Guid("0c733a30-2a1c-11ce-ade5-00aa0044773d")]
    public unsafe interface _ISequentialStream : _IUnknown
    {
        [PreserveSig]
        unsafe new int QueryInterface(Guid* riid, IUnknown* ppvObject);

        [PreserveSig]
        unsafe new uint AddRef();

        [PreserveSig]
        unsafe new uint Release();

        [PreserveSig]
        unsafe int RemoteRead(byte* pv, uint cb, uint* pcbRead);

        [PreserveSig]
        unsafe int RemoteWrite(byte* pv, uint cb, uint* pcbWritten);
    }

    [ComImport]
    [Guid("0000000b-0000-0000-c000-000000000046")]
    public unsafe interface _IStorage : _IUnknown
    {
        [PreserveSig]
        unsafe new int QueryInterface(Guid* riid, IUnknown* ppvObject);

        [PreserveSig]
        unsafe new uint AddRef();

        [PreserveSig]
        unsafe new uint Release();

        [PreserveSig]
        unsafe int CreateStream(char* pwcsName, uint grfMode, uint reserved1, uint reserved2, IStream* ppstm);

        [PreserveSig]
        unsafe int RemoteOpenStream(char* pwcsName, uint cbReserved1, byte* reserved1, uint grfMode, uint reserved2, IStream* ppstm);

        [PreserveSig]
        unsafe int CreateStorage(char* pwcsName, uint grfMode, uint reserved1, uint reserved2, IStorage* ppstg);

        [PreserveSig]
        unsafe int OpenStorage(char* pwcsName, IStorage pstgPriority, uint grfMode, char** snbExclude, uint reserved, IStorage* ppstg);

        [PreserveSig]
        unsafe int RemoteCopyTo(uint ciidExclude, Guid* rgiidExclude, char** snbExclude, IStorage pstgDest);

        [PreserveSig]
        unsafe int MoveElementTo(char* pwcsName, IStorage pstgDest, char* pwcsNewName, uint grfFlags);

        [PreserveSig]
        unsafe int Commit(uint grfCommitFlags);

        [PreserveSig]
        unsafe int Revert();

        [PreserveSig]
        unsafe int RemoteEnumElements(uint reserved1, uint cbReserved2, byte* reserved2, uint reserved3, IEnumSTATSTG* ppenum);

        [PreserveSig]
        unsafe int DestroyElement(char* pwcsName);

        [PreserveSig]
        unsafe int RenameElement(char* pwcsOldName, char* pwcsNewName);

        [PreserveSig]
        unsafe int SetElementTimes(char* pwcsName, FILETIME* pctime, FILETIME* patime, FILETIME* pmtime);

        [PreserveSig]
        unsafe int SetClass(Guid* clsid);

        [PreserveSig]
        unsafe int SetStateBits(uint grfStateBits, uint grfMask);

        [PreserveSig]
        unsafe int Stat(STATSTG* pstatstg, uint grfStatFlag);
    }

    [ComImport]
    [Guid("0000000c-0000-0000-c000-000000000046")]
    public unsafe interface _IStream : _ISequentialStream
    {
        [PreserveSig]
        unsafe new int QueryInterface(Guid* riid, IUnknown* ppvObject);

        [PreserveSig]
        unsafe new uint AddRef();

        [PreserveSig]
        unsafe new uint Release();

        [PreserveSig]
        unsafe new int RemoteRead(byte* pv, uint cb, uint* pcbRead);

        [PreserveSig]
        unsafe new int RemoteWrite(byte* pv, uint cb, uint* pcbWritten);

        [PreserveSig]
        unsafe int RemoteSeek(long dlibMove, uint dwOrigin, ulong* plibNewPosition);

        [PreserveSig]
        unsafe int SetSize(ulong libNewSize);

        [PreserveSig]
        unsafe int RemoteCopyTo(IStream pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten);

        [PreserveSig]
        unsafe int Commit(uint grfCommitFlags);

        [PreserveSig]
        unsafe int Revert();

        [PreserveSig]
        unsafe int LockRegion(ulong libOffset, ulong cb, uint dwLockType);

        [PreserveSig]
        unsafe int UnlockRegion(ulong libOffset, ulong cb, uint dwLockType);

        [PreserveSig]
        unsafe int Stat(STATSTG* pstatstg, uint grfStatFlag);

        [PreserveSig]
        unsafe int Clone(IStream* ppstm);
    }

    [ComImport]
    [Guid("00020403-0000-0000-c000-000000000046")]
    public unsafe interface _ITypeComp : _IUnknown
    {
        [PreserveSig]
        unsafe new int QueryInterface(Guid* riid, IUnknown* ppvObject);

        [PreserveSig]
        unsafe new uint AddRef();

        [PreserveSig]
        unsafe new uint Release();

        [PreserveSig]
        unsafe int RemoteBind(char* szName, uint lHashVal, ushort wFlags, ITypeInfo* ppTInfo, DESCKIND* pDescKind, FUNCDESC** ppFuncDesc, VARDESC** ppVarDesc, ITypeComp* ppTypeComp, CLEANLOCALSTORAGE* pDummy);

        [PreserveSig]
        unsafe int RemoteBindType(char* szName, uint lHashVal, ITypeInfo* ppTInfo);
    }

    [ComImport]
    [Guid("00020401-0000-0000-c000-000000000046")]
    public unsafe interface _ITypeInfo : _IUnknown
    {
        [PreserveSig]
        unsafe new int QueryInterface(Guid* riid, IUnknown* ppvObject);

        [PreserveSig]
        unsafe new uint AddRef();

        [PreserveSig]
        unsafe new uint Release();

        [PreserveSig]
        unsafe int RemoteGetTypeAttr(TYPEATTR** ppTypeAttr, CLEANLOCALSTORAGE* pDummy);

        [PreserveSig]
        unsafe int GetTypeComp(ITypeComp* ppTComp);

        [PreserveSig]
        unsafe int RemoteGetFuncDesc(uint index, FUNCDESC** ppFuncDesc, CLEANLOCALSTORAGE* pDummy);

        [PreserveSig]
        unsafe int RemoteGetVarDesc(uint index, VARDESC** ppVarDesc, CLEANLOCALSTORAGE* pDummy);

        [PreserveSig]
        unsafe int RemoteGetNames(int memid, char** rgBstrNames, uint cMaxNames, uint* pcNames);

        [PreserveSig]
        unsafe int GetRefTypeOfImplType(uint index, uint* pRefType);

        [PreserveSig]
        unsafe int GetImplTypeFlags(uint index, int* pImplTypeFlags);

        [PreserveSig]
        unsafe int LocalGetIDsOfNames();

        [PreserveSig]
        unsafe int LocalInvoke();

        [PreserveSig]
        unsafe int RemoteGetDocumentation(int memid, uint refPtrFlags, char** pBstrName, char** pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile);

        [PreserveSig]
        unsafe int RemoteGetDllEntry(int memid, INVOKEKIND invKind, uint refPtrFlags, char** pBstrDllName, char** pBstrName, ushort* pwOrdinal);

        [PreserveSig]
        unsafe int GetRefTypeInfo(uint hRefType, ITypeInfo* ppTInfo);

        [PreserveSig]
        unsafe int LocalAddressOfMember();

        [PreserveSig]
        unsafe int RemoteCreateInstance(Guid* riid, IUnknown* ppvObj);

        [PreserveSig]
        unsafe int GetMops(int memid, char** pBstrMops);

        [PreserveSig]
        unsafe int RemoteGetContainingTypeLib(ITypeLib* ppTLib, uint* pIndex);

        [PreserveSig]
        unsafe int LocalReleaseTypeAttr();

        [PreserveSig]
        unsafe int LocalReleaseFuncDesc();

        [PreserveSig]
        unsafe int LocalReleaseVarDesc();
    }

    [ComImport]
    [Guid("00020402-0000-0000-c000-000000000046")]
    public unsafe interface _ITypeLib : _IUnknown
    {
        [PreserveSig]
        unsafe new int QueryInterface(Guid* riid, IUnknown* ppvObject);

        [PreserveSig]
        unsafe new uint AddRef();

        [PreserveSig]
        unsafe new uint Release();

        [PreserveSig]
        unsafe int RemoteGetTypeInfoCount(uint* pcTInfo);

        [PreserveSig]
        unsafe int GetTypeInfo(uint index, ITypeInfo* ppTInfo);

        [PreserveSig]
        unsafe int GetTypeInfoType(uint index, TYPEKIND* pTKind);

        [PreserveSig]
        unsafe int GetTypeInfoOfGuid(Guid* guid, ITypeInfo* ppTinfo);

        [PreserveSig]
        unsafe int RemoteGetLibAttr(TLIBATTR** ppTLibAttr, CLEANLOCALSTORAGE* pDummy);

        [PreserveSig]
        unsafe int GetTypeComp(ITypeComp* ppTComp);

        [PreserveSig]
        unsafe int RemoteGetDocumentation(int index, uint refPtrFlags, char** pBstrName, char** pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile);

        [PreserveSig]
        unsafe int RemoteIsName(char* szNameBuf, uint lHashVal, BOOL* pfName, char** pBstrLibName);

        [PreserveSig]
        unsafe int RemoteFindName(char* szNameBuf, uint lHashVal, ITypeInfo* ppTInfo, int* rgMemId, ushort* pcFound, char** pBstrLibName);

        [PreserveSig]
        unsafe int LocalReleaseTLibAttr();
    }

    [ComImport]
    [Guid("00000000-0000-0000-c000-000000000046")]
    public unsafe interface _IUnknown
    {
        [PreserveSig]
        unsafe int QueryInterface(Guid* riid, IUnknown* ppvObject);

        [PreserveSig]
        unsafe uint AddRef();

        [PreserveSig]
        unsafe uint Release();
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public unsafe struct IEnumSTATSTG : _IEnumSTATSTG, _IUnknown, IDisposable
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        private unsafe struct IEnumSTATSTG_vtbl
        {
            internal IntPtr method_0;
            internal IntPtr method_1;
            internal IntPtr method_2;
            internal IntPtr method_3;
            internal IntPtr method_4;
            internal IntPtr method_5;
            internal IntPtr method_6;
        }

        private unsafe delegate int delegate_0(IEnumSTATSTG_vtbl** @this, Guid* riid, IUnknown* ppvObject);
        private unsafe delegate uint delegate_1(IEnumSTATSTG_vtbl** @this);
        private unsafe delegate uint delegate_2(IEnumSTATSTG_vtbl** @this);
        private unsafe delegate int delegate_3(IEnumSTATSTG_vtbl** @this, uint celt, STATSTG* rgelt, uint* pceltFetched);
        private unsafe delegate int delegate_4(IEnumSTATSTG_vtbl** @this, uint celt);
        private unsafe delegate int delegate_5(IEnumSTATSTG_vtbl** @this);
        private unsafe delegate int delegate_6(IEnumSTATSTG_vtbl** @this, IEnumSTATSTG* ppenum);

        private readonly void* reference;
        private static readonly Guid iid = new Guid("0000000d-0000-0000-c000-000000000046");

        public static unsafe Guid IID
        {
            get
            {
                return iid;
            }
        }

        public unsafe int QueryInterface(Guid* riid, IUnknown* ppvObject)
        {
            IEnumSTATSTG_vtbl** @this = (IEnumSTATSTG_vtbl**)reference;
            IEnumSTATSTG_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_0, typeof(delegate_0));
            delegate_0 method = (delegate_0)genericDelegate;
            return method(@this, riid, ppvObject);
        }

        public unsafe uint AddRef()
        {
            IEnumSTATSTG_vtbl** @this = (IEnumSTATSTG_vtbl**)reference;
            IEnumSTATSTG_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_1, typeof(delegate_1));
            delegate_1 method = (delegate_1)genericDelegate;
            return method(@this);
        }

        public unsafe uint Release()
        {
            IEnumSTATSTG_vtbl** @this = (IEnumSTATSTG_vtbl**)reference;
            IEnumSTATSTG_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_2, typeof(delegate_2));
            delegate_2 method = (delegate_2)genericDelegate;
            return method(@this);
        }

        public unsafe int RemoteNext(uint celt, STATSTG* rgelt, uint* pceltFetched)
        {
            IEnumSTATSTG_vtbl** @this = (IEnumSTATSTG_vtbl**)reference;
            IEnumSTATSTG_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_3, typeof(delegate_3));
            delegate_3 method = (delegate_3)genericDelegate;
            return method(@this, celt, rgelt, pceltFetched);
        }

        public unsafe int Skip(uint celt)
        {
            IEnumSTATSTG_vtbl** @this = (IEnumSTATSTG_vtbl**)reference;
            IEnumSTATSTG_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_4, typeof(delegate_4));
            delegate_4 method = (delegate_4)genericDelegate;
            return method(@this, celt);
        }

        public unsafe int Reset()
        {
            IEnumSTATSTG_vtbl** @this = (IEnumSTATSTG_vtbl**)reference;
            IEnumSTATSTG_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_5, typeof(delegate_5));
            delegate_5 method = (delegate_5)genericDelegate;
            return method(@this);
        }

        public unsafe int Clone(IEnumSTATSTG* ppenum)
        {
            IEnumSTATSTG_vtbl** @this = (IEnumSTATSTG_vtbl**)reference;
            IEnumSTATSTG_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_6, typeof(delegate_6));
            delegate_6 method = (delegate_6)genericDelegate;
            return method(@this, ppenum);
        }

        void IDisposable.Dispose()
        {
            while ((reference != null) && (Release() > 0))
            {
            }
        }

        public unsafe IEnumSTATSTG(IntPtr value)
        {
            reference = (void*)value;
        }

        public unsafe IEnumSTATSTG(void* value)
        {
            reference = value;
        }

        public static unsafe explicit operator IEnumSTATSTG(IUnknown value)
        {
            return new IEnumSTATSTG(*((void**)(&value)));
        }

        public static unsafe implicit operator IUnknown(IEnumSTATSTG value)
        {
            return new IUnknown(value.reference);
        }

        public static unsafe implicit operator IntPtr(IEnumSTATSTG value)
        {
            return new IntPtr(value.reference);
        }

        public static unsafe implicit operator void*(IEnumSTATSTG value)
        {
            return value.reference;
        }

        public static unsafe implicit operator IEnumSTATSTG(IntPtr value)
        {
            return new IEnumSTATSTG(value);
        }

        public static unsafe implicit operator IEnumSTATSTG(void* value)
        {
            return new IEnumSTATSTG(value);
        }

        public unsafe override bool Equals(object obj)
        {
            IEnumSTATSTG other = (IEnumSTATSTG)obj;
            return reference == other.reference;
        }

        public unsafe override int GetHashCode()
        {
            return new IntPtr(reference).GetHashCode();
        }

        public unsafe static bool operator ==(IEnumSTATSTG left, IEnumSTATSTG right)
        {
            return left.reference == right.reference;
        }

        public unsafe static bool operator !=(IEnumSTATSTG left, IEnumSTATSTG right)
        {
            return left.reference != right.reference;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public unsafe struct IEnumString : _IEnumString, _IUnknown, IDisposable
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        private unsafe struct IEnumString_vtbl
        {
            internal IntPtr method_0;
            internal IntPtr method_1;
            internal IntPtr method_2;
            internal IntPtr method_3;
            internal IntPtr method_4;
            internal IntPtr method_5;
            internal IntPtr method_6;
        }

        private unsafe delegate int delegate_0(IEnumString_vtbl** @this, Guid* riid, IUnknown* ppvObject);
        private unsafe delegate uint delegate_1(IEnumString_vtbl** @this);
        private unsafe delegate uint delegate_2(IEnumString_vtbl** @this);
        private unsafe delegate int delegate_3(IEnumString_vtbl** @this, uint celt, char** rgelt, uint* pceltFetched);
        private unsafe delegate int delegate_4(IEnumString_vtbl** @this, uint celt);
        private unsafe delegate int delegate_5(IEnumString_vtbl** @this);
        private unsafe delegate int delegate_6(IEnumString_vtbl** @this, IEnumString* ppenum);

        private readonly void* reference;
        private static readonly Guid iid = new Guid("00000101-0000-0000-c000-000000000046");

        public static unsafe Guid IID
        {
            get
            {
                return iid;
            }
        }

        public unsafe int QueryInterface(Guid* riid, IUnknown* ppvObject)
        {
            IEnumString_vtbl** @this = (IEnumString_vtbl**)reference;
            IEnumString_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_0, typeof(delegate_0));
            delegate_0 method = (delegate_0)genericDelegate;
            return method(@this, riid, ppvObject);
        }

        public unsafe uint AddRef()
        {
            IEnumString_vtbl** @this = (IEnumString_vtbl**)reference;
            IEnumString_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_1, typeof(delegate_1));
            delegate_1 method = (delegate_1)genericDelegate;
            return method(@this);
        }

        public unsafe uint Release()
        {
            IEnumString_vtbl** @this = (IEnumString_vtbl**)reference;
            IEnumString_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_2, typeof(delegate_2));
            delegate_2 method = (delegate_2)genericDelegate;
            return method(@this);
        }

        public unsafe int RemoteNext(uint celt, char** rgelt, uint* pceltFetched)
        {
            IEnumString_vtbl** @this = (IEnumString_vtbl**)reference;
            IEnumString_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_3, typeof(delegate_3));
            delegate_3 method = (delegate_3)genericDelegate;
            return method(@this, celt, rgelt, pceltFetched);
        }

        public unsafe int Skip(uint celt)
        {
            IEnumString_vtbl** @this = (IEnumString_vtbl**)reference;
            IEnumString_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_4, typeof(delegate_4));
            delegate_4 method = (delegate_4)genericDelegate;
            return method(@this, celt);
        }

        public unsafe int Reset()
        {
            IEnumString_vtbl** @this = (IEnumString_vtbl**)reference;
            IEnumString_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_5, typeof(delegate_5));
            delegate_5 method = (delegate_5)genericDelegate;
            return method(@this);
        }

        public unsafe int Clone(IEnumString* ppenum)
        {
            IEnumString_vtbl** @this = (IEnumString_vtbl**)reference;
            IEnumString_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_6, typeof(delegate_6));
            delegate_6 method = (delegate_6)genericDelegate;
            return method(@this, ppenum);
        }

        void IDisposable.Dispose()
        {
            while ((reference != null) && (Release() > 0))
            {
            }
        }

        public unsafe IEnumString(IntPtr value)
        {
            reference = (void*)value;
        }

        public unsafe IEnumString(void* value)
        {
            reference = value;
        }

        public static unsafe explicit operator IEnumString(IUnknown value)
        {
            return new IEnumString(*((void**)(&value)));
        }

        public static unsafe implicit operator IUnknown(IEnumString value)
        {
            return new IUnknown(value.reference);
        }

        public static unsafe implicit operator IntPtr(IEnumString value)
        {
            return new IntPtr(value.reference);
        }

        public static unsafe implicit operator void*(IEnumString value)
        {
            return value.reference;
        }

        public static unsafe implicit operator IEnumString(IntPtr value)
        {
            return new IEnumString(value);
        }

        public static unsafe implicit operator IEnumString(void* value)
        {
            return new IEnumString(value);
        }

        public unsafe override bool Equals(object obj)
        {
            IEnumString other = (IEnumString)obj;
            return reference == other.reference;
        }

        public unsafe override int GetHashCode()
        {
            return new IntPtr(reference).GetHashCode();
        }

        public unsafe static bool operator ==(IEnumString left, IEnumString right)
        {
            return left.reference == right.reference;
        }

        public unsafe static bool operator !=(IEnumString left, IEnumString right)
        {
            return left.reference != right.reference;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public unsafe struct IEnumUnknown : _IEnumUnknown, _IUnknown, IDisposable
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        private unsafe struct IEnumUnknown_vtbl
        {
            internal IntPtr method_0;
            internal IntPtr method_1;
            internal IntPtr method_2;
            internal IntPtr method_3;
            internal IntPtr method_4;
            internal IntPtr method_5;
            internal IntPtr method_6;
        }

        private unsafe delegate int delegate_0(IEnumUnknown_vtbl** @this, Guid* riid, IUnknown* ppvObject);
        private unsafe delegate uint delegate_1(IEnumUnknown_vtbl** @this);
        private unsafe delegate uint delegate_2(IEnumUnknown_vtbl** @this);
        private unsafe delegate int delegate_3(IEnumUnknown_vtbl** @this, uint celt, IUnknown* rgelt, uint* pceltFetched);
        private unsafe delegate int delegate_4(IEnumUnknown_vtbl** @this, uint celt);
        private unsafe delegate int delegate_5(IEnumUnknown_vtbl** @this);
        private unsafe delegate int delegate_6(IEnumUnknown_vtbl** @this, IEnumUnknown* ppenum);

        private readonly void* reference;
        private static readonly Guid iid = new Guid("00000100-0000-0000-c000-000000000046");

        public static unsafe Guid IID
        {
            get
            {
                return iid;
            }
        }

        public unsafe int QueryInterface(Guid* riid, IUnknown* ppvObject)
        {
            IEnumUnknown_vtbl** @this = (IEnumUnknown_vtbl**)reference;
            IEnumUnknown_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_0, typeof(delegate_0));
            delegate_0 method = (delegate_0)genericDelegate;
            return method(@this, riid, ppvObject);
        }

        public unsafe uint AddRef()
        {
            IEnumUnknown_vtbl** @this = (IEnumUnknown_vtbl**)reference;
            IEnumUnknown_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_1, typeof(delegate_1));
            delegate_1 method = (delegate_1)genericDelegate;
            return method(@this);
        }

        public unsafe uint Release()
        {
            IEnumUnknown_vtbl** @this = (IEnumUnknown_vtbl**)reference;
            IEnumUnknown_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_2, typeof(delegate_2));
            delegate_2 method = (delegate_2)genericDelegate;
            return method(@this);
        }

        public unsafe int RemoteNext(uint celt, IUnknown* rgelt, uint* pceltFetched)
        {
            IEnumUnknown_vtbl** @this = (IEnumUnknown_vtbl**)reference;
            IEnumUnknown_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_3, typeof(delegate_3));
            delegate_3 method = (delegate_3)genericDelegate;
            return method(@this, celt, rgelt, pceltFetched);
        }

        public unsafe int Skip(uint celt)
        {
            IEnumUnknown_vtbl** @this = (IEnumUnknown_vtbl**)reference;
            IEnumUnknown_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_4, typeof(delegate_4));
            delegate_4 method = (delegate_4)genericDelegate;
            return method(@this, celt);
        }

        public unsafe int Reset()
        {
            IEnumUnknown_vtbl** @this = (IEnumUnknown_vtbl**)reference;
            IEnumUnknown_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_5, typeof(delegate_5));
            delegate_5 method = (delegate_5)genericDelegate;
            return method(@this);
        }

        public unsafe int Clone(IEnumUnknown* ppenum)
        {
            IEnumUnknown_vtbl** @this = (IEnumUnknown_vtbl**)reference;
            IEnumUnknown_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_6, typeof(delegate_6));
            delegate_6 method = (delegate_6)genericDelegate;
            return method(@this, ppenum);
        }

        void IDisposable.Dispose()
        {
            while ((reference != null) && (Release() > 0))
            {
            }
        }

        public unsafe IEnumUnknown(IntPtr value)
        {
            reference = (void*)value;
        }

        public unsafe IEnumUnknown(void* value)
        {
            reference = value;
        }

        public static unsafe explicit operator IEnumUnknown(IUnknown value)
        {
            return new IEnumUnknown(*((void**)(&value)));
        }

        public static unsafe implicit operator IUnknown(IEnumUnknown value)
        {
            return new IUnknown(value.reference);
        }

        public static unsafe implicit operator IntPtr(IEnumUnknown value)
        {
            return new IntPtr(value.reference);
        }

        public static unsafe implicit operator void*(IEnumUnknown value)
        {
            return value.reference;
        }

        public static unsafe implicit operator IEnumUnknown(IntPtr value)
        {
            return new IEnumUnknown(value);
        }

        public static unsafe implicit operator IEnumUnknown(void* value)
        {
            return new IEnumUnknown(value);
        }

        public unsafe override bool Equals(object obj)
        {
            IEnumUnknown other = (IEnumUnknown)obj;
            return reference == other.reference;
        }

        public unsafe override int GetHashCode()
        {
            return new IntPtr(reference).GetHashCode();
        }

        public unsafe static bool operator ==(IEnumUnknown left, IEnumUnknown right)
        {
            return left.reference == right.reference;
        }

        public unsafe static bool operator !=(IEnumUnknown left, IEnumUnknown right)
        {
            return left.reference != right.reference;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public unsafe struct IErrorLog : _IErrorLog, _IUnknown, IDisposable
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        private unsafe struct IErrorLog_vtbl
        {
            internal IntPtr method_0;
            internal IntPtr method_1;
            internal IntPtr method_2;
            internal IntPtr method_3;
        }

        private unsafe delegate int delegate_0(IErrorLog_vtbl** @this, Guid* riid, IUnknown* ppvObject);
        private unsafe delegate uint delegate_1(IErrorLog_vtbl** @this);
        private unsafe delegate uint delegate_2(IErrorLog_vtbl** @this);
        private unsafe delegate int delegate_3(IErrorLog_vtbl** @this, char* pszPropName, EXCEPINFO* pExcepInfo);

        private readonly void* reference;
        private static readonly Guid iid = new Guid("3127ca40-446e-11ce-8135-00aa004bb851");

        public static unsafe Guid IID
        {
            get
            {
                return iid;
            }
        }

        public unsafe int QueryInterface(Guid* riid, IUnknown* ppvObject)
        {
            IErrorLog_vtbl** @this = (IErrorLog_vtbl**)reference;
            IErrorLog_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_0, typeof(delegate_0));
            delegate_0 method = (delegate_0)genericDelegate;
            return method(@this, riid, ppvObject);
        }

        public unsafe uint AddRef()
        {
            IErrorLog_vtbl** @this = (IErrorLog_vtbl**)reference;
            IErrorLog_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_1, typeof(delegate_1));
            delegate_1 method = (delegate_1)genericDelegate;
            return method(@this);
        }

        public unsafe uint Release()
        {
            IErrorLog_vtbl** @this = (IErrorLog_vtbl**)reference;
            IErrorLog_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_2, typeof(delegate_2));
            delegate_2 method = (delegate_2)genericDelegate;
            return method(@this);
        }

        public unsafe int AddError(char* pszPropName, EXCEPINFO* pExcepInfo)
        {
            IErrorLog_vtbl** @this = (IErrorLog_vtbl**)reference;
            IErrorLog_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_3, typeof(delegate_3));
            delegate_3 method = (delegate_3)genericDelegate;
            return method(@this, pszPropName, pExcepInfo);
        }

        void IDisposable.Dispose()
        {
            while ((reference != null) && (Release() > 0))
            {
            }
        }

        public unsafe IErrorLog(IntPtr value)
        {
            reference = (void*)value;
        }

        public unsafe IErrorLog(void* value)
        {
            reference = value;
        }

        public static unsafe explicit operator IErrorLog(IUnknown value)
        {
            return new IErrorLog(*((void**)(&value)));
        }

        public static unsafe implicit operator IUnknown(IErrorLog value)
        {
            return new IUnknown(value.reference);
        }

        public static unsafe implicit operator IntPtr(IErrorLog value)
        {
            return new IntPtr(value.reference);
        }

        public static unsafe implicit operator void*(IErrorLog value)
        {
            return value.reference;
        }

        public static unsafe implicit operator IErrorLog(IntPtr value)
        {
            return new IErrorLog(value);
        }

        public static unsafe implicit operator IErrorLog(void* value)
        {
            return new IErrorLog(value);
        }

        public unsafe override bool Equals(object obj)
        {
            IErrorLog other = (IErrorLog)obj;
            return reference == other.reference;
        }

        public unsafe override int GetHashCode()
        {
            return new IntPtr(reference).GetHashCode();
        }

        public unsafe static bool operator ==(IErrorLog left, IErrorLog right)
        {
            return left.reference == right.reference;
        }

        public unsafe static bool operator !=(IErrorLog left, IErrorLog right)
        {
            return left.reference != right.reference;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public unsafe struct IPropertyBag2 : _IPropertyBag2, _IUnknown, IDisposable
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        private unsafe struct IPropertyBag2_vtbl
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

        private unsafe delegate int delegate_0(IPropertyBag2_vtbl** @this, Guid* riid, IUnknown* ppvObject);
        private unsafe delegate uint delegate_1(IPropertyBag2_vtbl** @this);
        private unsafe delegate uint delegate_2(IPropertyBag2_vtbl** @this);
        private unsafe delegate int delegate_3(IPropertyBag2_vtbl** @this, uint cProperties, PROPBAG2* pPropBag, IErrorLog pErrLog, VARIANT* pvarValue, int* phrError);
        private unsafe delegate int delegate_4(IPropertyBag2_vtbl** @this, uint cProperties, PROPBAG2* pPropBag, VARIANT* pvarValue);
        private unsafe delegate int delegate_5(IPropertyBag2_vtbl** @this, uint* pcProperties);
        private unsafe delegate int delegate_6(IPropertyBag2_vtbl** @this, uint iProperty, uint cProperties, PROPBAG2* pPropBag, uint* pcProperties);
        private unsafe delegate int delegate_7(IPropertyBag2_vtbl** @this, char* pstrName, uint dwHint, IUnknown pUnkObject, IErrorLog pErrLog);

        private readonly void* reference;
        private static readonly Guid iid = new Guid("22f55882-280b-11d0-a8a9-00a0c90c2004");

        public static unsafe Guid IID
        {
            get
            {
                return iid;
            }
        }

        public unsafe int QueryInterface(Guid* riid, IUnknown* ppvObject)
        {
            IPropertyBag2_vtbl** @this = (IPropertyBag2_vtbl**)reference;
            IPropertyBag2_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_0, typeof(delegate_0));
            delegate_0 method = (delegate_0)genericDelegate;
            return method(@this, riid, ppvObject);
        }

        public unsafe uint AddRef()
        {
            IPropertyBag2_vtbl** @this = (IPropertyBag2_vtbl**)reference;
            IPropertyBag2_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_1, typeof(delegate_1));
            delegate_1 method = (delegate_1)genericDelegate;
            return method(@this);
        }

        public unsafe uint Release()
        {
            IPropertyBag2_vtbl** @this = (IPropertyBag2_vtbl**)reference;
            IPropertyBag2_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_2, typeof(delegate_2));
            delegate_2 method = (delegate_2)genericDelegate;
            return method(@this);
        }

        public unsafe int Read(uint cProperties, PROPBAG2* pPropBag, IErrorLog pErrLog, VARIANT* pvarValue, int* phrError)
        {
            IPropertyBag2_vtbl** @this = (IPropertyBag2_vtbl**)reference;
            IPropertyBag2_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_3, typeof(delegate_3));
            delegate_3 method = (delegate_3)genericDelegate;
            return method(@this, cProperties, pPropBag, pErrLog, pvarValue, phrError);
        }

        public unsafe int Write(uint cProperties, PROPBAG2* pPropBag, VARIANT* pvarValue)
        {
            IPropertyBag2_vtbl** @this = (IPropertyBag2_vtbl**)reference;
            IPropertyBag2_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_4, typeof(delegate_4));
            delegate_4 method = (delegate_4)genericDelegate;
            return method(@this, cProperties, pPropBag, pvarValue);
        }

        public unsafe int CountProperties(uint* pcProperties)
        {
            IPropertyBag2_vtbl** @this = (IPropertyBag2_vtbl**)reference;
            IPropertyBag2_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_5, typeof(delegate_5));
            delegate_5 method = (delegate_5)genericDelegate;
            return method(@this, pcProperties);
        }

        public unsafe int GetPropertyInfo(uint iProperty, uint cProperties, PROPBAG2* pPropBag, uint* pcProperties)
        {
            IPropertyBag2_vtbl** @this = (IPropertyBag2_vtbl**)reference;
            IPropertyBag2_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_6, typeof(delegate_6));
            delegate_6 method = (delegate_6)genericDelegate;
            return method(@this, iProperty, cProperties, pPropBag, pcProperties);
        }

        public unsafe int LoadObject(char* pstrName, uint dwHint, IUnknown pUnkObject, IErrorLog pErrLog)
        {
            IPropertyBag2_vtbl** @this = (IPropertyBag2_vtbl**)reference;
            IPropertyBag2_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_7, typeof(delegate_7));
            delegate_7 method = (delegate_7)genericDelegate;
            return method(@this, pstrName, dwHint, pUnkObject, pErrLog);
        }

        void IDisposable.Dispose()
        {
            while ((reference != null) && (Release() > 0))
            {
            }
        }

        public unsafe IPropertyBag2(IntPtr value)
        {
            reference = (void*)value;
        }

        public unsafe IPropertyBag2(void* value)
        {
            reference = value;
        }

        public static unsafe explicit operator IPropertyBag2(IUnknown value)
        {
            return new IPropertyBag2(*((void**)(&value)));
        }

        public static unsafe implicit operator IUnknown(IPropertyBag2 value)
        {
            return new IUnknown(value.reference);
        }

        public static unsafe implicit operator IntPtr(IPropertyBag2 value)
        {
            return new IntPtr(value.reference);
        }

        public static unsafe implicit operator void*(IPropertyBag2 value)
        {
            return value.reference;
        }

        public static unsafe implicit operator IPropertyBag2(IntPtr value)
        {
            return new IPropertyBag2(value);
        }

        public static unsafe implicit operator IPropertyBag2(void* value)
        {
            return new IPropertyBag2(value);
        }

        public unsafe override bool Equals(object obj)
        {
            IPropertyBag2 other = (IPropertyBag2)obj;
            return reference == other.reference;
        }

        public unsafe override int GetHashCode()
        {
            return new IntPtr(reference).GetHashCode();
        }

        public unsafe static bool operator ==(IPropertyBag2 left, IPropertyBag2 right)
        {
            return left.reference == right.reference;
        }

        public unsafe static bool operator !=(IPropertyBag2 left, IPropertyBag2 right)
        {
            return left.reference != right.reference;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public unsafe struct IRecordInfo : _IRecordInfo, _IUnknown, IDisposable
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        private unsafe struct IRecordInfo_vtbl
        {
            internal IntPtr method_0;
            internal IntPtr method_1;
            internal IntPtr method_2;
            internal IntPtr method_3;
            internal IntPtr method_4;
            internal IntPtr method_5;
            internal IntPtr method_6;
            internal IntPtr method_7;
            internal IntPtr method_8;
            internal IntPtr method_9;
            internal IntPtr method_10;
            internal IntPtr method_11;
            internal IntPtr method_12;
            internal IntPtr method_13;
            internal IntPtr method_14;
            internal IntPtr method_15;
            internal IntPtr method_16;
            internal IntPtr method_17;
            internal IntPtr method_18;
        }

        private unsafe delegate int delegate_0(IRecordInfo_vtbl** @this, Guid* riid, IUnknown* ppvObject);
        private unsafe delegate uint delegate_1(IRecordInfo_vtbl** @this);
        private unsafe delegate uint delegate_2(IRecordInfo_vtbl** @this);
        private unsafe delegate int delegate_3(IRecordInfo_vtbl** @this, void* pvNew);
        private unsafe delegate int delegate_4(IRecordInfo_vtbl** @this, void* pvExisting);
        private unsafe delegate int delegate_5(IRecordInfo_vtbl** @this, void* pvExisting, void* pvNew);
        private unsafe delegate int delegate_6(IRecordInfo_vtbl** @this, Guid* pguid);
        private unsafe delegate int delegate_7(IRecordInfo_vtbl** @this, char** pbstrName);
        private unsafe delegate int delegate_8(IRecordInfo_vtbl** @this, uint* pcbSize);
        private unsafe delegate int delegate_9(IRecordInfo_vtbl** @this, ITypeInfo* ppTypeInfo);
        private unsafe delegate int delegate_10(IRecordInfo_vtbl** @this, void* pvData, char* szFieldName, VARIANT* pvarField);
        private unsafe delegate int delegate_11(IRecordInfo_vtbl** @this, void* pvData, char* szFieldName, VARIANT* pvarField, void** ppvDataCArray);
        private unsafe delegate int delegate_12(IRecordInfo_vtbl** @this, uint wFlags, void* pvData, char* szFieldName, VARIANT* pvarField);
        private unsafe delegate int delegate_13(IRecordInfo_vtbl** @this, uint wFlags, void* pvData, char* szFieldName, VARIANT* pvarField);
        private unsafe delegate int delegate_14(IRecordInfo_vtbl** @this, uint* pcNames, char** rgBstrNames);
        private unsafe delegate BOOL delegate_15(IRecordInfo_vtbl** @this, IRecordInfo pRecordInfo);
        private unsafe delegate void* delegate_16(IRecordInfo_vtbl** @this);
        private unsafe delegate int delegate_17(IRecordInfo_vtbl** @this, void* pvSource, void** ppvDest);
        private unsafe delegate int delegate_18(IRecordInfo_vtbl** @this, void* pvRecord);

        private readonly void* reference;
        private static readonly Guid iid = new Guid("0000002f-0000-0000-c000-000000000046");

        public static unsafe Guid IID
        {
            get
            {
                return iid;
            }
        }

        public unsafe int QueryInterface(Guid* riid, IUnknown* ppvObject)
        {
            IRecordInfo_vtbl** @this = (IRecordInfo_vtbl**)reference;
            IRecordInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_0, typeof(delegate_0));
            delegate_0 method = (delegate_0)genericDelegate;
            return method(@this, riid, ppvObject);
        }

        public unsafe uint AddRef()
        {
            IRecordInfo_vtbl** @this = (IRecordInfo_vtbl**)reference;
            IRecordInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_1, typeof(delegate_1));
            delegate_1 method = (delegate_1)genericDelegate;
            return method(@this);
        }

        public unsafe uint Release()
        {
            IRecordInfo_vtbl** @this = (IRecordInfo_vtbl**)reference;
            IRecordInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_2, typeof(delegate_2));
            delegate_2 method = (delegate_2)genericDelegate;
            return method(@this);
        }

        public unsafe int RecordInit(void* pvNew)
        {
            IRecordInfo_vtbl** @this = (IRecordInfo_vtbl**)reference;
            IRecordInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_3, typeof(delegate_3));
            delegate_3 method = (delegate_3)genericDelegate;
            return method(@this, pvNew);
        }

        public unsafe int RecordClear(void* pvExisting)
        {
            IRecordInfo_vtbl** @this = (IRecordInfo_vtbl**)reference;
            IRecordInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_4, typeof(delegate_4));
            delegate_4 method = (delegate_4)genericDelegate;
            return method(@this, pvExisting);
        }

        public unsafe int RecordCopy(void* pvExisting, void* pvNew)
        {
            IRecordInfo_vtbl** @this = (IRecordInfo_vtbl**)reference;
            IRecordInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_5, typeof(delegate_5));
            delegate_5 method = (delegate_5)genericDelegate;
            return method(@this, pvExisting, pvNew);
        }

        public unsafe int GetGuid(Guid* pguid)
        {
            IRecordInfo_vtbl** @this = (IRecordInfo_vtbl**)reference;
            IRecordInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_6, typeof(delegate_6));
            delegate_6 method = (delegate_6)genericDelegate;
            return method(@this, pguid);
        }

        public unsafe int GetName(char** pbstrName)
        {
            IRecordInfo_vtbl** @this = (IRecordInfo_vtbl**)reference;
            IRecordInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_7, typeof(delegate_7));
            delegate_7 method = (delegate_7)genericDelegate;
            return method(@this, pbstrName);
        }

        public unsafe int GetSize(uint* pcbSize)
        {
            IRecordInfo_vtbl** @this = (IRecordInfo_vtbl**)reference;
            IRecordInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_8, typeof(delegate_8));
            delegate_8 method = (delegate_8)genericDelegate;
            return method(@this, pcbSize);
        }

        public unsafe int GetTypeInfo(ITypeInfo* ppTypeInfo)
        {
            IRecordInfo_vtbl** @this = (IRecordInfo_vtbl**)reference;
            IRecordInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_9, typeof(delegate_9));
            delegate_9 method = (delegate_9)genericDelegate;
            return method(@this, ppTypeInfo);
        }

        public unsafe int GetField(void* pvData, char* szFieldName, VARIANT* pvarField)
        {
            IRecordInfo_vtbl** @this = (IRecordInfo_vtbl**)reference;
            IRecordInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_10, typeof(delegate_10));
            delegate_10 method = (delegate_10)genericDelegate;
            return method(@this, pvData, szFieldName, pvarField);
        }

        public unsafe int GetFieldNoCopy(void* pvData, char* szFieldName, VARIANT* pvarField, void** ppvDataCArray)
        {
            IRecordInfo_vtbl** @this = (IRecordInfo_vtbl**)reference;
            IRecordInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_11, typeof(delegate_11));
            delegate_11 method = (delegate_11)genericDelegate;
            return method(@this, pvData, szFieldName, pvarField, ppvDataCArray);
        }

        public unsafe int PutField(uint wFlags, void* pvData, char* szFieldName, VARIANT* pvarField)
        {
            IRecordInfo_vtbl** @this = (IRecordInfo_vtbl**)reference;
            IRecordInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_12, typeof(delegate_12));
            delegate_12 method = (delegate_12)genericDelegate;
            return method(@this, wFlags, pvData, szFieldName, pvarField);
        }

        public unsafe int PutFieldNoCopy(uint wFlags, void* pvData, char* szFieldName, VARIANT* pvarField)
        {
            IRecordInfo_vtbl** @this = (IRecordInfo_vtbl**)reference;
            IRecordInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_13, typeof(delegate_13));
            delegate_13 method = (delegate_13)genericDelegate;
            return method(@this, wFlags, pvData, szFieldName, pvarField);
        }

        public unsafe int GetFieldNames(uint* pcNames, char** rgBstrNames)
        {
            IRecordInfo_vtbl** @this = (IRecordInfo_vtbl**)reference;
            IRecordInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_14, typeof(delegate_14));
            delegate_14 method = (delegate_14)genericDelegate;
            return method(@this, pcNames, rgBstrNames);
        }

        public unsafe BOOL IsMatchingType(IRecordInfo pRecordInfo)
        {
            IRecordInfo_vtbl** @this = (IRecordInfo_vtbl**)reference;
            IRecordInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_15, typeof(delegate_15));
            delegate_15 method = (delegate_15)genericDelegate;
            return method(@this, pRecordInfo);
        }

        public unsafe void* RecordCreate()
        {
            IRecordInfo_vtbl** @this = (IRecordInfo_vtbl**)reference;
            IRecordInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_16, typeof(delegate_16));
            delegate_16 method = (delegate_16)genericDelegate;
            return method(@this);
        }

        public unsafe int RecordCreateCopy(void* pvSource, void** ppvDest)
        {
            IRecordInfo_vtbl** @this = (IRecordInfo_vtbl**)reference;
            IRecordInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_17, typeof(delegate_17));
            delegate_17 method = (delegate_17)genericDelegate;
            return method(@this, pvSource, ppvDest);
        }

        public unsafe int RecordDestroy(void* pvRecord)
        {
            IRecordInfo_vtbl** @this = (IRecordInfo_vtbl**)reference;
            IRecordInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_18, typeof(delegate_18));
            delegate_18 method = (delegate_18)genericDelegate;
            return method(@this, pvRecord);
        }

        void IDisposable.Dispose()
        {
            while ((reference != null) && (Release() > 0))
            {
            }
        }

        public unsafe IRecordInfo(IntPtr value)
        {
            reference = (void*)value;
        }

        public unsafe IRecordInfo(void* value)
        {
            reference = value;
        }

        public static unsafe explicit operator IRecordInfo(IUnknown value)
        {
            return new IRecordInfo(*((void**)(&value)));
        }

        public static unsafe implicit operator IUnknown(IRecordInfo value)
        {
            return new IUnknown(value.reference);
        }

        public static unsafe implicit operator IntPtr(IRecordInfo value)
        {
            return new IntPtr(value.reference);
        }

        public static unsafe implicit operator void*(IRecordInfo value)
        {
            return value.reference;
        }

        public static unsafe implicit operator IRecordInfo(IntPtr value)
        {
            return new IRecordInfo(value);
        }

        public static unsafe implicit operator IRecordInfo(void* value)
        {
            return new IRecordInfo(value);
        }

        public unsafe override bool Equals(object obj)
        {
            IRecordInfo other = (IRecordInfo)obj;
            return reference == other.reference;
        }

        public unsafe override int GetHashCode()
        {
            return new IntPtr(reference).GetHashCode();
        }

        public unsafe static bool operator ==(IRecordInfo left, IRecordInfo right)
        {
            return left.reference == right.reference;
        }

        public unsafe static bool operator !=(IRecordInfo left, IRecordInfo right)
        {
            return left.reference != right.reference;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public unsafe struct ISequentialStream : _ISequentialStream, _IUnknown, IDisposable
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        private unsafe struct ISequentialStream_vtbl
        {
            internal IntPtr method_0;
            internal IntPtr method_1;
            internal IntPtr method_2;
            internal IntPtr method_3;
            internal IntPtr method_4;
        }

        private unsafe delegate int delegate_0(ISequentialStream_vtbl** @this, Guid* riid, IUnknown* ppvObject);
        private unsafe delegate uint delegate_1(ISequentialStream_vtbl** @this);
        private unsafe delegate uint delegate_2(ISequentialStream_vtbl** @this);
        private unsafe delegate int delegate_3(ISequentialStream_vtbl** @this, byte* pv, uint cb, uint* pcbRead);
        private unsafe delegate int delegate_4(ISequentialStream_vtbl** @this, byte* pv, uint cb, uint* pcbWritten);

        private readonly void* reference;
        private static readonly Guid iid = new Guid("0c733a30-2a1c-11ce-ade5-00aa0044773d");

        public static unsafe Guid IID
        {
            get
            {
                return iid;
            }
        }

        public unsafe int QueryInterface(Guid* riid, IUnknown* ppvObject)
        {
            ISequentialStream_vtbl** @this = (ISequentialStream_vtbl**)reference;
            ISequentialStream_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_0, typeof(delegate_0));
            delegate_0 method = (delegate_0)genericDelegate;
            return method(@this, riid, ppvObject);
        }

        public unsafe uint AddRef()
        {
            ISequentialStream_vtbl** @this = (ISequentialStream_vtbl**)reference;
            ISequentialStream_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_1, typeof(delegate_1));
            delegate_1 method = (delegate_1)genericDelegate;
            return method(@this);
        }

        public unsafe uint Release()
        {
            ISequentialStream_vtbl** @this = (ISequentialStream_vtbl**)reference;
            ISequentialStream_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_2, typeof(delegate_2));
            delegate_2 method = (delegate_2)genericDelegate;
            return method(@this);
        }

        public unsafe int RemoteRead(byte* pv, uint cb, uint* pcbRead)
        {
            ISequentialStream_vtbl** @this = (ISequentialStream_vtbl**)reference;
            ISequentialStream_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_3, typeof(delegate_3));
            delegate_3 method = (delegate_3)genericDelegate;
            return method(@this, pv, cb, pcbRead);
        }

        public unsafe int RemoteWrite(byte* pv, uint cb, uint* pcbWritten)
        {
            ISequentialStream_vtbl** @this = (ISequentialStream_vtbl**)reference;
            ISequentialStream_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_4, typeof(delegate_4));
            delegate_4 method = (delegate_4)genericDelegate;
            return method(@this, pv, cb, pcbWritten);
        }

        void IDisposable.Dispose()
        {
            while ((reference != null) && (Release() > 0))
            {
            }
        }

        public unsafe ISequentialStream(IntPtr value)
        {
            reference = (void*)value;
        }

        public unsafe ISequentialStream(void* value)
        {
            reference = value;
        }

        public static unsafe explicit operator ISequentialStream(IUnknown value)
        {
            return new ISequentialStream(*((void**)(&value)));
        }

        public static unsafe implicit operator IUnknown(ISequentialStream value)
        {
            return new IUnknown(value.reference);
        }

        public static unsafe implicit operator IntPtr(ISequentialStream value)
        {
            return new IntPtr(value.reference);
        }

        public static unsafe implicit operator void*(ISequentialStream value)
        {
            return value.reference;
        }

        public static unsafe implicit operator ISequentialStream(IntPtr value)
        {
            return new ISequentialStream(value);
        }

        public static unsafe implicit operator ISequentialStream(void* value)
        {
            return new ISequentialStream(value);
        }

        public unsafe override bool Equals(object obj)
        {
            ISequentialStream other = (ISequentialStream)obj;
            return reference == other.reference;
        }

        public unsafe override int GetHashCode()
        {
            return new IntPtr(reference).GetHashCode();
        }

        public unsafe static bool operator ==(ISequentialStream left, ISequentialStream right)
        {
            return left.reference == right.reference;
        }

        public unsafe static bool operator !=(ISequentialStream left, ISequentialStream right)
        {
            return left.reference != right.reference;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public unsafe struct IStorage : _IStorage, _IUnknown, IDisposable
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        private unsafe struct IStorage_vtbl
        {
            internal IntPtr method_0;
            internal IntPtr method_1;
            internal IntPtr method_2;
            internal IntPtr method_3;
            internal IntPtr method_4;
            internal IntPtr method_5;
            internal IntPtr method_6;
            internal IntPtr method_7;
            internal IntPtr method_8;
            internal IntPtr method_9;
            internal IntPtr method_10;
            internal IntPtr method_11;
            internal IntPtr method_12;
            internal IntPtr method_13;
            internal IntPtr method_14;
            internal IntPtr method_15;
            internal IntPtr method_16;
            internal IntPtr method_17;
        }

        private unsafe delegate int delegate_0(IStorage_vtbl** @this, Guid* riid, IUnknown* ppvObject);
        private unsafe delegate uint delegate_1(IStorage_vtbl** @this);
        private unsafe delegate uint delegate_2(IStorage_vtbl** @this);
        private unsafe delegate int delegate_3(IStorage_vtbl** @this, char* pwcsName, uint grfMode, uint reserved1, uint reserved2, IStream* ppstm);
        private unsafe delegate int delegate_4(IStorage_vtbl** @this, char* pwcsName, uint cbReserved1, byte* reserved1, uint grfMode, uint reserved2, IStream* ppstm);
        private unsafe delegate int delegate_5(IStorage_vtbl** @this, char* pwcsName, uint grfMode, uint reserved1, uint reserved2, IStorage* ppstg);
        private unsafe delegate int delegate_6(IStorage_vtbl** @this, char* pwcsName, IStorage pstgPriority, uint grfMode, char** snbExclude, uint reserved, IStorage* ppstg);
        private unsafe delegate int delegate_7(IStorage_vtbl** @this, uint ciidExclude, Guid* rgiidExclude, char** snbExclude, IStorage pstgDest);
        private unsafe delegate int delegate_8(IStorage_vtbl** @this, char* pwcsName, IStorage pstgDest, char* pwcsNewName, uint grfFlags);
        private unsafe delegate int delegate_9(IStorage_vtbl** @this, uint grfCommitFlags);
        private unsafe delegate int delegate_10(IStorage_vtbl** @this);
        private unsafe delegate int delegate_11(IStorage_vtbl** @this, uint reserved1, uint cbReserved2, byte* reserved2, uint reserved3, IEnumSTATSTG* ppenum);
        private unsafe delegate int delegate_12(IStorage_vtbl** @this, char* pwcsName);
        private unsafe delegate int delegate_13(IStorage_vtbl** @this, char* pwcsOldName, char* pwcsNewName);
        private unsafe delegate int delegate_14(IStorage_vtbl** @this, char* pwcsName, FILETIME* pctime, FILETIME* patime, FILETIME* pmtime);
        private unsafe delegate int delegate_15(IStorage_vtbl** @this, Guid* clsid);
        private unsafe delegate int delegate_16(IStorage_vtbl** @this, uint grfStateBits, uint grfMask);
        private unsafe delegate int delegate_17(IStorage_vtbl** @this, STATSTG* pstatstg, uint grfStatFlag);

        private readonly void* reference;
        private static readonly Guid iid = new Guid("0000000b-0000-0000-c000-000000000046");

        public static unsafe Guid IID
        {
            get
            {
                return iid;
            }
        }

        public unsafe int QueryInterface(Guid* riid, IUnknown* ppvObject)
        {
            IStorage_vtbl** @this = (IStorage_vtbl**)reference;
            IStorage_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_0, typeof(delegate_0));
            delegate_0 method = (delegate_0)genericDelegate;
            return method(@this, riid, ppvObject);
        }

        public unsafe uint AddRef()
        {
            IStorage_vtbl** @this = (IStorage_vtbl**)reference;
            IStorage_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_1, typeof(delegate_1));
            delegate_1 method = (delegate_1)genericDelegate;
            return method(@this);
        }

        public unsafe uint Release()
        {
            IStorage_vtbl** @this = (IStorage_vtbl**)reference;
            IStorage_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_2, typeof(delegate_2));
            delegate_2 method = (delegate_2)genericDelegate;
            return method(@this);
        }

        public unsafe int CreateStream(char* pwcsName, uint grfMode, uint reserved1, uint reserved2, IStream* ppstm)
        {
            IStorage_vtbl** @this = (IStorage_vtbl**)reference;
            IStorage_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_3, typeof(delegate_3));
            delegate_3 method = (delegate_3)genericDelegate;
            return method(@this, pwcsName, grfMode, reserved1, reserved2, ppstm);
        }

        public unsafe int RemoteOpenStream(char* pwcsName, uint cbReserved1, byte* reserved1, uint grfMode, uint reserved2, IStream* ppstm)
        {
            IStorage_vtbl** @this = (IStorage_vtbl**)reference;
            IStorage_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_4, typeof(delegate_4));
            delegate_4 method = (delegate_4)genericDelegate;
            return method(@this, pwcsName, cbReserved1, reserved1, grfMode, reserved2, ppstm);
        }

        public unsafe int CreateStorage(char* pwcsName, uint grfMode, uint reserved1, uint reserved2, IStorage* ppstg)
        {
            IStorage_vtbl** @this = (IStorage_vtbl**)reference;
            IStorage_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_5, typeof(delegate_5));
            delegate_5 method = (delegate_5)genericDelegate;
            return method(@this, pwcsName, grfMode, reserved1, reserved2, ppstg);
        }

        public unsafe int OpenStorage(char* pwcsName, IStorage pstgPriority, uint grfMode, char** snbExclude, uint reserved, IStorage* ppstg)
        {
            IStorage_vtbl** @this = (IStorage_vtbl**)reference;
            IStorage_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_6, typeof(delegate_6));
            delegate_6 method = (delegate_6)genericDelegate;
            return method(@this, pwcsName, pstgPriority, grfMode, snbExclude, reserved, ppstg);
        }

        public unsafe int RemoteCopyTo(uint ciidExclude, Guid* rgiidExclude, char** snbExclude, IStorage pstgDest)
        {
            IStorage_vtbl** @this = (IStorage_vtbl**)reference;
            IStorage_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_7, typeof(delegate_7));
            delegate_7 method = (delegate_7)genericDelegate;
            return method(@this, ciidExclude, rgiidExclude, snbExclude, pstgDest);
        }

        public unsafe int MoveElementTo(char* pwcsName, IStorage pstgDest, char* pwcsNewName, uint grfFlags)
        {
            IStorage_vtbl** @this = (IStorage_vtbl**)reference;
            IStorage_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_8, typeof(delegate_8));
            delegate_8 method = (delegate_8)genericDelegate;
            return method(@this, pwcsName, pstgDest, pwcsNewName, grfFlags);
        }

        public unsafe int Commit(uint grfCommitFlags)
        {
            IStorage_vtbl** @this = (IStorage_vtbl**)reference;
            IStorage_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_9, typeof(delegate_9));
            delegate_9 method = (delegate_9)genericDelegate;
            return method(@this, grfCommitFlags);
        }

        public unsafe int Revert()
        {
            IStorage_vtbl** @this = (IStorage_vtbl**)reference;
            IStorage_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_10, typeof(delegate_10));
            delegate_10 method = (delegate_10)genericDelegate;
            return method(@this);
        }

        public unsafe int RemoteEnumElements(uint reserved1, uint cbReserved2, byte* reserved2, uint reserved3, IEnumSTATSTG* ppenum)
        {
            IStorage_vtbl** @this = (IStorage_vtbl**)reference;
            IStorage_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_11, typeof(delegate_11));
            delegate_11 method = (delegate_11)genericDelegate;
            return method(@this, reserved1, cbReserved2, reserved2, reserved3, ppenum);
        }

        public unsafe int DestroyElement(char* pwcsName)
        {
            IStorage_vtbl** @this = (IStorage_vtbl**)reference;
            IStorage_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_12, typeof(delegate_12));
            delegate_12 method = (delegate_12)genericDelegate;
            return method(@this, pwcsName);
        }

        public unsafe int RenameElement(char* pwcsOldName, char* pwcsNewName)
        {
            IStorage_vtbl** @this = (IStorage_vtbl**)reference;
            IStorage_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_13, typeof(delegate_13));
            delegate_13 method = (delegate_13)genericDelegate;
            return method(@this, pwcsOldName, pwcsNewName);
        }

        public unsafe int SetElementTimes(char* pwcsName, FILETIME* pctime, FILETIME* patime, FILETIME* pmtime)
        {
            IStorage_vtbl** @this = (IStorage_vtbl**)reference;
            IStorage_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_14, typeof(delegate_14));
            delegate_14 method = (delegate_14)genericDelegate;
            return method(@this, pwcsName, pctime, patime, pmtime);
        }

        public unsafe int SetClass(Guid* clsid)
        {
            IStorage_vtbl** @this = (IStorage_vtbl**)reference;
            IStorage_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_15, typeof(delegate_15));
            delegate_15 method = (delegate_15)genericDelegate;
            return method(@this, clsid);
        }

        public unsafe int SetStateBits(uint grfStateBits, uint grfMask)
        {
            IStorage_vtbl** @this = (IStorage_vtbl**)reference;
            IStorage_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_16, typeof(delegate_16));
            delegate_16 method = (delegate_16)genericDelegate;
            return method(@this, grfStateBits, grfMask);
        }

        public unsafe int Stat(STATSTG* pstatstg, uint grfStatFlag)
        {
            IStorage_vtbl** @this = (IStorage_vtbl**)reference;
            IStorage_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_17, typeof(delegate_17));
            delegate_17 method = (delegate_17)genericDelegate;
            return method(@this, pstatstg, grfStatFlag);
        }

        void IDisposable.Dispose()
        {
            while ((reference != null) && (Release() > 0))
            {
            }
        }

        public unsafe IStorage(IntPtr value)
        {
            reference = (void*)value;
        }

        public unsafe IStorage(void* value)
        {
            reference = value;
        }

        public static unsafe explicit operator IStorage(IUnknown value)
        {
            return new IStorage(*((void**)(&value)));
        }

        public static unsafe implicit operator IUnknown(IStorage value)
        {
            return new IUnknown(value.reference);
        }

        public static unsafe implicit operator IntPtr(IStorage value)
        {
            return new IntPtr(value.reference);
        }

        public static unsafe implicit operator void*(IStorage value)
        {
            return value.reference;
        }

        public static unsafe implicit operator IStorage(IntPtr value)
        {
            return new IStorage(value);
        }

        public static unsafe implicit operator IStorage(void* value)
        {
            return new IStorage(value);
        }

        public unsafe override bool Equals(object obj)
        {
            IStorage other = (IStorage)obj;
            return reference == other.reference;
        }

        public unsafe override int GetHashCode()
        {
            return new IntPtr(reference).GetHashCode();
        }

        public unsafe static bool operator ==(IStorage left, IStorage right)
        {
            return left.reference == right.reference;
        }

        public unsafe static bool operator !=(IStorage left, IStorage right)
        {
            return left.reference != right.reference;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public unsafe struct IStream : _IStream, _ISequentialStream, IDisposable
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        private unsafe struct IStream_vtbl
        {
            internal IntPtr method_0;
            internal IntPtr method_1;
            internal IntPtr method_2;
            internal IntPtr method_3;
            internal IntPtr method_4;
            internal IntPtr method_5;
            internal IntPtr method_6;
            internal IntPtr method_7;
            internal IntPtr method_8;
            internal IntPtr method_9;
            internal IntPtr method_10;
            internal IntPtr method_11;
            internal IntPtr method_12;
            internal IntPtr method_13;
        }

        private unsafe delegate int delegate_0(IStream_vtbl** @this, Guid* riid, IUnknown* ppvObject);
        private unsafe delegate uint delegate_1(IStream_vtbl** @this);
        private unsafe delegate uint delegate_2(IStream_vtbl** @this);
        private unsafe delegate int delegate_3(IStream_vtbl** @this, byte* pv, uint cb, uint* pcbRead);
        private unsafe delegate int delegate_4(IStream_vtbl** @this, byte* pv, uint cb, uint* pcbWritten);
        private unsafe delegate int delegate_5(IStream_vtbl** @this, long dlibMove, uint dwOrigin, ulong* plibNewPosition);
        private unsafe delegate int delegate_6(IStream_vtbl** @this, ulong libNewSize);
        private unsafe delegate int delegate_7(IStream_vtbl** @this, IStream pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten);
        private unsafe delegate int delegate_8(IStream_vtbl** @this, uint grfCommitFlags);
        private unsafe delegate int delegate_9(IStream_vtbl** @this);
        private unsafe delegate int delegate_10(IStream_vtbl** @this, ulong libOffset, ulong cb, uint dwLockType);
        private unsafe delegate int delegate_11(IStream_vtbl** @this, ulong libOffset, ulong cb, uint dwLockType);
        private unsafe delegate int delegate_12(IStream_vtbl** @this, STATSTG* pstatstg, uint grfStatFlag);
        private unsafe delegate int delegate_13(IStream_vtbl** @this, IStream* ppstm);

        private readonly void* reference;
        private static readonly Guid iid = new Guid("0000000c-0000-0000-c000-000000000046");

        public static unsafe Guid IID
        {
            get
            {
                return iid;
            }
        }

        public unsafe int QueryInterface(Guid* riid, IUnknown* ppvObject)
        {
            IStream_vtbl** @this = (IStream_vtbl**)reference;
            IStream_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_0, typeof(delegate_0));
            delegate_0 method = (delegate_0)genericDelegate;
            return method(@this, riid, ppvObject);
        }

        public unsafe uint AddRef()
        {
            IStream_vtbl** @this = (IStream_vtbl**)reference;
            IStream_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_1, typeof(delegate_1));
            delegate_1 method = (delegate_1)genericDelegate;
            return method(@this);
        }

        public unsafe uint Release()
        {
            IStream_vtbl** @this = (IStream_vtbl**)reference;
            IStream_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_2, typeof(delegate_2));
            delegate_2 method = (delegate_2)genericDelegate;
            return method(@this);
        }

        public unsafe int RemoteRead(byte* pv, uint cb, uint* pcbRead)
        {
            IStream_vtbl** @this = (IStream_vtbl**)reference;
            IStream_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_3, typeof(delegate_3));
            delegate_3 method = (delegate_3)genericDelegate;
            return method(@this, pv, cb, pcbRead);
        }

        public unsafe int RemoteWrite(byte* pv, uint cb, uint* pcbWritten)
        {
            IStream_vtbl** @this = (IStream_vtbl**)reference;
            IStream_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_4, typeof(delegate_4));
            delegate_4 method = (delegate_4)genericDelegate;
            return method(@this, pv, cb, pcbWritten);
        }

        public unsafe int RemoteSeek(long dlibMove, uint dwOrigin, ulong* plibNewPosition)
        {
            IStream_vtbl** @this = (IStream_vtbl**)reference;
            IStream_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_5, typeof(delegate_5));
            delegate_5 method = (delegate_5)genericDelegate;
            return method(@this, dlibMove, dwOrigin, plibNewPosition);
        }

        public unsafe int SetSize(ulong libNewSize)
        {
            IStream_vtbl** @this = (IStream_vtbl**)reference;
            IStream_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_6, typeof(delegate_6));
            delegate_6 method = (delegate_6)genericDelegate;
            return method(@this, libNewSize);
        }

        public unsafe int RemoteCopyTo(IStream pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            IStream_vtbl** @this = (IStream_vtbl**)reference;
            IStream_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_7, typeof(delegate_7));
            delegate_7 method = (delegate_7)genericDelegate;
            return method(@this, pstm, cb, pcbRead, pcbWritten);
        }

        public unsafe int Commit(uint grfCommitFlags)
        {
            IStream_vtbl** @this = (IStream_vtbl**)reference;
            IStream_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_8, typeof(delegate_8));
            delegate_8 method = (delegate_8)genericDelegate;
            return method(@this, grfCommitFlags);
        }

        public unsafe int Revert()
        {
            IStream_vtbl** @this = (IStream_vtbl**)reference;
            IStream_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_9, typeof(delegate_9));
            delegate_9 method = (delegate_9)genericDelegate;
            return method(@this);
        }

        public unsafe int LockRegion(ulong libOffset, ulong cb, uint dwLockType)
        {
            IStream_vtbl** @this = (IStream_vtbl**)reference;
            IStream_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_10, typeof(delegate_10));
            delegate_10 method = (delegate_10)genericDelegate;
            return method(@this, libOffset, cb, dwLockType);
        }

        public unsafe int UnlockRegion(ulong libOffset, ulong cb, uint dwLockType)
        {
            IStream_vtbl** @this = (IStream_vtbl**)reference;
            IStream_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_11, typeof(delegate_11));
            delegate_11 method = (delegate_11)genericDelegate;
            return method(@this, libOffset, cb, dwLockType);
        }

        public unsafe int Stat(STATSTG* pstatstg, uint grfStatFlag)
        {
            IStream_vtbl** @this = (IStream_vtbl**)reference;
            IStream_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_12, typeof(delegate_12));
            delegate_12 method = (delegate_12)genericDelegate;
            return method(@this, pstatstg, grfStatFlag);
        }

        public unsafe int Clone(IStream* ppstm)
        {
            IStream_vtbl** @this = (IStream_vtbl**)reference;
            IStream_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_13, typeof(delegate_13));
            delegate_13 method = (delegate_13)genericDelegate;
            return method(@this, ppstm);
        }

        void IDisposable.Dispose()
        {
            while ((reference != null) && (Release() > 0))
            {
            }
        }

        public unsafe IStream(IntPtr value)
        {
            reference = (void*)value;
        }

        public unsafe IStream(void* value)
        {
            reference = value;
        }

        public static unsafe explicit operator IStream(ISequentialStream value)
        {
            return new IStream(*((void**)(&value)));
        }

        public static unsafe implicit operator ISequentialStream(IStream value)
        {
            return new ISequentialStream(value.reference);
        }

        public static unsafe explicit operator IStream(IUnknown value)
        {
            return new IStream(*((void**)(&value)));
        }

        public static unsafe implicit operator IUnknown(IStream value)
        {
            return new IUnknown(value.reference);
        }

        public static unsafe implicit operator IntPtr(IStream value)
        {
            return new IntPtr(value.reference);
        }

        public static unsafe implicit operator void*(IStream value)
        {
            return value.reference;
        }

        public static unsafe implicit operator IStream(IntPtr value)
        {
            return new IStream(value);
        }

        public static unsafe implicit operator IStream(void* value)
        {
            return new IStream(value);
        }

        public unsafe override bool Equals(object obj)
        {
            IStream other = (IStream)obj;
            return reference == other.reference;
        }

        public unsafe override int GetHashCode()
        {
            return new IntPtr(reference).GetHashCode();
        }

        public unsafe static bool operator ==(IStream left, IStream right)
        {
            return left.reference == right.reference;
        }

        public unsafe static bool operator !=(IStream left, IStream right)
        {
            return left.reference != right.reference;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public unsafe struct ITypeComp : _ITypeComp, _IUnknown, IDisposable
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        private unsafe struct ITypeComp_vtbl
        {
            internal IntPtr method_0;
            internal IntPtr method_1;
            internal IntPtr method_2;
            internal IntPtr method_3;
            internal IntPtr method_4;
        }

        private unsafe delegate int delegate_0(ITypeComp_vtbl** @this, Guid* riid, IUnknown* ppvObject);
        private unsafe delegate uint delegate_1(ITypeComp_vtbl** @this);
        private unsafe delegate uint delegate_2(ITypeComp_vtbl** @this);
        private unsafe delegate int delegate_3(ITypeComp_vtbl** @this, char* szName, uint lHashVal, ushort wFlags, ITypeInfo* ppTInfo, DESCKIND* pDescKind, FUNCDESC** ppFuncDesc, VARDESC** ppVarDesc, ITypeComp* ppTypeComp, CLEANLOCALSTORAGE* pDummy);
        private unsafe delegate int delegate_4(ITypeComp_vtbl** @this, char* szName, uint lHashVal, ITypeInfo* ppTInfo);

        private readonly void* reference;
        private static readonly Guid iid = new Guid("00020403-0000-0000-c000-000000000046");

        public static unsafe Guid IID
        {
            get
            {
                return iid;
            }
        }

        public unsafe int QueryInterface(Guid* riid, IUnknown* ppvObject)
        {
            ITypeComp_vtbl** @this = (ITypeComp_vtbl**)reference;
            ITypeComp_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_0, typeof(delegate_0));
            delegate_0 method = (delegate_0)genericDelegate;
            return method(@this, riid, ppvObject);
        }

        public unsafe uint AddRef()
        {
            ITypeComp_vtbl** @this = (ITypeComp_vtbl**)reference;
            ITypeComp_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_1, typeof(delegate_1));
            delegate_1 method = (delegate_1)genericDelegate;
            return method(@this);
        }

        public unsafe uint Release()
        {
            ITypeComp_vtbl** @this = (ITypeComp_vtbl**)reference;
            ITypeComp_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_2, typeof(delegate_2));
            delegate_2 method = (delegate_2)genericDelegate;
            return method(@this);
        }

        public unsafe int RemoteBind(char* szName, uint lHashVal, ushort wFlags, ITypeInfo* ppTInfo, DESCKIND* pDescKind, FUNCDESC** ppFuncDesc, VARDESC** ppVarDesc, ITypeComp* ppTypeComp, CLEANLOCALSTORAGE* pDummy)
        {
            ITypeComp_vtbl** @this = (ITypeComp_vtbl**)reference;
            ITypeComp_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_3, typeof(delegate_3));
            delegate_3 method = (delegate_3)genericDelegate;
            return method(@this, szName, lHashVal, wFlags, ppTInfo, pDescKind, ppFuncDesc, ppVarDesc, ppTypeComp, pDummy);
        }

        public unsafe int RemoteBindType(char* szName, uint lHashVal, ITypeInfo* ppTInfo)
        {
            ITypeComp_vtbl** @this = (ITypeComp_vtbl**)reference;
            ITypeComp_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_4, typeof(delegate_4));
            delegate_4 method = (delegate_4)genericDelegate;
            return method(@this, szName, lHashVal, ppTInfo);
        }

        void IDisposable.Dispose()
        {
            while ((reference != null) && (Release() > 0))
            {
            }
        }

        public unsafe ITypeComp(IntPtr value)
        {
            reference = (void*)value;
        }

        public unsafe ITypeComp(void* value)
        {
            reference = value;
        }

        public static unsafe explicit operator ITypeComp(IUnknown value)
        {
            return new ITypeComp(*((void**)(&value)));
        }

        public static unsafe implicit operator IUnknown(ITypeComp value)
        {
            return new IUnknown(value.reference);
        }

        public static unsafe implicit operator IntPtr(ITypeComp value)
        {
            return new IntPtr(value.reference);
        }

        public static unsafe implicit operator void*(ITypeComp value)
        {
            return value.reference;
        }

        public static unsafe implicit operator ITypeComp(IntPtr value)
        {
            return new ITypeComp(value);
        }

        public static unsafe implicit operator ITypeComp(void* value)
        {
            return new ITypeComp(value);
        }

        public unsafe override bool Equals(object obj)
        {
            ITypeComp other = (ITypeComp)obj;
            return reference == other.reference;
        }

        public unsafe override int GetHashCode()
        {
            return new IntPtr(reference).GetHashCode();
        }

        public unsafe static bool operator ==(ITypeComp left, ITypeComp right)
        {
            return left.reference == right.reference;
        }

        public unsafe static bool operator !=(ITypeComp left, ITypeComp right)
        {
            return left.reference != right.reference;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public unsafe struct ITypeInfo : _ITypeInfo, _IUnknown, IDisposable
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        private unsafe struct ITypeInfo_vtbl
        {
            internal IntPtr method_0;
            internal IntPtr method_1;
            internal IntPtr method_2;
            internal IntPtr method_3;
            internal IntPtr method_4;
            internal IntPtr method_5;
            internal IntPtr method_6;
            internal IntPtr method_7;
            internal IntPtr method_8;
            internal IntPtr method_9;
            internal IntPtr method_10;
            internal IntPtr method_11;
            internal IntPtr method_12;
            internal IntPtr method_13;
            internal IntPtr method_14;
            internal IntPtr method_15;
            internal IntPtr method_16;
            internal IntPtr method_17;
            internal IntPtr method_18;
            internal IntPtr method_19;
            internal IntPtr method_20;
            internal IntPtr method_21;
        }

        private unsafe delegate int delegate_0(ITypeInfo_vtbl** @this, Guid* riid, IUnknown* ppvObject);
        private unsafe delegate uint delegate_1(ITypeInfo_vtbl** @this);
        private unsafe delegate uint delegate_2(ITypeInfo_vtbl** @this);
        private unsafe delegate int delegate_3(ITypeInfo_vtbl** @this, TYPEATTR** ppTypeAttr, CLEANLOCALSTORAGE* pDummy);
        private unsafe delegate int delegate_4(ITypeInfo_vtbl** @this, ITypeComp* ppTComp);
        private unsafe delegate int delegate_5(ITypeInfo_vtbl** @this, uint index, FUNCDESC** ppFuncDesc, CLEANLOCALSTORAGE* pDummy);
        private unsafe delegate int delegate_6(ITypeInfo_vtbl** @this, uint index, VARDESC** ppVarDesc, CLEANLOCALSTORAGE* pDummy);
        private unsafe delegate int delegate_7(ITypeInfo_vtbl** @this, int memid, char** rgBstrNames, uint cMaxNames, uint* pcNames);
        private unsafe delegate int delegate_8(ITypeInfo_vtbl** @this, uint index, uint* pRefType);
        private unsafe delegate int delegate_9(ITypeInfo_vtbl** @this, uint index, int* pImplTypeFlags);
        private unsafe delegate int delegate_10(ITypeInfo_vtbl** @this);
        private unsafe delegate int delegate_11(ITypeInfo_vtbl** @this);
        private unsafe delegate int delegate_12(ITypeInfo_vtbl** @this, int memid, uint refPtrFlags, char** pBstrName, char** pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile);
        private unsafe delegate int delegate_13(ITypeInfo_vtbl** @this, int memid, INVOKEKIND invKind, uint refPtrFlags, char** pBstrDllName, char** pBstrName, ushort* pwOrdinal);
        private unsafe delegate int delegate_14(ITypeInfo_vtbl** @this, uint hRefType, ITypeInfo* ppTInfo);
        private unsafe delegate int delegate_15(ITypeInfo_vtbl** @this);
        private unsafe delegate int delegate_16(ITypeInfo_vtbl** @this, Guid* riid, IUnknown* ppvObj);
        private unsafe delegate int delegate_17(ITypeInfo_vtbl** @this, int memid, char** pBstrMops);
        private unsafe delegate int delegate_18(ITypeInfo_vtbl** @this, ITypeLib* ppTLib, uint* pIndex);
        private unsafe delegate int delegate_19(ITypeInfo_vtbl** @this);
        private unsafe delegate int delegate_20(ITypeInfo_vtbl** @this);
        private unsafe delegate int delegate_21(ITypeInfo_vtbl** @this);

        private readonly void* reference;
        private static readonly Guid iid = new Guid("00020401-0000-0000-c000-000000000046");

        public static unsafe Guid IID
        {
            get
            {
                return iid;
            }
        }

        public unsafe int QueryInterface(Guid* riid, IUnknown* ppvObject)
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_0, typeof(delegate_0));
            delegate_0 method = (delegate_0)genericDelegate;
            return method(@this, riid, ppvObject);
        }

        public unsafe uint AddRef()
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_1, typeof(delegate_1));
            delegate_1 method = (delegate_1)genericDelegate;
            return method(@this);
        }

        public unsafe uint Release()
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_2, typeof(delegate_2));
            delegate_2 method = (delegate_2)genericDelegate;
            return method(@this);
        }

        public unsafe int RemoteGetTypeAttr(TYPEATTR** ppTypeAttr, CLEANLOCALSTORAGE* pDummy)
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_3, typeof(delegate_3));
            delegate_3 method = (delegate_3)genericDelegate;
            return method(@this, ppTypeAttr, pDummy);
        }

        public unsafe int GetTypeComp(ITypeComp* ppTComp)
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_4, typeof(delegate_4));
            delegate_4 method = (delegate_4)genericDelegate;
            return method(@this, ppTComp);
        }

        public unsafe int RemoteGetFuncDesc(uint index, FUNCDESC** ppFuncDesc, CLEANLOCALSTORAGE* pDummy)
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_5, typeof(delegate_5));
            delegate_5 method = (delegate_5)genericDelegate;
            return method(@this, index, ppFuncDesc, pDummy);
        }

        public unsafe int RemoteGetVarDesc(uint index, VARDESC** ppVarDesc, CLEANLOCALSTORAGE* pDummy)
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_6, typeof(delegate_6));
            delegate_6 method = (delegate_6)genericDelegate;
            return method(@this, index, ppVarDesc, pDummy);
        }

        public unsafe int RemoteGetNames(int memid, char** rgBstrNames, uint cMaxNames, uint* pcNames)
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_7, typeof(delegate_7));
            delegate_7 method = (delegate_7)genericDelegate;
            return method(@this, memid, rgBstrNames, cMaxNames, pcNames);
        }

        public unsafe int GetRefTypeOfImplType(uint index, uint* pRefType)
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_8, typeof(delegate_8));
            delegate_8 method = (delegate_8)genericDelegate;
            return method(@this, index, pRefType);
        }

        public unsafe int GetImplTypeFlags(uint index, int* pImplTypeFlags)
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_9, typeof(delegate_9));
            delegate_9 method = (delegate_9)genericDelegate;
            return method(@this, index, pImplTypeFlags);
        }

        public unsafe int LocalGetIDsOfNames()
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_10, typeof(delegate_10));
            delegate_10 method = (delegate_10)genericDelegate;
            return method(@this);
        }

        public unsafe int LocalInvoke()
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_11, typeof(delegate_11));
            delegate_11 method = (delegate_11)genericDelegate;
            return method(@this);
        }

        public unsafe int RemoteGetDocumentation(int memid, uint refPtrFlags, char** pBstrName, char** pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile)
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_12, typeof(delegate_12));
            delegate_12 method = (delegate_12)genericDelegate;
            return method(@this, memid, refPtrFlags, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        }

        public unsafe int RemoteGetDllEntry(int memid, INVOKEKIND invKind, uint refPtrFlags, char** pBstrDllName, char** pBstrName, ushort* pwOrdinal)
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_13, typeof(delegate_13));
            delegate_13 method = (delegate_13)genericDelegate;
            return method(@this, memid, invKind, refPtrFlags, pBstrDllName, pBstrName, pwOrdinal);
        }

        public unsafe int GetRefTypeInfo(uint hRefType, ITypeInfo* ppTInfo)
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_14, typeof(delegate_14));
            delegate_14 method = (delegate_14)genericDelegate;
            return method(@this, hRefType, ppTInfo);
        }

        public unsafe int LocalAddressOfMember()
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_15, typeof(delegate_15));
            delegate_15 method = (delegate_15)genericDelegate;
            return method(@this);
        }

        public unsafe int RemoteCreateInstance(Guid* riid, IUnknown* ppvObj)
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_16, typeof(delegate_16));
            delegate_16 method = (delegate_16)genericDelegate;
            return method(@this, riid, ppvObj);
        }

        public unsafe int GetMops(int memid, char** pBstrMops)
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_17, typeof(delegate_17));
            delegate_17 method = (delegate_17)genericDelegate;
            return method(@this, memid, pBstrMops);
        }

        public unsafe int RemoteGetContainingTypeLib(ITypeLib* ppTLib, uint* pIndex)
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_18, typeof(delegate_18));
            delegate_18 method = (delegate_18)genericDelegate;
            return method(@this, ppTLib, pIndex);
        }

        public unsafe int LocalReleaseTypeAttr()
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_19, typeof(delegate_19));
            delegate_19 method = (delegate_19)genericDelegate;
            return method(@this);
        }

        public unsafe int LocalReleaseFuncDesc()
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_20, typeof(delegate_20));
            delegate_20 method = (delegate_20)genericDelegate;
            return method(@this);
        }

        public unsafe int LocalReleaseVarDesc()
        {
            ITypeInfo_vtbl** @this = (ITypeInfo_vtbl**)reference;
            ITypeInfo_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_21, typeof(delegate_21));
            delegate_21 method = (delegate_21)genericDelegate;
            return method(@this);
        }

        void IDisposable.Dispose()
        {
            while ((reference != null) && (Release() > 0))
            {
            }
        }

        public unsafe ITypeInfo(IntPtr value)
        {
            reference = (void*)value;
        }

        public unsafe ITypeInfo(void* value)
        {
            reference = value;
        }

        public static unsafe explicit operator ITypeInfo(IUnknown value)
        {
            return new ITypeInfo(*((void**)(&value)));
        }

        public static unsafe implicit operator IUnknown(ITypeInfo value)
        {
            return new IUnknown(value.reference);
        }

        public static unsafe implicit operator IntPtr(ITypeInfo value)
        {
            return new IntPtr(value.reference);
        }

        public static unsafe implicit operator void*(ITypeInfo value)
        {
            return value.reference;
        }

        public static unsafe implicit operator ITypeInfo(IntPtr value)
        {
            return new ITypeInfo(value);
        }

        public static unsafe implicit operator ITypeInfo(void* value)
        {
            return new ITypeInfo(value);
        }

        public unsafe override bool Equals(object obj)
        {
            ITypeInfo other = (ITypeInfo)obj;
            return reference == other.reference;
        }

        public unsafe override int GetHashCode()
        {
            return new IntPtr(reference).GetHashCode();
        }

        public unsafe static bool operator ==(ITypeInfo left, ITypeInfo right)
        {
            return left.reference == right.reference;
        }

        public unsafe static bool operator !=(ITypeInfo left, ITypeInfo right)
        {
            return left.reference != right.reference;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public unsafe struct ITypeLib : _ITypeLib, _IUnknown, IDisposable
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        private unsafe struct ITypeLib_vtbl
        {
            internal IntPtr method_0;
            internal IntPtr method_1;
            internal IntPtr method_2;
            internal IntPtr method_3;
            internal IntPtr method_4;
            internal IntPtr method_5;
            internal IntPtr method_6;
            internal IntPtr method_7;
            internal IntPtr method_8;
            internal IntPtr method_9;
            internal IntPtr method_10;
            internal IntPtr method_11;
            internal IntPtr method_12;
        }

        private unsafe delegate int delegate_0(ITypeLib_vtbl** @this, Guid* riid, IUnknown* ppvObject);
        private unsafe delegate uint delegate_1(ITypeLib_vtbl** @this);
        private unsafe delegate uint delegate_2(ITypeLib_vtbl** @this);
        private unsafe delegate int delegate_3(ITypeLib_vtbl** @this, uint* pcTInfo);
        private unsafe delegate int delegate_4(ITypeLib_vtbl** @this, uint index, ITypeInfo* ppTInfo);
        private unsafe delegate int delegate_5(ITypeLib_vtbl** @this, uint index, TYPEKIND* pTKind);
        private unsafe delegate int delegate_6(ITypeLib_vtbl** @this, Guid* guid, ITypeInfo* ppTinfo);
        private unsafe delegate int delegate_7(ITypeLib_vtbl** @this, TLIBATTR** ppTLibAttr, CLEANLOCALSTORAGE* pDummy);
        private unsafe delegate int delegate_8(ITypeLib_vtbl** @this, ITypeComp* ppTComp);
        private unsafe delegate int delegate_9(ITypeLib_vtbl** @this, int index, uint refPtrFlags, char** pBstrName, char** pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile);
        private unsafe delegate int delegate_10(ITypeLib_vtbl** @this, char* szNameBuf, uint lHashVal, BOOL* pfName, char** pBstrLibName);
        private unsafe delegate int delegate_11(ITypeLib_vtbl** @this, char* szNameBuf, uint lHashVal, ITypeInfo* ppTInfo, int* rgMemId, ushort* pcFound, char** pBstrLibName);
        private unsafe delegate int delegate_12(ITypeLib_vtbl** @this);

        private readonly void* reference;
        private static readonly Guid iid = new Guid("00020402-0000-0000-c000-000000000046");

        public static unsafe Guid IID
        {
            get
            {
                return iid;
            }
        }

        public unsafe int QueryInterface(Guid* riid, IUnknown* ppvObject)
        {
            ITypeLib_vtbl** @this = (ITypeLib_vtbl**)reference;
            ITypeLib_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_0, typeof(delegate_0));
            delegate_0 method = (delegate_0)genericDelegate;
            return method(@this, riid, ppvObject);
        }

        public unsafe uint AddRef()
        {
            ITypeLib_vtbl** @this = (ITypeLib_vtbl**)reference;
            ITypeLib_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_1, typeof(delegate_1));
            delegate_1 method = (delegate_1)genericDelegate;
            return method(@this);
        }

        public unsafe uint Release()
        {
            ITypeLib_vtbl** @this = (ITypeLib_vtbl**)reference;
            ITypeLib_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_2, typeof(delegate_2));
            delegate_2 method = (delegate_2)genericDelegate;
            return method(@this);
        }

        public unsafe int RemoteGetTypeInfoCount(uint* pcTInfo)
        {
            ITypeLib_vtbl** @this = (ITypeLib_vtbl**)reference;
            ITypeLib_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_3, typeof(delegate_3));
            delegate_3 method = (delegate_3)genericDelegate;
            return method(@this, pcTInfo);
        }

        public unsafe int GetTypeInfo(uint index, ITypeInfo* ppTInfo)
        {
            ITypeLib_vtbl** @this = (ITypeLib_vtbl**)reference;
            ITypeLib_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_4, typeof(delegate_4));
            delegate_4 method = (delegate_4)genericDelegate;
            return method(@this, index, ppTInfo);
        }

        public unsafe int GetTypeInfoType(uint index, TYPEKIND* pTKind)
        {
            ITypeLib_vtbl** @this = (ITypeLib_vtbl**)reference;
            ITypeLib_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_5, typeof(delegate_5));
            delegate_5 method = (delegate_5)genericDelegate;
            return method(@this, index, pTKind);
        }

        public unsafe int GetTypeInfoOfGuid(Guid* guid, ITypeInfo* ppTinfo)
        {
            ITypeLib_vtbl** @this = (ITypeLib_vtbl**)reference;
            ITypeLib_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_6, typeof(delegate_6));
            delegate_6 method = (delegate_6)genericDelegate;
            return method(@this, guid, ppTinfo);
        }

        public unsafe int RemoteGetLibAttr(TLIBATTR** ppTLibAttr, CLEANLOCALSTORAGE* pDummy)
        {
            ITypeLib_vtbl** @this = (ITypeLib_vtbl**)reference;
            ITypeLib_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_7, typeof(delegate_7));
            delegate_7 method = (delegate_7)genericDelegate;
            return method(@this, ppTLibAttr, pDummy);
        }

        public unsafe int GetTypeComp(ITypeComp* ppTComp)
        {
            ITypeLib_vtbl** @this = (ITypeLib_vtbl**)reference;
            ITypeLib_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_8, typeof(delegate_8));
            delegate_8 method = (delegate_8)genericDelegate;
            return method(@this, ppTComp);
        }

        public unsafe int RemoteGetDocumentation(int index, uint refPtrFlags, char** pBstrName, char** pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile)
        {
            ITypeLib_vtbl** @this = (ITypeLib_vtbl**)reference;
            ITypeLib_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_9, typeof(delegate_9));
            delegate_9 method = (delegate_9)genericDelegate;
            return method(@this, index, refPtrFlags, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        }

        public unsafe int RemoteIsName(char* szNameBuf, uint lHashVal, BOOL* pfName, char** pBstrLibName)
        {
            ITypeLib_vtbl** @this = (ITypeLib_vtbl**)reference;
            ITypeLib_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_10, typeof(delegate_10));
            delegate_10 method = (delegate_10)genericDelegate;
            return method(@this, szNameBuf, lHashVal, pfName, pBstrLibName);
        }

        public unsafe int RemoteFindName(char* szNameBuf, uint lHashVal, ITypeInfo* ppTInfo, int* rgMemId, ushort* pcFound, char** pBstrLibName)
        {
            ITypeLib_vtbl** @this = (ITypeLib_vtbl**)reference;
            ITypeLib_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_11, typeof(delegate_11));
            delegate_11 method = (delegate_11)genericDelegate;
            return method(@this, szNameBuf, lHashVal, ppTInfo, rgMemId, pcFound, pBstrLibName);
        }

        public unsafe int LocalReleaseTLibAttr()
        {
            ITypeLib_vtbl** @this = (ITypeLib_vtbl**)reference;
            ITypeLib_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_12, typeof(delegate_12));
            delegate_12 method = (delegate_12)genericDelegate;
            return method(@this);
        }

        void IDisposable.Dispose()
        {
            while ((reference != null) && (Release() > 0))
            {
            }
        }

        public unsafe ITypeLib(IntPtr value)
        {
            reference = (void*)value;
        }

        public unsafe ITypeLib(void* value)
        {
            reference = value;
        }

        public static unsafe explicit operator ITypeLib(IUnknown value)
        {
            return new ITypeLib(*((void**)(&value)));
        }

        public static unsafe implicit operator IUnknown(ITypeLib value)
        {
            return new IUnknown(value.reference);
        }

        public static unsafe implicit operator IntPtr(ITypeLib value)
        {
            return new IntPtr(value.reference);
        }

        public static unsafe implicit operator void*(ITypeLib value)
        {
            return value.reference;
        }

        public static unsafe implicit operator ITypeLib(IntPtr value)
        {
            return new ITypeLib(value);
        }

        public static unsafe implicit operator ITypeLib(void* value)
        {
            return new ITypeLib(value);
        }

        public unsafe override bool Equals(object obj)
        {
            ITypeLib other = (ITypeLib)obj;
            return reference == other.reference;
        }

        public unsafe override int GetHashCode()
        {
            return new IntPtr(reference).GetHashCode();
        }

        public unsafe static bool operator ==(ITypeLib left, ITypeLib right)
        {
            return left.reference == right.reference;
        }

        public unsafe static bool operator !=(ITypeLib left, ITypeLib right)
        {
            return left.reference != right.reference;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public unsafe struct IUnknown : _IUnknown
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        private unsafe struct IUnknown_vtbl
        {
            internal IntPtr method_0;
            internal IntPtr method_1;
            internal IntPtr method_2;
        }

        private unsafe delegate int delegate_0(IUnknown_vtbl** @this, Guid* riid, IUnknown* ppvObject);
        private unsafe delegate uint delegate_1(IUnknown_vtbl** @this);
        private unsafe delegate uint delegate_2(IUnknown_vtbl** @this);

        private readonly void* reference;
        private static readonly Guid iid = new Guid("00000000-0000-0000-c000-000000000046");

        public static unsafe Guid IID
        {
            get
            {
                return iid;
            }
        }

        public unsafe int QueryInterface(Guid* riid, IUnknown* ppvObject)
        {
            IUnknown_vtbl** @this = (IUnknown_vtbl**)reference;
            IUnknown_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_0, typeof(delegate_0));
            delegate_0 method = (delegate_0)genericDelegate;
            return method(@this, riid, ppvObject);
        }

        public unsafe uint AddRef()
        {
            IUnknown_vtbl** @this = (IUnknown_vtbl**)reference;
            IUnknown_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_1, typeof(delegate_1));
            delegate_1 method = (delegate_1)genericDelegate;
            return method(@this);
        }

        public unsafe uint Release()
        {
            IUnknown_vtbl** @this = (IUnknown_vtbl**)reference;
            IUnknown_vtbl* vtbl = *@this;
            if (vtbl == null)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->method_2, typeof(delegate_2));
            delegate_2 method = (delegate_2)genericDelegate;
            return method(@this);
        }

        public unsafe IUnknown(IntPtr value)
        {
            reference = (void*)value;
        }

        public unsafe IUnknown(void* value)
        {
            reference = value;
        }

        public static unsafe implicit operator IntPtr(IUnknown value)
        {
            return new IntPtr(value.reference);
        }

        public static unsafe implicit operator void*(IUnknown value)
        {
            return value.reference;
        }

        public static unsafe implicit operator IUnknown(IntPtr value)
        {
            return new IUnknown(value);
        }

        public static unsafe implicit operator IUnknown(void* value)
        {
            return new IUnknown(value);
        }

        public unsafe override bool Equals(object obj)
        {
            IUnknown other = (IUnknown)obj;
            return reference == other.reference;
        }

        public unsafe override int GetHashCode()
        {
            return new IntPtr(reference).GetHashCode();
        }

        public unsafe static bool operator ==(IUnknown left, IUnknown right)
        {
            return left.reference == right.reference;
        }

        public unsafe static bool operator !=(IUnknown left, IUnknown right)
        {
            return left.reference != right.reference;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public unsafe struct FARPROC : IDisposable
    {
        private static readonly ConcurrentDictionary<IntPtr, _FARPROC> references = new ConcurrentDictionary<IntPtr, _FARPROC>();

        private readonly IntPtr reference;

        public unsafe FARPROC(_FARPROC value)
            : this()
        {
            IntPtr reference = IntPtr.Zero;
            if (value != null)
            {
                value = new _FARPROC(value);
                reference = Marshal.GetFunctionPointerForDelegate(value);
                references.TryAdd(reference, value);
            }
            this.reference = reference;
        }

        public unsafe FARPROC(IntPtr value)
        {
            reference = value;
        }

        public unsafe FARPROC(void* value)
        {
            reference = new IntPtr(value);
        }

        public static unsafe implicit operator IntPtr(FARPROC value)
        {
            return value.reference;
        }

        public static unsafe implicit operator void*(FARPROC value)
        {
            return (void*)value.reference;
        }

        public static unsafe implicit operator FARPROC(IntPtr value)
        {
            return new FARPROC(value);
        }

        public static unsafe implicit operator FARPROC(void* value)
        {
            return new FARPROC(value);
        }

        public static unsafe implicit operator FARPROC(_FARPROC value)
        {
            return new FARPROC(value);
        }

        public static unsafe implicit operator _FARPROC(FARPROC value)
        {
            IntPtr reference = value.reference;
            return (reference == IntPtr.Zero) ? null : (_FARPROC)Marshal.GetDelegateForFunctionPointer(reference, typeof(_FARPROC));
        }

        public void Dispose()
        {
            _FARPROC removedReference;
            references.TryRemove(reference, out removedReference);
        }

        public void RemoveAllReferences()
        {
            references.Clear();
        }

        public unsafe override bool Equals(object obj)
        {
            FARPROC other = (FARPROC)obj;
            return reference == other.reference;
        }

        public unsafe override int GetHashCode()
        {
            return reference.GetHashCode();
        }

        public unsafe static bool operator ==(FARPROC left, FARPROC right)
        {
            return left.reference == right.reference;
        }

        public unsafe static bool operator !=(FARPROC left, FARPROC right)
        {
            return left.reference != right.reference;
        }

        public unsafe void Invoke()
        {
            if (reference == IntPtr.Zero)
                throw new InvalidComObjectException();
            Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(reference, typeof(_FARPROC));
            _FARPROC method = (_FARPROC)genericDelegate;
            method();
        }
    }

    public unsafe static partial class NativeMethods
    {
        [DllImport("ntdll.dll", EntryPoint = "RtlCompareMemory", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe IntPtr RtlCompareMemory(void* Source1, void* Source2, IntPtr Length);

        [DllImport("ntdll.dll", EntryPoint = "RtlFillMemory", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe void RtlFillMemory(void* Destination, IntPtr Length, byte Fill);

        [DllImport("ntdll.dll", EntryPoint = "RtlMoveMemory", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe void RtlMoveMemory(void* Destination, void* Source, IntPtr Length);

        [DllImport("ntdll.dll", EntryPoint = "RtlZeroMemory", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern unsafe void RtlZeroMemory(void* Destination, IntPtr Length);
    }

    public unsafe static partial class NativeConstants
    {
    }
}
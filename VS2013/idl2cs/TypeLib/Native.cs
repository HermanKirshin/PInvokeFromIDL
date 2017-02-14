using System;
using System.Runtime.InteropServices;

namespace idl2cs.TypeLib
{
    public enum FUNCFLAGS : ushort
    {
        FUNCFLAG_FRESTRICTED = 0x1,
        FUNCFLAG_FSOURCE = 0x2,
        FUNCFLAG_FBINDABLE = 0x4,
        FUNCFLAG_FREQUESTEDIT = 0x8,
        FUNCFLAG_FDISPLAYBIND = 0x10,
        FUNCFLAG_FDEFAULTBIND = 0x20,
        FUNCFLAG_FHIDDEN = 0x40,
        FUNCFLAG_FUSESGETLASTERROR = 0x80,
        FUNCFLAG_FDEFAULTCOLLELEM = 0x100,
        FUNCFLAG_FUIDEFAULT = 0x200,
        FUNCFLAG_FNONBROWSABLE = 0x400,
        FUNCFLAG_FREPLACEABLE = 0x800,
        FUNCFLAG_FIMMEDIATEBIND = 0x1000
    }

    public enum IMPLTYPEFLAG
    {
        IMPLTYPEFLAG_FDEFAULT = 0x1,
        IMPLTYPEFLAG_FSOURCE = 0x2,
        IMPLTYPEFLAG_FRESTRICTED = 0x4,
        IMPLTYPEFLAG_FDEFAULTVTABLE = 0x8
    }

    public enum FUNCKIND
    {
        FUNC_VIRTUAL = 0,
        FUNC_PUREVIRTUAL = (FUNC_VIRTUAL + 1),
        FUNC_NONVIRTUAL = (FUNC_PUREVIRTUAL + 1),
        FUNC_STATIC = (FUNC_NONVIRTUAL + 1),
        FUNC_DISPATCH = (FUNC_STATIC + 1)
    }

    public enum INVOKEKIND
    {
        INVOKE_FUNC = 1,
        INVOKE_PROPERTYGET = 2,
        INVOKE_PROPERTYPUT = 4,
        INVOKE_PROPERTYPUTREF = 8
    }

    public enum TYPEFLAGS
    {
        TYPEFLAG_FAPPOBJECT = 0x1,
        TYPEFLAG_FCANCREATE = 0x2,
        TYPEFLAG_FLICENSED = 0x4,
        TYPEFLAG_FPREDECLID = 0x8,
        TYPEFLAG_FHIDDEN = 0x10,
        TYPEFLAG_FCONTROL = 0x20,
        TYPEFLAG_FDUAL = 0x40,
        TYPEFLAG_FNONEXTENSIBLE = 0x80,
        TYPEFLAG_FOLEAUTOMATION = 0x100,
        TYPEFLAG_FRESTRICTED = 0x200,
        TYPEFLAG_FAGGREGATABLE = 0x400,
        TYPEFLAG_FREPLACEABLE = 0x800,
        TYPEFLAG_FDISPATCHABLE = 0x1000,
        TYPEFLAG_FREVERSEBIND = 0x2000,
        TYPEFLAG_FPROXY = 0x4000
    }

    public enum TYPEKIND
    {
        TKIND_ENUM = 0,
        TKIND_RECORD = (TKIND_ENUM + 1),
        TKIND_MODULE = (TKIND_RECORD + 1),
        TKIND_INTERFACE = (TKIND_MODULE + 1),
        TKIND_DISPATCH = (TKIND_INTERFACE + 1),
        TKIND_COCLASS = (TKIND_DISPATCH + 1),
        TKIND_ALIAS = (TKIND_COCLASS + 1),
        TKIND_UNION = (TKIND_ALIAS + 1),
        TKIND_MAX = (TKIND_UNION + 1)
    }

    public enum VARFLAGS : ushort
    {
        VARFLAG_FREADONLY = 0x1,
        VARFLAG_FSOURCE = 0x2,
        VARFLAG_FBINDABLE = 0x4,
        VARFLAG_FREQUESTEDIT = 0x8,
        VARFLAG_FDISPLAYBIND = 0x10,
        VARFLAG_FDEFAULTBIND = 0x20,
        VARFLAG_FHIDDEN = 0x40,
        VARFLAG_FRESTRICTED = 0x80,
        VARFLAG_FDEFAULTCOLLELEM = 0x100,
        VARFLAG_FUIDEFAULT = 0x200,
        VARFLAG_FNONBROWSABLE = 0x400,
        VARFLAG_FREPLACEABLE = 0x800,
        VARFLAG_FIMMEDIATEBIND = 0x1000
    }

    public enum VARKIND
    {
        VAR_PERINSTANCE = 0,
        VAR_STATIC = (VAR_PERINSTANCE + 1),
        VAR_CONST = (VAR_STATIC + 1),
        VAR_DISPATCH = (VAR_CONST + 1)
    }

    public enum LIBFLAGS
    {
        LIBFLAG_FRESTRICTED = 0x1,
        LIBFLAG_FCONTROL = 0x2,
        LIBFLAG_FHIDDEN = 0x4,
        LIBFLAG_FHASDISKIMAGE = 0x8
    }

    public enum REGKIND
    {
        REGKIND_DEFAULT = 0,
        REGKIND_REGISTER = 1,
        REGKIND_NONE = 2
    }

    public enum SYSKIND
    {
        SYS_WIN16 = 0,
        SYS_WIN32 = (SYS_WIN16 + 1),
        SYS_MAC = (SYS_WIN32 + 1),
        SYS_WIN64 = (SYS_MAC + 1)
    }

    [Flags]
    public enum PARAMFLAGS : ushort
    {
        PARAMFLAG_NONE = 0,
        PARAMFLAG_FIN = 0x1,
        PARAMFLAG_FOUT = 0x2,
        PARAMFLAG_FLCID = 0x4,
        PARAMFLAG_FRETVAL = 0x8,
        PARAMFLAG_FOPT = 0x10,
        PARAMFLAG_FHASDEFAULT = 0x20,
        PARAMFLAG_FHASCUSTDATA = 0x40
    }

    public enum VARENUM : ushort
    {
        VT_EMPTY = 0,
        VT_NULL = 1,
        VT_I2 = 2,
        VT_I4 = 3,
        VT_R4 = 4,
        VT_R8 = 5,
        VT_CY = 6,
        VT_DATE = 7,
        VT_BSTR = 8,
        VT_DISPATCH = 9,
        VT_ERROR = 10,
        VT_BOOL = 11,
        VT_VARIANT = 12,
        VT_UNKNOWN = 13,
        VT_DECIMAL = 14,
        VT_I1 = 16,
        VT_UI1 = 17,
        VT_UI2 = 18,
        VT_UI4 = 19,
        VT_I8 = 20,
        VT_UI8 = 21,
        VT_INT = 22,
        VT_UINT = 23,
        VT_VOID = 24,
        VT_HRESULT = 25,
        VT_PTR = 26,
        VT_SAFEARRAY = 27,
        VT_CARRAY = 28,
        VT_USERDEFINED = 29,
        VT_LPSTR = 30,
        VT_LPWSTR = 31,
        VT_RECORD = 36,
        VT_INT_PTR = 37,
        VT_UINT_PTR = 38,
        VT_FILETIME = 64,
        VT_BLOB = 65,
        VT_STREAM = 66,
        VT_STORAGE = 67,
        VT_STREAMED_OBJECT = 68,
        VT_STORED_OBJECT = 69,
        VT_BLOB_OBJECT = 70,
        VT_CF = 71,
        VT_CLSID = 72,
        VT_VERSIONED_STREAM = 73,
        VT_BSTR_BLOB = 0xfff,
        VT_VECTOR = 0x1000,
        VT_ARRAY = 0x2000,
        VT_BYREF = 0x4000,
        VT_RESERVED = 0x8000,
        VT_ILLEGAL = 0xffff,
        VT_ILLEGALMASKED = 0xfff,
        VT_TYPEMASK = 0xfff
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct TLIBATTR
    {
        public Guid guid;
        public uint lcid;
        public SYSKIND syskind;
        public ushort wMajorVerNum;
        public ushort wMinorVerNum;
        public ushort wLibFlags;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct SAFEARRAYBOUND
    {
        public uint cElements;
        public int lBound;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct SAFEARRAY
    {
        public ushort cDims;
        public ushort fFeatures;
        public uint cbElements;
        public uint cLocks;
        public void* pvData;
        public SAFEARRAYBOUND rgsabound;
    }

    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
    public unsafe struct VARIANT
    {
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public unsafe struct VARIANT_UNION1
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
            public short boolVal;

            [FieldOffset(0)]
            public short @bool;

            [FieldOffset(0)]
            public long scode;

            [FieldOffset(0)]
            public long cyVal;

            [FieldOffset(0)]
            public double date;

            [FieldOffset(0)]
            public char* bstrVal;

            [FieldOffset(0)]
            public IntPtr punkVal; //IUnknown

            [FieldOffset(0)]
            public IntPtr pdispVal; //IDispatch

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
            public short* pboolVal;

            [FieldOffset(0)]
            public short* pbool;

            [FieldOffset(0)]
            public long* pscode;

            [FieldOffset(0)]
            public long* pcyVal;

            [FieldOffset(0)]
            public double* pdate;

            [FieldOffset(0)]
            public char** pbstrVal;

            [FieldOffset(0)]
            public IntPtr* ppunkVal;  //IUnknown

            [FieldOffset(0)]
            public IntPtr* ppdispVal;  //IDispatch

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
            public VARIANT_STRUCT2 __struct2;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public unsafe struct VARIANT_STRUCT2
        {
            public void* pvRecord;
            public IntPtr pRecInfo; // IRecordInfo
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public unsafe struct VARIANT_STRUCT1
        {
            public VARENUM vt;
            public ushort wReserved1;
            public ushort wReserved2;
            public ushort wReserved3;
            public VARIANT_UNION1 __union1;
        }

        [FieldOffset(0)]
        public VARIANT_STRUCT1 __struct1;

        [FieldOffset(0)]
        public decimal decVal;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct TYPEDESC
    {
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public unsafe struct TYPEDESC_UNION1
        {
            [FieldOffset(0)]
            public TYPEDESC* lptdesc;

            [FieldOffset(0)]
            public ARRAYDESC* lpadesc;

            [FieldOffset(0)]
            public uint hreftype;
        }

        public TYPEDESC_UNION1 __union1;
        public VARENUM vt;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct ARRAYDESC
    {
        public TYPEDESC tdescElem;
        public ushort cDims;
        public SAFEARRAYBOUND rgbounds;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CUSTDATA
    {
        public uint cCustData;
        public CUSTDATAITEM* prgCustData;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct CUSTDATAITEM
    {
        public Guid guid;
        public VARIANT varValue;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct ELEMDESC
    {
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public struct ELEMDESC_UNION1
        {
            [FieldOffset(0)]
            public System.Runtime.InteropServices.ComTypes.IDLDESC idldesc;

            [FieldOffset(0)]
            public PARAMDESC paramdesc;
        }

        public TYPEDESC tdesc;
        public ELEMDESC_UNION1 __union1;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct FUNCDESC
    {
        public int memid;
        public int* lprgscode;
        public ELEMDESC* lprgelemdescParam;
        public FUNCKIND funckind;
        public INVOKEKIND invkind;
        public System.Runtime.InteropServices.ComTypes.CALLCONV callconv;
        public short cParams;
        public short cParamsOpt;
        public short oVft;
        public short cScodes;
        public ELEMDESC elemdescFunc;
        public FUNCFLAGS wFuncFlags;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct PARAMDESC
    {
        public PARAMDESCEX* pparamdescex;
        public PARAMFLAGS wParamFlags;
    }

    public unsafe struct PARAMDESCEX
    {
        public uint cBytes;
        public VARIANT varDefaultValue;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct TYPEATTR
    {
        public Guid guid;
        public uint lcid;
        public uint dwReserved;
        public uint memidConstructor;
        public uint memidDestructor;
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
        public System.Runtime.InteropServices.ComTypes.IDLDESC idldescType;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct VARDESC
    {
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public struct VARDESC_UNION1
        {
            [FieldOffset(0)]
            public uint oInst;
            [FieldOffset(0)]
            public VARIANT* lpvarValue;
        }

        public int memid;
        public char* lpstrSchema;
        public VARDESC_UNION1 __union1;
        public ELEMDESC elemdescVar;
        public VARFLAGS wVarFlags;
        public VARKIND varkind;
    }

    [ComImport]
    [Guid("00020403-0000-0000-C000-000000000046")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ITypeComp
    {
        unsafe void Bind(
            [In, MarshalAs(UnmanagedType.LPWStr)] string szName,
            [In] uint lHashVal,
            [In] ushort wFlags,
            [Out] out ITypeInfo ppTInfo,
            [Out] System.Runtime.InteropServices.ComTypes.DESCKIND* pDescKind,
            [Out] System.Runtime.InteropServices.ComTypes.BINDPTR* pBindPtr);

        unsafe void BindType(
            [In, MarshalAs(UnmanagedType.LPWStr)]  string szName,
            [In] uint lHashVal,
            [Out] out ITypeInfo ppTInfo,
            [Out] out ITypeComp ppTComp);

    };

    [ComImport]
    [Guid("00020402-0000-0000-C000-000000000046")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ITypeLib
    {
        [PreserveSig]
        uint GetTypeInfoCount();

        unsafe void GetTypeInfo(
           [In] uint index,
           [Out] out ITypeInfo ppTInfo);

        unsafe void GetTypeInfoType(
           [In] uint index,
           [Out] out TYPEKIND pTKind);

        unsafe void GetTypeInfoOfGuid(
           [In, MarshalAs(UnmanagedType.LPStruct)] Guid guid,
           [Out] out ITypeInfo ppTinfo);

        unsafe void GetLibAttr(
            [Out] out TLIBATTR ppTLibAttr);

        unsafe void GetTypeComp(
           [Out] out ITypeComp ppTComp);

        unsafe void GetDocumentation(
            [In] int index,
            [Out] out char* pBstrName,
            [Out] out char* pBstrDocString,
            [Out] out uint pdwHelpContext,
            [Out] out char* pBstrHelpFile);

        unsafe void IsName(
            [In, Out, MarshalAs(UnmanagedType.LPWStr)] string szNameBuf,
            [In] uint lHashVal,
            [Out] out bool pfName);

        unsafe void FindName(
            [In, Out, MarshalAs(UnmanagedType.LPWStr)] string szNameBuf,
            [In] uint lHashVal,
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4, ArraySubType = UnmanagedType.Interface), Out] ITypeInfo[] ppTInfo,
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4, ArraySubType = UnmanagedType.I4), Out] int[] rgMemId,
            [In, Out] ref ushort pcFound);

        [PreserveSig]
        unsafe void ReleaseTLibAttr(
            [In] TLIBATTR* pTLibAttr);

    }

    [ComImport]
    [Guid("00020411-0000-0000-C000-000000000046")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ITypeLib2 : ITypeLib
    {
        [PreserveSig]
        new uint GetTypeInfoCount();

        unsafe new void GetTypeInfo(
           [In] uint index,
           [Out] out ITypeInfo ppTInfo);

        unsafe new void GetTypeInfoType(
           [In] uint index,
           [Out] out TYPEKIND pTKind);

        unsafe new void GetTypeInfoOfGuid(
           [In, MarshalAs(UnmanagedType.LPStruct)] Guid guid,
           [Out] out ITypeInfo ppTinfo);

        unsafe new void GetLibAttr(
            [Out] out TLIBATTR ppTLibAttr);

        unsafe new void GetTypeComp(
           [Out] out ITypeComp ppTComp);

        unsafe new void GetDocumentation(
            [In] int index,
            [Out] out char* pBstrName,
            [Out] out char* pBstrDocString,
            [Out] out uint pdwHelpContext,
            [Out] out char* pBstrHelpFile);

        unsafe new void IsName(
            [In, Out, MarshalAs(UnmanagedType.LPWStr)] string szNameBuf,
            [In] uint lHashVal,
            [Out] out bool pfName);

        unsafe new void FindName(
            [In, Out, MarshalAs(UnmanagedType.LPWStr)] string szNameBuf,
            [In] uint lHashVal,
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4, ArraySubType = UnmanagedType.Interface), Out] ITypeInfo[] ppTInfo,
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4, ArraySubType = UnmanagedType.I4), Out] int[] rgMemId,
            [In, Out] ref ushort pcFound);

        [PreserveSig]
        unsafe new void ReleaseTLibAttr(
            [In] TLIBATTR* pTLibAttr);

        unsafe void GetCustData(
           [In, MarshalAs(UnmanagedType.LPStruct)] Guid guid,
           [Out] out VARIANT pVarVal);

        unsafe void GetLibStatistics(
            [Out] out uint pcUniqueNames,
            [Out] out uint pcchUniqueNames);

        unsafe void GetDocumentation2(
            [In] int index,
            [In] uint lcid,
            [Out] out char* pbstrHelpString,
            [Out] out uint pdwHelpStringContext,
            [Out] out char* pbstrHelpStringDll);

        unsafe void GetAllCustData(
           [Out] out CUSTDATA pCustData);

    };

    [ComImport]
    [Guid("00020401-0000-0000-C000-000000000046")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ITypeInfo
    {
        unsafe void GetTypeAttr(
            [Out] out TYPEATTR* ppTypeAttr);

        unsafe void GetTypeComp(
           [Out, Optional] out ITypeComp ppTComp);

        unsafe void GetFuncDesc(
            [In] uint index,
            [Out] out FUNCDESC* ppFuncDesc);

        unsafe void GetVarDesc(
            [In] uint index,
            [Out] out VARDESC* ppVarDesc);

        unsafe void GetNames(
            [In] int memid,
            [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 2)] string[] rgBstrNames,
            [In] uint cMaxNames,
            [Out] out uint pcNames);

        unsafe void GetRefTypeOfImplType(
           [In] uint index,
           [Out] out uint pRefType);

        unsafe void GetImplTypeFlags(
           [In] uint index,
           [Out] out int pImplTypeFlags);

        unsafe void GetIDsOfNames(
            [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 1)] string[] rgszNames,
            [In] uint cNames,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] int[] pMemId);

        unsafe void Invoke(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pvInstance,
            [In] int memid,
            [In] ushort wFlags,
            [In, Out] ref System.Runtime.InteropServices.ComTypes.DISPPARAMS pDispParams,
            [Out] out VARIANT pVarResult,
            [Out] out System.Runtime.InteropServices.ComTypes.EXCEPINFO pExcepInfo,
            [Out] out uint puArgErr);

        unsafe void GetDocumentation(
            [In] int memid,
            [Out] out char* pBstrName,
            [Out] out char* pBstrDocString,
            [Out] out uint pdwHelpContext,
            [Out] out char* pBstrHelpFile);

        unsafe void GetDllEntry(
            [In] int memid,
            [In] INVOKEKIND invKind,
            [Out] out char* pBstrDllName,
            [Out] out char* pBstrName,
            [Out] out ushort pwOrdinal);

        unsafe void GetRefTypeInfo(
           [In] uint hRefType,
           [Out] out ITypeInfo ppTInfo);

        unsafe void AddressOfMember(
            [In] int memid,
            [In] INVOKEKIND invKind,
            [Out] out void* ppv);

        unsafe void CreateInstance(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [Out, MarshalAs(UnmanagedType.IUnknown)] out object ppvObj);

        unsafe void GetMops(
           [In] int memid,
           [Out] out char* pBstrMops);

        unsafe void GetContainingTypeLib(
            [Out] out ITypeLib ppTLib,
            [Out] out uint pIndex);

        [PreserveSig]
        unsafe void ReleaseTypeAttr(
            [In] TYPEATTR* pTypeAttr);

        [PreserveSig]
        unsafe void ReleaseFuncDesc(
            [In] FUNCDESC* pFuncDesc);

        [PreserveSig]
        unsafe void ReleaseVarDesc(
            [In] VARDESC* pVarDesc);

    };

    [ComImport]
    [Guid("00020412-0000-0000-C000-000000000046")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ITypeInfo2 : ITypeInfo
    {
        unsafe new void GetTypeAttr(
            [Out] out TYPEATTR* ppTypeAttr);

        unsafe new void GetTypeComp(
           [Out, Optional] out ITypeComp ppTComp);

        unsafe new void GetFuncDesc(
            [In] uint index,
            [Out] out FUNCDESC* ppFuncDesc);

        unsafe new void GetVarDesc(
            [In] uint index,
            [Out] out VARDESC* ppVarDesc);

        unsafe void GetNames(
            [In] int memid,
            [In] char** rgBstrNames,
            [In] uint cMaxNames,
            [Out] out uint pcNames);

        unsafe new void GetRefTypeOfImplType(
           [In] uint index,
           [Out] out uint pRefType);

        unsafe new void GetImplTypeFlags(
           [In] uint index,
           [Out] out int pImplTypeFlags);

        unsafe new void GetIDsOfNames(
            [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 1)] string[] rgszNames,
            [In] uint cNames,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] int[] pMemId);

        unsafe new void Invoke(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pvInstance,
            [In] int memid,
            [In] ushort wFlags,
            [In, Out] ref System.Runtime.InteropServices.ComTypes.DISPPARAMS pDispParams,
            [Out] out VARIANT pVarResult,
            [Out] out System.Runtime.InteropServices.ComTypes.EXCEPINFO pExcepInfo,
            [Out] out uint puArgErr);

        unsafe new void GetDocumentation(
            [In] int memid,
            [Out] out char* pBstrName,
            [Out] out char* pBstrDocString,
            [Out] out uint pdwHelpContext,
            [Out] out char* pBstrHelpFile);

        unsafe new void GetDllEntry(
            [In] int memid,
            [In] INVOKEKIND invKind,
            [Out] out char* pBstrDllName,
            [Out] out char* pBstrName,
            [Out] out ushort pwOrdinal);

        unsafe new void GetRefTypeInfo(
           [In] uint hRefType,
           [Out] out ITypeInfo ppTInfo);

        unsafe new void AddressOfMember(
            [In] int memid,
            [In] INVOKEKIND invKind,
            [Out] out void* ppv);

        unsafe new void CreateInstance(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [Out, MarshalAs(UnmanagedType.IUnknown)] out object ppvObj);

        unsafe new void GetMops(
           [In] int memid,
           [Out] out char* pBstrMops);

        unsafe new void GetContainingTypeLib(
            [Out] out ITypeLib ppTLib,
            [Out] out uint pIndex);

        [PreserveSig]
        unsafe new void ReleaseTypeAttr(
            [In] TYPEATTR* pTypeAttr);

        [PreserveSig]
        unsafe new void ReleaseFuncDesc(
            [In] FUNCDESC* pFuncDesc);

        [PreserveSig]
        unsafe new void ReleaseVarDesc(
            [In] VARDESC* pVarDesc);

        unsafe void GetTypeKind(
           [Out] out TYPEKIND pTypeKind);

        unsafe void GetTypeFlags(
           [Out] out uint pTypeFlags);

        unsafe void GetFuncIndexOfMemId(
           [In] int memid,
           [In] INVOKEKIND invKind,
           [Out] out uint pFuncIndex);

        unsafe void GetVarIndexOfMemId(
           [In] int memid,
           [Out] out uint pVarIndex);

        unsafe void GetCustData(
           [In, MarshalAs(UnmanagedType.LPStruct)] Guid guid,
           [Out] out VARIANT pVarVal);

        unsafe void GetFuncCustData(
           [In] uint index,
           [In, MarshalAs(UnmanagedType.LPStruct)] Guid guid,
           [Out] out VARIANT pVarVal);

        unsafe void GetParamCustData(
           [In] uint indexFunc,
           [In] uint indexParam,
           [In, MarshalAs(UnmanagedType.LPStruct)] Guid guid,
           [Out] out VARIANT pVarVal);

        unsafe void GetVarCustData(
           [In] uint index,
           [In, MarshalAs(UnmanagedType.LPStruct)] Guid guid,
           [Out] out VARIANT pVarVal);

        unsafe void GetImplTypeCustData(
           [In] uint index,
           [In, MarshalAs(UnmanagedType.LPStruct)] Guid guid,
           [Out] out VARIANT pVarVal);

        unsafe void GetDocumentation2(
            [In] int memid,
            [In] uint lcid,
            [Out] out char* pbstrHelpString,
            [Out] out uint pdwHelpStringContext,
            [Out] out char* pbstrHelpStringDll);

        unsafe void GetAllCustData(
           [Out] out CUSTDATA pCustData);

        unsafe void GetAllFuncCustData(
           [In] uint index,
           [Out] out CUSTDATA pCustData);

        unsafe void GetAllParamCustData(
           [In] uint indexFunc,
           [In] uint indexParam,
           [Out] out CUSTDATA pCustData);

        unsafe void GetAllVarCustData(
           [In] uint index,
           [Out] out CUSTDATA pCustData);

        unsafe void GetAllImplTypeCustData(
           [In] uint index,
           [Out] out CUSTDATA pCustData);
    };

    public static class NativeConstants
    {
        public const int MEMBERID_NIL = -1;
    }

    public static unsafe class NativeMethods
    {
        [DllImport("oleaut32.dll")]
        public static extern unsafe int LoadTypeLib([MarshalAs(UnmanagedType.BStr)] string strFile, out ITypeLib ppTypeLib);
        
        [DllImport("oleaut32.dll")]
        public static extern unsafe void SysFreeString(char* bstrString);
    }
}

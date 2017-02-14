#define STRUCT_SIZES \
{\
    { L"ARRAYDESC", sizeof(::ARRAYDESC) },\
    { L"BLOB", sizeof(::BLOB) },\
    { L"BOOL", sizeof(::BOOL) },\
    { L"BOOLEAN", sizeof(::BOOLEAN) },\
    { L"BSTRBLOB", sizeof(::BSTRBLOB) },\
    { L"CABOOL", sizeof(::CABOOL) },\
    { L"CABSTR", sizeof(::CABSTR) },\
    { L"CABSTRBLOB", sizeof(::CABSTRBLOB) },\
    { L"CAC", sizeof(::CAC) },\
    { L"CACLIPDATA", sizeof(::CACLIPDATA) },\
    { L"CACLSID", sizeof(::CACLSID) },\
    { L"CACY", sizeof(::CACY) },\
    { L"CADATE", sizeof(::CADATE) },\
    { L"CADBL", sizeof(::CADBL) },\
    { L"CAFILETIME", sizeof(::CAFILETIME) },\
    { L"CAFLT", sizeof(::CAFLT) },\
    { L"CAH", sizeof(::CAH) },\
    { L"CAI", sizeof(::CAI) },\
    { L"CAL", sizeof(::CAL) },\
    { L"CALPSTR", sizeof(::CALPSTR) },\
    { L"CALPWSTR", sizeof(::CALPWSTR) },\
    { L"CAPROPVARIANT", sizeof(::CAPROPVARIANT) },\
    { L"CASCODE", sizeof(::CASCODE) },\
    { L"CAUB", sizeof(::CAUB) },\
    { L"CAUH", sizeof(::CAUH) },\
    { L"CAUI", sizeof(::CAUI) },\
    { L"CAUL", sizeof(::CAUL) },\
    { L"CLEANLOCALSTORAGE", sizeof(::CLEANLOCALSTORAGE) },\
    { L"CLIPDATA", sizeof(::CLIPDATA) },\
    { L"ELEMDESC", sizeof(::ELEMDESC) },\
    { L"EXCEPINFO", sizeof(::EXCEPINFO) },\
    { L"FILETIME", sizeof(::FILETIME) },\
    { L"FUNCDESC", sizeof(::FUNCDESC) },\
    { L"IDLDESC", sizeof(::IDLDESC) },\
    { L"LUID", sizeof(::LUID) },\
    { L"PARAMDESC", sizeof(::PARAMDESC) },\
    { L"PARAMDESCEX", sizeof(::PARAMDESCEX) },\
    { L"POINT", sizeof(::POINT) },\
    { L"PROPBAG2", sizeof(::PROPBAG2) },\
    { L"PROPVARIANT", sizeof(::PROPVARIANT) },\
    { L"RECT", sizeof(::RECT) },\
    { L"SAFEARRAY", sizeof(::SAFEARRAY) },\
    { L"SAFEARRAYBOUND", sizeof(::SAFEARRAYBOUND) },\
    { L"SECURITY_ATTRIBUTES", sizeof(::SECURITY_ATTRIBUTES) },\
    { L"SIZE", sizeof(::SIZE) },\
    { L"STATSTG", sizeof(::STATSTG) },\
    { L"SYSTEMTIME", sizeof(::SYSTEMTIME) },\
    { L"TLIBATTR", sizeof(::TLIBATTR) },\
    { L"TYPEATTR", sizeof(::TYPEATTR) },\
    { L"TYPEDESC", sizeof(::TYPEDESC) },\
    { L"VARDESC", sizeof(::VARDESC) },\
    { L"VARIANT", sizeof(::VARIANT) },\
    { L"VERSIONEDSTREAM", sizeof(::VERSIONEDSTREAM) },\
    { L"WAVEFORMATEX", sizeof(::WAVEFORMATEX) },\
    { L"LOGFONTW", sizeof(::LOGFONTW) },\
    { L"MSG", sizeof(::MSG) },\
    { L"PAINTSTRUCT", sizeof(::PAINTSTRUCT) },\
    { L"WNDCLASSEX", sizeof(::WNDCLASSEX) },\
    { NULL, 0 }\
}\

#define STRUCT_OFFSETS \
{\
    { L"ARRAYDESC.tdescElem", FIELD_OFFSET(::ARRAYDESC, tdescElem) },\
    { L"ARRAYDESC.tdescElem.lptdesc", FIELD_OFFSET(::ARRAYDESC, tdescElem.lptdesc) },\
    { L"ARRAYDESC.tdescElem.lpadesc", FIELD_OFFSET(::ARRAYDESC, tdescElem.lpadesc) },\
    { L"ARRAYDESC.tdescElem.hreftype", FIELD_OFFSET(::ARRAYDESC, tdescElem.hreftype) },\
    { L"ARRAYDESC.tdescElem.vt", FIELD_OFFSET(::ARRAYDESC, tdescElem.vt) },\
    { L"ARRAYDESC.cDims", FIELD_OFFSET(::ARRAYDESC, cDims) },\
    { L"ARRAYDESC.rgbounds", FIELD_OFFSET(::ARRAYDESC, rgbounds) },\
    { L"BLOB.cbSize", FIELD_OFFSET(::BLOB, cbSize) },\
    { L"BLOB.pBlobData", FIELD_OFFSET(::BLOB, pBlobData) },\
    { L"BSTRBLOB.cbSize", FIELD_OFFSET(::BSTRBLOB, cbSize) },\
    { L"BSTRBLOB.pData", FIELD_OFFSET(::BSTRBLOB, pData) },\
    { L"CABOOL.cElems", FIELD_OFFSET(::CABOOL, cElems) },\
    { L"CABOOL.pElems", FIELD_OFFSET(::CABOOL, pElems) },\
    { L"CABSTR.cElems", FIELD_OFFSET(::CABSTR, cElems) },\
    { L"CABSTR.pElems", FIELD_OFFSET(::CABSTR, pElems) },\
    { L"CABSTRBLOB.cElems", FIELD_OFFSET(::CABSTRBLOB, cElems) },\
    { L"CABSTRBLOB.pElems", FIELD_OFFSET(::CABSTRBLOB, pElems) },\
    { L"CAC.cElems", FIELD_OFFSET(::CAC, cElems) },\
    { L"CAC.pElems", FIELD_OFFSET(::CAC, pElems) },\
    { L"CACLIPDATA.cElems", FIELD_OFFSET(::CACLIPDATA, cElems) },\
    { L"CACLIPDATA.pElems", FIELD_OFFSET(::CACLIPDATA, pElems) },\
    { L"CACLSID.cElems", FIELD_OFFSET(::CACLSID, cElems) },\
    { L"CACLSID.pElems", FIELD_OFFSET(::CACLSID, pElems) },\
    { L"CACY.cElems", FIELD_OFFSET(::CACY, cElems) },\
    { L"CACY.pElems", FIELD_OFFSET(::CACY, pElems) },\
    { L"CADATE.cElems", FIELD_OFFSET(::CADATE, cElems) },\
    { L"CADATE.pElems", FIELD_OFFSET(::CADATE, pElems) },\
    { L"CADBL.cElems", FIELD_OFFSET(::CADBL, cElems) },\
    { L"CADBL.pElems", FIELD_OFFSET(::CADBL, pElems) },\
    { L"CAFILETIME.cElems", FIELD_OFFSET(::CAFILETIME, cElems) },\
    { L"CAFILETIME.pElems", FIELD_OFFSET(::CAFILETIME, pElems) },\
    { L"CAFLT.cElems", FIELD_OFFSET(::CAFLT, cElems) },\
    { L"CAFLT.pElems", FIELD_OFFSET(::CAFLT, pElems) },\
    { L"CAH.cElems", FIELD_OFFSET(::CAH, cElems) },\
    { L"CAH.pElems", FIELD_OFFSET(::CAH, pElems) },\
    { L"CAI.cElems", FIELD_OFFSET(::CAI, cElems) },\
    { L"CAI.pElems", FIELD_OFFSET(::CAI, pElems) },\
    { L"CAL.cElems", FIELD_OFFSET(::CAL, cElems) },\
    { L"CAL.pElems", FIELD_OFFSET(::CAL, pElems) },\
    { L"CALPSTR.cElems", FIELD_OFFSET(::CALPSTR, cElems) },\
    { L"CALPSTR.pElems", FIELD_OFFSET(::CALPSTR, pElems) },\
    { L"CALPWSTR.cElems", FIELD_OFFSET(::CALPWSTR, cElems) },\
    { L"CALPWSTR.pElems", FIELD_OFFSET(::CALPWSTR, pElems) },\
    { L"CAPROPVARIANT.cElems", FIELD_OFFSET(::CAPROPVARIANT, cElems) },\
    { L"CAPROPVARIANT.pElems", FIELD_OFFSET(::CAPROPVARIANT, pElems) },\
    { L"CASCODE.cElems", FIELD_OFFSET(::CASCODE, cElems) },\
    { L"CASCODE.pElems", FIELD_OFFSET(::CASCODE, pElems) },\
    { L"CAUB.cElems", FIELD_OFFSET(::CAUB, cElems) },\
    { L"CAUB.pElems", FIELD_OFFSET(::CAUB, pElems) },\
    { L"CAUH.cElems", FIELD_OFFSET(::CAUH, cElems) },\
    { L"CAUH.pElems", FIELD_OFFSET(::CAUH, pElems) },\
    { L"CAUI.cElems", FIELD_OFFSET(::CAUI, cElems) },\
    { L"CAUI.pElems", FIELD_OFFSET(::CAUI, pElems) },\
    { L"CAUL.cElems", FIELD_OFFSET(::CAUL, cElems) },\
    { L"CAUL.pElems", FIELD_OFFSET(::CAUL, pElems) },\
    { L"CLEANLOCALSTORAGE.pInterface", FIELD_OFFSET(::CLEANLOCALSTORAGE, pInterface) },\
    { L"CLEANLOCALSTORAGE.pStorage", FIELD_OFFSET(::CLEANLOCALSTORAGE, pStorage) },\
    { L"CLEANLOCALSTORAGE.flags", FIELD_OFFSET(::CLEANLOCALSTORAGE, flags) },\
    { L"CLIPDATA.cbSize", FIELD_OFFSET(::CLIPDATA, cbSize) },\
    { L"CLIPDATA.ulClipFmt", FIELD_OFFSET(::CLIPDATA, ulClipFmt) },\
    { L"CLIPDATA.pClipData", FIELD_OFFSET(::CLIPDATA, pClipData) },\
    { L"ELEMDESC.tdesc", FIELD_OFFSET(::ELEMDESC, tdesc) },\
    { L"ELEMDESC.tdesc.lptdesc", FIELD_OFFSET(::ELEMDESC, tdesc.lptdesc) },\
    { L"ELEMDESC.tdesc.lpadesc", FIELD_OFFSET(::ELEMDESC, tdesc.lpadesc) },\
    { L"ELEMDESC.tdesc.hreftype", FIELD_OFFSET(::ELEMDESC, tdesc.hreftype) },\
    { L"ELEMDESC.tdesc.vt", FIELD_OFFSET(::ELEMDESC, tdesc.vt) },\
    { L"ELEMDESC.paramdesc", FIELD_OFFSET(::ELEMDESC, paramdesc) },\
    { L"ELEMDESC.paramdesc.pparamdescex", FIELD_OFFSET(::ELEMDESC, paramdesc.pparamdescex) },\
    { L"ELEMDESC.paramdesc.wParamFlags", FIELD_OFFSET(::ELEMDESC, paramdesc.wParamFlags) },\
    { L"EXCEPINFO.wCode", FIELD_OFFSET(::EXCEPINFO, wCode) },\
    { L"EXCEPINFO.wReserved", FIELD_OFFSET(::EXCEPINFO, wReserved) },\
    { L"EXCEPINFO.bstrSource", FIELD_OFFSET(::EXCEPINFO, bstrSource) },\
    { L"EXCEPINFO.bstrDescription", FIELD_OFFSET(::EXCEPINFO, bstrDescription) },\
    { L"EXCEPINFO.bstrHelpFile", FIELD_OFFSET(::EXCEPINFO, bstrHelpFile) },\
    { L"EXCEPINFO.dwHelpContext", FIELD_OFFSET(::EXCEPINFO, dwHelpContext) },\
    { L"EXCEPINFO.pvReserved", FIELD_OFFSET(::EXCEPINFO, pvReserved) },\
    { L"EXCEPINFO.pfnDeferredFillIn", FIELD_OFFSET(::EXCEPINFO, pfnDeferredFillIn) },\
    { L"EXCEPINFO.scode", FIELD_OFFSET(::EXCEPINFO, scode) },\
    { L"FILETIME.dwLowDateTime", FIELD_OFFSET(::FILETIME, dwLowDateTime) },\
    { L"FILETIME.dwHighDateTime", FIELD_OFFSET(::FILETIME, dwHighDateTime) },\
    { L"FUNCDESC.memid", FIELD_OFFSET(::FUNCDESC, memid) },\
    { L"FUNCDESC.lprgscode", FIELD_OFFSET(::FUNCDESC, lprgscode) },\
    { L"FUNCDESC.lprgelemdescParam", FIELD_OFFSET(::FUNCDESC, lprgelemdescParam) },\
    { L"FUNCDESC.funckind", FIELD_OFFSET(::FUNCDESC, funckind) },\
    { L"FUNCDESC.invkind", FIELD_OFFSET(::FUNCDESC, invkind) },\
    { L"FUNCDESC.callconv", FIELD_OFFSET(::FUNCDESC, callconv) },\
    { L"FUNCDESC.cParams", FIELD_OFFSET(::FUNCDESC, cParams) },\
    { L"FUNCDESC.cParamsOpt", FIELD_OFFSET(::FUNCDESC, cParamsOpt) },\
    { L"FUNCDESC.oVft", FIELD_OFFSET(::FUNCDESC, oVft) },\
    { L"FUNCDESC.cScodes", FIELD_OFFSET(::FUNCDESC, cScodes) },\
    { L"FUNCDESC.elemdescFunc", FIELD_OFFSET(::FUNCDESC, elemdescFunc) },\
    { L"FUNCDESC.elemdescFunc.tdesc", FIELD_OFFSET(::FUNCDESC, elemdescFunc.tdesc) },\
    { L"FUNCDESC.elemdescFunc.tdesc.lptdesc", FIELD_OFFSET(::FUNCDESC, elemdescFunc.tdesc.lptdesc) },\
    { L"FUNCDESC.elemdescFunc.tdesc.lpadesc", FIELD_OFFSET(::FUNCDESC, elemdescFunc.tdesc.lpadesc) },\
    { L"FUNCDESC.elemdescFunc.tdesc.hreftype", FIELD_OFFSET(::FUNCDESC, elemdescFunc.tdesc.hreftype) },\
    { L"FUNCDESC.elemdescFunc.tdesc.vt", FIELD_OFFSET(::FUNCDESC, elemdescFunc.tdesc.vt) },\
    { L"FUNCDESC.elemdescFunc.paramdesc", FIELD_OFFSET(::FUNCDESC, elemdescFunc.paramdesc) },\
    { L"FUNCDESC.elemdescFunc.paramdesc.pparamdescex", FIELD_OFFSET(::FUNCDESC, elemdescFunc.paramdesc.pparamdescex) },\
    { L"FUNCDESC.elemdescFunc.paramdesc.wParamFlags", FIELD_OFFSET(::FUNCDESC, elemdescFunc.paramdesc.wParamFlags) },\
    { L"FUNCDESC.wFuncFlags", FIELD_OFFSET(::FUNCDESC, wFuncFlags) },\
    { L"IDLDESC.dwReserved", FIELD_OFFSET(::IDLDESC, dwReserved) },\
    { L"IDLDESC.wIDLFlags", FIELD_OFFSET(::IDLDESC, wIDLFlags) },\
    { L"LUID.LowPart", FIELD_OFFSET(::LUID, LowPart) },\
    { L"LUID.HighPart", FIELD_OFFSET(::LUID, HighPart) },\
    { L"PARAMDESC.pparamdescex", FIELD_OFFSET(::PARAMDESC, pparamdescex) },\
    { L"PARAMDESC.wParamFlags", FIELD_OFFSET(::PARAMDESC, wParamFlags) },\
    { L"PARAMDESCEX.cBytes", FIELD_OFFSET(::PARAMDESCEX, cBytes) },\
    { L"PARAMDESCEX.varDefaultValue", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue) },\
    { L"PARAMDESCEX.varDefaultValue.vt", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.vt) },\
    { L"PARAMDESCEX.varDefaultValue.wReserved1", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.wReserved1) },\
    { L"PARAMDESCEX.varDefaultValue.wReserved2", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.wReserved2) },\
    { L"PARAMDESCEX.varDefaultValue.wReserved3", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.wReserved3) },\
    { L"PARAMDESCEX.varDefaultValue.llVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.llVal) },\
    { L"PARAMDESCEX.varDefaultValue.lVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.lVal) },\
    { L"PARAMDESCEX.varDefaultValue.bVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.bVal) },\
    { L"PARAMDESCEX.varDefaultValue.iVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.iVal) },\
    { L"PARAMDESCEX.varDefaultValue.fltVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.fltVal) },\
    { L"PARAMDESCEX.varDefaultValue.dblVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.dblVal) },\
    { L"PARAMDESCEX.varDefaultValue.boolVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.boolVal) },\
    { L"PARAMDESCEX.varDefaultValue.scode", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.scode) },\
    { L"PARAMDESCEX.varDefaultValue.cyVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.cyVal) },\
    { L"PARAMDESCEX.varDefaultValue.date", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.date) },\
    { L"PARAMDESCEX.varDefaultValue.bstrVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.bstrVal) },\
    { L"PARAMDESCEX.varDefaultValue.punkVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.punkVal) },\
    { L"PARAMDESCEX.varDefaultValue.pdispVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.pdispVal) },\
    { L"PARAMDESCEX.varDefaultValue.parray", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.parray) },\
    { L"PARAMDESCEX.varDefaultValue.pbVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.pbVal) },\
    { L"PARAMDESCEX.varDefaultValue.piVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.piVal) },\
    { L"PARAMDESCEX.varDefaultValue.plVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.plVal) },\
    { L"PARAMDESCEX.varDefaultValue.pllVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.pllVal) },\
    { L"PARAMDESCEX.varDefaultValue.pfltVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.pfltVal) },\
    { L"PARAMDESCEX.varDefaultValue.pdblVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.pdblVal) },\
    { L"PARAMDESCEX.varDefaultValue.pboolVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.pboolVal) },\
    { L"PARAMDESCEX.varDefaultValue.pscode", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.pscode) },\
    { L"PARAMDESCEX.varDefaultValue.pcyVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.pcyVal) },\
    { L"PARAMDESCEX.varDefaultValue.pdate", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.pdate) },\
    { L"PARAMDESCEX.varDefaultValue.pbstrVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.pbstrVal) },\
    { L"PARAMDESCEX.varDefaultValue.ppunkVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.ppunkVal) },\
    { L"PARAMDESCEX.varDefaultValue.ppdispVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.ppdispVal) },\
    { L"PARAMDESCEX.varDefaultValue.pparray", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.pparray) },\
    { L"PARAMDESCEX.varDefaultValue.pvarVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.pvarVal) },\
    { L"PARAMDESCEX.varDefaultValue.byref", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.byref) },\
    { L"PARAMDESCEX.varDefaultValue.cVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.cVal) },\
    { L"PARAMDESCEX.varDefaultValue.uiVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.uiVal) },\
    { L"PARAMDESCEX.varDefaultValue.ulVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.ulVal) },\
    { L"PARAMDESCEX.varDefaultValue.ullVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.ullVal) },\
    { L"PARAMDESCEX.varDefaultValue.intVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.intVal) },\
    { L"PARAMDESCEX.varDefaultValue.uintVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.uintVal) },\
    { L"PARAMDESCEX.varDefaultValue.pdecVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.pdecVal) },\
    { L"PARAMDESCEX.varDefaultValue.pcVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.pcVal) },\
    { L"PARAMDESCEX.varDefaultValue.puiVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.puiVal) },\
    { L"PARAMDESCEX.varDefaultValue.pulVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.pulVal) },\
    { L"PARAMDESCEX.varDefaultValue.pullVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.pullVal) },\
    { L"PARAMDESCEX.varDefaultValue.pintVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.pintVal) },\
    { L"PARAMDESCEX.varDefaultValue.puintVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.puintVal) },\
    { L"PARAMDESCEX.varDefaultValue.pvRecord", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.pvRecord) },\
    { L"PARAMDESCEX.varDefaultValue.pRecInfo", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.pRecInfo) },\
    { L"PARAMDESCEX.varDefaultValue.decVal", FIELD_OFFSET(::PARAMDESCEX, varDefaultValue.decVal) },\
    { L"POINT.x", FIELD_OFFSET(::POINT, x) },\
    { L"POINT.y", FIELD_OFFSET(::POINT, y) },\
    { L"PROPBAG2.dwType", FIELD_OFFSET(::PROPBAG2, dwType) },\
    { L"PROPBAG2.vt", FIELD_OFFSET(::PROPBAG2, vt) },\
    { L"PROPBAG2.cfType", FIELD_OFFSET(::PROPBAG2, cfType) },\
    { L"PROPBAG2.dwHint", FIELD_OFFSET(::PROPBAG2, dwHint) },\
    { L"PROPBAG2.pstrName", FIELD_OFFSET(::PROPBAG2, pstrName) },\
    { L"PROPBAG2.clsid", FIELD_OFFSET(::PROPBAG2, clsid) },\
    { L"PROPVARIANT.vt", FIELD_OFFSET(::PROPVARIANT, vt) },\
    { L"PROPVARIANT.wReserved1", FIELD_OFFSET(::PROPVARIANT, wReserved1) },\
    { L"PROPVARIANT.wReserved2", FIELD_OFFSET(::PROPVARIANT, wReserved2) },\
    { L"PROPVARIANT.wReserved3", FIELD_OFFSET(::PROPVARIANT, wReserved3) },\
    { L"PROPVARIANT.cVal", FIELD_OFFSET(::PROPVARIANT, cVal) },\
    { L"PROPVARIANT.bVal", FIELD_OFFSET(::PROPVARIANT, bVal) },\
    { L"PROPVARIANT.iVal", FIELD_OFFSET(::PROPVARIANT, iVal) },\
    { L"PROPVARIANT.uiVal", FIELD_OFFSET(::PROPVARIANT, uiVal) },\
    { L"PROPVARIANT.lVal", FIELD_OFFSET(::PROPVARIANT, lVal) },\
    { L"PROPVARIANT.ulVal", FIELD_OFFSET(::PROPVARIANT, ulVal) },\
    { L"PROPVARIANT.intVal", FIELD_OFFSET(::PROPVARIANT, intVal) },\
    { L"PROPVARIANT.uintVal", FIELD_OFFSET(::PROPVARIANT, uintVal) },\
    { L"PROPVARIANT.hVal", FIELD_OFFSET(::PROPVARIANT, hVal) },\
    { L"PROPVARIANT.uhVal", FIELD_OFFSET(::PROPVARIANT, uhVal) },\
    { L"PROPVARIANT.fltVal", FIELD_OFFSET(::PROPVARIANT, fltVal) },\
    { L"PROPVARIANT.dblVal", FIELD_OFFSET(::PROPVARIANT, dblVal) },\
    { L"PROPVARIANT.boolVal", FIELD_OFFSET(::PROPVARIANT, boolVal) },\
    { L"PROPVARIANT.scode", FIELD_OFFSET(::PROPVARIANT, scode) },\
    { L"PROPVARIANT.cyVal", FIELD_OFFSET(::PROPVARIANT, cyVal) },\
    { L"PROPVARIANT.date", FIELD_OFFSET(::PROPVARIANT, date) },\
    { L"PROPVARIANT.filetime", FIELD_OFFSET(::PROPVARIANT, filetime) },\
    { L"PROPVARIANT.filetime.dwLowDateTime", FIELD_OFFSET(::PROPVARIANT, filetime.dwLowDateTime) },\
    { L"PROPVARIANT.filetime.dwHighDateTime", FIELD_OFFSET(::PROPVARIANT, filetime.dwHighDateTime) },\
    { L"PROPVARIANT.puuid", FIELD_OFFSET(::PROPVARIANT, puuid) },\
    { L"PROPVARIANT.pclipdata", FIELD_OFFSET(::PROPVARIANT, pclipdata) },\
    { L"PROPVARIANT.bstrVal", FIELD_OFFSET(::PROPVARIANT, bstrVal) },\
    { L"PROPVARIANT.bstrblobVal", FIELD_OFFSET(::PROPVARIANT, bstrblobVal) },\
    { L"PROPVARIANT.bstrblobVal.cbSize", FIELD_OFFSET(::PROPVARIANT, bstrblobVal.cbSize) },\
    { L"PROPVARIANT.bstrblobVal.pData", FIELD_OFFSET(::PROPVARIANT, bstrblobVal.pData) },\
    { L"PROPVARIANT.blob", FIELD_OFFSET(::PROPVARIANT, blob) },\
    { L"PROPVARIANT.blob.cbSize", FIELD_OFFSET(::PROPVARIANT, blob.cbSize) },\
    { L"PROPVARIANT.blob.pBlobData", FIELD_OFFSET(::PROPVARIANT, blob.pBlobData) },\
    { L"PROPVARIANT.pszVal", FIELD_OFFSET(::PROPVARIANT, pszVal) },\
    { L"PROPVARIANT.pwszVal", FIELD_OFFSET(::PROPVARIANT, pwszVal) },\
    { L"PROPVARIANT.punkVal", FIELD_OFFSET(::PROPVARIANT, punkVal) },\
    { L"PROPVARIANT.pdispVal", FIELD_OFFSET(::PROPVARIANT, pdispVal) },\
    { L"PROPVARIANT.pStream", FIELD_OFFSET(::PROPVARIANT, pStream) },\
    { L"PROPVARIANT.pStorage", FIELD_OFFSET(::PROPVARIANT, pStorage) },\
    { L"PROPVARIANT.pVersionedStream", FIELD_OFFSET(::PROPVARIANT, pVersionedStream) },\
    { L"PROPVARIANT.parray", FIELD_OFFSET(::PROPVARIANT, parray) },\
    { L"PROPVARIANT.cac", FIELD_OFFSET(::PROPVARIANT, cac) },\
    { L"PROPVARIANT.cac.cElems", FIELD_OFFSET(::PROPVARIANT, cac.cElems) },\
    { L"PROPVARIANT.cac.pElems", FIELD_OFFSET(::PROPVARIANT, cac.pElems) },\
    { L"PROPVARIANT.caub", FIELD_OFFSET(::PROPVARIANT, caub) },\
    { L"PROPVARIANT.caub.cElems", FIELD_OFFSET(::PROPVARIANT, caub.cElems) },\
    { L"PROPVARIANT.caub.pElems", FIELD_OFFSET(::PROPVARIANT, caub.pElems) },\
    { L"PROPVARIANT.cai", FIELD_OFFSET(::PROPVARIANT, cai) },\
    { L"PROPVARIANT.cai.cElems", FIELD_OFFSET(::PROPVARIANT, cai.cElems) },\
    { L"PROPVARIANT.cai.pElems", FIELD_OFFSET(::PROPVARIANT, cai.pElems) },\
    { L"PROPVARIANT.caui", FIELD_OFFSET(::PROPVARIANT, caui) },\
    { L"PROPVARIANT.caui.cElems", FIELD_OFFSET(::PROPVARIANT, caui.cElems) },\
    { L"PROPVARIANT.caui.pElems", FIELD_OFFSET(::PROPVARIANT, caui.pElems) },\
    { L"PROPVARIANT.cal", FIELD_OFFSET(::PROPVARIANT, cal) },\
    { L"PROPVARIANT.cal.cElems", FIELD_OFFSET(::PROPVARIANT, cal.cElems) },\
    { L"PROPVARIANT.cal.pElems", FIELD_OFFSET(::PROPVARIANT, cal.pElems) },\
    { L"PROPVARIANT.caul", FIELD_OFFSET(::PROPVARIANT, caul) },\
    { L"PROPVARIANT.caul.cElems", FIELD_OFFSET(::PROPVARIANT, caul.cElems) },\
    { L"PROPVARIANT.caul.pElems", FIELD_OFFSET(::PROPVARIANT, caul.pElems) },\
    { L"PROPVARIANT.cah", FIELD_OFFSET(::PROPVARIANT, cah) },\
    { L"PROPVARIANT.cah.cElems", FIELD_OFFSET(::PROPVARIANT, cah.cElems) },\
    { L"PROPVARIANT.cah.pElems", FIELD_OFFSET(::PROPVARIANT, cah.pElems) },\
    { L"PROPVARIANT.cauh", FIELD_OFFSET(::PROPVARIANT, cauh) },\
    { L"PROPVARIANT.cauh.cElems", FIELD_OFFSET(::PROPVARIANT, cauh.cElems) },\
    { L"PROPVARIANT.cauh.pElems", FIELD_OFFSET(::PROPVARIANT, cauh.pElems) },\
    { L"PROPVARIANT.caflt", FIELD_OFFSET(::PROPVARIANT, caflt) },\
    { L"PROPVARIANT.caflt.cElems", FIELD_OFFSET(::PROPVARIANT, caflt.cElems) },\
    { L"PROPVARIANT.caflt.pElems", FIELD_OFFSET(::PROPVARIANT, caflt.pElems) },\
    { L"PROPVARIANT.cadbl", FIELD_OFFSET(::PROPVARIANT, cadbl) },\
    { L"PROPVARIANT.cadbl.cElems", FIELD_OFFSET(::PROPVARIANT, cadbl.cElems) },\
    { L"PROPVARIANT.cadbl.pElems", FIELD_OFFSET(::PROPVARIANT, cadbl.pElems) },\
    { L"PROPVARIANT.cabool", FIELD_OFFSET(::PROPVARIANT, cabool) },\
    { L"PROPVARIANT.cabool.cElems", FIELD_OFFSET(::PROPVARIANT, cabool.cElems) },\
    { L"PROPVARIANT.cabool.pElems", FIELD_OFFSET(::PROPVARIANT, cabool.pElems) },\
    { L"PROPVARIANT.cascode", FIELD_OFFSET(::PROPVARIANT, cascode) },\
    { L"PROPVARIANT.cascode.cElems", FIELD_OFFSET(::PROPVARIANT, cascode.cElems) },\
    { L"PROPVARIANT.cascode.pElems", FIELD_OFFSET(::PROPVARIANT, cascode.pElems) },\
    { L"PROPVARIANT.cacy", FIELD_OFFSET(::PROPVARIANT, cacy) },\
    { L"PROPVARIANT.cacy.cElems", FIELD_OFFSET(::PROPVARIANT, cacy.cElems) },\
    { L"PROPVARIANT.cacy.pElems", FIELD_OFFSET(::PROPVARIANT, cacy.pElems) },\
    { L"PROPVARIANT.cadate", FIELD_OFFSET(::PROPVARIANT, cadate) },\
    { L"PROPVARIANT.cadate.cElems", FIELD_OFFSET(::PROPVARIANT, cadate.cElems) },\
    { L"PROPVARIANT.cadate.pElems", FIELD_OFFSET(::PROPVARIANT, cadate.pElems) },\
    { L"PROPVARIANT.cafiletime", FIELD_OFFSET(::PROPVARIANT, cafiletime) },\
    { L"PROPVARIANT.cafiletime.cElems", FIELD_OFFSET(::PROPVARIANT, cafiletime.cElems) },\
    { L"PROPVARIANT.cafiletime.pElems", FIELD_OFFSET(::PROPVARIANT, cafiletime.pElems) },\
    { L"PROPVARIANT.cauuid", FIELD_OFFSET(::PROPVARIANT, cauuid) },\
    { L"PROPVARIANT.cauuid.cElems", FIELD_OFFSET(::PROPVARIANT, cauuid.cElems) },\
    { L"PROPVARIANT.cauuid.pElems", FIELD_OFFSET(::PROPVARIANT, cauuid.pElems) },\
    { L"PROPVARIANT.caclipdata", FIELD_OFFSET(::PROPVARIANT, caclipdata) },\
    { L"PROPVARIANT.caclipdata.cElems", FIELD_OFFSET(::PROPVARIANT, caclipdata.cElems) },\
    { L"PROPVARIANT.caclipdata.pElems", FIELD_OFFSET(::PROPVARIANT, caclipdata.pElems) },\
    { L"PROPVARIANT.cabstr", FIELD_OFFSET(::PROPVARIANT, cabstr) },\
    { L"PROPVARIANT.cabstr.cElems", FIELD_OFFSET(::PROPVARIANT, cabstr.cElems) },\
    { L"PROPVARIANT.cabstr.pElems", FIELD_OFFSET(::PROPVARIANT, cabstr.pElems) },\
    { L"PROPVARIANT.cabstrblob", FIELD_OFFSET(::PROPVARIANT, cabstrblob) },\
    { L"PROPVARIANT.cabstrblob.cElems", FIELD_OFFSET(::PROPVARIANT, cabstrblob.cElems) },\
    { L"PROPVARIANT.cabstrblob.pElems", FIELD_OFFSET(::PROPVARIANT, cabstrblob.pElems) },\
    { L"PROPVARIANT.calpstr", FIELD_OFFSET(::PROPVARIANT, calpstr) },\
    { L"PROPVARIANT.calpstr.cElems", FIELD_OFFSET(::PROPVARIANT, calpstr.cElems) },\
    { L"PROPVARIANT.calpstr.pElems", FIELD_OFFSET(::PROPVARIANT, calpstr.pElems) },\
    { L"PROPVARIANT.calpwstr", FIELD_OFFSET(::PROPVARIANT, calpwstr) },\
    { L"PROPVARIANT.calpwstr.cElems", FIELD_OFFSET(::PROPVARIANT, calpwstr.cElems) },\
    { L"PROPVARIANT.calpwstr.pElems", FIELD_OFFSET(::PROPVARIANT, calpwstr.pElems) },\
    { L"PROPVARIANT.capropvar", FIELD_OFFSET(::PROPVARIANT, capropvar) },\
    { L"PROPVARIANT.capropvar.cElems", FIELD_OFFSET(::PROPVARIANT, capropvar.cElems) },\
    { L"PROPVARIANT.capropvar.pElems", FIELD_OFFSET(::PROPVARIANT, capropvar.pElems) },\
    { L"PROPVARIANT.pcVal", FIELD_OFFSET(::PROPVARIANT, pcVal) },\
    { L"PROPVARIANT.pbVal", FIELD_OFFSET(::PROPVARIANT, pbVal) },\
    { L"PROPVARIANT.piVal", FIELD_OFFSET(::PROPVARIANT, piVal) },\
    { L"PROPVARIANT.puiVal", FIELD_OFFSET(::PROPVARIANT, puiVal) },\
    { L"PROPVARIANT.plVal", FIELD_OFFSET(::PROPVARIANT, plVal) },\
    { L"PROPVARIANT.pulVal", FIELD_OFFSET(::PROPVARIANT, pulVal) },\
    { L"PROPVARIANT.pintVal", FIELD_OFFSET(::PROPVARIANT, pintVal) },\
    { L"PROPVARIANT.puintVal", FIELD_OFFSET(::PROPVARIANT, puintVal) },\
    { L"PROPVARIANT.pfltVal", FIELD_OFFSET(::PROPVARIANT, pfltVal) },\
    { L"PROPVARIANT.pdblVal", FIELD_OFFSET(::PROPVARIANT, pdblVal) },\
    { L"PROPVARIANT.pboolVal", FIELD_OFFSET(::PROPVARIANT, pboolVal) },\
    { L"PROPVARIANT.pdecVal", FIELD_OFFSET(::PROPVARIANT, pdecVal) },\
    { L"PROPVARIANT.pscode", FIELD_OFFSET(::PROPVARIANT, pscode) },\
    { L"PROPVARIANT.pcyVal", FIELD_OFFSET(::PROPVARIANT, pcyVal) },\
    { L"PROPVARIANT.pdate", FIELD_OFFSET(::PROPVARIANT, pdate) },\
    { L"PROPVARIANT.pbstrVal", FIELD_OFFSET(::PROPVARIANT, pbstrVal) },\
    { L"PROPVARIANT.ppunkVal", FIELD_OFFSET(::PROPVARIANT, ppunkVal) },\
    { L"PROPVARIANT.ppdispVal", FIELD_OFFSET(::PROPVARIANT, ppdispVal) },\
    { L"PROPVARIANT.pparray", FIELD_OFFSET(::PROPVARIANT, pparray) },\
    { L"PROPVARIANT.pvarVal", FIELD_OFFSET(::PROPVARIANT, pvarVal) },\
    { L"PROPVARIANT.decVal", FIELD_OFFSET(::PROPVARIANT, decVal) },\
    { L"RECT.left", FIELD_OFFSET(::RECT, left) },\
    { L"RECT.top", FIELD_OFFSET(::RECT, top) },\
    { L"RECT.right", FIELD_OFFSET(::RECT, right) },\
    { L"RECT.bottom", FIELD_OFFSET(::RECT, bottom) },\
    { L"SAFEARRAY.cDims", FIELD_OFFSET(::SAFEARRAY, cDims) },\
    { L"SAFEARRAY.fFeatures", FIELD_OFFSET(::SAFEARRAY, fFeatures) },\
    { L"SAFEARRAY.cbElements", FIELD_OFFSET(::SAFEARRAY, cbElements) },\
    { L"SAFEARRAY.cLocks", FIELD_OFFSET(::SAFEARRAY, cLocks) },\
    { L"SAFEARRAY.pvData", FIELD_OFFSET(::SAFEARRAY, pvData) },\
    { L"SAFEARRAY.rgsabound", FIELD_OFFSET(::SAFEARRAY, rgsabound) },\
    { L"SAFEARRAYBOUND.cElements", FIELD_OFFSET(::SAFEARRAYBOUND, cElements) },\
    { L"SAFEARRAYBOUND.lLbound", FIELD_OFFSET(::SAFEARRAYBOUND, lLbound) },\
    { L"SECURITY_ATTRIBUTES.nLength", FIELD_OFFSET(::SECURITY_ATTRIBUTES, nLength) },\
    { L"SECURITY_ATTRIBUTES.lpSecurityDescriptor", FIELD_OFFSET(::SECURITY_ATTRIBUTES, lpSecurityDescriptor) },\
    { L"SECURITY_ATTRIBUTES.bInheritHandle", FIELD_OFFSET(::SECURITY_ATTRIBUTES, bInheritHandle) },\
    { L"SIZE.cx", FIELD_OFFSET(::SIZE, cx) },\
    { L"SIZE.cy", FIELD_OFFSET(::SIZE, cy) },\
    { L"STATSTG.pwcsName", FIELD_OFFSET(::STATSTG, pwcsName) },\
    { L"STATSTG.type", FIELD_OFFSET(::STATSTG, type) },\
    { L"STATSTG.cbSize", FIELD_OFFSET(::STATSTG, cbSize) },\
    { L"STATSTG.mtime", FIELD_OFFSET(::STATSTG, mtime) },\
    { L"STATSTG.mtime.dwLowDateTime", FIELD_OFFSET(::STATSTG, mtime.dwLowDateTime) },\
    { L"STATSTG.mtime.dwHighDateTime", FIELD_OFFSET(::STATSTG, mtime.dwHighDateTime) },\
    { L"STATSTG.ctime", FIELD_OFFSET(::STATSTG, ctime) },\
    { L"STATSTG.ctime.dwLowDateTime", FIELD_OFFSET(::STATSTG, ctime.dwLowDateTime) },\
    { L"STATSTG.ctime.dwHighDateTime", FIELD_OFFSET(::STATSTG, ctime.dwHighDateTime) },\
    { L"STATSTG.atime", FIELD_OFFSET(::STATSTG, atime) },\
    { L"STATSTG.atime.dwLowDateTime", FIELD_OFFSET(::STATSTG, atime.dwLowDateTime) },\
    { L"STATSTG.atime.dwHighDateTime", FIELD_OFFSET(::STATSTG, atime.dwHighDateTime) },\
    { L"STATSTG.grfMode", FIELD_OFFSET(::STATSTG, grfMode) },\
    { L"STATSTG.grfLocksSupported", FIELD_OFFSET(::STATSTG, grfLocksSupported) },\
    { L"STATSTG.clsid", FIELD_OFFSET(::STATSTG, clsid) },\
    { L"STATSTG.grfStateBits", FIELD_OFFSET(::STATSTG, grfStateBits) },\
    { L"STATSTG.reserved", FIELD_OFFSET(::STATSTG, reserved) },\
    { L"SYSTEMTIME.wYear", FIELD_OFFSET(::SYSTEMTIME, wYear) },\
    { L"SYSTEMTIME.wMonth", FIELD_OFFSET(::SYSTEMTIME, wMonth) },\
    { L"SYSTEMTIME.wDayOfWeek", FIELD_OFFSET(::SYSTEMTIME, wDayOfWeek) },\
    { L"SYSTEMTIME.wDay", FIELD_OFFSET(::SYSTEMTIME, wDay) },\
    { L"SYSTEMTIME.wHour", FIELD_OFFSET(::SYSTEMTIME, wHour) },\
    { L"SYSTEMTIME.wMinute", FIELD_OFFSET(::SYSTEMTIME, wMinute) },\
    { L"SYSTEMTIME.wSecond", FIELD_OFFSET(::SYSTEMTIME, wSecond) },\
    { L"SYSTEMTIME.wMilliseconds", FIELD_OFFSET(::SYSTEMTIME, wMilliseconds) },\
    { L"TLIBATTR.guid", FIELD_OFFSET(::TLIBATTR, guid) },\
    { L"TLIBATTR.lcid", FIELD_OFFSET(::TLIBATTR, lcid) },\
    { L"TLIBATTR.syskind", FIELD_OFFSET(::TLIBATTR, syskind) },\
    { L"TLIBATTR.wMajorVerNum", FIELD_OFFSET(::TLIBATTR, wMajorVerNum) },\
    { L"TLIBATTR.wMinorVerNum", FIELD_OFFSET(::TLIBATTR, wMinorVerNum) },\
    { L"TLIBATTR.wLibFlags", FIELD_OFFSET(::TLIBATTR, wLibFlags) },\
    { L"TYPEATTR.guid", FIELD_OFFSET(::TYPEATTR, guid) },\
    { L"TYPEATTR.lcid", FIELD_OFFSET(::TYPEATTR, lcid) },\
    { L"TYPEATTR.dwReserved", FIELD_OFFSET(::TYPEATTR, dwReserved) },\
    { L"TYPEATTR.memidConstructor", FIELD_OFFSET(::TYPEATTR, memidConstructor) },\
    { L"TYPEATTR.memidDestructor", FIELD_OFFSET(::TYPEATTR, memidDestructor) },\
    { L"TYPEATTR.lpstrSchema", FIELD_OFFSET(::TYPEATTR, lpstrSchema) },\
    { L"TYPEATTR.cbSizeInstance", FIELD_OFFSET(::TYPEATTR, cbSizeInstance) },\
    { L"TYPEATTR.typekind", FIELD_OFFSET(::TYPEATTR, typekind) },\
    { L"TYPEATTR.cFuncs", FIELD_OFFSET(::TYPEATTR, cFuncs) },\
    { L"TYPEATTR.cVars", FIELD_OFFSET(::TYPEATTR, cVars) },\
    { L"TYPEATTR.cImplTypes", FIELD_OFFSET(::TYPEATTR, cImplTypes) },\
    { L"TYPEATTR.cbSizeVft", FIELD_OFFSET(::TYPEATTR, cbSizeVft) },\
    { L"TYPEATTR.cbAlignment", FIELD_OFFSET(::TYPEATTR, cbAlignment) },\
    { L"TYPEATTR.wTypeFlags", FIELD_OFFSET(::TYPEATTR, wTypeFlags) },\
    { L"TYPEATTR.wMajorVerNum", FIELD_OFFSET(::TYPEATTR, wMajorVerNum) },\
    { L"TYPEATTR.wMinorVerNum", FIELD_OFFSET(::TYPEATTR, wMinorVerNum) },\
    { L"TYPEATTR.tdescAlias", FIELD_OFFSET(::TYPEATTR, tdescAlias) },\
    { L"TYPEATTR.tdescAlias.lptdesc", FIELD_OFFSET(::TYPEATTR, tdescAlias.lptdesc) },\
    { L"TYPEATTR.tdescAlias.lpadesc", FIELD_OFFSET(::TYPEATTR, tdescAlias.lpadesc) },\
    { L"TYPEATTR.tdescAlias.hreftype", FIELD_OFFSET(::TYPEATTR, tdescAlias.hreftype) },\
    { L"TYPEATTR.tdescAlias.vt", FIELD_OFFSET(::TYPEATTR, tdescAlias.vt) },\
    { L"TYPEATTR.idldescType", FIELD_OFFSET(::TYPEATTR, idldescType) },\
    { L"TYPEATTR.idldescType.dwReserved", FIELD_OFFSET(::TYPEATTR, idldescType.dwReserved) },\
    { L"TYPEATTR.idldescType.wIDLFlags", FIELD_OFFSET(::TYPEATTR, idldescType.wIDLFlags) },\
    { L"TYPEDESC.lptdesc", FIELD_OFFSET(::TYPEDESC, lptdesc) },\
    { L"TYPEDESC.lpadesc", FIELD_OFFSET(::TYPEDESC, lpadesc) },\
    { L"TYPEDESC.hreftype", FIELD_OFFSET(::TYPEDESC, hreftype) },\
    { L"TYPEDESC.vt", FIELD_OFFSET(::TYPEDESC, vt) },\
    { L"VARDESC.memid", FIELD_OFFSET(::VARDESC, memid) },\
    { L"VARDESC.lpstrSchema", FIELD_OFFSET(::VARDESC, lpstrSchema) },\
    { L"VARDESC.oInst", FIELD_OFFSET(::VARDESC, oInst) },\
    { L"VARDESC.lpvarValue", FIELD_OFFSET(::VARDESC, lpvarValue) },\
    { L"VARDESC.elemdescVar", FIELD_OFFSET(::VARDESC, elemdescVar) },\
    { L"VARDESC.elemdescVar.tdesc", FIELD_OFFSET(::VARDESC, elemdescVar.tdesc) },\
    { L"VARDESC.elemdescVar.tdesc.lptdesc", FIELD_OFFSET(::VARDESC, elemdescVar.tdesc.lptdesc) },\
    { L"VARDESC.elemdescVar.tdesc.lpadesc", FIELD_OFFSET(::VARDESC, elemdescVar.tdesc.lpadesc) },\
    { L"VARDESC.elemdescVar.tdesc.hreftype", FIELD_OFFSET(::VARDESC, elemdescVar.tdesc.hreftype) },\
    { L"VARDESC.elemdescVar.tdesc.vt", FIELD_OFFSET(::VARDESC, elemdescVar.tdesc.vt) },\
    { L"VARDESC.elemdescVar.paramdesc", FIELD_OFFSET(::VARDESC, elemdescVar.paramdesc) },\
    { L"VARDESC.elemdescVar.paramdesc.pparamdescex", FIELD_OFFSET(::VARDESC, elemdescVar.paramdesc.pparamdescex) },\
    { L"VARDESC.elemdescVar.paramdesc.wParamFlags", FIELD_OFFSET(::VARDESC, elemdescVar.paramdesc.wParamFlags) },\
    { L"VARDESC.wVarFlags", FIELD_OFFSET(::VARDESC, wVarFlags) },\
    { L"VARDESC.varkind", FIELD_OFFSET(::VARDESC, varkind) },\
    { L"VARIANT.vt", FIELD_OFFSET(::VARIANT, vt) },\
    { L"VARIANT.wReserved1", FIELD_OFFSET(::VARIANT, wReserved1) },\
    { L"VARIANT.wReserved2", FIELD_OFFSET(::VARIANT, wReserved2) },\
    { L"VARIANT.wReserved3", FIELD_OFFSET(::VARIANT, wReserved3) },\
    { L"VARIANT.llVal", FIELD_OFFSET(::VARIANT, llVal) },\
    { L"VARIANT.lVal", FIELD_OFFSET(::VARIANT, lVal) },\
    { L"VARIANT.bVal", FIELD_OFFSET(::VARIANT, bVal) },\
    { L"VARIANT.iVal", FIELD_OFFSET(::VARIANT, iVal) },\
    { L"VARIANT.fltVal", FIELD_OFFSET(::VARIANT, fltVal) },\
    { L"VARIANT.dblVal", FIELD_OFFSET(::VARIANT, dblVal) },\
    { L"VARIANT.boolVal", FIELD_OFFSET(::VARIANT, boolVal) },\
    { L"VARIANT.scode", FIELD_OFFSET(::VARIANT, scode) },\
    { L"VARIANT.cyVal", FIELD_OFFSET(::VARIANT, cyVal) },\
    { L"VARIANT.date", FIELD_OFFSET(::VARIANT, date) },\
    { L"VARIANT.bstrVal", FIELD_OFFSET(::VARIANT, bstrVal) },\
    { L"VARIANT.punkVal", FIELD_OFFSET(::VARIANT, punkVal) },\
    { L"VARIANT.pdispVal", FIELD_OFFSET(::VARIANT, pdispVal) },\
    { L"VARIANT.parray", FIELD_OFFSET(::VARIANT, parray) },\
    { L"VARIANT.pbVal", FIELD_OFFSET(::VARIANT, pbVal) },\
    { L"VARIANT.piVal", FIELD_OFFSET(::VARIANT, piVal) },\
    { L"VARIANT.plVal", FIELD_OFFSET(::VARIANT, plVal) },\
    { L"VARIANT.pllVal", FIELD_OFFSET(::VARIANT, pllVal) },\
    { L"VARIANT.pfltVal", FIELD_OFFSET(::VARIANT, pfltVal) },\
    { L"VARIANT.pdblVal", FIELD_OFFSET(::VARIANT, pdblVal) },\
    { L"VARIANT.pboolVal", FIELD_OFFSET(::VARIANT, pboolVal) },\
    { L"VARIANT.pscode", FIELD_OFFSET(::VARIANT, pscode) },\
    { L"VARIANT.pcyVal", FIELD_OFFSET(::VARIANT, pcyVal) },\
    { L"VARIANT.pdate", FIELD_OFFSET(::VARIANT, pdate) },\
    { L"VARIANT.pbstrVal", FIELD_OFFSET(::VARIANT, pbstrVal) },\
    { L"VARIANT.ppunkVal", FIELD_OFFSET(::VARIANT, ppunkVal) },\
    { L"VARIANT.ppdispVal", FIELD_OFFSET(::VARIANT, ppdispVal) },\
    { L"VARIANT.pparray", FIELD_OFFSET(::VARIANT, pparray) },\
    { L"VARIANT.pvarVal", FIELD_OFFSET(::VARIANT, pvarVal) },\
    { L"VARIANT.byref", FIELD_OFFSET(::VARIANT, byref) },\
    { L"VARIANT.cVal", FIELD_OFFSET(::VARIANT, cVal) },\
    { L"VARIANT.uiVal", FIELD_OFFSET(::VARIANT, uiVal) },\
    { L"VARIANT.ulVal", FIELD_OFFSET(::VARIANT, ulVal) },\
    { L"VARIANT.ullVal", FIELD_OFFSET(::VARIANT, ullVal) },\
    { L"VARIANT.intVal", FIELD_OFFSET(::VARIANT, intVal) },\
    { L"VARIANT.uintVal", FIELD_OFFSET(::VARIANT, uintVal) },\
    { L"VARIANT.pdecVal", FIELD_OFFSET(::VARIANT, pdecVal) },\
    { L"VARIANT.pcVal", FIELD_OFFSET(::VARIANT, pcVal) },\
    { L"VARIANT.puiVal", FIELD_OFFSET(::VARIANT, puiVal) },\
    { L"VARIANT.pulVal", FIELD_OFFSET(::VARIANT, pulVal) },\
    { L"VARIANT.pullVal", FIELD_OFFSET(::VARIANT, pullVal) },\
    { L"VARIANT.pintVal", FIELD_OFFSET(::VARIANT, pintVal) },\
    { L"VARIANT.puintVal", FIELD_OFFSET(::VARIANT, puintVal) },\
    { L"VARIANT.pvRecord", FIELD_OFFSET(::VARIANT, pvRecord) },\
    { L"VARIANT.pRecInfo", FIELD_OFFSET(::VARIANT, pRecInfo) },\
    { L"VARIANT.decVal", FIELD_OFFSET(::VARIANT, decVal) },\
    { L"VERSIONEDSTREAM.guidVersion", FIELD_OFFSET(::VERSIONEDSTREAM, guidVersion) },\
    { L"VERSIONEDSTREAM.pStream", FIELD_OFFSET(::VERSIONEDSTREAM, pStream) },\
    { L"WAVEFORMATEX.wFormatTag", FIELD_OFFSET(::WAVEFORMATEX, wFormatTag) },\
    { L"WAVEFORMATEX.nChannels", FIELD_OFFSET(::WAVEFORMATEX, nChannels) },\
    { L"WAVEFORMATEX.nSamplesPerSec", FIELD_OFFSET(::WAVEFORMATEX, nSamplesPerSec) },\
    { L"WAVEFORMATEX.nAvgBytesPerSec", FIELD_OFFSET(::WAVEFORMATEX, nAvgBytesPerSec) },\
    { L"WAVEFORMATEX.nBlockAlign", FIELD_OFFSET(::WAVEFORMATEX, nBlockAlign) },\
    { L"WAVEFORMATEX.wBitsPerSample", FIELD_OFFSET(::WAVEFORMATEX, wBitsPerSample) },\
    { L"WAVEFORMATEX.cbSize", FIELD_OFFSET(::WAVEFORMATEX, cbSize) },\
    { L"LOGFONTW.lfHeight", FIELD_OFFSET(::LOGFONTW, lfHeight) },\
    { L"LOGFONTW.lfWidth", FIELD_OFFSET(::LOGFONTW, lfWidth) },\
    { L"LOGFONTW.lfEscapement", FIELD_OFFSET(::LOGFONTW, lfEscapement) },\
    { L"LOGFONTW.lfOrientation", FIELD_OFFSET(::LOGFONTW, lfOrientation) },\
    { L"LOGFONTW.lfWeight", FIELD_OFFSET(::LOGFONTW, lfWeight) },\
    { L"LOGFONTW.lfItalic", FIELD_OFFSET(::LOGFONTW, lfItalic) },\
    { L"LOGFONTW.lfUnderline", FIELD_OFFSET(::LOGFONTW, lfUnderline) },\
    { L"LOGFONTW.lfStrikeOut", FIELD_OFFSET(::LOGFONTW, lfStrikeOut) },\
    { L"LOGFONTW.lfCharSet", FIELD_OFFSET(::LOGFONTW, lfCharSet) },\
    { L"LOGFONTW.lfOutPrecision", FIELD_OFFSET(::LOGFONTW, lfOutPrecision) },\
    { L"LOGFONTW.lfClipPrecision", FIELD_OFFSET(::LOGFONTW, lfClipPrecision) },\
    { L"LOGFONTW.lfQuality", FIELD_OFFSET(::LOGFONTW, lfQuality) },\
    { L"LOGFONTW.lfPitchAndFamily", FIELD_OFFSET(::LOGFONTW, lfPitchAndFamily) },\
    { L"LOGFONTW.lfFaceName", FIELD_OFFSET(::LOGFONTW, lfFaceName) },\
    { L"MSG.hwnd", FIELD_OFFSET(::MSG, hwnd) },\
    { L"MSG.message", FIELD_OFFSET(::MSG, message) },\
    { L"MSG.wParam", FIELD_OFFSET(::MSG, wParam) },\
    { L"MSG.lParam", FIELD_OFFSET(::MSG, lParam) },\
    { L"MSG.time", FIELD_OFFSET(::MSG, time) },\
    { L"MSG.pt", FIELD_OFFSET(::MSG, pt) },\
    { L"MSG.pt.x", FIELD_OFFSET(::MSG, pt.x) },\
    { L"MSG.pt.y", FIELD_OFFSET(::MSG, pt.y) },\
    { L"PAINTSTRUCT.hdc", FIELD_OFFSET(::PAINTSTRUCT, hdc) },\
    { L"PAINTSTRUCT.fErase", FIELD_OFFSET(::PAINTSTRUCT, fErase) },\
    { L"PAINTSTRUCT.rcPaint", FIELD_OFFSET(::PAINTSTRUCT, rcPaint) },\
    { L"PAINTSTRUCT.rcPaint.left", FIELD_OFFSET(::PAINTSTRUCT, rcPaint.left) },\
    { L"PAINTSTRUCT.rcPaint.top", FIELD_OFFSET(::PAINTSTRUCT, rcPaint.top) },\
    { L"PAINTSTRUCT.rcPaint.right", FIELD_OFFSET(::PAINTSTRUCT, rcPaint.right) },\
    { L"PAINTSTRUCT.rcPaint.bottom", FIELD_OFFSET(::PAINTSTRUCT, rcPaint.bottom) },\
    { L"PAINTSTRUCT.fRestore", FIELD_OFFSET(::PAINTSTRUCT, fRestore) },\
    { L"PAINTSTRUCT.fIncUpdate", FIELD_OFFSET(::PAINTSTRUCT, fIncUpdate) },\
    { L"PAINTSTRUCT.rgbReserved", FIELD_OFFSET(::PAINTSTRUCT, rgbReserved) },\
    { L"WNDCLASSEX.cbSize", FIELD_OFFSET(::WNDCLASSEX, cbSize) },\
    { L"WNDCLASSEX.style", FIELD_OFFSET(::WNDCLASSEX, style) },\
    { L"WNDCLASSEX.lpfnWndProc", FIELD_OFFSET(::WNDCLASSEX, lpfnWndProc) },\
    { L"WNDCLASSEX.cbClsExtra", FIELD_OFFSET(::WNDCLASSEX, cbClsExtra) },\
    { L"WNDCLASSEX.cbWndExtra", FIELD_OFFSET(::WNDCLASSEX, cbWndExtra) },\
    { L"WNDCLASSEX.hInstance", FIELD_OFFSET(::WNDCLASSEX, hInstance) },\
    { L"WNDCLASSEX.hIcon", FIELD_OFFSET(::WNDCLASSEX, hIcon) },\
    { L"WNDCLASSEX.hCursor", FIELD_OFFSET(::WNDCLASSEX, hCursor) },\
    { L"WNDCLASSEX.hbrBackground", FIELD_OFFSET(::WNDCLASSEX, hbrBackground) },\
    { L"WNDCLASSEX.lpszMenuName", FIELD_OFFSET(::WNDCLASSEX, lpszMenuName) },\
    { L"WNDCLASSEX.lpszClassName", FIELD_OFFSET(::WNDCLASSEX, lpszClassName) },\
    { L"WNDCLASSEX.hIconSm", FIELD_OFFSET(::WNDCLASSEX, hIconSm) },\
    { NULL, 0 }\
}\

#define ENUM_SIZES \
{\
    { L"CALLCONV", sizeof(::CALLCONV) },\
    { L"DESCKIND", sizeof(::DESCKIND) },\
    { L"FUNCKIND", sizeof(::FUNCKIND) },\
    { L"INVOKEKIND", sizeof(::INVOKEKIND) },\
    { L"SYSKIND", sizeof(::SYSKIND) },\
    { L"TYPEKIND", sizeof(::TYPEKIND) },\
    { L"VARKIND", sizeof(::VARKIND) },\
    { L"CLSCTX", sizeof(::CLSCTX) },\
    { NULL, 0 }\
}\

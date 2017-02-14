using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace idl2cs.TypeLib
{
    public unsafe class LibDesc : IDisposable
    {
        private ITypeLib2 typeLib;
        private List<object> comObjects = new List<object>();
        private List<ITypeInfo2> referencedTypes = new List<ITypeInfo2>();

        public unsafe string Name
        {
            get
            {
                char* name = null;
                char* docString = null;
                char* helpFile = null;
                try
                {
                    uint helpContext;
                    typeLib.GetDocumentation(-1, out name, out docString, out helpContext, out helpFile);
                    return new string(name);
                }
                finally
                {
                    if (name != null)
                        NativeMethods.SysFreeString(name);
                    if (docString != null)
                        NativeMethods.SysFreeString(docString);
                    if (helpFile != null)
                        NativeMethods.SysFreeString(helpFile);
                }
            }
        }

        public IEnumerable<TypeDesc> Types
        {
            get
            {
                uint count = typeLib.GetTypeInfoCount();
                for (uint i = 0; i < count; i++)
                {
                    ITypeInfo typeInfo;
                    typeLib.GetTypeInfo(i, out typeInfo);
                    comObjects.Add(typeInfo);

                    yield return new TypeDesc((ITypeInfo2)typeInfo, GetReferencedType, GetReferencedTypeInfo);
                }
            }
        }

        //public IEnumerable<TypeDesc> ReferencedTypes
        //{
        //    get
        //    {
        //        var types = Types.Select(x => x.Name).ToArray();
        //        var allReferencedTypes = referencedTypes.Select(x => new TypeDesc(x, GetReferencedType, GetReferencedTypeInfo, customTypeMapping));

        //        var allReferencedTypeNames = allReferencedTypes.Where(x => !types.Contains(x.Name)).Select(x => x.Name);

        //        return allReferencedTypeNames.Select(x => allReferencedTypes.First(y => y.Name == x));
        //    }
        //}

        public LibDesc(string file)
        {
            ITypeLib typeLib;
            NativeMethods.LoadTypeLib(file, out typeLib);
            comObjects.Add(typeLib);

            this.typeLib = (ITypeLib2)typeLib;
        }

        private TypeDesc GetReferencedType(ITypeInfo2 typeInfo, uint reference)
        {
            return new TypeDesc(GetReferencedTypeInfo(typeInfo, reference), GetReferencedType, GetReferencedTypeInfo);
        }

        private ITypeInfo2 GetReferencedTypeInfo(ITypeInfo2 typeInfo, uint reference)
        {
            ITypeInfo refTypeInfo;
            typeInfo.GetRefTypeInfo(reference, out refTypeInfo);
            comObjects.Add(refTypeInfo);
            ITypeInfo2 result = (ITypeInfo2)refTypeInfo;
            referencedTypes.Add(result);
            return result;
        }

        public void Dispose()
        {
            for (int i = (comObjects.Count - 1); i >= 0; i--)
                Marshal.ReleaseComObject(comObjects[i]);
            comObjects.Clear();
        }
    }
}

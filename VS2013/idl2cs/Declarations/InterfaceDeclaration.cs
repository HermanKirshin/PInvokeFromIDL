using idl2cs.TypeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idl2cs.Declarations
{
    public class InterfaceDeclaration : BaseTypeDeclaration
    {
        private readonly bool isIUnknown;
        private readonly bool isUserImplemented;
        private readonly bool ignoreIdentifier;

        protected override string DeclarationType
        {
            get
            {
                return "unsafe interface";
            }
        }

        protected override IEnumerable<string> Attributes
        {
            get
            {
                if (!ignoreIdentifier)
                {
                    yield return "[ComImport]";
                    yield return "[Guid(\"" + Type.CLSID + "\")]";
                }
                if (isIUnknown)
                    yield return "[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]";
            }
        }

        public override string TypeName
        {
            get
            {
                return GetInterfaceName(Type);
            }
        }

        protected override IEnumerable<string> BaseTypes
        {
            get
            {
                return Type.DirectBaseTypes.Where(x => !IsSpecialInterface(x)).Select(GetInterfaceName);
            }
        }

        public InterfaceDeclaration(TypeDesc type, TextBlock container, AccessModifierType accessModifier)
            : base(type, container, accessModifier)
        {
            isIUnknown = type.BaseTypes.Any(x => x.Name == "IUnknown");
            isUserImplemented = IsUserImplemented(type);
            ignoreIdentifier = IsWithoutIdentifier(type);

            var methods = type.AllMethods.Select(x => new MethodDeclaration(x, this, AccessModifierType.Empty, IsInherited(x, type))).ToArray();

            WriteBaseLine(() => "{");
            for (int i = 0; i < methods.Length; i++)
            {
                AddTextBlock(methods[i]);
                if (i != (methods.Length - 1))
                    WriteLine();
            }
            WriteBaseLine(() => "}");
        }

        public static string GetInterfaceName(TypeDesc type)
        {
            if (IsUserImplemented(type))
                return type.Name;
            else
                return "_" + type.Name.TrimStart('@');
        }

        public static bool IsUserImplemented(TypeDesc type)
        {
            return type.BaseTypes.Any(x => x.Name == "__UserImplemented");
        }

        public static bool IsWithoutIdentifier(TypeDesc type)
        {
            return type.BaseTypes.Any(x => x.Name == "__IgnoreIdentifier");
        }

        public static bool IsDelegate(TypeDesc type)
        {
            return type.BaseTypes.Any(x => x.Name == "__Delegate");
        }

        public static bool IsSpecialInterface(TypeDesc type)
        {
            return (type.Name == "__UserImplemented") || (type.Name == "__IgnoreIdentifier") || (type.Name == "__Delegate") || IsDelegate(type);
        }

        private static bool IsInherited(MethodDesc method, TypeDesc type)
        {
            string[] array1 = new string[] { method.Name, method.ReturnValue.TypeDeclaration }.Union(method.Parameters.Select(x => x.TypeDeclaration)).ToArray();

            foreach (MethodDesc currentMethod in type.Methods)
            {
                string[] array2 = new string[] { currentMethod.Name, currentMethod.ReturnValue.TypeDeclaration }.Union(currentMethod.Parameters.Select(x => x.TypeDeclaration)).ToArray();

                if (array1.SequenceEqual(array2))
                    return false;
            }
            return true;
        }
    }
}

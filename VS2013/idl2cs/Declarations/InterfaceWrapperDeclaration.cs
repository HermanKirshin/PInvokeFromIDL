using idl2cs.TypeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idl2cs.Declarations
{
    public class InterfaceWrapperDeclaration : BaseTypeDeclaration
    {
        private readonly bool isIUnknown;
        private readonly bool isUserImplemented;
        private readonly bool ignoreIdentifier;

        protected override string DeclarationType
        {
            get
            {
                return "unsafe struct";
            }
        }

        protected override IEnumerable<string> Attributes
        {
            get
            {
                //yield return "[Serializable]";
                yield return "[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]";
            }
        }

        public override string TypeName
        {
            get
            {
                return Type.Name;
            }
        }

        protected override IEnumerable<string> BaseTypes
        {
            get
            {
                List<string> result = Type.DirectBaseTypes.Where(x => !InterfaceDeclaration.IsSpecialInterface(x)).Select(InterfaceDeclaration.GetInterfaceName).ToList();
                result.Insert(0, InterfaceDeclaration.GetInterfaceName(Type));
                if (isIUnknown)
                    result.Add("IDisposable");
                return result;
            }
        }

        private class DelegateCaller : TextBlock
        {
            public DelegateCaller(int index, MethodDesc method, InterfaceWrapperDeclaration container)
                : base(container, 0)
            {
                string delegateName = container.GetDelegateName(index);
                string vtblMethodName = container.GetMethodName(index);

                string returnDecl = MethodDeclaration.GetReturnValue(method);
                IEnumerable<string> argumentNames = MethodDeclaration.GetParameterNames(method);

                WriteLine(() => "{");
                WriteLine(() => "    " + container.vtbl.TypeName + "** @this = (" + container.vtbl.TypeName + "**)reference;");
                WriteLine(() => "    " + container.vtbl.TypeName + "* vtbl = *@this;");
                WriteLine(() => "    if (vtbl == null)");
                WriteLine(() => "        throw new InvalidComObjectException();");
                WriteLine(() => "    Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(vtbl->" + vtblMethodName + ", typeof(" + delegateName + "));");
                WriteLine(() => "    " + delegateName + " method = (" + delegateName + ")genericDelegate;");
                WriteLine(() => "    " + ((returnDecl == "void") ? "" : "return ") + "method(" + string.Join(", ", new string[] { "@this" }.Union(argumentNames)) + ");");
                WriteLine(() => "}");
            }
        }

        private InterfaceVtblDeclaration vtbl;

        public InterfaceWrapperDeclaration(TypeDesc type, TextBlock container, AccessModifierType accessModifier)
            : base(type, container, accessModifier)
        {
            isIUnknown = type.BaseTypes.Any(x => x.Name == "IUnknown");
            isUserImplemented = InterfaceDeclaration.IsUserImplemented(type);
            ignoreIdentifier = InterfaceDeclaration.IsWithoutIdentifier(type);

            var methods = type.AllMethods.ToArray();

            vtbl = new InterfaceVtblDeclaration(type, this);

            WriteBaseLine(() => "{");
            AddTextBlock(vtbl);
            WriteLine();

            for(int i = 0; i < methods.Length; i++)
            {
                int index = i;
                MethodDesc method = type.AllMethods.ToArray()[i];
                string parameters = vtbl.TypeName + "** @this";
                if (MethodDeclaration.GetParameterNames(method).Any())
                    parameters += ", " + MethodDeclaration.GetParameters(method);
                WriteLine(() => "private unsafe delegate " + MethodDeclaration.GetReturnValue(method) + " " + GetDelegateName(index) + "(" + parameters + ");");
            }
            WriteLine();

            WriteLine(() => "private readonly void* reference;");
            if (!ignoreIdentifier)
            {
                WriteLine(() => "private static readonly Guid iid = new Guid(\"" + type.CLSID.ToString() + "\");");
                WriteLine();
                WriteLine(() => AccessModifier + " static unsafe Guid IID");
                WriteLine(() => "{");
                WriteLine(() => "    get");
                WriteLine(() => "    {");
                WriteLine(() => "        return iid;");
                WriteLine(() => "    }");
                WriteLine(() => "}");
            }

            for (int i = 0; i < methods.Length; i++)
            {
                WriteLine();
                bool isNew = ((methods[i].Name == "GetType" || methods[i].Name == "ToString") && !methods[i].Parameters.Any());
                AddTextBlock(new MethodDeclaration(methods[i], this, AccessModifierType.Public, isNew, new DelegateCaller(i, methods[i], this)));
            }

            if (isIUnknown)
            {
                WriteLine();
                WriteLine(() => "void IDisposable.Dispose()");
                WriteLine(() => "{");
                WriteLine(() => "    while ((reference != null) && (Release() > 0))");
                WriteLine(() => "    {");
                WriteLine(() => "    }");
                WriteLine(() => "}");
            }

            WriteLine();
            WriteLine(() => AccessModifier + " unsafe " + TypeName + "(IntPtr value)");
            WriteLine(() => "{");
            WriteLine(() => "    reference = (void*)value;");
            WriteLine(() => "}");
            WriteLine();
            WriteLine(() => AccessModifier + " unsafe " + TypeName + "(void* value)");
            WriteLine(() => "{");
            WriteLine(() => "    reference = value;");
            WriteLine(() => "}");
            foreach (string baseTypeRefName in type.BaseTypes.Where(x => !InterfaceDeclaration.IsSpecialInterface(x)).Select(x => x.Name))
            {
                WriteLine();
                WriteLine(() => "public static unsafe explicit operator " + TypeName + "(" + baseTypeRefName + " value)");
                WriteLine(() => "{");
                WriteLine(() => "    return new " + TypeName + "(*((void**)(&value)));");
                WriteLine(() => "}");
                WriteLine();
                WriteLine(() => "public static unsafe implicit operator " + baseTypeRefName + "(" + TypeName + " value)");
                WriteLine(() => "{");
                WriteLine(() => "    return new " + baseTypeRefName + "(value.reference);");
                WriteLine(() => "}");
            }

            WriteLine();
            WriteLine(() => "public static unsafe implicit operator IntPtr(" + TypeName + " value)");
            WriteLine(() => "{");
            WriteLine(() => "    return new IntPtr(value.reference);");
            WriteLine(() => "}");
            WriteLine();
            WriteLine(() => "public static unsafe implicit operator void*(" + TypeName + " value)");
            WriteLine(() => "{");
            WriteLine(() => "    return value.reference;");
            WriteLine(() => "}");
            WriteLine();
            WriteLine(() => "public static unsafe implicit operator " + TypeName + "(IntPtr value)");
            WriteLine(() => "{");
            WriteLine(() => "    return new " + TypeName + "(value);");
            WriteLine(() => "}");
            WriteLine();
            WriteLine(() => "public static unsafe implicit operator " + TypeName + "(void* value)");
            WriteLine(() => "{");
            WriteLine(() => "    return new " + TypeName + "(value);");
            WriteLine(() => "}");

            WriteLine();
            WriteLine(() => "public unsafe override bool Equals(object obj)");
            WriteLine(() => "{");
            WriteLine(() => "    " + TypeName + " other = (" + TypeName + ")obj;");
            WriteLine(() => "    return reference == other.reference;");
            WriteLine(() => "}");
            WriteLine();
            WriteLine(() => "public unsafe override int GetHashCode()");
            WriteLine(() => "{");
            WriteLine(() => "    return new IntPtr(reference).GetHashCode();");
            WriteLine(() => "}");
            WriteLine();
            WriteLine(() => "public unsafe static bool operator ==(" + TypeName + " left, " + TypeName + " right)");
            WriteLine(() => "{");
            WriteLine(() => "    return left.reference == right.reference;");
            WriteLine(() => "}");
            WriteLine();
            WriteLine(() => "public unsafe static bool operator !=(" + TypeName + " left, " + TypeName + " right)");
            WriteLine(() => "{");
            WriteLine(() => "    return left.reference != right.reference;");
            WriteLine(() => "}");

            WriteBaseLine(() => "}");
        }

        public string GetDelegateName(int index)
        {
            return "delegate_" + index.ToString();
        }

        public string GetMethodName(int index)
        {
            return "method_" + index.ToString();
        }
    }
}

using idl2cs.TypeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idl2cs.Declarations
{
    public class MethodDeclaration : TextBlock
    {
        public MethodDeclaration(MethodDesc method, BaseTypeDeclaration container, AccessModifierType accessModifier, bool isNew = false, TextBlock code = null, string nameOverride = null)
            : base(container, 0)
        {
            string additionalModifier = (accessModifier == AccessModifierType.Empty ? "" : " ") + ((method.Dll != null) ? "static extern " : "") + "unsafe " + (isNew ? "new " : "");

            if (code == null)
            {
                if (method.Dll != null)
                    WriteLine(() => "[DllImport(\"" + method.Dll + "\", EntryPoint = \"" + method.EntryPoint + "\", CallingConvention = CallingConvention." + method.Convention.ToString() + ", CharSet = CharSet.Unicode, SetLastError = true)]");
                else
                    WriteLine(() => "[PreserveSig]");
            }

            WriteLine(() => accessModifier + additionalModifier + GetReturnValue(method) + " " + ((nameOverride == null) ? method.Name : nameOverride) + "(" + GetParameters(method) + ")" + ((code == null) ? ";" : ""));
            if (code != null)
                AddTextBlock(code);
        }
        
        public static string GetParameters(MethodDesc method)
        {
            return string.Join(", ", method.Parameters.Select(x => GetParameterTypeDeclaration(x) + " " + x.Name + (x.HasValue ? (" = " + GetValueInitializer(x)) : "")));
        }

        private static string GetParameterTypeDeclaration(ParameterDesc parameter)
        {
            return parameter.TypeDeclaration + (parameter.ArraySizes.Any() ? "*" : "");
        }

        public static IEnumerable<string> GetParameterNames(MethodDesc method)
        {
            return method.Parameters.Select(x => x.Name);
        }

        public static string GetReturnValue(MethodDesc method)
        {
            return GetParameterTypeDeclaration(method.ReturnValue);
        }

        public static string GetValueInitializer(ParameterDesc parameter)
        {
            string result;
            if (parameter.Value == null || parameter.Value.ToString() == "0")
                result = "null";
            else
                result = parameter.Value.ToString();

            if (result == "null")
            {
                if (((parameter.Type.Kind == TypeKind.Interface) && (parameter.IndirectionLevel == 1)) || (parameter.IndirectionLevel == 0))
                    result = "default(" + parameter.TypeDeclaration + ")";
            }
            else
                result = "(" + parameter.TypeDeclaration + ")" + result;

            return result;
        }
    }
}

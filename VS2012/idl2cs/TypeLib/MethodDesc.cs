using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace idl2cs.TypeLib
{
    public class MethodDesc
    {
        public readonly string Name;
        public readonly string Dll;
        public readonly string EntryPoint;
        public readonly ParameterDesc ReturnValue;
        public readonly IEnumerable<ParameterDesc> Parameters;
        public readonly CallingConvention Convention;

        public readonly int Offset;

        public unsafe MethodDesc(string name, string dll, string entryPoint, FUNCDESC funcdesc, string[] argumentNames, Func<uint, TypeDesc> typeFactory)
        {
            string tmpl = "___overloaded000";
            if ((name.Length > tmpl.Length) && (name.IndexOf("___overloaded") == (name.Length - tmpl.Length)))
                name = name.Substring(0, name.Length - tmpl.Length);

            Name = EscapMethodName(name);
            Dll = dll;
            EntryPoint = entryPoint;

            Offset = funcdesc.oVft;

            ReturnValue = new ParameterDesc(funcdesc.elemdescFunc, string.Empty, typeFactory, 0, false, null);
            List<ParameterDesc> parameters = new List<ParameterDesc>();
            for (int i = 0; i < funcdesc.cParams; i++)
                parameters.Add(new ParameterDesc(funcdesc.lprgelemdescParam[i], (i < argumentNames.Length) ? argumentNames[i] : "__arg" + i, typeFactory, 0, false, null));
            Parameters = parameters.AsReadOnly();

            //if (funcdesc.cParamsOpt != 0)
            //    throw new Exception("Variable number of optional parameters is not supported");
            //if (funcdesc.invkind != INVOKEKIND.INVOKE_FUNC)
            //    throw new Exception("Only functions are currently supported");
            if (funcdesc.cScodes >= 1)
                throw new Exception("Only one return value is supported");

            switch (funcdesc.callconv)
            {
                case System.Runtime.InteropServices.ComTypes.CALLCONV.CC_CDECL:
                    Convention = CallingConvention.Cdecl;
                    break;
                case System.Runtime.InteropServices.ComTypes.CALLCONV.CC_STDCALL:
                    Convention = CallingConvention.StdCall;
                    break;
                default:
                    throw new Exception("Calling convention " + funcdesc.callconv + " is not supported");
            }

            switch (funcdesc.funckind)
            {
                case FUNCKIND.FUNC_DISPATCH:
                case FUNCKIND.FUNC_VIRTUAL:
                case FUNCKIND.FUNC_PUREVIRTUAL:
                case FUNCKIND.FUNC_NONVIRTUAL:
                case FUNCKIND.FUNC_STATIC:
                    break;
                default:
                    throw new Exception("Function kind " + funcdesc.funckind + " is not supported");
            }
        }

        private static string EscapMethodName(string name)
        {
            switch (name)
            {
                case "abstract":
                case "as":
                case "base":
                case "break":
                case "case":
                case "catch":
                case "checked":
                case "class":
                case "const":
                case "continue":
                case "default":
                case "delegate":
                case "do":
                case "else":
                case "enum":
                case "event":
                case "explicit":
                case "extern":
                case "false":
                case "finally":
                case "fixed":
                case "for":
                case "foreach":
                case "goto":
                case "if":
                case "implicit":
                case "in":
                case "interface":
                case "internal":
                case "is":
                case "lock":
                case "namespace":
                case "new":
                case "null":
                case "operator":
                case "out":
                case "override":
                case "params":
                case "private":
                case "protected":
                case "public":
                case "readonly":
                case "ref":
                case "return":
                case "sealed":
                case "sizeof":
                case "stackalloc":
                case "static":
                case "struct":
                case "switch":
                case "this":
                case "throw":
                case "true":
                case "try":
                case "typeof":
                case "unchecked":
                case "unsafe":
                case "using":
                case "virtual":
                case "volatile":
                case "while":
                case "add":
                case "alias":
                case "ascending":
                case "async":
                case "await":
                case "descending":
                case "dynamic":
                case "from":
                case "get":
                case "global":
                case "group":
                case "into":
                case "join":
                case "let":
                case "orderby":
                case "partial":
                case "remove":
                case "select":
                case "set":
                case "value":
                case "var":
                case "where":
                case "yield ":

                case "bool":
                case "byte":
                case "char":
                case "decimal":
                case "double":
                case "float":
                case "int":
                case "long":
                case "ushort":
                case "ulong":
                case "uint":
                case "string":
                case "short":
                case "object":
                case "sbyte":
                case "void":
                    return "@" + name;
                default:
                    return name;
            }
        }
    }
}

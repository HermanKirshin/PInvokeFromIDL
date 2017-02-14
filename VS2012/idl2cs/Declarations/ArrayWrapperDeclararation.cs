using idl2cs.TypeLib;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idl2cs.Declarations
{
    public class ArrayWrapperDeclararation : BaseTypeDeclaration
    {
        private readonly IEnumerable<int> arraySizes;

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
                return "Array" + arraySizes.Count().ToString() + "D_" + Type.Name + "_" + string.Join("_", arraySizes);
            }
        }

        public ArrayWrapperDeclararation(ParameterDesc parameter, BaseTypeDeclaration container, AccessModifierType accessModifier)
            : base(parameter.Type, container, accessModifier)
        {
            this.arraySizes = parameter.ArraySizes;
            int totalLength = 1;

            int[] sizes = arraySizes.ToArray();

            List<string> lengthConstants = new List<string>();
            List<string> indexerParameters = new List<string>();

            for(int i = 0; i < sizes.Length; i++)
            {
                totalLength *= sizes[i];
                
                lengthConstants.Add("length" + i.ToString());
                indexerParameters.Add("index" + i.ToString());
            }

            List<string> parts = new List<string>();
            for (int i = 0; i < sizes.Length; i++)
            {
                List<string> multipliers = new List<string>();
                multipliers.Add(indexerParameters[i]);
                for (int j = i; j < (sizes.Length - 1); j++)
                    multipliers.Add(lengthConstants[j]);
                parts.Add(string.Join(" * ", multipliers));
            }

            string index = string.Join(" + ", parts);
            
            bool canBeFixedArray = IsPrimitiveType(parameter.Type.Name) && (parameter.IndirectionLevel == 0);

            WriteBaseLine(() => "{");

            for (int i = 0; i < sizes.Length; i++)
                AddTextBlock(new ConstDeclaration(new TypeDesc("int"), lengthConstants[i], this, AccessModifierType.Private, sizes[i]));
            WriteLine();

            if (!canBeFixedArray)
            {
                for (int i = 0; i < totalLength; i++)
                    AddTextBlock(new FieldDeclaration(parameter.Type, "data" + i.ToString(), this, AccessModifierType.Private));
            }
            else
                AddTextBlock(new FieldDeclaration(parameter.Type, "data", this, AccessModifierType.Private, totalLength));
          
            WriteLine();

            WriteLine(() => AccessModifier + " unsafe " + parameter.Type.Name + " this[" + string.Join(", ", indexerParameters.Select(x => "int " + x)) + "]");
            WriteLine(() => "{");
            WriteLine(() => "    get");
            WriteLine(() => "    {");
            WriteLine(() => "        fixed (" + parameter.Type.Name + "* pointer = " + (canBeFixedArray ? "data" : "&data0") + ")");
            WriteLine(() => "        {");
            WriteLine(() => "            return pointer[" + index + "];");
            WriteLine(() => "        }");
            WriteLine(() => "    }");
            WriteLine(() => "    set");
            WriteLine(() => "    {");
            WriteLine(() => "        fixed (" + parameter.Type.Name + "* pointer = " + (canBeFixedArray ? "data" : "&data0") + ")");
            WriteLine(() => "        {");
            WriteLine(() => "            pointer[" + index + "] = value;");
            WriteLine(() => "        }");
            WriteLine(() => "    }");
            WriteLine(() => "}");
            
            WriteLine();

            WriteLine(() => "public static unsafe implicit operator " + parameter.Type.Name + "[](" + TypeName + " value)");
            WriteLine(() => "{");
            WriteLine(() => "    " + parameter.Type.Name + "[] result = new " + parameter.Type.Name + "[" + totalLength + "];");
            WriteLine(() => "    " + parameter.Type.Name + "* pointer = " + (canBeFixedArray ? "value.data" : "&value.data0") + ";");
            WriteLine(() => "    {");
            WriteLine(() => "        for (int i = 0; i < " + totalLength + "; i++)");
            WriteLine(() => "            result[i] = pointer[i];");
            WriteLine(() => "    }");
            WriteLine(() => "    return result;");
            WriteLine(() => "}");
            WriteLine();
            WriteLine(() => "public static unsafe implicit operator " + TypeName + "(" + parameter.Type.Name + "[] value)");
            WriteLine(() => "{");
            WriteLine(() => "    if (value == null)");
            WriteLine(() => "       throw new ArgumentNullException(\"value\");");
            WriteLine(() => "    " + TypeName + " result = new " + TypeName + "();");
            WriteLine(() => "    " + parameter.Type.Name + "* pointer = " + (canBeFixedArray ? "result.data" : "&result.data0") + ";");
            WriteLine(() => "    for (int i = 0; i < ((value.Length < " + totalLength + ") ? value.Length : " + totalLength + "); i++)");
            WriteLine(() => "        pointer[i] = value[i];");
            WriteLine(() => "    return result;");
            WriteLine(() => "}");

            WriteBaseLine(() => "}");
        }

        private static bool IsPrimitiveType(string typeName)
        {
            switch (typeName)
            {
                case "bool":
                case "byte":
                case "short":
                case "int":
                case "long":
                case "char":
                case "sbyte":
                case "ushort":
                case "uint":
                case "ulong":
                case "float":
                case "double":
                    return true;
                default:
                    return false;
            }
        }
    }
}

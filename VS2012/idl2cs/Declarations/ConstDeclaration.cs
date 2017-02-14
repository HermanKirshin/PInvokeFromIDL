using idl2cs.TypeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idl2cs.Declarations
{
    public class ConstDeclaration : TextBlock
    {
        public ConstDeclaration(TypeDesc type, string name, BaseTypeDeclaration container, AccessModifierType accessModifier, object value)
            : base(container, 0)
        {
            WriteLine(() => accessModifier + " const " + type.Name + " " + name + " = " + GetValueInitializer(value) + ";");
        }

        public ConstDeclaration(ParameterDesc parameter, BaseTypeDeclaration container, AccessModifierType accessModifier)
            : base(container, 0)
        {
            WriteLine(() => accessModifier + " const " + ((parameter.Value is string) ? "string" : parameter.TypeDeclaration) + " " + parameter.Name + " = " + GetValueInitializer(parameter.Value) + ";");
        }

        public static string GetValueInitializer(object value)
        {
            if (value is string)
                return "@\"" + value.ToString().Replace("\"", "\"\"") + "\"";
            else
                return value.ToString() + (value is float ? "f" : "");
        }
    }
}

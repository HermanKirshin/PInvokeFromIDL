using idl2cs.TypeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idl2cs.Declarations
{
    public class FieldDeclaration : TextBlock
    {
        public FieldDeclaration(TypeDesc type, string name, BaseTypeDeclaration container, AccessModifierType accessModifier)
            : base(container, 0)
        {
            WriteLine(() => accessModifier + " " + type.Name + " " + name + ";");
        }

        public FieldDeclaration(TypeDesc type, string name, BaseTypeDeclaration container, AccessModifierType accessModifier, int arraySize)
            : base(container, 0)
        {
            WriteLine(() => accessModifier + " fixed " + type.Name + " " + name + "[" + arraySize + "];");
        }

        public FieldDeclaration(ParameterDesc parameter, BaseTypeDeclaration container, AccessModifierType accessModifier)
            : base(container, 0)
        {
            if (parameter.Hidden)
                accessModifier = AccessModifierType.Private;

            string fieldType;
            if (parameter.ArraySizes.Any())
                fieldType = new ArrayWrapperDeclararation(parameter, container, accessModifier).TypeName;
            else
                fieldType = parameter.TypeDeclaration;

            WriteLine(() => accessModifier + " " + fieldType + " " + parameter.Name + ";");
        }
    }
}

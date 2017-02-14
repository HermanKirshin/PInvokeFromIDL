using idl2cs.TypeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idl2cs.Declarations
{
    public class NativeMethodsDeclaration : BaseTypeDeclaration
    {
        protected override string DeclarationType
        {
            get 
            {
                return "unsafe static partial class";
            }
        }

        public override string TypeName
        {
            get
            {
                return "NativeMethods";
            }
        }

        public NativeMethodsDeclaration(IEnumerable<TypeDesc> types, TextBlock container, AccessModifierType accessModifier)
            : base(new TypeDesc("void"), container, accessModifier)
        {
            var methods = types.SelectMany(x => x.Methods).Where(x => x.Dll != null).OrderBy(x => x.Name).Select(x => new MethodDeclaration(x, this, AccessModifier)).ToArray();

            WriteBaseLine(() => "{");
            for (int i = 0; i < methods.Length; i++)
            {
                AddTextBlock(methods[i]);
                if (i != (methods.Length - 1))
                    WriteLine();
            }
            WriteBaseLine(() => "}");
        }
    }
}

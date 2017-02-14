using idl2cs.TypeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idl2cs.Declarations
{
    public class NativeConstantsDeclaration : BaseTypeDeclaration
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
                return "NativeConstants";
            }
        }

        public NativeConstantsDeclaration(IEnumerable<TypeDesc> types, TextBlock container, AccessModifierType accessModifier)
            : base(new TypeDesc("void"), container, accessModifier)
        {
            var constants = types.SelectMany(x => x.Fields).OrderBy(x => x.Name).Select(x => new ConstDeclaration(x, this, AccessModifier)).ToList();

            WriteBaseLine(() => "{");
            constants.ForEach(AddTextBlock);
            WriteBaseLine(() => "}");
        }
    }
}

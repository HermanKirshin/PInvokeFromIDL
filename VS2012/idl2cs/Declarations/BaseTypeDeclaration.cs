using idl2cs.TypeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idl2cs.Declarations
{
    public abstract class BaseTypeDeclaration : TextBlock
    {
        protected AccessModifierType AccessModifier
        {
            get;
            private set;
        }

        public virtual string TypeName
        {
            get
            {
                return Type.Name;
            }
        }

        protected TypeDesc Type
        {
            get;
            private set;
        }

        protected virtual IEnumerable<string> Attributes
        {
            get
            {
                return new string[0];
            }
        }

        protected virtual IEnumerable<string> BaseTypes
        {
            get
            {
                return Type.DirectBaseTypes.Select(x => x.Name);
            }
        }

        protected abstract string DeclarationType
        {
            get;
        }

        protected BaseTypeDeclaration(TypeDesc type, TextBlock container, AccessModifierType accessModifier)
            : base(container, 1)
        {
            Type = type;
            AccessModifier = accessModifier;

            foreach (string attribute in Attributes)
                WriteBaseLine(() => attribute);
            WriteBaseLine(() => AccessModifier + " " + DeclarationType + " " + TypeName + (BaseTypes.Any() ? " : " + string.Join(", ", BaseTypes) : string.Empty));
        }
    }
}

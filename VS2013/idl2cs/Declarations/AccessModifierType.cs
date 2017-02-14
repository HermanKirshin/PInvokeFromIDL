using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idl2cs.Declarations
{
    public sealed class AccessModifierType
    {
        public static readonly AccessModifierType Private = new AccessModifierType { Text = "private" };
        public static readonly AccessModifierType Public = new AccessModifierType { Text = "public" };
        public static readonly AccessModifierType Internal = new AccessModifierType { Text = "internal" };
        public static readonly AccessModifierType Empty = new AccessModifierType { Text = "" };

        public string Text
        {
            get;
            private set;
        }

        private AccessModifierType()
        {
        }

        public override string ToString()
        {
            return Text;
        }

        public override int GetHashCode()
        {
            return Text.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return (obj is AccessModifierType) && (Text == (obj as AccessModifierType).Text);
        }
    }
}

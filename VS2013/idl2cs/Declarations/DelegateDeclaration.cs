using idl2cs.TypeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idl2cs.Declarations
{
    public class DelegateDeclaration : BaseTypeDeclaration
    {
        private readonly MethodDesc method;
        private readonly string prefix = "";

        protected override string DeclarationType
        {
            get
            {
                return "unsafe delegate";
            }
        }

        protected override IEnumerable<string> BaseTypes
        {
            get
            {
                return new string[0];
            }
        }

        public override string TypeName
        {
            get
            {
                return MethodDeclaration.GetReturnValue(method) + " " + DelegateTypeName + "(" + MethodDeclaration.GetParameters(method) + ");";
            }
        }

        public DelegateDeclaration(MethodDesc method, TextBlock container, AccessModifierType accessModifier)
            : base(new TypeDesc("void"), container, accessModifier)
        {
            this.method = method;
        }

        public DelegateDeclaration(TypeDesc type, TextBlock container, AccessModifierType accessModifier)
            : base(new TypeDesc("void"), container, accessModifier)
        {
            this.method = type.Methods.Single(x => x.Name == type.Name);
            prefix = "_";
        }

        public string DelegateTypeName
        {
            get
            {
                return prefix + method.Name;
            }
        }
    }
}

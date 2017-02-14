using idl2cs.TypeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idl2cs.Declarations
{
    public class InterfaceVtblDeclaration : BaseTypeDeclaration
    {
        private readonly bool isIUnknown;
        private readonly bool isUserImplemented;
        private readonly bool ignoreIdentifier;

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
                return Type.Name.TrimStart('@') + "_vtbl";
            }
        }

        protected override IEnumerable<string> BaseTypes
        {
            get
            {
                return new string[0];
            }
        }

        public InterfaceVtblDeclaration(TypeDesc type, InterfaceWrapperDeclaration container)
            : base(type, container, AccessModifierType.Private)
        {
            isIUnknown = type.BaseTypes.Any(x => x.Name == "IUnknown");
            isUserImplemented = InterfaceDeclaration.IsUserImplemented(type);
            ignoreIdentifier = InterfaceDeclaration.IsWithoutIdentifier(type);

            var methods = type.AllMethods.OrderBy(x => x.Name).Select(x => new MethodDeclaration(x, this, AccessModifierType.Internal)).ToArray();

            WriteBaseLine(() => "{");
            for(int i = 0; i < methods.Length; i++)
                AddTextBlock(new FieldDeclaration(new TypeDesc("IntPtr"), container.GetMethodName(i), this, AccessModifierType.Internal));
            WriteBaseLine(() => "}");
        }
    }
}

using idl2cs.TypeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idl2cs.Declarations
{
    public class DelegateWrapperDeclaration : BaseTypeDeclaration
    {
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
                return Type.Name;
            }
        }

        protected override IEnumerable<string> BaseTypes
        {
            get
            {
                yield return "IDisposable";
            }
        }

        private class DelegateCaller : TextBlock
        {
            public DelegateCaller(MethodDesc method, DelegateWrapperDeclaration container)
                : base(container, 0)
            {
                DelegateDeclaration delegateDeclaration = new DelegateDeclaration(container.Type, container, container.AccessModifier);
                
                string returnDecl = MethodDeclaration.GetReturnValue(method);
                IEnumerable<string> argumentNames = MethodDeclaration.GetParameterNames(method);

                WriteLine(() => "{");
                WriteLine(() => "    if (reference == IntPtr.Zero)");
                WriteLine(() => "        throw new InvalidComObjectException();");
                WriteLine(() => "    Delegate genericDelegate = Marshal.GetDelegateForFunctionPointer(reference, typeof(" + delegateDeclaration.DelegateTypeName + "));");
                WriteLine(() => "    " + delegateDeclaration.DelegateTypeName + " method = (" + delegateDeclaration.DelegateTypeName + ")genericDelegate;");
                WriteLine(() => "    " + ((returnDecl == "void") ? "" : "return ") + "method(" + string.Join(", ", argumentNames) + ");");
                WriteLine(() => "}");
            }
        }

        public DelegateWrapperDeclaration(TypeDesc type, TextBlock container, AccessModifierType accessModifier)
            : base(type, container, accessModifier)
        {
            DelegateDeclaration delegateDeclaration = new DelegateDeclaration(type, container, accessModifier);
            
            WriteBaseLine(() => "{");
            WriteLine(() => "private static readonly ConcurrentDictionary<IntPtr, " + delegateDeclaration.DelegateTypeName + "> references = new ConcurrentDictionary<IntPtr, " + delegateDeclaration.DelegateTypeName + ">();");
            WriteLine();
            WriteLine(() => "private readonly IntPtr reference;");
            WriteLine();
            WriteLine(() => AccessModifier + " unsafe " + TypeName + "(" + delegateDeclaration.DelegateTypeName + " value)");
            WriteLine(() => "    : this()");
            WriteLine(() => "{");
            WriteLine(() => "    IntPtr reference = IntPtr.Zero;");
            WriteLine(() => "    if (value != null)");
            WriteLine(() => "    {");
            WriteLine(() => "        value = new " + delegateDeclaration.DelegateTypeName + "(value);");
            WriteLine(() => "        reference = Marshal.GetFunctionPointerForDelegate(value);");
            WriteLine(() => "        references.TryAdd(reference, value);");
            WriteLine(() => "    }");
            WriteLine(() => "    this.reference = reference;");
            WriteLine(() => "}");
            WriteLine();
            WriteLine(() => AccessModifier + " unsafe " + TypeName + "(IntPtr value)");
            WriteLine(() => "{");
            WriteLine(() => "    reference = value;");
            WriteLine(() => "}");
            WriteLine();
            WriteLine(() => AccessModifier + " unsafe " + TypeName + "(void* value)");
            WriteLine(() => "{");
            WriteLine(() => "    reference = new IntPtr(value);");
            WriteLine(() => "}");

            WriteLine();
            WriteLine(() => "public static unsafe implicit operator IntPtr(" + TypeName + " value)");
            WriteLine(() => "{");
            WriteLine(() => "    return value.reference;");
            WriteLine(() => "}");
            WriteLine();
            WriteLine(() => "public static unsafe implicit operator void*(" + TypeName + " value)");
            WriteLine(() => "{");
            WriteLine(() => "    return (void*)value.reference;");
            WriteLine(() => "}");
            WriteLine();
            WriteLine(() => "public static unsafe implicit operator " + TypeName + "(IntPtr value)");
            WriteLine(() => "{");
            WriteLine(() => "    return new " + TypeName + "(value);");
            WriteLine(() => "}");
            WriteLine();
            WriteLine(() => "public static unsafe implicit operator " + TypeName + "(void* value)");
            WriteLine(() => "{");
            WriteLine(() => "    return new " + TypeName + "(value);");
            WriteLine(() => "}");

            WriteLine();
            WriteLine(() => "public static unsafe implicit operator " + TypeName + "(" + delegateDeclaration.DelegateTypeName + " value)");
            WriteLine(() => "{");
            WriteLine(() => "    return new " + TypeName + "(value);");
            WriteLine(() => "}");
            WriteLine();
            WriteLine(() => "public static unsafe implicit operator " + delegateDeclaration.DelegateTypeName + "(" + TypeName + " value)");
            WriteLine(() => "{");
            WriteLine(() => "    IntPtr reference = value.reference;");
            WriteLine(() => "    return (reference == IntPtr.Zero) ? null : (" + delegateDeclaration.DelegateTypeName + ")Marshal.GetDelegateForFunctionPointer(reference, typeof(" + delegateDeclaration.DelegateTypeName + "));");
            WriteLine(() => "}");
            WriteLine();
            WriteLine(() => "public void Dispose()");
            WriteLine(() => "{");
            WriteLine(() => "    " + delegateDeclaration.DelegateTypeName + " removedReference;");
            WriteLine(() => "    references.TryRemove(reference, out removedReference);");
            WriteLine(() => "}");
            WriteLine();
            WriteLine(() => AccessModifier + " void RemoveAllReferences()");
            WriteLine(() => "{");
            WriteLine(() => "    references.Clear();");
            WriteLine(() => "}");
            
            WriteLine();
            WriteLine(() => "public unsafe override bool Equals(object obj)");
            WriteLine(() => "{");
            WriteLine(() => "    " + TypeName + " other = (" + TypeName + ")obj;");
            WriteLine(() => "    return reference == other.reference;");
            WriteLine(() => "}");
            WriteLine();
            WriteLine(() => "public unsafe override int GetHashCode()");
            WriteLine(() => "{");
            WriteLine(() => "    return reference.GetHashCode();");
            WriteLine(() => "}");
            WriteLine();
            WriteLine(() => "public unsafe static bool operator ==(" + TypeName + " left, " + TypeName + " right)");
            WriteLine(() => "{");
            WriteLine(() => "    return left.reference == right.reference;");
            WriteLine(() => "}");
            WriteLine();
            WriteLine(() => "public unsafe static bool operator !=(" + TypeName + " left, " + TypeName + " right)");
            WriteLine(() => "{");
            WriteLine(() => "    return left.reference != right.reference;");
            WriteLine(() => "}");

            WriteLine();
             
            MethodDesc method = type.AllMethods.Single();

            AddTextBlock(new MethodDeclaration(method, this, AccessModifier, false, new DelegateCaller(method, this), "Invoke"));

            WriteBaseLine(() => "}");
        }
    }
}

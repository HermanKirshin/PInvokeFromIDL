using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idl2cs.Declarations
{
    public abstract class TextBlock
    {
        private readonly int indent;

        private List<Func<string>> lines = new List<Func<string>>();

        protected TextBlock(int indent)
        {
            this.indent = indent;
        }

        protected TextBlock(TextBlock container, int indent)
        {
            this.indent = container.indent + indent;
        }

        protected void AddTextBlock(TextBlock textBlock)
        {
            //string text = "";
            //for (int i = 0; i < (textBlock.indent); i++)
            //    text += "    ";

            foreach (var line in textBlock.lines)
                lines.Add(() => line());
        }

        protected void WriteLine()
        {
            lines.Add(() => string.Empty);
        }

        protected void WriteBaseLine(Func<string> line)
        {
            string text = "";
            for (int i = 0; i < indent; i++)
                text += "    ";
            lines.Add(() => text + line());
        }

        protected void WriteLine(Func<string> line)
        {
            string text = "";
            for (int i = 0; i < (indent + 1); i++)
                text += "    ";
            lines.Add(() => text + line());
        }

        public string GetString()
        {
            return string.Join(Environment.NewLine, lines.Select(x => x()));
        }
    }
}

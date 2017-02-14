using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idl2cs
{
    internal sealed class CommandLineArguments
    {
        public readonly string DefinitionFile;
        public readonly string CodeFile;
        public readonly string ConfigurationFile;
        public readonly string LibraryFile;

        public CommandLineArguments(string[] args)
        {
            const string idlPrefix = "/idl:";
            const string tlbPrefix = "/tlb:";
            const string cfgPrefix = "/cfg:";
            const string csPrefix = "/cs:";

            DefinitionFile = (args.SingleOrDefault(x => x.ToUpperInvariant().StartsWith(idlPrefix.ToUpperInvariant())) ?? idlPrefix).Substring(idlPrefix.Length);
            LibraryFile = (args.SingleOrDefault(x => x.ToUpperInvariant().StartsWith(tlbPrefix.ToUpperInvariant())) ?? tlbPrefix).Substring(tlbPrefix.Length);
            ConfigurationFile = (args.SingleOrDefault(x => x.ToUpperInvariant().StartsWith(cfgPrefix.ToUpperInvariant())) ?? cfgPrefix).Substring(cfgPrefix.Length);
            CodeFile = (args.SingleOrDefault(x => x.ToUpperInvariant().StartsWith(csPrefix.ToUpperInvariant())) ?? csPrefix).Substring(csPrefix.Length);

            if (!(string.IsNullOrEmpty(LibraryFile) ^ string.IsNullOrEmpty(DefinitionFile)))
                throw new Exception("Either idl or tlb file should be specified");

            string baseFileName = Path.GetFileNameWithoutExtension(string.IsNullOrEmpty(LibraryFile) ? DefinitionFile : LibraryFile);
            string baseFolder = Path.GetDirectoryName(string.IsNullOrEmpty(LibraryFile) ? DefinitionFile : LibraryFile);

            if (string.IsNullOrEmpty(LibraryFile))
                LibraryFile = Path.Combine(Path.GetTempPath(), baseFileName + "_" + DateTime.Now.Ticks.ToString() + ".tlb");

            if (string.IsNullOrEmpty(CodeFile))
                CodeFile = Path.Combine(baseFolder, baseFileName + ".cs");
            if (string.IsNullOrEmpty(ConfigurationFile))
                ConfigurationFile = Path.Combine(baseFolder, baseFileName + ".cfg");
        }
    }
}

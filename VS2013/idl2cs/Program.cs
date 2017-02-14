using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;
using idl2cs.Declarations;

namespace idl2cs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;

            try
            {
                Console.WriteLine("idl2cs 3.1");

                if (args.Length == 0)
                {
                    Settings.CreateSampleConfiguration();
                    return;
                }

                CommandLineArguments arguments = new CommandLineArguments(args);
                Settings configuration = Settings.ParseEmbeddedSettings(arguments.DefinitionFile) ?? Settings.LoadConfiguration(arguments.ConfigurationFile);

                using (WorkingFolder workingFolder = new WorkingFolder())
                using (CompiledLibrary libraryFile = string.IsNullOrEmpty(arguments.DefinitionFile) ? null : new CompiledLibrary(workingFolder, arguments.DefinitionFile, arguments.LibraryFile))
                {
                    string code = CodeWriter.GenerateCode(arguments.LibraryFile, configuration);

                    if (!File.Exists(arguments.CodeFile) || (File.ReadAllText(arguments.CodeFile) != code))
                        File.WriteAllText(arguments.CodeFile, code);
                }
            }
            catch (Exception excepton)
            {
                Console.WriteLine(excepton.Message);
            }
        }
    }
}

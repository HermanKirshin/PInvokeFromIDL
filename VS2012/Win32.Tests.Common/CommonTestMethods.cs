using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.IO;
using System.Diagnostics;

namespace Win32.Tests.Common
{
    public interface INativeTests
    {
        Dictionary<string, int> GetStructureSizes();

        Dictionary<string, int> GetStructureOffsets();

        Dictionary<string, int> GetEnumerationSizes();
    }

    public static class CommonTestMethods
    {
        private static IEnumerable<Type> NativeStructures
        {
            get
            {
                return Assembly.GetAssembly(typeof(NativeMethods))
                    .GetTypes()
                    .Where(x => x.IsValueType && !x.GetInterfaces().Any() && x.IsPublic);            
            }
        }

        private static IEnumerable<Type> NativeEnumerations
        {
            get
            {
                return Assembly.GetAssembly(typeof(NativeMethods))
                    .GetTypes()
                    .Where(x => x.IsEnum);
            }
        }

        public static void RunAsProcess(Action<string> errorReportingAction)
        {
            using (Process process = Process.Start(new ProcessStartInfo
            {
                FileName = Assembly.GetCallingAssembly().Location,
                RedirectStandardOutput = true,
                UseShellExecute = false
            }))
            {
                if (!process.WaitForExit(300000))
                {
                    process.Kill();
                    errorReportingAction("Test process is not responding.");
                }
                if (process.ExitCode != 0)
                    errorReportingAction("Test process returned " + process.ExitCode.ToString(CultureInfo.InvariantCulture) + ".");

                string output = process.StandardOutput.ReadToEnd().Trim();
                if (!string.IsNullOrEmpty(output))
                    errorReportingAction(output);
            }
        }

        public static string Run(string nativeTestsAssembly, ProcessorArchitecture expectedArchitecture)
        {
            List<string> errors = new List<string>();

            int expectedIntPtrSize;
            switch (expectedArchitecture)
            {
                case ProcessorArchitecture.Amd64:
                    expectedIntPtrSize = 8;
                    break;
                case ProcessorArchitecture.X86:
                    expectedIntPtrSize = 4;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            if (IntPtr.Size != expectedIntPtrSize)
                errors.Add("Expected test process architecture is " + expectedArchitecture + ".");
            else
            {
                try
                {
                    string nativeAssemblyPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), nativeTestsAssembly);

                    Assembly assembly = Assembly.LoadFrom(nativeAssemblyPath);
                    Type implementation = assembly.GetType("Win32.Tests.Native.NativeTests");

                    INativeTests nativeTests = (INativeTests)Activator.CreateInstance(implementation);

                    TestDllImports(errors);
                    TestStructureSizes(errors, nativeTests.GetStructureSizes());
                    TestStructureFieldOffsets(errors, nativeTests.GetStructureOffsets());
                    TestEnumerationSizes(errors, nativeTests.GetEnumerationSizes());
                }
                catch (Exception exception)
                {
                    errors.Add(exception.ToString());
                }
            }

            return string.Join(Environment.NewLine, errors);
        }

        private unsafe static void TestDllImports(List<string> errors)
        {
            MethodInfo[] methods = typeof(NativeMethods).GetMethods(BindingFlags.Public | BindingFlags.Static);
            var attributes = methods.ToDictionary(x => x, x => x.GetCustomAttribute<DllImportAttribute>());

            Dictionary<string, IntPtr> libraries = new Dictionary<string, IntPtr>();

            foreach (var attribute in attributes)
            {
                if (!libraries.ContainsKey(attribute.Value.Value))
                {
                    fixed (char* library = attribute.Value.Value.ToArray())
                    {
                        IntPtr handle = NativeMethods.LoadLibrary(library);
                        if (handle == IntPtr.Zero)
                        {
                            errors.Add("Library " + attribute.Value.Value + " cannot be loaded.");
                            continue;
                        }
                        libraries[attribute.Value.Value] = handle;
                    }
                }

                fixed (byte* entryPoint = Encoding.ASCII.GetBytes(attribute.Value.EntryPoint))
                {
                    FARPROC address = NativeMethods.GetProcAddress(libraries[attribute.Value.Value], (sbyte*)entryPoint);
                    if (address == (void*)null)
                    {
                        errors.Add("Function " + attribute.Value.EntryPoint + " was not found in library " + attribute.Value.Value + ".");
                        continue;
                    }
                }
            }
        }

        private unsafe static void TestStructureSizes(List<string> errors, Dictionary<string, int> nativeData)
        {
            Dictionary<string, int> managedData = NativeStructures.ToDictionary(x => x.Name, x => Marshal.SizeOf(x));

            var difference = nativeData.Keys.Except(managedData.Keys);
            if (difference.Any())
            {
                errors.Add("Structure lists are different: " + string.Join(", ", difference) + ".");
                return;
            }

            foreach(string key in nativeData.Keys)
            {
                int nativeSize = nativeData[key];
                int managedSize = managedData[key];

                if (nativeSize != managedSize)
                    errors.Add("Structure " + key + " declarations are different. Expected size is " + nativeSize.ToString(CultureInfo.InvariantCulture) + " actual size is " + managedSize.ToString(CultureInfo.InvariantCulture) + ".");
            }
        }

        private unsafe static void TestEnumerationSizes(List<string> errors, Dictionary<string, int> nativeData)
        {
            Dictionary<string, int> managedData = NativeEnumerations.ToDictionary(x => x.Name, x => Marshal.SizeOf(Enum.GetUnderlyingType(x)));

            var difference = nativeData.Keys.Except(managedData.Keys);
            if (difference.Any())
            {
                errors.Add("Enumeration lists are different: " + string.Join(", ", difference) + ".");
                return;
            }

            foreach (string key in nativeData.Keys)
            {
                int nativeSize = nativeData[key];
                int managedSize = managedData[key];

                if (nativeSize != managedSize)
                    errors.Add("Enumeration " + key + " declarations are different. Expected size is " + nativeSize.ToString(CultureInfo.InvariantCulture) + " actual size is " + managedSize.ToString(CultureInfo.InvariantCulture) + ".");
            }
        }

        private unsafe static void TestStructureFieldOffsets(List<string> errors, Dictionary<string, int> nativeData)
        {
            IReadOnlyDictionary<string, int> managedData = GetManagedFieldOffsets();

            var difference = nativeData.Keys.Except(managedData.Keys);
            if (difference.Any())
            {
                errors.Add("Structure lists are different: " + string.Join(", ", difference) + ".");
                return;
            }

            foreach (string key in nativeData.Keys)
            {
                int nativeOffset = nativeData[key];
                int managedOffset = managedData[key];

                if (nativeOffset != managedOffset)
                    errors.Add("Structure " + key + " declarations are different. Expected offset of field " + key + " is " + nativeOffset.ToString(CultureInfo.InvariantCulture) + " actual offset is " + managedOffset.ToString(CultureInfo.InvariantCulture) + ".");
            }
        }

        internal static IReadOnlyCollection<string> GetManagedStructureNames()
        {
            return NativeStructures.Select(x => x.Name).ToList();
        }

        internal static IReadOnlyDictionary<string, int> GetManagedFieldOffsets()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (Type type in NativeStructures)
                GetManagedFieldOffsets(type, type.Name, 0, result);
            return result;
        }

        internal static IReadOnlyCollection<string> GetManagedEnumerationNames()
        {
            return NativeEnumerations.Select(x => x.Name).ToList();
        }

        private static void GetManagedFieldOffsets(Type type, string path, int baseOffset, Dictionary<string, int> offsets)
        {
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var field in fields)
            {
                if (!field.IsPublic)
                    continue;

                string currentPath = path + (field.Name.StartsWith("__MIDL__") ? "" : ("." + field.Name.TrimStart('@')));

                bool nestedType = CommonTestMethods.NativeStructures.Contains(field.FieldType) ||
                    ((field.FieldType.Name.StartsWith("__MIDL__") || field.Name.StartsWith("__MIDL__")) && field.FieldType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance).Any());

                int currentOffset = baseOffset + Marshal.OffsetOf(type, field.Name).ToInt32();

                if (!field.Name.StartsWith("__MIDL__"))
                    offsets.Add(currentPath, currentOffset);

                if (nestedType)
                    GetManagedFieldOffsets(field.FieldType, currentPath, currentOffset, offsets);
            }
        }


        private static void Main(string[] args)
        {
            string targetFile = args[0];

            StringBuilder result = new StringBuilder();

            result.AppendLine("#define STRUCT_SIZES \\");
            result.AppendLine("{\\");
            foreach (string typeName in CommonTestMethods.GetManagedStructureNames())
                result.AppendLine("    { L\"" + typeName + "\", sizeof(::" + typeName + ") },\\");
            result.AppendLine("    { NULL, 0 }\\");
            result.AppendLine("}\\");

            result.AppendLine();

            result.AppendLine("#define STRUCT_OFFSETS \\");
            result.AppendLine("{\\");
            foreach (string item in CommonTestMethods.GetManagedFieldOffsets().Keys)
                result.AppendLine("    { L\"" + item + "\", FIELD_OFFSET(::" + item.Substring(0, item.IndexOf('.')) + ", " + item.Substring(item.IndexOf('.') + 1) + ") },\\");
            result.AppendLine("    { NULL, 0 }\\");
            result.AppendLine("}\\");

            result.AppendLine();

            result.AppendLine("#define ENUM_SIZES \\");
            result.AppendLine("{\\");
            foreach (string typeName in CommonTestMethods.GetManagedEnumerationNames())
                result.AppendLine("    { L\"" + typeName + "\", sizeof(::" + typeName + ") },\\");
            result.AppendLine("    { NULL, 0 }\\");
            result.AppendLine("}\\");

            File.WriteAllText(targetFile, result.ToString());
        }
    }
}

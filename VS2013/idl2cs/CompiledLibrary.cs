using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idl2cs
{
    internal sealed class CompiledLibrary : IDisposable
    {
        private readonly string path;

        public CompiledLibrary(WorkingFolder workingFolder, string definitionFile, string libraryFile)
        {
            if (string.IsNullOrEmpty(definitionFile))
                return;
            path = libraryFile;

            try
            {
                string c1_path = Path.Combine(workingFolder.Folder, "c1.dll");
                string cl_path = Path.Combine(workingFolder.Folder, "cl.exe");
                string midl_path = Path.Combine(workingFolder.Folder, "midl.exe");
                string midlc_path = Path.Combine(workingFolder.Folder, "midlc.exe");
                string mspdb120_path = Path.Combine(workingFolder.Folder, "mspdb120.dll");
                string oaidl_path = Path.Combine(workingFolder.Folder, "oaidl.idl");
                string clui_path = Path.Combine(workingFolder.Folder, "1033", "clui.dll");
                string inject_path = Path.Combine(workingFolder.Folder, "inject.dll");

                if (!Directory.Exists(Path.GetDirectoryName(clui_path)))
                    Directory.CreateDirectory(Path.GetDirectoryName(clui_path));

                if (!File.Exists(c1_path) || !File.ReadAllBytes(c1_path).SequenceEqual(Resources.c1_exe))
                    File.WriteAllBytes(c1_path, Resources.c1_exe);
                if (!File.Exists(cl_path) || !File.ReadAllBytes(cl_path).SequenceEqual(Resources.cl_exe))
                    File.WriteAllBytes(cl_path, Resources.cl_exe);
                if (!File.Exists(midl_path) || !File.ReadAllBytes(midl_path).SequenceEqual(Resources.midl_exe))
                    File.WriteAllBytes(midl_path, Resources.midl_exe);
                if (!File.Exists(midlc_path) || !File.ReadAllBytes(midlc_path).SequenceEqual(Resources.midlc_exe))
                    File.WriteAllBytes(midlc_path, Resources.midlc_exe);
                if (!File.Exists(mspdb120_path) || !File.ReadAllBytes(mspdb120_path).SequenceEqual(Resources.mspdb120_dll))
                    File.WriteAllBytes(mspdb120_path, Resources.mspdb120_dll);
                if (!File.Exists(oaidl_path) || !File.ReadAllBytes(oaidl_path).SequenceEqual(Resources.oaidl_idl))
                    File.WriteAllBytes(oaidl_path, Resources.oaidl_idl);
                if (!File.Exists(clui_path) || !File.ReadAllBytes(clui_path).SequenceEqual(Resources.clui_dll))
                    File.WriteAllBytes(clui_path, Resources.clui_dll);
                if (!File.Exists(inject_path) || !File.ReadAllBytes(inject_path).SequenceEqual(Resources.inject_dll))
                    File.WriteAllBytes(inject_path, Resources.inject_dll);

                using (Process midl = Process.Start(new ProcessStartInfo
                {
                    FileName = Path.Combine(workingFolder.Folder, "midl.exe"),
                    Arguments = string.Format("/I \"{0}\" /I \"{3}\" /no_def_idir \"{1}\" /tlb \"{2}\"", workingFolder.Folder, definitionFile, libraryFile, Path.GetDirectoryName(definitionFile)),
                    UseShellExecute = false
                }))
                {
                    midl.WaitForExit();
                    if (midl.ExitCode != 0)
                        throw new Exception("midl.exe returned " + midl.ExitCode + ".");
                }
            }
            catch
            {
                Dispose();
                throw;
            }
        }

        public void Dispose()
        {
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
                File.Delete(path);
        }
    }
}

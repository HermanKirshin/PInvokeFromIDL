using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idl2cs
{
    internal sealed class WorkingFolder : IDisposable
    {
        private readonly string oldDirectory;

        public readonly string Folder;

        public WorkingFolder()
        {
            oldDirectory = Environment.CurrentDirectory;
            Folder = Path.Combine(Path.GetTempPath(), "idl2cs_31");

            if (!Directory.Exists(Folder))
                Directory.CreateDirectory(Folder);

            Environment.CurrentDirectory = Folder;
        }

        public void Dispose()
        {
            Environment.CurrentDirectory = oldDirectory;
        }
    }
}

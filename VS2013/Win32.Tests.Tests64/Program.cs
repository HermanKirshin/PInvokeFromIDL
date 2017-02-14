using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Win32.Tests.Common;
using Win32.Tests.Native;

namespace Win32.Tests.Tests64
{
    [TestClass]
    public class Program
    {
        [TestMethod]
        public void Test64()
        {
            CommonTestMethods.RunAsProcess(x => Assert.Fail(Environment.NewLine + x));
        }

        private static void Main()
        {
            Console.Write(CommonTestMethods.Run("Win32.Tests.Native64.dll", ProcessorArchitecture.Amd64));
        }
    }
}

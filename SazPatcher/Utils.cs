using System;
using System.IO;
using System.Threading;

namespace SazPatcher
{
    class Utils
    {
        private const string patchFileName = "SazPatch.log";
        public static string patchPath = (Directory.GetCurrentDirectory() + "\\Patch\\");
        public static string patchFilePath = patchPath + patchFileName;

        public static void ExitProgram(int delay)
        {
            Console.WriteLine("Exiting");
            Thread.Sleep(delay);
            Environment.Exit(0);
        }
    }
}

using System;
using System.IO;
using System.Threading;

namespace SazPatchMaker
{
    class Utils
    {
        private const string patchFileName = "SazPatch.log";
        public static string patchPath = (Directory.GetCurrentDirectory() + "\\Patch\\");
        public static string patchFilePath = patchPath + patchFileName;
       
        public static void RestartProgram(int delay)
        {
            Console.WriteLine("Reloading");
            Thread.Sleep(delay);
            Console.Clear();
            Program.Main();
        }
    }
}

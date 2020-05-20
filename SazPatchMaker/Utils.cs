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
        public static string GetUserInput()
        {
            return Console.ReadLine();
        }

        public static void PrintLine(string text)
        {
            Console.WriteLine(text);
        }

        public static void Print(string text)
        {
            Console.Write(text);
        }

        public static void RestartProgram(int delay)
        {
            PrintLine("Reloading");
            Thread.Sleep(delay);
            Console.Clear();
            Program.Main();
        }
    }
}

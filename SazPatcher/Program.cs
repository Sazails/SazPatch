using System;
using System.IO;
using System.Threading;

namespace SazPatcher
{
    class Program
    {
        static void Main()
        {
            Utils.PrintLine("SazPatcher started.");

            if (!Directory.Exists(Utils.patchPath))
            {
                Utils.PrintLine(string.Format("No Patch folder in current directory: {0}", Directory.GetCurrentDirectory()));
                Utils.ExitProgram(3000);
            }

            Patcher.Patch();

            Utils.PrintLine("SazPatcher finished.");
            Utils.PrintLine("Press any key to quit.");
            Console.ReadKey();
        }

        static void ReloadProgram(int delay)
        {
            Utils.PrintLine("Reloading");
            Thread.Sleep(delay);
            Console.Clear();
            Main();
        }
    }
}

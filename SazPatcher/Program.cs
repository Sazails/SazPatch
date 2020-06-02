using System;
using System.IO;
using System.Threading;

namespace SazPatcher
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("SazPatcher started.");

            if (!Directory.Exists(Utils.patchPath))
            {
                Console.WriteLine(string.Format("No Patch folder in current directory: {0}", Directory.GetCurrentDirectory()));
                Utils.ExitProgram(3000);
            }

            Patcher.Patch();

            Console.WriteLine("SazPatcher finished.");
            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }

        static void ReloadProgram(int delay)
        {
            Console.WriteLine("Reloading");
            Thread.Sleep(delay);
            Console.Clear();
            Main();
        }
    }
}

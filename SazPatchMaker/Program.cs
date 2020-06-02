using System;
using System.IO;

namespace SazPatchMaker
{
    class Program
    {
        public static string oldContentPath = "";
        public static string newContentPath = "";

        public static void Main()
        {
            Console.WriteLine("SazPatchMaker started.");

            GetUserInput();
            Patcher.CreatePatch();

            Console.WriteLine("SazPatchMaker finished.");
            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }

        static void GetUserInput()
        {
            #region Old content path input
            Console.WriteLine("Enter old content folder path: ");
            oldContentPath = Console.ReadLine();
            oldContentPath += "\\";

            if (!Directory.Exists(oldContentPath))
            {
                Console.WriteLine("Old content path does not exist: {0}", oldContentPath);
                Utils.RestartProgram(3000);
            }
            #endregion

            #region New content path input
            Console.WriteLine("Enter new content folder path: ");
            newContentPath = Console.ReadLine();
            newContentPath += "\\";

            if (!Directory.Exists(newContentPath))
            {
                Console.WriteLine("New content path does not exist: {0}", newContentPath);
                Utils.RestartProgram(3000);
            }
            #endregion

            #region Confirm path inputs
            Console.WriteLine("Old path: {0}\nNew path: {1}", oldContentPath, newContentPath);
            Console.WriteLine("Create the patch? | y = yes | n = no |");
            string answer = Console.ReadLine();

            if (answer == "y" || answer == "yes" || answer == "Y" || answer == "YES")
                return;
            else
                Utils.RestartProgram(1000);
            #endregion
        }
    }
}

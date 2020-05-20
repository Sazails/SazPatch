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
            Utils.PrintLine("SazPatchMaker started.");

            GetUserInput();
            Patcher.CreatePatch();

            Utils.PrintLine("SazPatchMaker finished.");
            Utils.PrintLine("Press any key to quit.");
            Console.ReadKey();
        }

        static void GetUserInput()
        {
            #region Old content path input
            Utils.Print("Enter old content folder path: ");
            oldContentPath = Utils.GetUserInput();
            oldContentPath += "\\";

            if (!Directory.Exists(oldContentPath))
            {
                Utils.PrintLine(string.Format("Old content path does not exist: {0}", oldContentPath));
                Utils.RestartProgram(3000);
            }
            #endregion

            #region New content path input
            Utils.Print("Enter new content folder path: ");
            newContentPath = Utils.GetUserInput();
            newContentPath += "\\";

            if (!Directory.Exists(newContentPath))
            {
                Utils.PrintLine(string.Format("New content path does not exist: {0}", newContentPath));
                Utils.RestartProgram(3000);
            }
            #endregion

            #region Confirm path inputs
            Utils.PrintLine(string.Format("Old path: {0}\nNew path: {1}", oldContentPath, newContentPath));
            Utils.PrintLine(string.Format("Create the patch? | y = yes | n = no |"));
            string answer = Utils.GetUserInput();

            if (answer == "y" || answer == "yes" || answer == "Y" || answer == "YES")
                return;
            else
                Utils.RestartProgram(1000);
            #endregion
        }
    }
}

using System.IO;

namespace SazPatcher
{
    class Patcher
    {
        public static void Patch()
        {
            string[] logCommands = File.ReadAllLines(Utils.patchFilePath);
            foreach (string command in logCommands)
            {
                Utils.PrintLine(string.Format("Found: {0}", command));

                string path = command.Split(new char[] { '<', '>' })[1];

                CopyFile(path);
            }
        }

        private static void CopyFile(string filePath)
        {
            string dir = Path.Combine(Directory.GetCurrentDirectory(), Path.GetDirectoryName(filePath));
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            string fromPath = Path.Combine(Utils.patchPath, filePath);
            string toPath = Path.Combine(Directory.GetCurrentDirectory() + "\\", filePath);


            if (File.Exists(toPath))
                File.Delete(toPath);

            if (File.Exists(fromPath))
            {
                Utils.PrintLine(string.Format("Moving file from {0} to {1}", fromPath, toPath));
                File.Move(fromPath, toPath);
                Utils.PrintLine(string.Format("Finished moving file from {0} to {1}", fromPath, toPath));
            }
        }
    }
}

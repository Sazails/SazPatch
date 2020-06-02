using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SazPatchMaker
{
    class Patcher
    {
        public static void CreatePatch()
        {
            #region Get file paths
            List<string> oldContentFilePaths = Directory.GetFiles(Program.oldContentPath, "*", SearchOption.AllDirectories).ToList();
            List<string> newContentFilePaths = Directory.GetFiles(Program.newContentPath, "*", SearchOption.AllDirectories).ToList();
            List<string> patchFilePaths = new List<string>();

            for(int x = 0; x < oldContentFilePaths.Count; x++)
                oldContentFilePaths[x] = oldContentFilePaths[x].Replace(Program.oldContentPath, "");

            for (int x = 0; x < newContentFilePaths.Count; x++)
                newContentFilePaths[x] = newContentFilePaths[x].Replace(Program.newContentPath, "");
            #endregion

            if (!Directory.Exists(Utils.patchPath))
                Directory.CreateDirectory(Utils.patchPath);

            using (StreamWriter writer = File.CreateText(Utils.patchFilePath))
            {
                foreach (string newFilePath in newContentFilePaths)
                {
                    // Check if file exists in the old version
                    if (!oldContentFilePaths.Contains(newFilePath))
                    {
                        patchFilePaths.Add(newFilePath);
                        CopyFile(newFilePath);
                        Logger.WriteFilePatch(writer, newFilePath, Logger.PatchType.CREATE);
                    }
                    // Check file size and modification time
                    else if (oldContentFilePaths.Contains(newFilePath))
                    {
                        FileInfo oldFile = new FileInfo(Path.Combine(Program.oldContentPath, newFilePath));
                        FileInfo newFile = new FileInfo(Path.Combine(Program.newContentPath, newFilePath));

                        if ((oldFile.Length != newFile.Length) || (oldFile.LastWriteTime != newFile.LastWriteTime))
                        {
                            patchFilePaths.Add(newFilePath);
                            CopyFile(newFilePath);
                            Console.WriteLine("Logged '{0}' of type '{1}'", newFilePath, Logger.PatchType.UPDATE);
                            Logger.WriteFilePatch(writer, newFilePath, Logger.PatchType.UPDATE);
                        }
                    }
                }
                writer.Close();
            }
        }

        private static void CopyFile(string filePath)
        {
            string dir = Path.Combine(Utils.patchPath, Path.GetDirectoryName(filePath));
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            File.Copy(Path.Combine(Program.newContentPath, filePath), Path.Combine(Utils.patchPath, filePath), true);
        }
    }
}

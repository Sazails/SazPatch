using System.IO;

namespace SazPatchMaker
{
    class Logger
    {
        public enum PatchType { CREATE, UPDATE, DELETE }

        public static void WriteFilePatch(StreamWriter writer, string filePath, PatchType patchType)
        {
            writer.WriteLine(string.Format("#{0}# <{1}>", patchType, filePath));
        }
    }
}

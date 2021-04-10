using System.IO;

namespace MD5CollisionGenerator.Utils
{
    public static class BinaryFileWriter
    {
        
        public static void Write(string fileName, byte[] prefix, byte[] goodFileBinary, byte[] evilFileBinary)
        {
            using var fs = File.OpenWrite(fileName);
            using var writer = new BinaryWriter(fs);
            writer.Write(prefix);
            writer.Write(goodFileBinary.Length);
            writer.Write(evilFileBinary.Length);
            fs.Write(goodFileBinary);
            fs.Write(evilFileBinary);
            fs.Close();
        }
    }
}
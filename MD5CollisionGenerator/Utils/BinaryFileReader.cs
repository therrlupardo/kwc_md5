using System.IO;

namespace MD5CollisionGenerator.Utils
{
    public static class BinaryFileReader
    {
        public static byte[] Read(string fileName)
        {
            using var fs = File.OpenRead(fileName);
            var data = new byte[fs.Length];
            fs.Position = 0;
            fs.Read(data, 0, data.Length);
            return data;
        }
    }
}
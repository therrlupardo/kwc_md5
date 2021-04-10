using MD5CollisionGenerator.Utils;
using MD5CollisionGenerator.Vectors;

namespace MD5CollisionGenerator
{
    static class Program
    {
        public static void Main(string[] args)
        {
            var goodFileBinary = BinaryFileReader.Read(args[0]);
            var evilFileBinary = BinaryFileReader.Read(args[1]);

            BinaryFileWriter.Write("good.bin", CollidedVectorsGenerator.BaseVector, goodFileBinary, evilFileBinary);
            BinaryFileWriter.Write("evil.bin", CollidedVectorsGenerator.CollidedVector, goodFileBinary, evilFileBinary);

            Md5Utils.Show("good.bin");
            Md5Utils.Show("evil.bin");

        }

    }
}
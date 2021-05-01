using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Runner.Extensions;

namespace Runner
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var inputFile = args[0];
            const string outputFile = "temp";
            // var outputFile = args[1];
            using var reader = new BinaryReader(File.OpenRead(inputFile));
            var prefix = reader.ReadBytes(128);
            var sizeOfGoodFile = reader.ReadInt32();
            var sizeOfEvilFile = reader.ReadInt32();

            if (IsEvilFile(prefix))
                SaveEvilFileToOutput(outputFile, reader, sizeOfGoodFile, sizeOfEvilFile);
            else
                SaveGoodFileToOutput(outputFile, reader, sizeOfGoodFile);

            $"chmod +x ./{outputFile}".Bash();
            Console.WriteLine($"./{outputFile}".Bash());
        }

        private static void SaveGoodFileToOutput(string outputFileName, BinaryReader reader, int sizeOfGoodFile)
        {
            var good = reader.ReadBytes(sizeOfGoodFile);
            using var writer = new BinaryWriter(File.OpenWrite(outputFileName));
            writer.Write(good);
            writer.Close();
        }

        private static void SaveEvilFileToOutput(string outputFileName, BinaryReader reader, int sizeOfGoodFile,
            int sizeOfEvilFile)
        {
            reader.ReadBytes(sizeOfGoodFile);
            var evil = reader.ReadBytes(sizeOfEvilFile);
            using var writer = new BinaryWriter(File.OpenWrite(outputFileName));
            writer.Write(evil);
            writer.Close();
        }

        private static bool IsEvilFile(IReadOnlyList<byte> prefix)
        {
            return prefix[123] == 0xab;
        }
    }
}
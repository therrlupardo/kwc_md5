using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace MD5CollisionGenerator.Utils
{
    public static class Md5Utils
    {
        public static void Show(string fileName)
        {
            var md5Provider = new MD5CryptoServiceProvider();
            var md5 = md5Provider.ComputeHash(BinaryFileReader.Read(fileName));
            Console.WriteLine($"MD5 hash for {fileName} is {md5.ToHexString()}");
        } 
        
        private static string ToHexString(this IReadOnlyList<byte> data)
        {
            var sb = new StringBuilder();
            foreach (var t in data)
                sb.AppendFormat("{0:X2}", t);
            return sb.ToString ();
        }
    }
}
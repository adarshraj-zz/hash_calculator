using System.IO;
using System.Security.Cryptography;

namespace HashCalculator {
    class FileHasher {
        private static FileStream GetFileStream(string filePath) {
            return (new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
        }

        public static string GetHash(byte[] input) {
            string fileHash;
            fileHash = System.BitConverter.ToString(input);
            fileHash = fileHash.Replace("-", "");
            return fileHash.ToLower();
        }

        public static string MD5Hash(string filePath) {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            FileStream MD5Stream;

            MD5Stream = GetFileStream(filePath);
            byte[] fileMD5 = md5.ComputeHash(MD5Stream);
            return (GetHash(fileMD5));
        }

        public static string SHA1Hash(string filePath) {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            FileStream Sha1Stream;

            Sha1Stream = GetFileStream(filePath);
            byte[] fileSha1 = sha1.ComputeHash(Sha1Stream);
            return (GetHash(fileSha1));
        }

        public static string SHA256Hash(string filePath) {
            SHA256Managed sha256 = new SHA256Managed();
            FileStream Sha256Stream;

            Sha256Stream = GetFileStream(filePath);
            byte[] fileSha256 = sha256.ComputeHash(Sha256Stream);
            return (GetHash(fileSha256));
        }

        public static string SHA384Hash(string filePath) {
            SHA384Managed sha384 = new SHA384Managed();
            FileStream Sha384Stream;

            Sha384Stream = GetFileStream(filePath);
            byte[] fileSha384 = sha384.ComputeHash(Sha384Stream);
            return (GetHash(fileSha384));
        }

        public static string SHA512Hash(string filePath) {
            SHA512Managed sha512 = new SHA512Managed();
            FileStream Sha512Stream;

            Sha512Stream = GetFileStream(filePath);
            byte[] fileSha512 = sha512.ComputeHash(Sha512Stream);
            return (GetHash(fileSha512));
        }
    }
}

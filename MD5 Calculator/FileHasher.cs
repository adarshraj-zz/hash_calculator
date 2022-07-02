using System.IO;
using System.Security.Cryptography;

namespace HashAlgo {
    class FileHasher {
        public static string MD5Hash(string filePath) {
            return getHashedValue(filePath, new MD5CryptoServiceProvider());
        }

        public static string SHA1Hash(string filePath) {
            return getHashedValue(filePath, new SHA1CryptoServiceProvider());
        }

        public static string SHA256Hash(string filePath) {
            return getHashedValue(filePath, new SHA256Managed());
        }

        public static string SHA384Hash(string filePath) {
            return getHashedValue(filePath, new SHA384Managed());
        }

        public static string SHA512Hash(string filePath) {
           return getHashedValue(filePath, new SHA512Managed());
        }

        private static string getHashedValue(string filePath, HashAlgorithm algorithm) {
            FileStream hashStream = getFileStream(filePath);
            byte[] hashBytes = algorithm.ComputeHash(hashStream);
            return (getHash(hashBytes));
        }

        private static FileStream getFileStream(string filePath) {
            if(File.Exists(filePath)) {
                return (new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
            } else {
                return null;
            }
        }

        public static string getHash(byte[] input) {
            string fileHash = System.BitConverter.ToString(input);
            return fileHash.Replace("-", "").ToLower();
        }
    }
}

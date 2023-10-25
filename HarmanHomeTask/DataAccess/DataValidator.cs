using System.Security.Cryptography;

namespace HarmanHomeTask.DataAccess
{
    public static class FileDataValidator
    {
        public static bool IsValid(string FileName, string CheckSum, int ByteSize) 
        {
            long length = new FileInfo(FileName).Length;
            if ((int)length != ByteSize) { return false;}

            return CalculateMD5(FileName).Equals(CheckSum);
        }
        private static string CalculateMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.LicenseManager.LicenseInformations.Tools
{
   public static class EncrpytionTool
    {
        private const string masterKey = "Süper Şifremiz";
        public static string Encrypt(string data)
        {
            byte[] encryptedData = UTF8Encoding.UTF8.GetBytes(data);
            using (MD5CryptoServiceProvider md5=new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(masterKey));
                using (TripleDESCryptoServiceProvider tripleDes=new TripleDESCryptoServiceProvider {Key=keys,Mode=CipherMode.ECB,Padding=PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDes.CreateEncryptor();
                    byte[] result = transform.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
                    return Convert.ToBase64String(result, 0, result.Length);
                }
            }
        }
        public static string Decrypt(string data)
        {
            byte[] encryptedData =Convert.FromBase64String(data);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(masterKey));
                using (TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDes.CreateDecryptor();
                    byte[] result = transform.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
                    return UTF8Encoding.UTF8.GetString(result);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
namespace EncryptorDecryptor
{
    class AesEncryptor
    {
        
        static string IV = "M8SzvBVteoiru2Bd";//16 char 128bits
        static string Key = "bV9yJ8R4mh5ujbUCk8qLjeQky9s3Xgmk"; //32 char 256bits
        public static string Encrypt(string unencrypted)
        {
            
            byte[] textBytes = ASCIIEncoding.ASCII.GetBytes(unencrypted.ToCharArray());
            AesCryptoServiceProvider enDec = new AesCryptoServiceProvider();
            enDec.BlockSize = 128;
            enDec.KeySize = 256;
            enDec.Key = ASCIIEncoding.ASCII.GetBytes(Key);
            enDec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            enDec.Padding = PaddingMode.PKCS7;
            enDec.Mode = CipherMode.CBC;
            ICryptoTransform iCrypt = enDec.CreateEncryptor(enDec.Key, enDec.IV);
            byte[] enc = iCrypt.TransformFinalBlock(textBytes, 0, textBytes.Length);
            iCrypt.Dispose();
            return Convert.ToBase64String(enc);
        }
        public static string Decrypt(string encrypted)
        {
            
            byte[] encBytes = Convert.FromBase64String(encrypted);
            AesCryptoServiceProvider enDec = new AesCryptoServiceProvider();
            enDec.BlockSize = 128;
            enDec.KeySize = 256;
            enDec.Key = ASCIIEncoding.ASCII.GetBytes(Key);
            enDec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            enDec.Padding = PaddingMode.PKCS7;
            enDec.Mode = CipherMode.CBC;
            ICryptoTransform iCrypt = enDec.CreateDecryptor(enDec.Key, enDec.IV);
            byte[] dec = iCrypt.TransformFinalBlock(encBytes, 0, encBytes.Length);
            iCrypt.Dispose();

            return ASCIIEncoding.ASCII.GetString(dec);
        }
    }
}

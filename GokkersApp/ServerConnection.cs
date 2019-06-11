
using EncryptorDecryptor;
using System.IO;
namespace GokkersApp
{
    public class ServerConnection

    {
        public void encryptString(string unenc)
        {
            string parent = System.IO.Directory.GetParent("..").FullName;
            File.WriteAllText(parent + "/gokResources/c.gok", AesEncryptor.Encrypt(unenc));
        }
        public void encryptCompString(string unenc)
        {
            string parent = System.IO.Directory.GetParent("..").FullName;
            File.WriteAllText(parent + "/gokResources/cg.gok", AesEncryptor.Encrypt(unenc));
        }
        public string decryptCompString(string enc)
        {
            string parent = System.IO.Directory.GetParent("..").FullName;

            string decode = AesEncryptor.Decrypt(enc);


            return decode;
        }

    }
}

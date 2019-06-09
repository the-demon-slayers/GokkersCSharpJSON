using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

using System.IO;
using System.Windows.Forms;

using EncryptorDecryptor;
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

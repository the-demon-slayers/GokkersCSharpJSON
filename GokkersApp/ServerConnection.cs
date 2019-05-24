using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

using System.IO;
using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using EncryptorDecryptor;
namespace GokkersApp
{
    public class ServerConnection
    {
        public MySqlConnection connection;
       
        private string connectionString;
        public string sslM;
        public string activeUserName;
        
        public void svLoginEncrypted()
        {
                string parent = System.IO.Directory.GetParent("..").FullName;
                
                string dir = File.ReadAllText(parent + "/gokResources/c.gok");

              
                string decode = AesEncryptor.Decrypt(dir);
                connectionString = decode;
            
                connection = new MySqlConnection(connectionString);
        }
     
    }
}

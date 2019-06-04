using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using EncryptorDecryptor;
namespace GokkersApp
{
    public partial class UserSelector : Form
    {
        public string SelectedUser;
        public UserSelector()
        {
            InitializeComponent();
            LoadUsers();
        }
        void LoadUsers()
        {

            string parent = System.IO.Directory.GetParent("..").FullName;
            string[] files = Directory.GetFiles(parent +"/gokResources/savedata", "*.gok",SearchOption.TopDirectoryOnly);
            
            for (int i = 0; i < files.Length; i++)
            {
                userComboBox.Items.Add(Path.GetFileNameWithoutExtension(files[i]));


            }
            userComboBox.Refresh();
            
        }
        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chooseUserButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userComboBox.Text))
            {
                MessageBox.Show("Geen gebruiker geselecteerd");
            }
            else
            {
                
                SelectedUser = userComboBox.Text.ToString();
                this.Close();
            }
        }

        private void makeNewUserButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(newUserTextBox.Text) || string.IsNullOrWhiteSpace(newUserTextBox.Text))
            {
                if(newUserTextBox.Text.Contains(".") || newUserTextBox.Text.Contains("[") || newUserTextBox.Text.Contains("]") || newUserTextBox.Text.Contains("/") || newUserTextBox.Text.Contains("\""))
                {
                    MessageBox.Show("A.U.B typ niks verkeerd.");
                }
                else
                {
                    MessageBox.Show("Schrijf een nieuwe gebruikernaam.");
                }
            }
            else
            {
                SelectedUser = newUserTextBox.Text;
                this.Close();
            }
            
           
        }
    }
}

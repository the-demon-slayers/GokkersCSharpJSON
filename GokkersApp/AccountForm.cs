using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace GokkersApp
{
    public partial class AccountForm : Form
    {
        public ServerConnection testConnection = new ServerConnection();
        
        bool newAccountMode;
        public AccountForm()
        {
            InitializeComponent();
        }
        void initalizeServerConnection()
        {

        }
        private void loginButton_Click(object sender, EventArgs e)
        {
           
            if (newAccountMode)
            {
                try
                {
                    testConnection.svLogin("localhost", "f9", "root", "", "3306", "none");
                    testConnection.connection.Open();
                    MessageBox.Show("Connection to " + "database" + " succesful");
                    //connectionStateLabel.Text = "Connected : " + testConnection.serverName;
                    testConnection.connection.Close();
                }
                catch (MySqlException err)
                {
                    MessageBox.Show("Connection to" + " database" + " failed...");
                    // connectionStateLabel.Text = "Failed to connect to " + testConnection.serverName + " Consider checking XAMPP.";
                }
            }
            else
            {
                testConnection.svLogin("localhost", "f9", "root", "", "3306", "none");
                try
                {
                   
                    
                    MySqlCommand scmd = new MySqlCommand("select count(*) as cnt from Users where username =@usr and password= @pwd",testConnection.connection);
                    //*Connection String to actually log in.
                    scmd.Parameters.Clear();
                    scmd.Parameters.AddWithValue("@usr", usernameTextBox.Text);
                    scmd.Parameters.AddWithValue("@pwd", passwordTextBox.Text);
                    testConnection.activeUserName = usernameTextBox.Text;
                    testConnection.connection.Open();
                    ///Test the connection string
                    if(scmd.ExecuteScalar().ToString()=="1")
                    {
                        MessageBox.Show("Connection to " + "database" + " succesful");
                    }
                    else
                    {
                        MessageBox.Show("Incorect login credentials.");
                    }
                    ///
                    //connectionStateLabel.Text = "Connected : " + testConnection.serverName;
                    testConnection.connection.Close();
                }
                catch (MySqlException err)
                {
                    MessageBox.Show("Connection to" + " database" + " failed..." + err.Message);
                    // connectionStateLabel.Text = "Failed to connect to " + testConnection.serverName + " Consider checking XAMPP.";
                }
            }
        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            if(!newAccountMode)
            {
                loginButton.Text = "Toevoegen";
                newAccountMode = true;
            }
            else
            {
                loginButton.Text = "Inloggen";
                newAccountMode = false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;

/* Gokkers C# App bij TheDemonSlayers
 * 
 * 
 * Main C# Designer : Ajmal Zaid Ashley (Zaid)
 *
 * Secondary C# Contriubutors : Justin Ergbo, Renzo, Robin*/
namespace GokkersApp
{

    public partial class mainForm : Form
    {
       
        RootObject rootObject;
        public List<Player> Players = new List<Player>();
        public List<TeamBase> TeamsBase= new List<TeamBase>();
        public List<string> Teams = new List<string>();
        public int wins, losses, points;
        public bool connected = false;
        public bool canProceed = false;
        SaveData saveData = new SaveData();
        ServerConnection serverConnection;
        public mainForm()
        {
            InitializeComponent();
           
            establishConnection();
            if (connected)
            {
                downloadFromDatabase();
            }
            string parent = System.IO.Directory.GetParent("..").FullName;
            string dir = parent +"/gokResources/gamedatax.gok";
            LoadDatabase(dir);
            if (canProceed)
            {
                loadGame(saveData.user_name);
            }
            else
            {
                OpenUserData();
             
            }
            updateWinLabels();
          
        }
        void OpenUserData()
        {
            UserSelector userSelector = new UserSelector();
            userSelector.ShowDialog();
            if(userSelector.DialogResult != DialogResult.OK)
            {
                canProceed = true;
                userNameLabel.Text = userSelector.SelectedUser;
                saveData.user_name = userSelector.SelectedUser;
                loadGame(userSelector.SelectedUser);

            }
            else
            {
                canProceed = false;
            }
        }
        void RefreshTitleBar(string newText)
        {
            this.Text = newText;
        }
        void establishConnection ()
        {
            serverConnection = new ServerConnection();
            try
            {
                serverConnection.svLoginEncrypted();
                serverConnection.connection.Open();
              
                connected = true;
               
            }
            catch (MySqlException err)
            {
                MessageBox.Show("Connection to" + " database" + " failed...");
                connected = false;
                
            }
        }
        void downloadFromDatabase()
        {
            string commandString = "SELECT * FROM teams";
            MySqlDataAdapter sda = new MySqlDataAdapter(commandString, serverConnection.connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string parent = System.IO.Directory.GetParent("..").FullName;
            StreamWriter save = File.CreateText(parent+"/gokResources/gamedatax.gok");
            JsonSerializer serializer = new JsonSerializer();
            serializer.Serialize(save, dt);
            save.Close();
            MessageBox.Show("Database is succesvol vernieuwed");

        }
        void saveGame(string UserSave)
        {
            //saveData.last_user = userNameLabel.Text;
            saveData.user_name = userNameLabel.Text;
            saveData.wins = wins;
            saveData.losses = losses;
            saveData.points = points;
            string parent = System.IO.Directory.GetParent("..").FullName;
            StreamWriter save = File.CreateText(parent +"/gokResources/savedata/" +UserSave+".gok");
            JsonSerializer serializer = new JsonSerializer();
            serializer.Serialize(save, saveData);
            save.Close();

        }
        void loadGame(string UserSave)
        {
            bool fileFound = false;
            try
            {
                string parent = System.IO.Directory.GetParent("..").FullName;
                using (File.Open(parent+"/gokResources/savedata/" +UserSave+".gok", FileMode.Open))
                {
                    fileFound = true;
                    
                  
                }
            }
            catch (FileNotFoundException ex)
            {
                fileFound = false;
                points = 5;
            }
            if(fileFound)
            {
                string parent = System.IO.Directory.GetParent("..").FullName;
                StreamReader sr = File.OpenText(parent+"/gokResources/savedata/"+UserSave+".gok");


                JsonSerializer serializer = new JsonSerializer();
                saveData = (SaveData)serializer.Deserialize(sr, typeof(SaveData));
                wins = saveData.wins;
                losses = saveData.losses;
                points = saveData.points;
                
                sr.Close();
            }
            else
            {
                //MessageBox.Show("Geen SaveGame getecteerd.");
                wins = 0;
                losses = 0;
                points = 32;
            }
            updateWinLabels();
        }
        void LoadDatabase(string dbName)
        {
            
            rootObject = new RootObject();
            StreamReader sr = File.OpenText(dbName);
            
            JsonSerializer serializer = new JsonSerializer();

            Datum[] temp = JsonConvert.DeserializeObject<Datum[]>(File.ReadAllText(dbName));
            //MessageBox.Show(temp[0].player_name.ToString());
            List<Datum> teams = temp.ToList<Datum>();
            playerListView.Clear();
            teamPickerComboBox.Items.Clear();
            TeamsBase.Clear();
            Teams.Clear();
            for (int i = 0; i < teams.Count; i++)
            {

                int x = Int32.Parse(teams[i].id.ToString());
                
                TeamsBase.Add(new TeamBase(teams[i].team_name, x, teams[i].team_name));
                
                
                Teams.Add(TeamsBase[i].team_name);
               
                if (!teamPickerComboBox.Items.Contains(TeamsBase[i].team_name))
                {
                    teamPickerComboBox.Items.Add(Teams[i].ToString());
                    playerListView.Items.Add(Teams[i].ToString());
                }

            }
            sr.Close();
            
            
         
          
            playerListView.Refresh();
        }
        void PerformRNG()
        {
            int x = 0;
            Random rng = new Random();
            x = (int)pointUpDown.Value;
            if (teamPickerComboBox.SelectedItem == null)
            {
                MessageBox.Show("Alstublieft selecteer een Team");
            }
            else
            {
                if (pointUpDown.Value < 2 || pointUpDown.Value > 15)
                {
                    MessageBox.Show("Je moet niet minder dan 2 en niet hoger dan 15 punten gokken");
                }
                else
                {
                    if (points >= pointUpDown.Value)
                    {
                        points = points - (int)pointUpDown.Value;
                        if (rng.Next(2) == 0)
                        {
                            wins++;
                            MessageBox.Show("Uw Team : " + teamPickerComboBox.SelectedItem.ToString() + " heeft gewonnen!");
                            RefreshTitleBar(teamPickerComboBox.SelectedItem.ToString() + " heeft gewonnen!!! HORAAH!");
                            points = points + (x * 2);
                        }
                        else
                        {
                            losses++;
                            MessageBox.Show("Uw Team : " + teamPickerComboBox.SelectedItem.ToString() + " verloor de wedstrijd!");
                            RefreshTitleBar(teamPickerComboBox.SelectedItem.ToString() + " verloor de wedstrijd!!! OH NEE!");
                            
                        }
                        saveGame(userNameLabel.Text);
                    }
                    else
                    {
                        MessageBox.Show("Je heeft te weing punten te gokken.");
                    }
                }
            }
        }
        void updateWinLabels()
        {
            winsLabel.Text = "Wins : " + wins.ToString();
            lossLabel.Text = "Losses : " + losses.ToString();
            pointLabel.Text ="Punten : " + points.ToString();
        }

        private void refreshConnectionButton_Click(object sender, EventArgs e)
        {
            establishConnection();
            if (connected)
            {
                downloadFromDatabase();
            }
            LoadDatabase("gamedatax.gok");
        }

        private void changeUserButton_Click(object sender, EventArgs e)
        {
            OpenUserData();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            PerformRNG();
            updateWinLabels();
        }
    }
}

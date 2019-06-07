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
        public DataGridView gridView;
        public List<string> Teams = new List<string>();
        List<Game> games = new List<Game>();
        public int selectedGameIndex;
        public int wins, losses, points;
        public bool connected = false;
        public bool canProceed = false;
        public bool cheat = false;
        SaveData saveData = new SaveData();
        ServerConnection serverConnection;

        public mainForm()
        {
            InitializeComponent();
            //Connect to the network...
            establishConnection();
            if (connected)
            {
                downloadFromDatabase(); //Download ze teams.
                downloadFromCompetitionDatabase(); //Download ze games.
            }
            //Load the database that was downloaded from the network.
            string parent = System.IO.Directory.GetParent("..").FullName;
            string dir = parent +"/gokResources/gamedatax.gok";
            string dirgame = parent + "/gokResources/gamedataxcomp.gok";
            LoadDatabase(dir);
            LoadCompetitionDatabase(dirgame);
            ///
            ///Check for userdata before and load it.
            if (canProceed)
            {
                loadGame(saveData.user_name);
            }
            else
            {
                //Opens the user data...
                OpenUserData();
             
            }
            ///
            ///Update labels.
            updateWinLabels();
          
        }

        void OpenUserData()
        {
            //Pulls up user data selection screen
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
                //Get the decrypted string and then log in to the database.
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
        //Download the teams database to a json file.
        void downloadFromDatabase()
        {
            //Select the teams database
            string commandString = "SELECT * FROM teams";
            MySqlDataAdapter sda = new MySqlDataAdapter(commandString, serverConnection.connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //SDA takes data from the selected database and fills up our datatable with information.
            string parent = System.IO.Directory.GetParent("..").FullName;
            StreamWriter save = File.CreateText(parent+"/gokResources/gamedatax.gok");

            JsonSerializer serializer = new JsonSerializer();
            serializer.Serialize(save, dt);
            //We simply save the datatable as a json file and we're good to go.
            save.Close();
            MessageBox.Show("Database is succesvol vernieuwed");

        }
        //Download the competitions database to a json file.
        void downloadFromCompetitionDatabase()
        {
            //Select the teams database
            string commandString = "SELECT * FROM games";
            MySqlDataAdapter sda = new MySqlDataAdapter(commandString, serverConnection.connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //SDA takes data from the selected database and fills up our datatable with information.
            string parent = System.IO.Directory.GetParent("..").FullName;
            StreamWriter save = File.CreateText(parent + "/gokResources/gamedataxcomp.gok");

            JsonSerializer serializer = new JsonSerializer();
            serializer.Serialize(save, dt);
            //We simply save the datatable as a json file and we're good to go.
            save.Close();
            MessageBox.Show("Wedstrijd Database is succesvol vernieuwed");

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
        //Set the default values for the score and points if no user is found.
        void setDefaults()
        {
            wins = 0;
            losses = 0;
            points = 32;
        }
        //Load game using the proper user string
        void loadGame(string UserSave)
        {
            bool fileFound = false;
            try
            {
                string parent = System.IO.Directory.GetParent("..").FullName;
                using (File.Open(parent + "/gokResources/savedata/" + UserSave + ".gok", FileMode.Open))
                {
                    fileFound = true;


                }
            }
            catch (Exception x)
            {
                if (x is FileNotFoundException || x is PathTooLongException)
                {


                    fileFound = false;
                }
                
            }
            //If the test file was found, then load the actual file. This is done to prevent exceptions.
            if(fileFound)
            {
                string parent = System.IO.Directory.GetParent("..").FullName;
                StreamReader sr = File.OpenText(parent+"/gokResources/savedata/"+UserSave+".gok");


                JsonSerializer serializer = new JsonSerializer();
                try
                {
                    saveData = (SaveData)serializer.Deserialize(sr, typeof(SaveData));
                    wins = saveData.wins;
                    losses = saveData.losses;
                    points = saveData.points;
                }
                catch (Exception err)
                {
                    MessageBox.Show("Gebruikerdata is onlessbar, data wordt verandert");
                    setDefaults();
                }
                
                sr.Close();
            }
            else
            {
                //Set everything to a defualt value
                setDefaults();
               
            }
            updateWinLabels();
        }
        void LoadDatabase(string dbName)
        {
            //Basically copies the entire database from the file and fills the class with its contents.
            
          
            
            JsonSerializer serializer = new JsonSerializer();
            /*Datum class is actually just used as an IO front for the actual TeamsBase Class for the JSON 
             * Deserialization event...*/
            Datum[] temp = JsonConvert.DeserializeObject<Datum[]>(File.ReadAllText(dbName));
            //MessageBox.Show(temp[0].player_name.ToString());
            List<Datum> teams = temp.ToList<Datum>();
            
           
            TeamsBase.Clear();
            Teams.Clear();
            //Fill tables with the loaded database.
            for (int i = 0; i < teams.Count; i++)
            {
                /*THIS WAS DONE BECAUSE ID IS AN STRING AND IT NEEDS TO TURN INTO AN INT.*/
                int x = Int32.Parse(teams[i].id.ToString());
                
                TeamsBase.Add(new TeamBase(teams[i].team_name, x, teams[i].team_name));
                
                
                Teams.Add(TeamsBase[i].team_name);
               
               

            }
           
                 
        
        }
        void LoadCompetitionDatabase(string dbName)
        {
            //Basically copies the entire database from the file and fills the class with its contents.
            
            

            JsonSerializer serializer = new JsonSerializer();

            Game[] temp = JsonConvert.DeserializeObject<Game[]>(File.ReadAllText(dbName));
            //MessageBox.Show(temp[0].player_name.ToString());
            games = temp.ToList<Game>();
            gameGridView.Rows.Clear();
            for (int i=0; i< games.Count; i++)
            {
             gameGridView.Rows.Add(games[i].team1, games[i].team2);
            }
            //gameGridView.Sort(gameGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
           
           

     
        }
        //This RNG betting function may or may not be removed so it's contents aren't important at the moment.
        /*
        void PerformRNG()
        {
            int x = 0;
            Random rng = new Random();
            x = (int)pointUpDown.Value;
            if (gameGridView.SelectedCells == null)
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
                
                            points = points + (x * 2);
                        }
                        else
                        {
                            losses++;
                         
                            
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
        */
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
                downloadFromCompetitionDatabase();
            }
            string parent = System.IO.Directory.GetParent("..").FullName;
            string dir = parent + "/gokResources/gamedatax.gok";
            string dirgame = parent + "/gokResources/gamedataxcomp.gok";
            LoadDatabase(dir);
            LoadCompetitionDatabase(dirgame);
        }

        private void changeUserButton_Click(object sender, EventArgs e)
        {
            OpenUserData();
        }
        //EXTREMELY BASIC CHEAT CODE...
        private void betButton_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.C)
            {
                cheat = true;
            }
            else
            {
                cheat = false;
            }
        }
        void GetCompetitionSelection(DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < games.Count; i++)
            {
                if (i == e.RowIndex)
                {
                    gameVersusLabel.Text = "U gok op wedstrijd van : " + games[i].team1 + " Vs. " + games[i].team2;
                    selectedGameIndex = i;
                }
            }
        }
        private void gameGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetCompetitionSelection(e);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if(cheat)
            {
                points += 164;
                cheat = false;
            }
            HandleBets(e);
            updateWinLabels();
        }

        void HandleBets(EventArgs e)
        {
            if (pointUpDown.Value > 1 && pointUpDown.Value < 16)
            {
                PointBetWindow pointBetWindow;
                pointBetWindow = new PointBetWindow();
                for (int i = 0; i < games.Count; i++)
                {
                    if (selectedGameIndex == i)
                    {
                        pointBetWindow.team1name = games[i].team1;
                        pointBetWindow.team2name = games[i].team2;
                        pointBetWindow.RefreshText();
                    }
                }
                pointBetWindow.ShowDialog();
                if (pointBetWindow.DialogResult != DialogResult.OK)
                {
                    int x;
                    int.TryParse(games[selectedGameIndex].team1_points, out x);
                    int y;
                    int.TryParse(games[selectedGameIndex].team2_points, out y);

                    if (x > y)
                    {
                        if (pointBetWindow.selectedTeamSide == 0)
                        {
                            MessageBox.Show("Uw team : " + games[selectedGameIndex].team1 + " heeft gewonnen");
                            checkPointValidation(true);
                        }
                        else
                        {
                            MessageBox.Show("Uw team : " + games[selectedGameIndex].team1 + " verloor de wedstrijd");
                            checkPointValidation(false);
                        }
                    }
                    if (x < y)
                    {
                        if (pointBetWindow.selectedTeamSide == 1)
                        {
                            MessageBox.Show("Uw team : " + games[selectedGameIndex].team2 + " heeft gewonnen");
                            checkPointValidation(true);
                        }
                        else
                        {
                            MessageBox.Show("Uw team : " + games[selectedGameIndex].team2 + " verloor de wedstrijd");
                            checkPointValidation(false);
                        }
                    }
                    if (x == y)
                    {
                        MessageBox.Show("De speel is gelijk.");
                        saveGame(userNameLabel.Text);
                    }
                    void checkPointValidation(bool win)
                    {
                        if (win)
                        {
                            if (x == pointBetWindow.team1points && y == pointBetWindow.team2points)
                            {
                                MessageBox.Show("Uw heeft de juiste uitkomst gedacht! Trippel punten!!!");
                                points += (int)pointUpDown.Value * 3;
                            }
                            else
                            {
                                points += (int)pointUpDown.Value * 2;
                            }
                            wins++;
                            saveGame(userNameLabel.Text);
                        }
                        else
                        {
                            points -= (int)pointUpDown.Value;
                            losses++;
                            saveGame(userNameLabel.Text);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Je mag niet hooger dan 15 of minder dan 2 punten gokken.");
            }
        }
    }
}

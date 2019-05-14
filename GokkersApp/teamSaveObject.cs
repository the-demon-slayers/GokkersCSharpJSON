using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokkersApp
{
    public class TeamSaveObject
    {
        public string userName;
        public int points;
        public int wins;
        public int losses;
        public Team[] savedTeams;
        public List<Team> currentTeams;
        public TeamSaveObject()
        {
            userName = "default";
            

        }
        public TeamSaveObject(string name, Team[] teams, List<Team> teamList)
        {
            this.userName = name;
            this.savedTeams = teams;
            this.currentTeams = teamList;
        }
        public TeamSaveObject(string name, List<Team> teamList)
        {
            this.userName = name;
            
            this.currentTeams = teamList;
        }
    }
}

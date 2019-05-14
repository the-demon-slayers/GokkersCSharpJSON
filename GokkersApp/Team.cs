using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokkersApp
{
    public class Team
    {
        public string teamName;
        public bool protectedTeam; //Cant remove this team from list.
        public List<Player> Players = new List<Player>();
        public Team(string name, bool protec)
        {
            this.teamName = name;
            this.protectedTeam = protec;
        }
        public void addPlayer(Player playerToAdd)
        {
            playerToAdd.assignedTeamName = teamName;
            Players.Add(playerToAdd);
        }
        public void addPlayer(Player playerToAdd, Player playerToAdd1)
        {
            playerToAdd.assignedTeamName = teamName;
            playerToAdd1.assignedTeamName = teamName;
            Players.Add(playerToAdd);
            Players.Add(playerToAdd1);
        }
        public void addPlayer(Player playerToAdd, Player playerToAdd1, Player playerToAdd2)
        {
            playerToAdd.assignedTeamName = teamName;
            playerToAdd1.assignedTeamName = teamName;
            playerToAdd2.assignedTeamName = teamName;
            Players.Add(playerToAdd);
            Players.Add(playerToAdd1);
            Players.Add(playerToAdd2);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

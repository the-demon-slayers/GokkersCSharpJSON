namespace GokkersApp
{
    public class Player
    {
        public int playerID;
        public string playerName;
        public string assignedTeamName;
        public Player(string name)
        {
            this.playerName = name;
        }
        public Player(string name, int player_id, string team)
        {
            this.playerName = name;
            this.playerID = player_id;
            this.assignedTeamName = team;
        }
    }
}

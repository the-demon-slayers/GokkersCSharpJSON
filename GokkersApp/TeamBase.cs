using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokkersApp
{
    public class TeamBase
    {
        public int id;
        public string team_name;
        public string made_by;

        public TeamBase(string name)
        {
            this.team_name = name;
        }
        public TeamBase(string name, int team_id, string creator)
        {
            this.team_name = name;
            this.id = team_id;
            this.made_by = creator;
        }
    }

}

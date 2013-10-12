using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_ClassRelationship
{
    class Team
    {
        public List<BaseballPlayer> Roster = new List<BaseballPlayer>();
        public string TeamName{ get; set;}

        public Team(string tn)
        {
            TeamName = tn;
        }

        public string joinTeam(BaseballPlayer bp)
        {
            Roster.Add(bp);
            string trans=bp.Name + " just joined the " + TeamName;
            return trans;
        }

    }
}

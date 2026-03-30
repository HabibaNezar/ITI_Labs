using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3Lab_visualC__Player_
{
    internal struct League
    {
        #region Properties
        public string Name { get; set; }
        public Team[] Teams { get; set; }
        #endregion

        #region Constructor
        public League(string name, Team[] teams)
        {
            Name = name;
            Teams = teams;
        }
        #endregion

        #region Indexer
        // Indexer: LeagueObject["ahly"] => object team
        public Team?  this[string teamName]
        {
            get
            {
                foreach (var t in Teams)
                {
                    // Using OrdinalIgnoreCase so "ahly" matches "Ahly"
                    if (t.TeamName.Equals(teamName, StringComparison.OrdinalIgnoreCase))
                    {
                        return t;
                    }
                }
                return null; // Return null if the team is not found
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            string info = $"=== LEAGUE: {Name} ===\n";
            foreach (var team in Teams)
            {
                info += team.ToString();
            }
            return info;
        }
        #endregion
    }
}

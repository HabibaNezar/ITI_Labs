using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3Lab_visualC__Player_
{
    internal struct Team
    {
        #region Properties
        public string TeamName { get; set; }
        public string CoachName { get; set; }
        public Player[] Players { get; set; }
        #endregion

        #region Constructor
        public Team(string teamName, string coachName, Player[] players)
        {
            TeamName = teamName;
            CoachName = coachName;
            Players = players;
        }
        #endregion

        #region Indexer
        // Indexer: TeamObject[tshirtnumber] = "update player name"
        public string this[int tshirtNumber]
        {
            get
            {
                foreach (var p in Players)
                {
                    if (p.TshirtNumber == tshirtNumber)
                        return p.Name;
                }
                return "Player not found";
            }
            set
            {
                for (int i = 0; i < Players.Length; i++)
                {
                    if (Players[i].TshirtNumber == tshirtNumber)
                    {
                        Players[i].Name = value; // Update the player's name
                        return;
                    }
                }
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            string info = $"\n--- Team: {TeamName} (Coach: {CoachName}) ---\n";
            foreach (var player in Players)
            {
                info += player.ToString() + "\n";
            }
            return info;
        }
        #endregion
    }
}

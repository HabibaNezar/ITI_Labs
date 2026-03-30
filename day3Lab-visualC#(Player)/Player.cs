using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3Lab_visualC__Player_
{
    internal struct Player
    {
        #region enum
        public enum Role
        {
            GK,
            DF,
            MF,
            FW
        }
        #endregion

        #region Properties
        // Auto-implemented properties are cleaner and save space
        public string Name { get; set; }
        public int TshirtNumber { get; set; }
        public Role PlayerRole { get; set; }
        #endregion

        #region Constructors
        public Player(string name, int tshirtNumber, Role r)
        {
            Name = name;
            TshirtNumber = tshirtNumber;
            PlayerRole = r;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            // Fixed the missing semicolon here
            return $"Player Name: {Name,-15} | T-Shirt: {TshirtNumber,-2} | Role: {PlayerRole}";
        }
        #endregion
    }
}
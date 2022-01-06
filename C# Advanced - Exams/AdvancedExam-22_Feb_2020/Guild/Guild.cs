using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    class Guild
    {
        //•	Field roster - collection 
        private List<Player> roster;
        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            roster = new List<Player>();
        }

        // Getter Count - returns the number of players
        public int Count
        {
            get
            {
                return roster.Count();
            }
        }
        public string Name { get; set; }
        public int Capacity { get; set; }

        //•	Method AddPlayer(Player player) - adds an entity to the roster if there is room for it
        public void AddPlayer(Player player)
        {
            if (roster.Count < this.Capacity)
            {
                roster.Add(player);
            }           
        }

        //•	Method RemovePlayer(string name) - removes a player by given name, if such exists, and returns bool

        public bool RemovePlayer(string name)
        {
            bool isExists = roster.Any(p => p.Name == name);

            if (isExists)
            {
                roster.RemoveAll(p => p.Name == name);
                return true;
            }
            return false;
        }
        // Method PromotePlayer(string name) - promote (set his rank to "Member") the first player with the given name. 
        // If the player is already a "Member", do nothing.

        public void PromotePlayer(string name)
        {
            bool isMemmber = roster.Any(x => x.Name == name && x.Rank == "Member");
            if (!isMemmber)
            {
                Player currentPlayer = roster.FirstOrDefault(x => x.Name == name);
                currentPlayer.Rank = "Member";
            }
        }
        //•	Method DemotePlayer(string name)- demote (set his rank to "Trial") 
        // the first player with the given name. If the player is already a "Trial",  do nothing.
        public void DemotePlayer(string name)
        {
            bool isTrialMemmber = roster.Any(x => x.Name == name && x.Rank == "Trial");
            if (!isTrialMemmber)
            {
                Player currentPlayer = roster.FirstOrDefault(x => x.Name == name);
                currentPlayer.Rank = "Trial";
            }
        }
        //•	Method KickPlayersByClass(string class) 
        //- removes all the players by the given class and returns all players from that class as an array
        public Player[] KickPlayersByClass(string removeClass)
        {
            Player[] removePlayers = roster.Where(x => x.Class == removeClass).ToArray();
            roster.RemoveAll(x => x.Class == removeClass);
            return removePlayers;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.Name}");
            for (int i = 0; i < roster.Count-1; i++)
            {
                sb.AppendLine(roster[i].ToString());
            }
            sb.Append(roster[Count - 1]).ToString();
            //foreach (var player in roster)
            //{
            //    sb.AppendLine(player.ToString());
            //}
            return sb.ToString();
        }
    }

}

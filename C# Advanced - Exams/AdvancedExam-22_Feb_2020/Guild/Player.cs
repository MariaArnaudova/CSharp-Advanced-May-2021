using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    class Player
    {
        // The class constructor should receive name and class. 
        public Player( string name, string newClass)
        {
            this.Name = name;
            this.Class = newClass;
            this.Rank = "Trial";
            this.Description = "n/a";
        }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Player {this.Name}: {this.Class}");
            sb.AppendLine($"Rank: {this.Rank}");
            sb.Append($"Description: {this. Description}");

            return sb.ToString();
        }
    }
}

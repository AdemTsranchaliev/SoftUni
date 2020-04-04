using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {
        public string Name { get; set; }

        public string Class { get; set; }

        public string Rank { get; set; }

        public string Description { get; set; }

        public Player(string name,string classN)
        {
            this.Name = name;
            this.Class = classN;
            this.Rank = "Trial";
            this.Description = "n/a";
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"Player {Name}: {Class}");
            builder.AppendLine($"Rank: {Rank}");
            builder.Append($"Description: {Description}");
            return builder.ToString().TrimEnd();

        }
    }
}

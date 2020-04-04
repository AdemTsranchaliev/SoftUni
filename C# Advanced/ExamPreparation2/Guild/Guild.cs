using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> players;

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => players.Count;

        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            if (this.Capacity >= players.Count+1)
            {
                players.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {
            var player = players.FirstOrDefault(x => x.Name == name);

            if (player == null)
            {
                return false;
            }
            else
            {
                this.players.Remove(player);
                return true;
            }
        }
        public void PromotePlayer(string name)
        {
            var player = players.FirstOrDefault(x => x.Name == name);

            if (player != null)
            {
                player.Rank = "Member";
            }

        }

        public void DemotePlayer(string name)
        {
            var player = players.FirstOrDefault(x => x.Name == name);

            if (player != null)
            {
                player.Rank = "Trial";
            }

        }

        public Player[] KickPlayersByClass(string classN)
        {
            var playersWithClass = players.Where(x=>x.Class==classN).ToArray();
            players.RemoveAll(x=>x.Class==classN);

            return playersWithClass;
        }

        public string Report()
        {
            var builder = new StringBuilder();

            builder.AppendLine($"Players in the guild: {this.Name}");

            foreach (var item in this.players)
            {
                builder.AppendLine(item.ToString());
            }

            return builder.ToString().TrimEnd();
        }

    }
}

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Game
{
    public class Highscore
    {
        public const int MaxPlayers = 10;

        private List<Player> currentHighscore;

        public Highscore()
        {
            this.currentHighscore = new List<Player>();
        }

        public ReadOnlyCollection<Player> players;

        public void AddPlayer(Player player)
        {
    
                this.currentHighscore.Add(player);
                this.currentHighscore = this.currentHighscore
                    .OrderByDescending(p => p.Points)
                    .Take(MaxPlayers)
                    .ToList();   
        }

        public IEnumerable<Player> Load()
        {
            return new ReadOnlyCollection<Player>(this.currentHighscore);
        }

    }
}

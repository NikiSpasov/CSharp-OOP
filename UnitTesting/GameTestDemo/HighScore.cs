namespace GameTestDemo
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    public class HighScore
    {
        public const int MaxPlayers = 10;
        private List<Player> currentHighscore = new List<Player>();

        private IEnumerable<Player> Load()
        {
            return new ReadOnlyCollection<Player>(this.currentHighscore);
        }

        public void AddPlayer(Player player)
        {
            if (this.currentHighscore.Count < 10)
            {
                this.currentHighscore.Add(player);
                this.currentHighscore = currentHighscore.OrderByDescending(p => p.Points)
                    .Take(MaxPlayers)
                    .ToList();
            }
        }

    }
}

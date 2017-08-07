using System.Linq;
using Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameTest
{
    [TestClass]
    public class HighscoreTest
    {
        private Highscore highscore;

        [TestInitialize]
        public void PreparePlayers()
        {
            this.highscore = new Highscore();
            for (int i = 0; i < Highscore.MaxPlayers + 10; i++)
            {
                highscore.AddPlayer(new Player(i.ToString(), i + 100));
            }
        }

        [TestMethod]
        public void AddPlayerShouldHaveNoMoreThanTenPlayers()
        {
            Assert.AreEqual(Highscore.MaxPlayers, this.highscore.Load().Count());
        }

        [TestMethod]
        public void AddPlayerShouldHaveOrderedByDescendingByPoints()
        {
            var points = this.highscore.Load().Select(p => p.Points).ToList();

            Assert.IsTrue(points.Any());

            var max = points.First();

            for (int i = 1; i < points.Count; i++)
            {
                var current = points[i];
                
                Assert.IsTrue(max >= current);

                max = current;

            }
        }
        
    }
}

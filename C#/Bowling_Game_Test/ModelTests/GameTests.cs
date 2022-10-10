using Bowling_Game.Model;
using NUnit.Framework;

namespace Bowling_Game_Test.ModelTests {
    public class GameTests {
        private Game game;

        [SetUp]
        public void Setup() {
            Player testPlayer = new Player();
            Lane testLane = new Lane();
            game = new Game(testPlayer, testLane);
        }

        [Test]
        public void Game_must_have_a_player_assigned() {
            Assert.IsNotNull(game.Player);
        }

        [Test]
        public void Game_must_have_a_lane_assigned() {
            Assert.IsNotNull(game.Lane);
        }
    }
}

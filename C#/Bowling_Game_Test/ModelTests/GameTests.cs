using Bowling_Game.Model;
using NUnit.Framework;

namespace Bowling_Game_Test.ModelTests {
    public class GameTests {
        private Game game;

        [SetUp]
        public void Setup() {
        }

        [Test]
        public void Game_must_have_a_player_assigned() {
            game = new Game();
            Player testPlayer = new Player();
            game.Player = testPlayer;
            Assert.IsNotNull(game.Player);
        }

        [Test]
        public void Game_must_have_a_lane_assigned() {
            game = new Game();
            Lane testLane = new Lane();
            game.Lane = testLane;
            Assert.IsNotNull(game.Lane);
        }
    }
}

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

        [Test]
        public void Score_must_be_zero_when_the_game_starts() {
            Assert.AreEqual(0, game.Score());
        }

        [Test]
        public void Lane_must_have_all_pins_up_when_the_game_starts() {
            Assert.AreEqual(10, game.Lane.GetPinsStanding());
        }
    }
}

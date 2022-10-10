using NUnit.Framework;
using Bowling_Game.Model;

namespace Bowling_Game_Test.ModelTests {
    class PlayerTest {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void Player_score_is_0_when_game_starts() {
            Player player = new Player();
            Assert.AreEqual(0, player.GetScore());
        }

        [Test]
        public void Player_score_increases_when_at_least_one_pin_is_knocked_down() {
            Player player = new Player();
            player.AddScore(1);
            Assert.AreEqual(1, player.GetScore());
        }
    }
}

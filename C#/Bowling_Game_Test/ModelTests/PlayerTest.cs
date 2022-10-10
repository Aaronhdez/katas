using NUnit.Framework;
using Bowling_Game.Model;

namespace Bowling_Game_Test.ModelTests {
    class PlayerTest {
        private Player player;

        [SetUp]
        public void Setup() {
            player = new Player();
        }

        [Test]
        public void Player_score_is_0_when_game_starts() {
            Assert.AreEqual(0, player.GetScore());
        }

        [Test]
        public void Player_score_increases_when_at_least_one_pin_is_knocked_down() {
            player.AddScore(1);
            Assert.AreEqual(1, player.GetScore());
        }

        [Test]
        public void Player_score_can_never_decrease() {
            player.AddScore(1);
            player.AddScore(-1);
            Assert.AreEqual(1, player.GetScore());
        }

        [Test]
        public void Player_score_can_never_increase_more_than_10_at_once() {
            player.AddScore(11);
            Assert.AreEqual(0, player.GetScore());
        }
    }
}

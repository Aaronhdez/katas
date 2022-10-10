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
    }
}

using NUnit.Framework;
using Bowling_Game.Model;

namespace Bowling_Game_Test.ModelTests {
    public class LaneTests {
        private Lane lane;

        [SetUp]
        public void Setup() {
            lane = new Lane();
        }

        [Test]
        public void Lane_has_10_pins_standing_when_created() {
            lane = new Lane();
            Assert.AreEqual(10, lane.GetPinsStanding());
        }
    }
}
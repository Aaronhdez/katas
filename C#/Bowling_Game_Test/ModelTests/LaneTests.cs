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
            Assert.AreEqual(10, lane.GetPinsStanding());
        }

        [Test]
        public void Lane_has_less_than_10_pins_standing_if_at_least_1_is_knocked_down() {
            lane.Remove(1);
            Assert.AreEqual(9, lane.GetPinsStanding());
        }

        [Test]
        public void Lane_cannot_have_more_than_10_pins_after_a_roll() {
            lane.Remove(-1);
            Assert.AreEqual(10, lane.GetPinsStanding());
        }

        [Test]
        public void Lane_cannot_have_negative_pins() {
            lane.Remove(11);
            Assert.AreEqual(10, lane.GetPinsStanding());
        }
    }
}
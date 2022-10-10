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

        [Test]
        public void Game_Should_Start_in_Frame_1() {
            Assert.AreEqual(1, game.FramesPlayed());
        }

        [Test]
        public void Frame_Should_Start_in_roll_0() {
            Assert.AreEqual(0, game.RollsPlayed());
        }

        [Test]
        public void RollsPlayed_should_increase_each_roll() {
            game.Roll(1);
            Assert.AreEqual(1, game.RollsPlayed());
        }

        [Test]
        public void RollsPlayed_not_be_higher_than_2() {
            for (int rolls = 0; rolls <= 2; rolls++) { 
                game.Roll(1);
            }
            Assert.AreEqual(1, game.RollsPlayed());
        }

        [Test]
        public void Frames_should_increase_each_two_rolls() {
            game.Roll(1);
            game.Roll(1);
            Assert.AreEqual(2, game.FramesPlayed());
        }

        [Test]
        public void Frames_should_increase_in_case_of_Strike() {
            game.Roll(10);
            Assert.AreEqual(2, game.FramesPlayed());
        }

        [Test]
        public void Lane_should_be_remove_pins_when_a_roll_is_done() {
            game.Roll(1);
            Assert.AreEqual(9, game.Lane.GetPinsStanding());
        }

        [Test]
        public void Lane_should_be_reloaded_when_frames_are_increased() {
            game.Roll(1);
            game.Roll(1);
            Assert.AreEqual(10, game.Lane.GetPinsStanding());
        }

        [Test]
        public void Lane_should_be_reloaded_after_a_strike() {
            game.Roll(10);
            Assert.AreEqual(10, game.Lane.GetPinsStanding());
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        [TestCase(10, 10)]
        public void Player_score_should_be_increase_on_each_roll(int pins, int expected) {
            game.Roll(pins);
            Assert.AreEqual(expected, game.Score());
        }

        [Test]
        public void Player_should_receive_a_double_bonus_if_an_strike_is_done() {
            game.Roll(10);
            Assert.AreEqual(2, game.GetCurrentBonus());
        }

        [Test]
        public void Score_should_be_increased_if_bonus_are_received() {
            game.Roll(10);
            game.Roll(1);
            game.Roll(1);
            Assert.AreEqual(14, game.Score());
        }

        [TestCase(0, 10, 1)]
        [TestCase(1, 9, 1)]
        [TestCase(2, 8, 1)]
        [TestCase(3, 7, 1)]
        [TestCase(4, 6, 1)]
        public void Player_should_receive_a_single_bonus_if_an_spare_is_done(
            int pins1, int pins2, int expected) {
            game.Roll(pins1);
            game.Roll(pins2);
            Assert.AreEqual(expected, game.GetCurrentBonus());
        }

    }
}

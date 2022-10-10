using System;

namespace Bowling_Game.Model {
    public class Game {
        private Player player;
        private Lane lane;
        private int framesPlayed;
        private int rollsPlayed;

        public Player Player { get => player; set => player = value; }
        public Lane Lane { get => lane; set => lane = value; }

        public Game() {
            framesPlayed = 1;
            rollsPlayed = 0;
        }

        public Game(Player player, Lane lane) {
            this.player = player;
            this.lane = lane;
            framesPlayed = 1;
            rollsPlayed = 0;
        }

        public void Roll(int pins) {
            if (pins == 10) {
                UpdateGameOnStrike();
            } else {
                UpdateGameOnNormalRoll();
            }
            UpdateRollsPlayed();
            UpdateFramesPlayed();
        }

        private void UpdateGameOnStrike() {
            rollsPlayed++;
        }

        private void UpdateGameOnNormalRoll() {
            throw new NotImplementedException();
        }

        private void UpdateRollsPlayed() {
            rollsPlayed = (rollsPlayed + 1) % 2;
        }

        private void UpdateFramesPlayed() {
            if (rollsPlayed == 0) {
                framesPlayed++;
            }
        }

        public int Score(){
            return player.GetScore();
        }

        public int FramesPlayed() {
            return framesPlayed;
        }

        public double RollsPlayed() {
            return rollsPlayed;
        }
    }
}

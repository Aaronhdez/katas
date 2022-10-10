using System;

namespace Bowling_Game.Model {
    public class Game {
        private Player player;
        private Lane lane;
        private int framesPlayed;
        private int rollsPlayed;
        private int bonus;

        public Player Player { get => player; set => player = value; }
        public Lane Lane { get => lane; set => lane = value; }

        public Game() {
            framesPlayed = 1;
            rollsPlayed = 0;
            bonus = 0;
        }

        public Game(Player player, Lane lane) {
            this.player = player;
            this.lane = lane;
            framesPlayed = 1;
            rollsPlayed = 0;
            bonus = 0;
        }

        public void Roll(int pins) {
            UpdateGameStatus(pins);
            UpdateRollsPlayed();
            UpdateFramesPlayed();
        }

        private void UpdateGameStatus(int pins) {
            lane.Remove(pins);
            UpdatePlayerScore(pins);
            if (ItsAStrike(pins)) {
                UpdateGameOnStrike();
            } else if (ItsASpare()) {
                UpdateGameOnSpare();
            } else { 
                UpdateGame(); 
            }
        }

        private void UpdatePlayerScore(int pins) {
            player.AddScore(pins);
            if (bonus > 0) {
                player.AddScore(pins);
                bonus--;
            }
        }

        private bool ItsAStrike(int pins) {
            return pins == 10 && rollsPlayed % 2 == 0;
        }

        private bool ItsASpare() {
            return Lane.GetPinsStanding() == 0 && rollsPlayed % 2 == 1;
        }

        private void UpdateGameOnStrike() {
            bonus = 2;
            rollsPlayed++;
        }

        private void UpdateGameOnSpare() {
            bonus = 1;
        }

        private void UpdateGame() {
        }

        private void UpdateRollsPlayed() {
            rollsPlayed = (rollsPlayed + 1) % 2;
        }

        private void UpdateFramesPlayed() {
            if (rollsPlayed == 0) {
                framesPlayed++;
                Lane.Reload();
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

        public int GetCurrentBonus() {
            return bonus;
        }
    }
}

using System;

namespace Bowling_Game.Model {
    public class Player {
        private int score;

        public Player() {
            score = 0;
        }

        public int GetScore() {
            return score;
        }

        public void AddScore(int points) {
            if (points >= 0) { 
                score += points;
            }
        }
    }
}

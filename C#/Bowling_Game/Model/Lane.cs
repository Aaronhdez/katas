using System;

namespace Bowling_Game.Model {
    public class Lane {
        private int pinsStanding;

        public Lane() {
            pinsStanding = 10;
        }
        public int GetPinsStanding(){
            return pinsStanding;
        }

        public void Remove(int pinsKnockedDown) {
            
        }
    }
}

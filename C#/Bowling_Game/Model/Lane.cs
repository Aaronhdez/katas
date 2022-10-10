using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Game.Model {
    public class Lane {
        private int pinsStanding;

        public Lane() {
            pinsStanding = 10;
        }
        public int GetPinsStanding(){
            return pinsStanding;
        }
    }
}

namespace Bowling_Game.Model {
    public class Game {
        private Player player;
        private Lane lane;

        public Player Player { get => player; set => player = value; }
        public Lane Lane { get => lane; set => lane = value; }

        public Game() {
        }

        public Game(Player player, Lane lane) {
            this.player = player;
            this.lane = lane;
        }

        public void Roll(int pins) {

        }

        public int Score(){
            return player.GetScore();
        }

    }
}

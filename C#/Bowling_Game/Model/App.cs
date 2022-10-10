using System;

namespace Bowling_Game.Model {
    class App {
        public static void Main(string[] args) {
            Player player = new Player();
            Lane lane = new Lane();
            Game game = new Game(player,lane);
            var rng = new Random();
            while (game.FramesPlayed() <= 10) {
                Console.Write("Frame: " + game.FramesPlayed() + ". ");
                var pinsKnockedDown = rng.Next(game.Lane.GetPinsStanding()+1);
                game.Roll(pinsKnockedDown);
                Console.WriteLine("Pins down: "+ pinsKnockedDown + ". Score: " + game.Score());
                Console.WriteLine("-----------");
            }
            Console.WriteLine("Final Score: "+game.Score());
            Console.ReadLine();
        }
    }
}

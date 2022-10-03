package app;

import model.Game;

import java.util.Random;

public class App {
    public static void main(String[] args) {
        Game bowlingGame = new Game();
        Random rng = new Random();
        for (int frame = 1; frame < 10; frame++) {
            int currentFrame = bowlingGame.getCurrentFrame();
            int roll = 0;
            while (currentFrame == bowlingGame.getCurrentFrame()){
                roll++;
                bowlingGame.roll(rng.nextInt(bowlingGame.getCurrentLane().getPinsStanding()+1));
                System.out.println("Frame "+frame+". Roll "+roll+". points:"+bowlingGame.score());
            }
        }
        System.out.println("Score: "+bowlingGame.score());
    }
}

package model;

public class Game {
    private Lane currentLane;
    private int score;

    public Game() {
        this.currentLane = new Lane();
    }

    public Lane getCurrentLane() {
        return currentLane;
    }

    public void roll(int pinsKockedDown){
        this.currentLane.roll(pinsKockedDown);
    }

    public int score(){
        return score;
    }
}

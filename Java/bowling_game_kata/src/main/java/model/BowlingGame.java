package model;

public class BowlingGame {
    private Lane currentLane;

    public BowlingGame() {
        this.currentLane = new Lane();
    }

    public Lane getCurrentLane() {
        return currentLane;
    }
}

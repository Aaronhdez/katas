package model;

public class Game {
    private final Player currentPlayer;
    private final Lane currentLane;
    private int currentFrame;

    public Game() {
        this.currentLane = new Lane();
        this.currentPlayer = new Player();
        this.currentFrame = 1;
    }

    public Lane getCurrentLane() {
        return currentLane;
    }

    public Player getCurrentPlayer() {
        return this.currentPlayer;
    }

    public void roll(int pinsKnockedDown){
        this.currentLane.roll(pinsKnockedDown);
        currentPlayer.addScore(pinsKnockedDown);
    }

    public int score(){
        return this.currentPlayer.getScore();
    }

    public int getCurrentFrame() {
        return currentFrame;
    }
}

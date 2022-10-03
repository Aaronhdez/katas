package model;

public class Game {
    private final Player currentPlayer;
    private final Lane currentLane;
    private int score;

    public Game() {
        this.currentLane = new Lane();
        this.currentPlayer = new Player();
    }

    public Lane getCurrentLane() {
        return currentLane;
    }

    public Player getCurrentPlayer() {
        return this.currentPlayer;
    }

    public void roll(int pinsKnockedDown){
        this.currentLane.roll(pinsKnockedDown);
    }

    public int score(){
        return this.currentPlayer.getScore();
    }
}

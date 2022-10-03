package model;

public class Game {
    private final Player currentPlayer;
    private final Lane currentLane;
    private int currentFrame;
    private int rollsPlayed = 0;

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
        rollsPlayed += 1;
        this.currentLane.roll(pinsKnockedDown);
        currentPlayer.addScore(pinsKnockedDown);

        updateFrameNumber();
    }

    private void updateFrameNumber() {
        if(rollsPlayed % 2 == 0 && currentFrame < 10){
            currentFrame += 1;
        }
    }

    public int score(){
        return this.currentPlayer.getScore();
    }

    public int getCurrentFrame() {
        return currentFrame;
    }
}

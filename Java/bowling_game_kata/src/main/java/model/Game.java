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

    public int getCurrentFrame() {
        return currentFrame;
    }

    public void roll(int pinsKnockedDown){
        currentLane.roll(pinsKnockedDown);
        currentPlayer.addScore(pinsKnockedDown);
        increaseRollsPlayed();
        managePoints(pinsKnockedDown);
        manageBonuses();
        updateFrameNumber();
    }

    private void manageBonuses() {
        if(isAStrike()){
            currentPlayer.setBonusRolls(2);
            increaseRollsPlayed();
            return;
        }
        if(isASpare()){
            currentPlayer.setBonusRolls(1);
            return;
        }
    }

    private void managePoints(int pinsKnockedDown) {
        if(currentPlayer.getBonusRolls() > 0) {
            currentPlayer.addBonus(pinsKnockedDown);
        }
    }

    private void increaseRollsPlayed() {
        rollsPlayed += 1;
    }

    private void updateFrameNumber() {
        if(rollsPlayed % 2 == 0 && currentFrame < 10){
            currentFrame += 1;
            currentLane.reloadLane();
        }
    }

    public int score(){
        return this.currentPlayer.getScore();
    }

    private boolean isAStrike() {
        return currentLane.getPinsStanding() == 0 && rollsPlayed % 2 == 1;
    }

    private boolean isASpare() {
        return currentLane.getPinsStanding() == 0 && rollsPlayed % 2 == 0;
    }
}

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
        manageBonuses(pinsKnockedDown);
        updateFrameNumber();
    }

    private void manageBonuses(int pinsKnockedDown) {
        if(isAStrike(pinsKnockedDown)){
            currentPlayer.setBonusRolls(2);
            increaseRollsPlayed();
        }
        /*if(isASpare()){
            currentPlayer.setBonusRolls(1);
            increaseRollsPlayed();
        }*/
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
        }
        currentLane.reloadLane();
    }

    public int score(){
        return this.currentPlayer.getScore();
    }

    private boolean isAStrike(int pinsKnockedDown) {
        return pinsKnockedDown == 10 && rollsPlayed % 2 == 1;
    }

    /*private boolean isASpare() {
        return currentLane.getPinsStanding() == 0
                && rollsPlayed % 2 == 0;
    }*/
}

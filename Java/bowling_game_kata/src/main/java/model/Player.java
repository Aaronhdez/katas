package model;

public class Player {
    private int score;

    private boolean strike;
    private int bonusRolls;

    public Player() {
        this.score = 0;
    }

    public int getScore() {
        return score;
    }

    public void addScore(int pinsKnockedDown) {
        this.score += pinsKnockedDown;
    }

    public void setBonusRolls(int bonusRolls) {
        this.bonusRolls = bonusRolls;
    }

    public int getBonusRolls() {
        return bonusRolls;
    }

    public void addBonus(int pinsKnockedDown) {
        if(bonusRolls > 0){
            bonusRolls -= 1;
            score += pinsKnockedDown;
        }
    }
}

package model;

public class Player {
    private int score;

    private boolean strike;

    public Player() {
        this.score = 0;
    }

    public int getScore() {
        return score;
    }

    public void addScore(int pinsKnockedDown) {
        this.score += pinsKnockedDown;
    }

    public void setStrike(boolean strike) {
        this.strike = strike;
    }

    public boolean getStrike() {
        return strike;
    }
}

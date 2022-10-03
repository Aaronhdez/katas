package model;

public class Lane {
    private int currentPinsStanding;


    public Lane() {
        this.currentPinsStanding = 10;
    }

    public int getPinsStanding() {
        return currentPinsStanding;
    }

    public void reloadLane() {
        this.currentPinsStanding = 10;
    }

    public void roll(int pinsKnockedDown) {
        if (pinsKnockedDown > currentPinsStanding || pinsKnockedDown < 0) {
            return;
        }
        currentPinsStanding -= pinsKnockedDown;
    }
}

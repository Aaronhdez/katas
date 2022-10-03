package model;

public class Lane {
    private int currentPinsStanding;


    public Lane() {
        this.currentPinsStanding = 10;
    }

    public int getPinsStanding() {
        return currentPinsStanding;
    }

    public void loadARound() {
        this.currentPinsStanding = 10;
    }
}

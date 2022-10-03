import model.BowlingGame;
import model.Lane;
import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.assertFalse;

public class BowlingGameTest {
    @Before
    public void setUp(){

    }

    @Test
    public void game_must_have_only_one_lane(){
        BowlingGame game = new BowlingGame();
        Lane currentLane = game.getCurrentLane();
        assertFalse(currentLane == null);
    }

}
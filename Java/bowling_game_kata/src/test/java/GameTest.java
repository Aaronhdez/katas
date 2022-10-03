import model.Game;
import model.Lane;
import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.assertFalse;

public class GameTest {
    @Before
    public void setUp(){

    }

    @Test
    public void game_must_have_only_one_lane(){
        Game game = new Game();
        Lane currentLane = game.getCurrentLane();
        assertFalse(currentLane == null);
    }

}

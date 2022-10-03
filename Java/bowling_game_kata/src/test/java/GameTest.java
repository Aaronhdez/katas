import model.Game;
import model.Lane;
import model.Player;
import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.assertEquals;
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

    @Test
    public void game_must_have_only_one_player(){
        Game game = new Game();
        Player currentPlayer = game.getCurrentPlayer();
        assertFalse(currentPlayer == null);
    }

    @Test
    public void game_sets_score_to_player_each_time_a_ball_is_rolled(){
        Game game = new Game();
        Player currentPlayer = game.getCurrentPlayer();
        game.roll(2);
        assertEquals(game.score(), 2);
    }

}

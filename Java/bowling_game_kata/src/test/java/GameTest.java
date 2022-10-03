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

    @Test
    public void frame_counter_should_be_increased_each_two_rolls(){
        Game game = new Game();
        game.roll(2);
        assertEquals(game.getCurrentFrame(), 1);
        game.roll(2);
        assertEquals(game.getCurrentFrame(), 2);
    }

    @Test
    public void player_should_receive_strike_status_if_a_strike_is_done(){
        Game game = new Game();
        game.roll(10);
        assertEquals(game.getCurrentPlayer().getStrike(), true);
    }

    @Test
    public void frame_should_increase_if_a_strike_is_done(){
        Game game = new Game();
        game.roll(10);
        assertEquals(game.getCurrentFrame(), 2);
    }

}

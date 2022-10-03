import model.Game;
import model.Lane;
import model.Player;
import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertFalse;

public class GameTest {
    private Game game;
    private Lane currentLane;
    private Player currentPlayer;

    @Before
    public void setUp(){
        game = new Game();
        currentLane = game.getCurrentLane();
        currentPlayer = game.getCurrentPlayer();
    }

    @Test
    public void game_must_have_only_one_lane(){
        assertFalse(currentLane == null);
    }

    @Test
    public void game_must_have_only_one_player(){
        assertFalse(currentPlayer == null);
    }

    @Test
    public void game_sets_score_to_player_each_time_a_ball_is_rolled(){
        game.roll(2);
        assertEquals(game.score(), 2);
    }

    @Test
    public void frame_counter_should_be_increased_each_two_rolls(){
        game.roll(2);
        assertEquals(game.getCurrentFrame(), 1);
        game.roll(2);
        assertEquals(game.getCurrentFrame(), 2);
    }

    @Test
    public void frame_should_increase_if_a_strike_is_done(){
        game.roll(10);
        assertEquals(game.getCurrentFrame(), 2);
    }

    @Test
    public void player_should_receive_strike_status_if_a_strike_is_done(){
        game.roll(10);
        assertEquals(game.getCurrentPlayer().getBonusRolls(), 2);
    }

    @Test
    public void player_should_receive_bonuses_if_a_strike_is_done(){
        game.roll(10);
        int scoreBeforeStrike = game.score();
        game.roll(2);
        game.roll(2);
        assertEquals(scoreBeforeStrike, 10);
        assertEquals(game.score(), 18);
    }

    @Test
    public void player_should_receive_bonuses_if_a_spare_is_done_on_two_rolls(){
        game.roll(9);
        game.roll(1);
        int scoreBeforeSpare = game.score();
        game.roll(2);
        game.roll(2);
        assertEquals(scoreBeforeSpare, 10);
        assertEquals(game.score(), 16);
    }

}

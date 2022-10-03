import model.Lane;
import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNotEquals;

public class LaneTest {
    private Lane lane;

    @Before
    public void setUp(){
        lane = new Lane();
    }

    @Test
    public void number_of_pins_is_10_on_each_round(){
        lane.reloadLane();
        int pinsStandingAfter = lane.getPinsStanding();
        assertEquals(10, pinsStandingAfter);
    }

    @Test
    public void number_of_pins_is_10_if_no_one_is_taken_down_after_first_roll(){
        lane.reloadLane();
        lane.roll(0);
        int pinsStandingAfter = lane.getPinsStanding();
        assertEquals(10, pinsStandingAfter);
    }

    @Test
    public void number_of_pins_is_less_than_10_if_any_pin_is_taken_down_after_a_roll(){
        lane.reloadLane();
        lane.roll(1);
        int pinsStandingAfter = lane.getPinsStanding();
        assertEquals(9, pinsStandingAfter);
    }


}

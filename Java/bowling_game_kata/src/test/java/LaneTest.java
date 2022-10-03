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
        lane.loadARound();
        int pinsStandingAfter = lane.getPinsStanding();
        assertEquals(10, pinsStandingAfter);
    }

    @Test
    public void number_of_pins_is_10_if_no_one_is_taken_down_after_first_roll(){
        lane.loadARound();
        int pinsStandingAfter = lane.getPinsStanding();
        lane.roll(0);
        assertEquals(10, pinsStandingAfter);
    }


}

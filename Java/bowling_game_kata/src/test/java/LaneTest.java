import model.Lane;
import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNotEquals;

public class LaneTest {
    @Before
    public void setUp(){

    }

    @Test
    public void number_of_pins_is_10_on_each_round(){
        Lane lane = new Lane();
        lane.loadARound();
        int pinsStandingAfter = lane.getPinsStanding();

        assertEquals(10, pinsStandingAfter);
    }

}

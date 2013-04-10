/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author 401
 */
public class BoxTest {
    Box box = new Box(10,20,30);
    public BoxTest() {
    }
    
    @BeforeClass
    public static void setUpClass() {
    }
    
    @AfterClass
    public static void tearDownClass() {
    }
    
    @Before
    public void setUp() {
    }
    
    @After
    public void tearDown() {
    }

    /**
     * Test of getWidth method, of class Box.
     */
    @Test
    public void testGetWidth() {
        System.out.println("getWidth");
        Box instance = box;
        double expResult = 10;
        double result = instance.getWidth();
        assertEquals(expResult, result, 10);
        // TODO review the generated test code and remove the default call to fail.
        //fail("The test case is a prototype.");
    }



    /**
     * Test of getHeight method, of class Box.
     */
    @Test
    public void testGetHeight() {
        System.out.println("getHeight");
        Box instance = box;
        double expResult = 20;
        double result = instance.getHeight();
        assertEquals(expResult, result, 20);
        // TODO review the generated test code and remove the default call to fail.
        //fail("The test case is a prototype.");
    }


    /**
     * Test of getDepth method, of class Box.
     */
    @Test
    public void testGetDepth() {
        System.out.println("getDepth");
        Box instance = box;
        double expResult =30;
        double result = instance.getDepth();
        assertEquals(expResult, result, 30);
        // TODO review the generated test code and remove the default call to fail.
       // fail("The test case is a prototype.");
    }



    /**
     * Test of bigBox method, of class Box.
     */
    @Test
    public void testBigBox() {
        System.out.println("bigBox");
        Box instance = box;
        boolean expResult = true;
        boolean result = instance.bigBox();
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        //fail("The test case is a prototype.");
    }
}

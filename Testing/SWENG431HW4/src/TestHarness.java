/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author 401
 */
public class TestHarness extends MyJUnit{
    boolean check (double red, double that){
        return false;
    }
    public static void main(String[] args){
        boolean th;
       
        T1 test = new T1();
        
        th = test.test();
        if (th)
            System.out.println("success");
        else
            System.out.println("failed");
        
 
    }
}

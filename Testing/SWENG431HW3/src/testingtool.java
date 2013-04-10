
import java.awt.AWTEvent;
import java.awt.Toolkit;

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author 401
 */
public class testingtool {
   
    public static void main(String[] args) throws Exception{
        Toolkit tk = Toolkit.getDefaultToolkit();
        MyAWTEventListener mawt = new MyAWTEventListener(args);
        tk.addAWTEventListener(mawt,AWTEvent.MOUSE_EVENT_MASK);
        
        
        
       // String str = args[0];
        MyGUI gui;
        gui = new MyGUI();
        gui.main(args);

        
        
    }
}

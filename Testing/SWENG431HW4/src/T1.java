/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author 401
 */
public class T1 implements testletIF{
    T1(){}
    @Override
    public boolean test() {
         Box box = new Box(10,20,30);
        return (box.getDepth()==30&&box.getHeight()==20&&box.getWidth()==10&&box.bigBox());
        //throw new UnsupportedOperationException("Not supported yet.");
    }

}

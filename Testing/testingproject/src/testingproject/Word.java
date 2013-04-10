/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package testingproject;

/**
 *
 * @author 401
 */
public class Word {
    private int x,l,y,w;
    Word(int x,int y,int w,int l){
        this.x = x;
        this.y =y;
        this.l =l;
        this.w = w;
        
    }

    /**
     * @return the x
     */
    public int getX() {
        return x;
    }

    /**
     * @return the l
     */
    public int getL() {
        return l;
    }

    /**
     * @return the y
     */
    public int getY() {
        return y;
    }

    /**
     * @return the w
     */
    public int getW() {
        return w;
    }
}

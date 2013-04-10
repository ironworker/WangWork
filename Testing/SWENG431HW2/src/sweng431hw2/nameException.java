/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package sweng431hw2;

/**
 *
 * @author 401
 */
public class nameException extends Exception{

    nameException(String name) {
        
            
            System.out.println("Name can only have 10 Charicters max!!!");
        
       // throw new UnsupportedOperationException("Name can have a maximum of 10 charicters");
    }

    nameException() {
        //throw new UnsupportedOperationException("Not yet implemented");
    }
    
}

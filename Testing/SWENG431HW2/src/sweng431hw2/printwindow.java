/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package sweng431hw2;
import javax.swing.JDialog; 
import java.awt.event.ActionListener;
import javax.swing.JPanel;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JButton;
import java.awt.event.ActionEvent;
import javax.swing.JTextField;
/**
 *
 * @author 401
 */
public class printwindow extends JDialog {
    private JPanel window = null;
    public printwindow(Integer age, String name){
        
        
        window = new JPanel();
        getContentPane().add(window);
        window.add(new JLabel(name));
        //window.add(new JTextField(name));
        window.add(new JLabel(age.toString()));
        pack();
        setVisible(true);
    }
}


import java.awt.AWTEvent;
import java.awt.event.AWTEventListener;
import java.awt.event.MouseEvent;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.DataInputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.io.Writer;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Vector;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JButton;
import javax.swing.JTextField;
import javax.swing.SwingUtilities;

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author 401
 */
class MyAWTEventListener implements AWTEventListener, Runnable {

    Ident ident;
    Vector v = new Vector();
    List<String> ins;
    List<String> outs;
    List<String> sum;
    List<Boolean> win;
    JTextField JTextField1, JTextField2, JTextField3;
    JButton button;
    Writer output;
    Thread t, p;
    String filename="C:\\Users\\401\\Documents\\NetBeansProjects\\SWENG431HW3\\src\\outputs.txt";
//    String[] args;
    String exp="", act="", equ="";
//    Boolean done = false;

    public MyAWTEventListener(String[] arg) throws FileNotFoundException, IOException {


        BufferedReader in = new BufferedReader(new InputStreamReader(new DataInputStream(new FileInputStream("C:\\Users\\401\\Documents\\NetBeansProjects\\SWENG431HW3\\src\\inputs.txt"))));
        String temp;
        temp = in.readLine();
        ins = Arrays.asList(temp.split("\t"));
        temp = in.readLine();
        outs = Arrays.asList(temp.split("\t"));
        temp = in.readLine();
        sum = Arrays.asList(temp.split("\t"));
        t = new Thread(this);
        


    }
//    public void results(){
//        ident = new Ident();
//        //ident.test(args);

//    }
    @Override
    public void eventDispatched(AWTEvent event) {
        if (event.getID() == MouseEvent.MOUSE_CLICKED) {
            v.add(event.getSource());
            if (event.getSource() instanceof JButton) {
                JTextField1 = (JTextField) v.get(0);;
                JTextField2 = (JTextField) v.get(1);
                JTextField3 = (JTextField) v.get(2);
                button = (JButton) v.get(3);
                File file = new File(filename);
                file.delete();
                t.start();
                
//                ident = new Ident();
//               ident.test(exp,act,equ);

            }
        } //throw new UnsupportedOperationException("Not supported yet.");
    }

    @Override
    public void run() {
        for (int i = 0; i < ins.size(); i++) {
            JTextField1.setText(ins.get(i));
            JTextField2.setText(outs.get(i));
            button.doClick();
            exp+=sum.get(i)+"\n";
            act+=JTextField3.getText()+"\n";

            try {
                
                output = new BufferedWriter(new OutputStreamWriter(new FileOutputStream(filename, true)));
            } catch (IOException ex) {
                Logger.getLogger(MyAWTEventListener.class.getName()).log(Level.SEVERE, null, ex);
            }
            try {
                //Integer temp = Integer.parseInt(ins.get(i))+Integer.parseInt(outs.get(i));
                if (JTextField3.getText().equals(sum.get(i))) {
                    equ+="TRUE\n";
                    output.append(ins.get(i) + " + " + outs.get(i) + " = " + sum.get(i) + "correct!!!\n");
                } else {
                    equ+="FALSE\n";
                    output.append(ins.get(i) + " + " + outs.get(i) + " = " + JTextField3.getText() + "FAIL!!!\n");
                }
            } catch (IOException ex) {
                Logger.getLogger(MyAWTEventListener.class.getName()).log(Level.SEVERE, null, ex);
            }
            try {
                output.close();
            } catch (IOException ex) {
                Logger.getLogger(MyAWTEventListener.class.getName()).log(Level.SEVERE, null, ex);
            }
           
        }
        appendText();
    }

    public void appendText() {
        SwingUtilities.invokeLater(new Runnable() {

            
        public void run() {
            ident = new Ident(exp,act,equ);
              ident.test();
              ident.set1(exp);
              ident.set2(act);
              ident.set3(equ);
            }
        });
    }
}
//
// 
//ident = new Ident();
//
// 
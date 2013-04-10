/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package testingproject;

import java.util.ArrayList;
import java.util.Vector;

/**
 *
 * @author 401
 */
public class WordList {
    Vector<Word []> words;
    private Word[] word = new Word[100];
    WordList(){
        
    }
    public Word getWord(int y, int x){
        return words.get(y[x]);
    }
    
    public void addWord(Word word){
        row = words.get(word.getY());
        words.add(row);
    }
}

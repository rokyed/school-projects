/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package hman;

/**
 *
 * @author 633-025471
 */
public class Hman {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
         java.awt.EventQueue.invokeLater(new Runnable(){
       public void run(){
           new HangmanFrame().setVisible(true);
       }
       
       });
    }
}

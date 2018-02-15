/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hman;

//import javax.swing.JButton;

import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.util.ArrayList;

import javax.swing.JButton;
import javax.swing.JOptionPane;


/**
 *
 * @author Andy
 */
public class KeyPad extends javax.swing.JPanel {

    /**
     * Creates new form KeyPad
     */
    ArrayList<JButton> buttons = new ArrayList<JButton>();
    Core mainCore;
    public KeyPad(Core core) {
        this.setSize(new Dimension(300,200));
        this.setMaximumSize(new Dimension(300,200));
     //   this.setLayout(new FlowLayout());
        initComponents();
        MakeKeys();
        SetButtons();
        mainCore = core;
        
    }
    public void MakeKeys(){
        String k = "";
       
        for( byte b = 97 ;b<123;b++){
           char c =(char) b; 
           
           JButton button = new JButton(c+"");
            button.setMnemonic(c);
           buttons.add(button);
           
        }
       
    }
    public void ResetKeys(){
         for(JButton bx : buttons){
             
                 bx.setEnabled(true);
        
             }
             this.repaint();
         this.validate();
    }
    
    public void SetButtons(){
         String k = "";
        for(JButton b : buttons){
           
            
            b.addActionListener(new java.awt.event.ActionListener() {
            @Override
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                buttonActionPerformed(evt);
            }
            });
            
            this.add(b,BorderLayout.CENTER);
            k+=b.getText()+" ";
            
        }
       
         // JOptionPane.showMessageDialog(this,k);
        this.repaint();
        this.validate();
    }
     private void buttonActionPerformed(java.awt.event.ActionEvent evt) { 
         JButton b =(JButton) evt.getSource();
         b.setEnabled(false);
         this.repaint();
         this.validate();
         //JOptionPane.showMessageDialog(this,b.getText());
         mainCore.ValidateLetter(b.getText());
         
    }  
   
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        setBackground(new java.awt.Color(255, 255, 153));
        setBorder(new javax.swing.border.MatteBorder(null));
    }// </editor-fold>//GEN-END:initComponents


    // Variables declaration - do not modify//GEN-BEGIN:variables
    // End of variables declaration//GEN-END:variables
}

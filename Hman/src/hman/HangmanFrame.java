/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hman;

import java.awt.BasicStroke;
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.Graphics2D;
import javax.swing.JOptionPane;
import java.util.Timer;
import java.util.*;

/**
 *
 * @author Andy
 */
public class HangmanFrame extends javax.swing.JFrame {

    /**
     * Creates new form HangmanFrame
     */
  Graphics2D g ;
    Core mainCore = new Core();
    Timer t;
    Timer t2;
   KeyPad k;
   
     TimerTask tx;
     TimerTask tx2;
    public HangmanFrame() {
        initComponents();
       // mainCore
        mainCore.SetPlayerName(JOptionPane.showInputDialog("Please enter your name."));
        k = new KeyPad(mainCore);
        mainCore.NewGame();
        g =  (Graphics2D) cvs.getGraphics();
        
       
         k.repaint();
        k.validate();
        k.setSize(jPanel1.getSize());
        this.jPanel1.add(k,BorderLayout.CENTER);
       this.setSize(new Dimension(400,400));
        this.repaint();
        this.validate();
        t = new Timer();
        t2= new Timer();
        t.schedule(
        tx = new TimerTask(){
             @Override
             public void run(){
                 run2();
            }
         } 
                 ,50,50
         );
        t2.schedule(
        tx2 = new TimerTask(){
             @Override
             public void run(){
                 tickk();
            }
        } 
                 ,1000,1000
         );
     
    }
    int fje= 0;
    public void tickk(){
       
    }
    public void draw(){
          int xCoord = cvs.getWidth()/3;
        int yCoord = cvs.getHeight()/3;
       
        g.clearRect(0,0,cvs.getWidth(),cvs.getHeight());
       
        g.setColor(Color.red);
        
      
        //base-----
        g.setColor(Color.BLACK);
        g.drawLine(xCoord, yCoord, xCoord+100, yCoord);
        g.drawLine(xCoord, yCoord, xCoord, yCoord*2);
        g.drawLine(0, yCoord*2, cvs.getWidth(), yCoord*2);
        g.setColor(Color.ORANGE);
        g.drawLine( xCoord+100, yCoord,xCoord+100,yCoord+20);
        //Head-----
        g.setColor(Color.BLACK);
        if(mainCore.GetMistakes()>0){
            if(mainCore.GetMistakes()>1){
                 if(mainCore.GetMistakes()>2){
                    if(mainCore.GetMistakes()>3){
                        g.drawString("HINT: "+mainCore.GetHint(), 0,cvs.getHeight()-40);
                        if(mainCore.GetMistakes()>4){
                            if(mainCore.GetMistakes()>5){
                                // left leg
                                g.drawLine( xCoord+100,yCoord+70,xCoord+95,yCoord+90);
                                g.drawLine( xCoord+95,yCoord+90,xCoord+95,yCoord+110);
                            }
                            // right leg
                             g.drawLine( xCoord+100,yCoord+70,xCoord+105,yCoord+90);
                             g.drawLine( xCoord+105,yCoord+90,xCoord+105,yCoord+110);
                        }
                        // left arm
                        g.drawLine( xCoord+100,yCoord+40,xCoord+94,yCoord+57);
                        g.drawLine( xCoord+94,yCoord+57,xCoord+85,yCoord+70); 
                    }
                    //right arm
                    g.drawLine( xCoord+100,yCoord+40,xCoord+106,yCoord+57);
                    g.drawLine( xCoord+106,yCoord+57,xCoord+115,yCoord+70); 
                }
                 //body
               g.drawLine( xCoord+100,yCoord+40,xCoord+100,yCoord+70);  
            } 
            //head+face
            g.drawOval(xCoord+90,yCoord+20, 20, 20);
             g.setStroke(new BasicStroke(1));
            g.drawLine( xCoord+95,yCoord+28,xCoord+98,yCoord+28);  
            g.drawLine( xCoord+102,yCoord+28,xCoord+105,yCoord+28);  
            g.drawLine( xCoord+97,yCoord+33,xCoord+103,yCoord+33);  
            
            
          
            
        }
        g.setStroke(new BasicStroke(2));
        g.setColor(Color.BLACK);  
        g.setFont(new Font("TimesRoman", Font.PLAIN, 15)); 
        g.drawString("QUESTION: "+mainCore.GetQuestion(), 0,20);  
        g.drawString("ANSWER: "+mainCore.GetShowingAnswer("_"),0,40);
        g.drawString("SCORE: "+mainCore.GetScore()+" points", 0,cvs.getHeight()-20);
        g.drawString("MISTAKES: "+mainCore.GetMistakes()+"/6", 0,cvs.getHeight());
       // g.copyArea(0,0,cvs.getWidth(),cvs.getHeight(),1,1);
        
    }
    public void run2() {
         draw();
        
       
        //cvs.validate();
       
        k.setSize(jPanel1.getSize());
       
       
        switch(mainCore.CheckWin()){
             case 0:
                 JOptionPane.showMessageDialog(this,"You lost!");

                 k.ResetKeys();
                 break;
             case 2:
                 JOptionPane.showMessageDialog(this,"Hey "+mainCore.GetPlayerName()+",you won with the marvelous score of : "+mainCore.GetScore()+" points!!");
                   k.ResetKeys();
                 break;
             default:
                 break;

         }
   } 
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel3 = new javax.swing.JPanel();
        cvs = new javax.swing.JPanel();
        jPanel1 = new javax.swing.JPanel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setMaximumSize(new java.awt.Dimension(787, 592));
        setMinimumSize(new java.awt.Dimension(787, 592));
        setResizable(false);

        jPanel3.setBorder(new javax.swing.border.MatteBorder(null));

        javax.swing.GroupLayout cvsLayout = new javax.swing.GroupLayout(cvs);
        cvs.setLayout(cvsLayout);
        cvsLayout.setHorizontalGroup(
            cvsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 619, Short.MAX_VALUE)
        );
        cvsLayout.setVerticalGroup(
            cvsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 456, Short.MAX_VALUE)
        );

        javax.swing.GroupLayout jPanel3Layout = new javax.swing.GroupLayout(jPanel3);
        jPanel3.setLayout(jPanel3Layout);
        jPanel3Layout.setHorizontalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 639, Short.MAX_VALUE)
            .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel3Layout.createSequentialGroup()
                    .addContainerGap()
                    .addComponent(cvs, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addContainerGap()))
        );
        jPanel3Layout.setVerticalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 478, Short.MAX_VALUE)
            .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel3Layout.createSequentialGroup()
                    .addContainerGap()
                    .addComponent(cvs, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addContainerGap()))
        );

        jPanel1.setBorder(new javax.swing.border.MatteBorder(null));

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 639, Short.MAX_VALUE)
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 86, Short.MAX_VALUE)
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addComponent(jPanel3, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jPanel3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    /**
     * @param args the command line arguments
     */
   

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JPanel cvs;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel3;
    // End of variables declaration//GEN-END:variables
}



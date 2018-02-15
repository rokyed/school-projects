/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hman;

/**
 *
 * @author Andy
 */
public class Question {
    public String Question = "";
    public String Answer = "";
    public String Hint = "";
    public Question(String question,String answer, String hint){
        Question = question;
        Answer = answer;
        Hint = hint;
    }
}

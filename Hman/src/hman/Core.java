/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hman;

import java.util.ArrayList;
import java.util.Random;


public class Core {
    public String playerName = "";
    public ArrayList<Question> questions = new ArrayList<Question>();
    public int QuestionNumber = 0;
    public int Mistakes =0;
    public int Score =0;
    public String ANSWER = "";
    public String Letters = "";
    public int LastCheck =0;
    
    public Core(){
        LoadQuestions();
        NewGame();
    }
    public void SetPlayerName(String player){
        if(player!= null){
            playerName = player;
        }
    
    } 
    public String GetPlayerName(){
        return playerName;
    
    }
    public void LoadQuestions(){
        String[] q = {"German matematician?","A tower in Paris?","Theory of black holes?",
            "Who introduced boolean algebra?","Tallest building in the world since 2010?","The capital of USA?","Smallest country in the world?",
        "Largest country in the world?","Country where Ottawa city is the capital?","Canadian winter sports-man,disciplined in moguls,who won 5 gold medals?!"};
        
        String[] a = {"Albert Enstein","Eiffel Tower","Stephen Hawking","George Boole",
            "Burj Khalifa","Washington DC","Vatican City","Russia","Canada","Alexandre Bilodeau"
        };
        
        String[] h = {"Hello Albert!!","Eiffel","Hey Stephen!!","Boolean",
            "Is in Dubai!!","Washington","Vatican","Russians are living there."
        ,"Always fresh ,always Tim Hortons!","Alexandre Bilooooooooooodeauuuuuuuuuuuu!!!!!!!!!!"};
        
        for(int i = 0; i<q.length;i++){
             Question qes = new Question(q[i],a[i],h[i]);
             questions.add(qes);
        }
       
       
       
    }
    
    public void ChooseQuestion(){
        Random r  = new Random();
        QuestionNumber = r.nextInt(questions.size());
        
        
    }
    public String GetHint(){
        return questions.get(QuestionNumber).Hint;
    }
    public int GetMistakes(){
        return Mistakes;
    }
    public int ValidateLetter(String letter){
        
        int letterRight = 1;// 0 is correct , 1 is wrong , 2 game over,3 win
        if(questions.get(QuestionNumber).Answer.toUpperCase().contains(letter.toUpperCase())){
            Letters += letter;
            letterRight = 0;
            Score++;
        }else{
            Score--;
            Mistakes++;
            if(Mistakes >=6 ){
               letterRight = 2;
            }else{
               letterRight = 1;  
            }
           
        }
        return letterRight;
    }
    public void NewGame(){
        Mistakes = 0;
        Letters = "";
        Score = 0;
        LastCheck = 1;
        ChooseQuestion();
    }
    public void NewRound(){
        Mistakes = 0;
        Letters = "";
        LastCheck = 1;
        ChooseQuestion();
    }
    public String GetQuestion(){
        return questions.get(QuestionNumber).Question;
    }
    public int GetScore(){
        return Score;
    }
    public String GetShowingAnswer(String specialChar){
        String answer="";
        for(int i=0;i<questions.get(QuestionNumber).Answer.length();i++){
            boolean letterMark = false;
            if(questions.get(QuestionNumber).Answer.charAt(i)==' '){
               letterMark=true;
               answer+=" ";
            }else{
                for(int u =0; u<Letters.length();u++){
                    if(Letters.toUpperCase().charAt(u)== questions.get(QuestionNumber).Answer.toUpperCase().charAt(i) ){
                        letterMark=true;
                        answer+= questions.get(QuestionNumber).Answer.charAt(i);
                    }    
                }
            }
            if(!letterMark ){
                answer+=specialChar;
            }
           
        }
        ANSWER = answer;
        return answer;
    }
    
    public int CheckWin(){
        int win = 1;// 0 lost , 1 not finised ,2 won
        
         if(Mistakes<6 ){
            
             if(!CheckAnswer()){
                 win = 1;
             }else{
                 NewRound();
                 win = 2;
             }
         }else{
             NewGame();
             win = 0;
         }
        LastCheck = win;
        return win;
        
    }
    
    public boolean CheckAnswer(){
        boolean correct = true;
         for(int i=0;i<questions.get(QuestionNumber).Answer.length();i++){
             if(questions.get(QuestionNumber).Answer.toUpperCase().charAt(i)!=' '){
                boolean foundLetter = false;
                 for(int u =0; u<Letters.length();u++){
                    if(Letters.toUpperCase().charAt(u)== questions.get(QuestionNumber).Answer.toUpperCase().charAt(i) ){
                       foundLetter =true;
                    }
                 }
                 if(!foundLetter){
                     correct = false;
                 }
             }
         }
        return correct;
        
    }
    
    
}

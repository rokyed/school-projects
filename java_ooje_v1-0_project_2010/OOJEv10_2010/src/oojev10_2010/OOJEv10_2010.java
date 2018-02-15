/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package oojev10_2010;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 *
 * @author 633-025471
 */
public class OOJEv10_2010 {
    public static Scanner scan = new Scanner(System.in);
    public static ArrayList<Payment> payments = new ArrayList<>();
    public static ArrayList<Employee> employees = new ArrayList<>();
    public static void main(String[] args) {
        // TODO code application logic here
      //test
        menu();
    }
    //menu
    public static void menu(){
        boolean loop = true;
        String input="";
        while(loop){
            FULLLINE();
            System.out.println("MENU");
            System.out.println("[e] Add employee");
            System.out.println("[p] Add payment");
            System.out.println("[m] List all employees");
            System.out.println("[n] List all payments");/*
            System.out.println("[o] See total overtime of all employees");
            System.out.println("[i] See total overtime of specific employees");
            System.out.println("[t] See total taxes of all employees");
            System.out.println("[r] See total taxes of specific employees");
            System.out.println("[k] See total pension of all employees");
            System.out.println("[l] See total pension of specific employees");
            System.out.println("[g] See total insurance of all employees");
            System.out.println("[h] See total insurance of specific employees");*/
            System.out.println("[x] Exit");
            input = scan.nextLine().toLowerCase();
            
            switch(input){
                case "e":
                    addEmployee();
                    break;
                case "p":
                    addPayment();
                    break;
                case "m":
                    listAllEmployees();
                    break;
                case "n":
                    listAllPay2();
                    break;
               /* case "o":
                    totalOvertime();
                    break;
                case "i":
                    specificOvertime();
                    break;
                case "t":
                    showTaxesForAll();
                    break;
                case "g":
                    showInsForEmployee();
                    break;
                case "h":
                    showInsForAll();
                    break;
                case "r":
                    showTaxesForEmployee();
                    break;
                case "k":
                    showPensionForAll();
                    break;
                case "l":
                    showPensionForEmployee();
                    break;*/
                case "x":
                    loop = false;
                    break;
                default:
                    input="";
                    break;
                
            }
        }
        System.out.println("Goodbye.");
        
    }
    
    // additions
    
    public static void addEmployee(){
         System.out.println("Please enter employee's number.");
         String empnumb = scan.nextLine();
         if(!empnumb.isEmpty()){
         if(!checkEmpNumber(empnumb)){
            System.out.println("Please enter employee's name.");
            String empname = scan.nextLine();
            System.out.println("Please enter employee's department.");
            System.out.println("1.Restaurant");
            System.out.println("2.Maintenance");
            System.out.println("3.Clerk/Landscapers");
            System.out.println("4.Sales");
            String empdep = scan.nextLine();
            try{
                byte dep = Byte.parseByte(empdep);
                if(dep >0 && dep < 5){
                    Employee emp = new Employee(empnumb,empname,dep);
                    employees.add(emp);
                }else{
                   System.out.println("No such department department.");  
                }
                
            }catch(Exception e){
                System.out.println("Something went wrong with your inserted data , please try again.");
            }
         }else{
           System.out.println("This employee is already in the database.");  
       
        }
         }else{
            System.out.println("Please fill out all data, don't skip like a cheater.");    
         }
    }
    public static void addPayment(){
         System.out.println("Please enter the week.(1 - 52)");
         String week = scan.nextLine();
         
         try{
         int week_no = Integer.parseInt(week);   
         if(week_no >0 && week_no<53){   
         System.out.println("Please enter employee's number.");
         String empnumb = scan.nextLine();
         if(checkEmpNumber(empnumb) && !checkPaymentMade(getEmpIDX(empnumb),week_no)){
             
             byte empdep = getEmpDep(empnumb);
             System.out.println("Please enter employee's hours.");
             String hrs = scan.nextLine();
            
             String sales ="0";
             if(empdep==4){
             System.out.println("Please enter employee's gross sales.");   
             sales= scan.nextLine();
            
             }

            double hours = Double.parseDouble(hrs);
            double saless = Double.parseDouble(sales);
            Payment p = new Payment(getEmpIDX(empnumb),hours,empdep,saless,week_no);
            payments.add(p);
            System.out.println("Payment succesfully inserted!");

             
         }else{
             System.out.println("No such employee's number or payment already made.");
         }
         }else{
             System.out.println("Wrong week only between 1 - 52.");
         }
         } catch (Exception e){
               System.out.println("Something went wrong with your inserted data , please try again.");
         }
    }
    // listings 
    public static void showTaxesForEmployee(){
         System.out.println("Please enter employee's number.");
         String empnumb = scan.nextLine();
          
         if(checkEmpNumber(empnumb)){
            System.out.println("All the taxes of this employee payments."); 
            double totalTax= 0;
            int empID = getEmpIDX(empnumb);
            for(Payment p:payments){
               if(p.employee_number == empID ){
                     System.out.println(MCELL("Week"+p.week)+CELL("Emp#: "+employees.get(p.employee_number).employee_number)+CELL("Name: "+employees.get(p.employee_number).employee_name)+CELL("Taxes: "+p.taxes));
                     totalTax += p.taxes;
               }
            }
            System.out.println("Total taxes of all payments of this employee are: "+totalTax);
         }else{
             System.out.println("No such employee's number.");
         }
    }
    public static void showTaxesForAll(){
        
         double overtime =0;
         for(Payment p:payments){
             
                    System.out.println(MCELL("Week"+p.week)+CELL("Emp#: "+employees.get(p.employee_number).employee_number)+CELL("Name: "+employees.get(p.employee_number).employee_name)+CELL("Taxes: "+p.taxes));
                   overtime += p.taxes;
           
         }
         System.out.println("Total taxes of all payments is: "+overtime);
    }
    public static void showPensionForEmployee(){
         System.out.println("Please enter employee's number.");
         String empnumb = scan.nextLine();
          
         if(checkEmpNumber(empnumb)){
            System.out.println("All the pensions of this employee payments."); 
            double totalTax= 0;
            int empID = getEmpIDX(empnumb);
            for(Payment p:payments){
               if(p.employee_number == empID ){
                     System.out.println(MCELL("Week"+p.week)+CELL("Emp#: "+employees.get(p.employee_number).employee_number)+CELL("Name: "+employees.get(p.employee_number).employee_name)+CELL("Pension: "+p.pension));
                     totalTax += p.pension;
               }
            }
            System.out.println("Total of all pensions of this employee are: "+totalTax);
         }else{
             System.out.println("No such employee's number.");
         }
    }
    public static void showPensionForAll(){
      
         double overtime =0;
         for(Payment p:payments){
             
                    System.out.println(MCELL("Week"+p.week)+CELL("Emp#: "+employees.get(p.employee_number).employee_number)+CELL("Name: "+employees.get(p.employee_number).employee_name)+CELL("Pension: "+p.pension));
                   overtime += p.pension;
           
         }
         System.out.println("Total of all pensions is: "+overtime);
    }
     public static void showInsForEmployee(){
         System.out.println("Please enter employee's number.");
         String empnumb = scan.nextLine();
          
         if(checkEmpNumber(empnumb)){
            System.out.println("All the insurance of this employee payments."); 
            double totalTax= 0;
            int empID = getEmpIDX(empnumb);
            for(Payment p:payments){
               if(p.employee_number == empID ){
                     System.out.println(MCELL("Week"+p.week)+CELL("Emp#: "+employees.get(p.employee_number).employee_number)+CELL("Name: "+employees.get(p.employee_number).employee_name)+CELL("Insurance: "+p.insurance));
                     totalTax += p.insurance;
               }
            }
            System.out.println("Total of all insurance of this employee are: "+totalTax);
         }else{
             System.out.println("No such employee's number.");
         }
    }
    public static void showInsForAll(){
      
         double overtime =0;
         for(Payment p:payments){
             
                    System.out.println(MCELL("Week"+p.week)+CELL("Emp#: "+employees.get(p.employee_number).employee_number)+CELL("Name: "+employees.get(p.employee_number).employee_name)+CELL("Pension: "+p.pension));
                   overtime += p.pension;
           
         }
         System.out.println("Total of all insurance is: "+overtime);
    }
    public static void listAllEmployees(){
         System.out.println(CELL("EMPLOYEE NUMBER")+CELL("NAME")+CELL("DEPARTMENT"));
         for(Employee e : employees){
         String department = "";
         switch (e.department){
             case 1:
                 department = "Restaurant";
                 break;
             case 2:
                  department = "Maintenance";
                 break;
             case 3:
                  department = "Clerk/Landscapers";
                 break;
             case 4:
                  department = "Sales";
                 break;
         }
          System.out.println(CELL(e.employee_number)+CELL(e.employee_name)+CELL(department));
         }
    }
    public static void listAllPay(){
         System.out.println(MCELL("WEEK")+CELL("EMPLOYEE NUMBER")+MCELL("HOURS")+MCELL("SALES*")+MCELL("GROSS")+MCELL("TAXES")+MCELL("PENSION")+MCELL("INSURANCE")+MCELL("OVERTIME")+MCELL("OVER HOURS"));
         for(Payment e : payments){
         String over = "";
         if(e.hoursExtra>0){
             over = "X";
         }
          System.out.println(MCELL(""+e.week)+CELL(employees.get(e.employee_number).employee_number)+MCELL(e.hoursMade+"")+MCELL(e.grosssales+"")+MCELL(e.gross+"")+MCELL(e.taxes+"")+MCELL(e.pension+"")+MCELL(e.insurance+"")+MCELL(over)+MCELL(e.hoursExtra+""));
         }
    }
    
    public static void listAllPay2(){
         int wCount= 1;
         double hrs = 0;
         double gro = 0;
         double sal = 0; 
         double tax = 0;
         double ins = 0;
         double pen = 0;
         double net = 0;
         for(int e = 0 ; e <employees.size();e++){
             String dep = "";
             switch(employees.get(e).department){
                  case 1:
                 dep = "Restaurant";
                 break;
             case 2:
                  dep = "Maintenance";
                 break;
             case 3:
                  dep = "Clerk/Landscapers";
                 break;
             case 4:
                  dep = "Sales";
                 break;
             }
             System.out.println(MCELL("NAME:")+CELL(employees.get(e).employee_name)+MCELL("#:")+CELL(employees.get(e).employee_number)+MCELL("DEP:")+CELL(dep));
             System.out.println(MCELL("WEEK")+CELL("EMPLOYEE NUMBER")+MCELL("HOURS")+MCELL("SALES*")+MCELL("GROSS")+MCELL("TAXES")+MCELL("PENSION")+MCELL("INSURANCE")+MCELL("NET")+MCELL("OVERTIME")+MCELL("TIME OVER"));
             for(int w = 1 ; w<=52;w++){
                 for(Payment p :payments){
                     if( p.employee_number == e && p.week ==w){
                        String overtime = (p.hoursExtra>0)?"X":"";
                        String overt = (p.hoursExtra>0)?p.hoursExtra+"":"";
                        System.out.println(MCELL(""+p.week)+CELL(employees.get(e).employee_number)+MCELL(p.hoursMade+"")+MCELL(p.grosssales+"")+MCELL(p.gross+"")+MCELL(p.taxes+"")+MCELL(p.pension+"")+MCELL(p.insurance+"")+MCELL(p.net+"")+MCELL(overtime)+MCELL(overt));
                        hrs+=p.hoursMade;
                        gro+=p.gross;
                        sal+=p.grosssales;
                        tax+=p.taxes;
                        ins+=p.insurance;
                        pen+=p.pension;
                        net+=p.net;
                     
                     }      
                 }
                 if(wCount == 4 ){
                    if(employees.get(e).department ==4 && hrs !=0 && net !=0){
                    
                   
                        System.out.println("MONTLY:");
                       System.out.println(MCELL("")+CELL(employees.get(e).employee_number)+MCELL(hrs+"")+MCELL(sal+"")+MCELL(gro+"")+MCELL(tax+"")+MCELL(pen+"")+MCELL(ins+"")+MCELL(net+""));
                      FULLLINE();
                       
                        
                    }
                    wCount=1;
                     hrs=0;
                    gro=0;
                    sal=0;
                    tax=0;
                    ins=0;
                    pen=0;
                    net=0;
                 }
                 wCount++;
            }
         
          //System.out.println(MCELL(""+e.week)+CELL(employees.get(e.employee_number).employee_number)+MCELL(e.hoursMade+"")+MCELL(e.grosssales+"")+MCELL(e.gross+"")+MCELL(e.taxes+"")+MCELL(e.pension+"")+MCELL(e.insurance+"")+MCELL(over)+MCELL(e.hoursExtra+""));
         }   
    }
    
    public static void totalOvertime(){
         System.out.println("Every employee with overtime will be listed here:");
         double overtime =0;
         for(Payment p:payments){
             if(p.hoursExtra != 0){
                    System.out.println(MCELL("Week"+p.week)+CELL("Emp#: "+employees.get(p.employee_number).employee_number)+CELL("Name: "+employees.get(p.employee_number).employee_name)+CELL("Over: "+p.hoursExtra));
                   overtime += p.hoursExtra;
             }
         }
         System.out.println("Total overtime of all payments is: "+overtime);
    }
    public static void specificOvertime(){
         System.out.println("Please enter employee's number.");
         String empnumb = scan.nextLine();
          
         if(checkEmpNumber(empnumb)){
            System.out.println("All the overtime of this employee payments."); 
            double totalOver= 0;
            int empID = getEmpIDX(empnumb);
            for(Payment p:payments){
               if(p.hoursExtra != 0 && p.employee_number == empID ){
                     System.out.println(MCELL("Week"+p.week)+CELL("Emp#: "+employees.get(p.employee_number).employee_number)+CELL("Name: "+employees.get(p.employee_number).employee_name)+CELL("Over: "+p.hoursExtra));
                     totalOver += p.hoursExtra;
               }
            }
            System.out.println("Total overtime of all payments is: "+totalOver);
         }else{
             System.out.println("No such employee's number.");
         }
    }
    //checkups and data gather
    public static int getEmpIDX(String empnumber){
         int idx =-1;
        for(int i=0 ; i < employees.size();i++){
         if(employees.get(i).employee_number.equals(empnumber)){
             idx=i;
             break;
         } 
       }
        return idx;
    }
    public static byte getEmpDep(String empnumber){
         byte found = 0;
       for(Employee e : employees){
         if(e.employee_number.equals(empnumber)){
             found = e.department;
             break;
         } 
       }
       return found;
    }
    public static boolean checkEmpNumber(String empnumber){
       boolean found = false;
       for(Employee e : employees){
         if(e.employee_number.equals(empnumber)){
             found = true;
             break;
         } 
       }
       return found;
    }
    public static boolean checkPaymentMade(int empIDX,int week){
        boolean found = false;
       for(Payment e : payments){
         if(e.employee_number==empIDX && e.week== week){
             found = true;
             break;
         } 
       }
       return found; 
    }
    // content organise
    public static String CELL(String content ){
        return ((content+ "                                                                   ").substring(0,20)+" ");
    }
    public static String MCELL(String content ){
        return ((content+ "                                                                   ").substring(0,10)+" ");
    }
     public static String MLINE( ){
        return ("-------------------------------------------------------------------").substring(0,11);
    }
     public static String LINE(){
        return ("-------------------------------------------------------------------").substring(0,21);
    }
     public static void FULLLINE(){
         System.out.println(MLINE()+LINE()+MLINE()+MLINE()+MLINE()+MLINE()+MLINE()+MLINE()+MLINE()+MLINE()+MLINE());
     }
    
    //------------------ full salary calculation.----------------------
  
    
}

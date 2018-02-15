/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package oojev10_2010;

/**
 *
 * @author John
 */
public class Payment {
    public int employee_number;
    public double hoursMade;
    public double hoursNormal;
    public double hoursExtra;
    public double gross;
    public double taxes;
    public double pension;
    public double insurance;
    public double net;
    public double grosssales;
    public int week;
    
    public Payment(int emp_number,double hours , byte department, double sales,int week_no){
        employee_number = emp_number;
        week = week_no;
        grosssales = sales;
        hoursMade = hours;
        if(hoursMade > 44 && department !=4){
            hoursExtra = hoursMade - 44;
            hoursNormal= 44;
        }else{
            if(hoursMade>44){
                hoursExtra = 0;
                hoursNormal = 44;
            }else{
                hoursExtra = 0;
                hoursNormal = hoursMade;
            }
        }
        gross = CalcGrossSalary(hours,sales,department);
        taxes = CalculateTax();
        pension = CalculatePension();
        insurance = CalculateEmploymentInsurance();
        net = CalculateNetSalary(hours,sales,department);
    }
    
    public double CalculateTax(){
        return  gross *(0.16+0.0605);
    } 
    public double CalculateEmploymentInsurance(){
        return ( gross *0.0198)+ (gross *0.0277);
    }
    public double CalculatePension(){
        return gross*0.0495;
    }
    public double CalculateNetSalary(double hours,double sales, byte department){
       double net = 0;
        double gross = CalcGrossSalary(hours,sales,department);
        net = gross - (taxes+pension+insurance);
        return net;
    }       
    public double CalcGrossSalary(double hours , double sales,byte department){
        double[] depSalary= new double[]{0,8.5,12.50,15.75,15};// hourly rates here
        double grossSalary = 0;
        double hoursPay = 0;
        double comission=0;
        if(department != 4){
            hoursPay = (depSalary[department]*1.5*hoursExtra)+(depSalary[department]*hoursNormal);
        }else{
            hoursPay = depSalary[department]*hoursNormal;
        }
        if(department ==4 ){
            if ( sales > 7000){
               comission = sales * 0.05; 
            }else if(sales >4250){
                comission = sales * 0.025; 
            }else if(sales >2500){
               comission = sales * 0.015;  
            }
        }
        grossSalary = hoursPay + comission;
        return grossSalary;
        
    }
}

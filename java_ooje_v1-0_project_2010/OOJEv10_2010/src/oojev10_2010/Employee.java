/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package oojev10_2010;

/**
 *
 * @author 633-025471
 */
public class Employee {
   public String employee_number = "";
   public String employee_name = "";
   public byte department = 0;// not asigned
    public Employee(String number, String name , byte department_in){
        employee_number = number;
        employee_name=name;
        department = department_in;
    }
}

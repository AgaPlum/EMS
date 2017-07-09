/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package simpleloop;
import java.util.Scanner;
/**
 *
 * @author Śliwka
 */
public class SimpleLoop {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner scan = new Scanner(System.in);
        int text;
    do{
        System.out.println("-------------------------------------------------");
        System.out.println("Menu");
        System.out.println("Choose what operation you want to do:");
        System.out.println("1. Show numbers");
        System.out.println("2. Operations on numbers");
        System.out.println("3. End the program");  
        System.out.println("-------------------------------------------------");
        try {
            text = Integer.parseInt(scan.nextLine());
            } 
        catch (NumberFormatException e) {
            System.out.println("This is not a number!");
            text = 0;
            }
        if(text==1)
        {
            int [] num ={5, 10, 15, 22 }; 
            for(int z:num)
             {
                System.out.println(z+",");
             }
        }
        else if(text==2)
        {
            int d=5+15;
            int b=d-5;
            int p=d*b;
            System.out.println("Sum:"+d);
            System.out.println("Difference:"+b);
            System.out.println("Multiplication:"+p);
            System.out.println("Division:"+(p/d));
        }
        else if (text==3)
        {
            System.out.println("Close the program");
        }
        else
        {
            System.out.println("Choose one more time");
        }
        }while(text!=3);
        System.out.println("Goodby");
                
    }
    
}

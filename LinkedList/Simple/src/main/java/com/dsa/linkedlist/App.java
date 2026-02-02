package com.dsa.linkedlist;

import java.util.Scanner;

public class App 
{
    public static void main( String[] args )
    {
      UIManager mgr=new UIManager();


      LinkedList list=new LinkedList();
        int choice;
        int data;  
        Scanner input=new Scanner(System.in);
    
        do { 
            mgr.showMenu();
            choice=mgr.getChoice();

            switch(choice){

                case 1:
                    {
                        System.out.println("Enter the data  : ");
                        data=input.nextInt();
                        list.insert(data);
                    } 
                break;

                case 2:{
                        System.out.println("Enter the data  : ");
                        data=input.nextInt();
                        list.remove(data);
                    } 
                break;

                case 3: {
                        System.out.println("Enter the data  : ");
                        data=input.nextInt();
                        boolean status=list.search(data);
                        System.out.println(status);
                    } 
                break;

                case 4: list.display();
                break;

                default: System.out.println("You choose to exit");
                break;
            }
        } while (choice!=5);
        
    }
    
    }


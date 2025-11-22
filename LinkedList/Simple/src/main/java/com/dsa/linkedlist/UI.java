package com.dsa.linkedlist;

 import java.util.Scanner;

// public class UI{

//     public void linkedListOperation(){

//         int choice;
//         int data;
//         LinkedList ll=new LinkedList();

//         System.out.println("1) Insert the data");
//         System.out.println("2) Remove an element");
//         System.out.println("3) Search an Element");
//         System.out.println("4) Display the data");
//         System.out.println("5) Exit");
//         System.out.println("Enter your choice : ");

//         Scanner input=new Scanner(System.in);
//         choice=input.nextInt();

//         System.out.println("Enter the data on which you want to perform the operation : ");
//         data=input.nextInt();


//             switch(choice){
//                 case 1:
//                     {
//                         ll.insert(data);
//                     }

//                 case 2:
//                     {
//                         ll.remove(data);
//                     }

//                 case 3:
//                     {
//                         ll.search(data);
//                     }
                
//                 case 4:
//                     {
//                         ll.display();
//                     }

//                 default:
//                     {
//                         System.out.println(" !!! You choose to exit !!! ");
//                     }
//             }
//         }
       

//     }

public class UI{

    public void uifunction(){
        LinkedList list=new LinkedList();
        Scanner input=new Scanner(System.in);
        int choice;
        int data;  
    
        do { 
            System.out.println("1) Insert the data");
            System.out.println("2) Remove an element");
            System.out.println("3) Search an Element");
            System.out.println("4) Display the data");
            System.out.println("5) Exit");
            System.out.println("***********************************");
            System.out.println("Enter your choice : ");
            choice=input.nextInt();

            

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
                        list.search(data);
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
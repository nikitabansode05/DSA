package com.dsa.linkedlist;

public class LinkedList {
    
    Node startNode;

    public LinkedList(){
        startNode.data=0;
        startNode.next=null;
    }

    public LinkedList(int data){
        startNode=new Node(data);
    }

    public void insert(int data){

        Node newNode=new Node(data);

        if(startNode==null){
            startNode=newNode;
        }

        Node current=startNode;

        while(current.next !=null){
            current=current.next;
        }

        current.next=newNode;
    }

    public void delete(int data){
        Node current=startNode;
        
           while (current.next!=null) { 
           System.out.println(current.data);
            Node previous=current;
            current=current.next;
            if(current.data==data){
                System.out.println(previous.data);
                previous.next=current.next;
                current=null;
                return;
            }
           }
    }

    public void search(int data){
        Node current=startNode;
        int count=1;
        while(current.next!=null){
            current=current.next;
            count++;
            if(current.data==data){
                System.out.println("Your data is : "+data+" at position : "+count);
            }
        }
    }


    public void display(){
        System.out.println("**********************************************************");
        Node current=startNode;
        while(current !=null){
            System.out.println(current.data);
            current=current.next;
        }
        System.out.println("**********************************************************");
    }
    
}

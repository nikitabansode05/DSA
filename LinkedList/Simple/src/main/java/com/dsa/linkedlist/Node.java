package com.dsa.linkedlist;

public class Node{
    
    int data;
    Node next;
    

    public Node(){
        data=0;
        next=null;
        
    }

    public Node(int data){
        this.data=data;
        next=null; 
    }

    public void display(){
        System.out.println(this.data);
    }
}
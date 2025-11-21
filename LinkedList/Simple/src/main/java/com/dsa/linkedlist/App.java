package com.dsa.linkedlist;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args )
    {
       LinkedList ll=new LinkedList();
       ll.insert(1);
       ll.insert(2);
       ll.insert(3);
       ll.insert(45);
       ll.insert(67);

       ll.display();
       ll.search(2);
       ll.remove(1);
       ll.display();
       
    }
}

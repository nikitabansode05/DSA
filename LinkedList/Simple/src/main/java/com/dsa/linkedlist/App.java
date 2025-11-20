package com.dsa.linkedlist;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args )
    {
       LinkedList ll=new LinkedList(0);
       ll.insert(1);
       ll.insert(2);
       ll.insert(3);
       ll.insert(45);
       ll.insert(67);

       ll.display();
       ll.delete(2);
       ll.display();
       ll.search(45);
    }
}

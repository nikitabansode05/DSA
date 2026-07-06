using System.Net.Http.Headers;

public class LinkedList
{
    public Node head{get;set;}

    public void insertfromFront(int data)
    {
        if (head == null)
        {
            head = new Node();
            head.data=data;
            head.next=null;
            head.previous=null;
        }
        else
        {
            Node newNode=new Node();
            Node shuffle=new Node();
            shuffle=head;
            newNode.data=data;
            newNode.next=shuffle;
            head=newNode;
            head.previous=null;
            shuffle=null;
        }
    }

    public void delete(int data)
    {
        if (data == head.data)
        {
            head=head.next;
            head.previous=null;
        }
        else{
            Node current=head;
            while (current != null)
            {
                if (current.data == data)
                {
                    if(current.next == null)
                    {
                        current.previous.next=null;
                        break;
                    }
                    else
                    {
                        current.previous.next=current.next;
                        current.next.previous=current.previous;
                        // current.previous=null;
                        // current.next=null;
                        break;
                    }
                    
                }                
                current=current.next;
            }
        }

    }

    public void update(int previousData,int newData)
    {
        Node current=head;
        while (current != null)
        {
            if (current.data == previousData)
            {
                current.data=newData;
                break;
            }
            current=current.next;
        }
    }

    public void insertfromBack(int data)
    {
        if (head == null)
        {
            head = new Node();
            head.data=data;
            head.next=null;
            head.previous=null;
        }
        else
        {
            Node newNode=new Node();
            newNode.data=data;
            Node current=head;
            while (current.next != null)
            {
                current=current.next;
            }
            current.next=newNode;
            newNode.previous=current;
            newNode.next=null;
        }
    } 

    public void display()
    {
        Node current=head;
        while (current != null)
        {
            Console.Write(current.data+"->");
            current=current.next;
        }
        Console.WriteLine();
    }
}
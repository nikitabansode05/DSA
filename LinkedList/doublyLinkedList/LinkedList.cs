using System.Net.Http.Headers;
public class LinkedList
{
    public Node head{get;set;}
    public Node tail{get;set;}

    public void insertfromFront(int data)
    {
        if (head == null)
        {
            head = new Node();
            head.data=data;
            head.next=null;
            head.previous=null;
            tail=head;
        }
        else
        {
            Node newNode=new Node();
            
            newNode.data=data;
            newNode.next=head;
            newNode.previous=null;
            head.previous=newNode;
            head=newNode;
            Node current=head;
            while (current != null)
            {
                if (current.next == null)
                {
                    tail=current;
                    break;
                }
                current=current.next;
            }
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
            tail=head;
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
            tail=newNode;
        }
    } 

    public void displayfromFront()
    {
        Node current=head;
        Console.WriteLine("Displaying from front");
        while (current != null)
        {
            Console.Write(current.data+"->");
            current=current.next;
        }
        Console.WriteLine();
    }

    public void displayfromBack()
    {
        Node current=tail;
        Console.WriteLine("Displaying from back");
        while (current!= null)
        {
            Console.Write(current.data+"->");
            current=current.previous;
        }
        Console.WriteLine();
    }
}
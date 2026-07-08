public class LinkedList
{
    public Node head{get;set;}

    public LinkedList(){
        head=null;
    }

    public void insert(int data)
    {
        if (head == null)
        {
            head.data=data;
            head.next=head;
        }
        else
        {
            Node current=head;
            Node newNode=new Node();
            while (current.next != head)
            {
                current=current.next;
            }
            newNode.data=data;
            newNode.next=head;
            current.next=newNode;
        }
    }

    public void update(int oldData,int newData)
    {
        Node current=head;
        while (current.next != head)
        {
            if (current.data == oldData)
            {
                current.data=newData;
                break;
            }
            current=current.next;
        }
    }

    public void delete(int data)
    {
        if (head.next == head)
        {
            head=null;
        }
        else
        {
            Node current=head;
            while (current.next != head)
            {
                if (head.data == data)
                {
                    head.next=head;
                }
            }
        }
    }

    public void display()
    {
        
    }
}
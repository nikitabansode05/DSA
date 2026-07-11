public class Queue
{
    public Node head{get;set;}

    public Queue()
    {
        head=null;
    }

    public void insert(int data)
    {
        if(head==null){
            head=new Node();
            head.data=data;
            head.next=null;
        }else{
            Node current=head;
            while(current.next!=null){
                current=current.next;
            }
            Node newNode=new Node();
            newNode.data=data;
            current.next=newNode;
            newNode.next=null;
        }
    }

    public void update(int oldData,int newData)
    {
        Node current=head;
        while (current != null)
        {
            if (current.data == oldData)
            {
                current.data=newData;
                break;
            }
            current=current.next;
        }
    }

    public void delete()
    {
       head=head.next; 
    }
    
    public void display()
    {
        Node current=head;
        while(current!=null){
            Console.Write(current.data+" ");
            current=current.next;
        }
        Console.WriteLine();
    }

}
public class LinkedList{

    public Node head{get;set;}

    public LinkedList(){
        head=null;
    }

    public LinkedList(Node head){
        this.head=head;
    }

    public void insert(int data){
        if(head==null){
            head=new Node();
            head.data=data;
            head.next=null;
        }
        else{
            Node current=head;
            while(current.next!=null){
                current=current.next;
            }
            Node node=new Node();
            node.data=data;
            node.next=null;
            current.next=node;
        }
    }

    public void display(){
        Node current=head;
        while(current!=null){
            Console.Write(current.data+" ");
            current=current.next;
        }
    }

    public void update(){
        Console.WriteLine("\nEnter the number to update :");
        int number= int.Parse(Console.ReadLine());
        Console.WriteLine("\nEnter the number to update with :");
        int newNumber= int.Parse(Console.ReadLine());

        Node update=head;
        while(update!=null){
            if(update.data==number){
                update.data=newNumber;
            }
            update=update.next;
        }
    }

    public void delete(){
        Console.WriteLine("Enter the number to delete : ");
        int number=int.Parse(Console.ReadLine());

        Node current=head;
        while(current.next!=null){
            if(current.next.data==number){
                current.next=current.next.next;
            }
            current=current.next;
        }

    }
}
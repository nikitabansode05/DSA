public class LinkedList{

    public Node head{get;set;}

    public LinkedList(){
        head=null;
    }

    public LinkedList(Node head){
        this.head=head;
    }

    public Node create(){
        Console.WriteLine("Enter the number of nodes to create :");
        int number=int.Parse(Console.ReadLine());

        Node current=head;
        Node next=new Node();
        for(int i=0;i<number;i++){
            Console.WriteLine("\nEnter the data in the list :");
            int data=int.Parse(Console.ReadLine());
            current.data=data;
            current=current.next;
        }

        return head;
    }

    public void update(){
        Console.WriteLine("Enter the number to update :");
        int number= int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number to update with :");
        int newNumber= int.Parse(Console.ReadLine());

        Node update=head;
        while(update!=null){
            if(update.data==number){
                update.data=newNumber;
            }
            Console.Write(update.data+" ");
            update=update.next;
        }
    }

   

    // public void delete(int data){
    //     Console.WriteLine("\nEnter the node to delete : ");
    //     int deleteNumber=int.Parse(Console.ReadLine());

    //     Node temporary=head;
    //     Node newList=new Node();

    //     while(temporary!=null){
    //         if(temporary.data==deleteNumber){
    //             if(temporary.previous==null){
    //                 newList=temporary.next;
    //                 newList.previous=null;
    //             }else{
    //                 Node afterDelete=temporary.previous;
    //                 afterDelete.next=temporary.next;
    //             }
    //         }
    //         // Console.WriteLine(newList.data);
    //         // newList=newList.next;
    //         temporary=temporary.next;
    //     }

    //     Console.WriteLine("After deletion");
    //     Node display=head;
    //     while(display!=null){
    //         Console.Write(display.data+" ");
    //         display=display.next;
    //     }

    // }

    public void insert(int data){

    }
}
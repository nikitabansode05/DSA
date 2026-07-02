public class Program{
    
    public static void Main(){

        Node node1=new Node();
        Node node2=new Node();
        Node node3=new Node();
        Node node4=new Node();
        Node node5=new Node();
       
        node1.data=3;
        node1.next=node2;

        node2.data=2;
        node2.next=node3;

        node3.data=7;
        node3.next=node4;

        node4.data=5;
        node4.next=node5;
        
        node5.data=0;
        node5.next=null;

        LinkedList linkedList=new LinkedList();
        //linkedList.delete(node1);
        Node newHead=linkedList.create();

        // while(newHead!=null){
        //     Console.Write(newHead+" ");
        //     newHead=newHead.next;
        // }
    }
}
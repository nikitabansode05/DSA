public class Program{

    public static createNode(int data){

    }
    
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

        Node temp=node1;
        while(temp!=null){
            Console.Write(temp.data+" ");
            temp=temp.next;
        }
    }
}
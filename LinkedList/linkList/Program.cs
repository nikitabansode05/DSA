public class Program{
    
    public static void Main(){

        LinkedList linkedList=new LinkedList();
        linkedList.insert(12);
        linkedList.insert(11);
        linkedList.insert(10);

        linkedList.display();

        linkedList.update();
        linkedList.display();

        linkedList.delete();
        linkedList.display();
    }
}
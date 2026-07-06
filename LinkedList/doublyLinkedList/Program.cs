public class Program
{
    public static void Main()
    {
        LinkedList list=new LinkedList();

        list.insertfromFront(9);
        list.insertfromFront(8);
        list.insertfromFront(7);
        list.display();
        list.insertfromBack(10);
        list.insertfromBack(11);
        list.insertfromBack(12);
        list.display();
        list.update(12,6);
        list.display();
        list.delete(8);
        list.display();
    }
}

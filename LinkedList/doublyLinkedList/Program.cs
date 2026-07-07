public class Program
{
    public static void Main()
    {
        LinkedList list=new LinkedList();

        list.insertfromFront(9);
        list.insertfromFront(8);
        list.insertfromFront(7);
        list.displayfromFront();
        list.displayfromBack();
        list.insertfromBack(10);
        list.insertfromBack(11);
        list.insertfromBack(12);
        list.displayfromFront();
        list.displayfromBack();
        list.update(12,6);
        list.displayfromFront();
        list.displayfromBack();
        list.delete(6);
        list.displayfromFront();
        list.displayfromBack();
    }
}

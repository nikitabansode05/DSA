public class Program
{
    public static void Main()
    {
        LinkedList list=new LinkedList();
        list.insert(10);
        list.display();

        list.insert(20);
        list.insert(30);
        list.insert(40);

        list.display();

        list.delete(30);
        list.display();

        list.update(10,5);
        list.display();

        list.update(40,15);
        list.display();

        list.update(20,25);
        list.display();

        list.delete(15);
        list.display();

    }

}
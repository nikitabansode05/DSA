public class Program
{
    public static void Main()
    {
        QueueInt queue = new QueueInt(4);
        queue.insert(2);
        queue.display();

        queue.insert(3);
        queue.insert(4);
        queue.insert(5);

        queue.display();

        queue.update(5,7);
        queue.display();

        queue.delete();
        queue.display();

        queue.delete();
        queue.display();
    }
}
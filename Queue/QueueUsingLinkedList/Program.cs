public class Program
{
    public static void Main()
    {
        Queue queue=new Queue();
        queue.insert(10);
        queue.display();
        
        queue.insert(20);
        queue.insert(30);
        queue.insert(40);

        queue.display();

        queue.delete();
        queue.display();

        queue.delete();
        queue.display();
    }
}
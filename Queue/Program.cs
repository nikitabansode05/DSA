using System.Collections;

public class Program
{
    public static void Main()
    {
        QueueInt queueInt = new QueueInt(4);
        queueInt.insert(2);
        queueInt.display();

        queueInt.insert(3);
        queueInt.insert(4);
        queueInt.insert(5);

        queueInt.display();

        queueInt.update(5,7);
        queueInt.display();

        queueInt.delete();
        queueInt.display();

        queueInt.delete();
        queueInt.display();

        QueueString queueString=new QueueString(4);
        queueString.insert("Apple");
        queueString.display();

        queueString.insert("Mango");
        queueString.insert("Nikita");
        queueString.insert("Banana");
        queueString.display();

        queueString.update("Nikita","Lichi");
        queueString.display();

        queueString.delete();
        queueString.display();
    }
}
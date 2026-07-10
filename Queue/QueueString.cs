public class QueueString
{
    public string[] queue;

    public QueueString(){}

    public QueueString(int length)
    {
        queue=new string[length];
    }

    public void insert(string data)
    {
        for(int i = 0; i < queue.Length; i++)
        {
            if (queue[i] == null)
            {
                queue[i]=data;
                break;
            }
        }
    }
    
    public void update(string oldValue,string newValue)
    {
        for(int i = 0; i < queue.Length; i++)
        {
            if (queue[i] == oldValue)
            {
                queue[i]=newValue;
                break;
            }
        }
    }

    public void delete()
    {
        for(int i = 0; i < queue.Length-1; i++)
        {
            queue[i]=queue[i+1];
        }
        queue[queue.Length-1]=null;
    }
    
    public void display()
    {
        for(int i = 0; i < queue.Length; i++)
        {
            Console.Write(queue[i]+" ");
        }
        Console.WriteLine("\n***********************************");
    }
}
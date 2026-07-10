public class QueueInt
{
    public int[] queue;

    public QueueInt()
    {
        queue=null;
    }

    public QueueInt(int length)
    {
        queue=new int[length];
    }

    public void insert(int data)
    {
      for(int i = 0; i < queue.Length; i++)
        {
            if (queue[i] == 0)
            {
                queue[i]=data;
                break;
            }
        }
    }

    public void update(int oldValue,int newValue)
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
        queue[queue.Length-1]=0;
    }

    public void display()
    {
        foreach(int q in queue)
        {
            Console.Write(q+" ");
        }
        Console.WriteLine("\n*****************************************");
    }
}
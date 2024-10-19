using System;

public class IntQueue
{
    private int[] queue;
    private int front;
    private int rear;
    private int size;
    private int capacity;

    public IntQueue(int capacity)
    {
        this.capacity = capacity;
        queue = new int[capacity];
        front = 0;
        rear = -1;
        size = 0;
    }

    public void Enqueue(int item)
    {
        if (size == capacity)
        {
            throw new InvalidOperationException("Queue is full.");
        }

        rear = (rear + 1) % capacity;
        queue[rear] = item;
        size++;
    }

    public int Dequeue()
    {
        if (size == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        int value = queue[front];
        front = (front + 1) % capacity;
        size--;
        return value;
    }

    public int Peek()
    {
        if (size == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return queue[front];
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    public int Count()
    {
        return size;
    }
}



public class Queue<T>
{
    private T[] queue;
    private int front;
    private int rear;
    private int size;
    private int capacity;

    public Queue(int capacity)
    {
        this.capacity = capacity;
        queue = new T[capacity];
        front = 0;
        rear = -1;
        size = 0;
    }

    public void Enqueue(T item)
    {
        if (size == capacity)
        {
            throw new InvalidOperationException("Queue is full.");
        }

        rear = (rear + 1) % capacity;
        queue[rear] = item;
        size++;
    }

    public T Dequeue()
    {
        if (size == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        T value = queue[front];
        front = (front + 1) % capacity;
        size--;
        return value;
    }

    public T Peek()
    {
        if (size == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return queue[front];
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    public int Count()
    {
        return size;
    }
}

public class Program
{
    public static void Main()
    {
        IntQueue intQueue = new IntQueue(5);
        intQueue.Enqueue(10);
        intQueue.Enqueue(20);
        intQueue.Enqueue(30);

        Console.WriteLine("Dequeued: " + intQueue.Dequeue()); 
        Console.WriteLine("Peek: " + intQueue.Peek()); 
        Console.WriteLine("Queue is empty: " + intQueue.IsEmpty());





        Queue<string> stringQueue = new Queue<string>(5);
        stringQueue.Enqueue("Apple");
        stringQueue.Enqueue("Banana");
        stringQueue.Enqueue("Cherry");

        Console.WriteLine("Dequeued: " + stringQueue.Dequeue()); 
        Console.WriteLine("Peek: " + stringQueue.Peek()); 
        Console.WriteLine("Queue is empty: " + stringQueue.IsEmpty()); 

        Queue<int> intQueue1 = new Queue<int>(5);
        intQueue1.Enqueue(100);
        intQueue1.Enqueue(200);
        intQueue1.Enqueue(300);

        Console.WriteLine("Dequeued: " + intQueue1.Dequeue()); 
        Console.WriteLine("Peek: " + intQueue1.Peek()); 
        Console.WriteLine("Queue is empty: " + intQueue1.IsEmpty()); 
    }
}





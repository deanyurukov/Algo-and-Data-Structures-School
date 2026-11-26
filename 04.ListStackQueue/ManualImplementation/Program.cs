namespace ManualImplementation;

class Stack<T>
{
    private T[] stack;

    public Stack(T[] stack)
    {
        this.stack = stack;
    }

    public void Push(T item)
    {
        stack = stack.Append(item).ToArray();
    }

    public T Pop()
    {
        if (stack.Length == 0)
        {
            throw new Exception("Stack is empty");
        }
        
        T last = stack[stack.Length - 1];
        T[] result = stack.SkipLast(1).ToArray();
        stack = result;
        
        return last;
    }

    public T Peek()
    {
        if (stack.Length == 0)
        {
            throw new Exception("Stack is empty");
        }
        
        return stack[stack.Length - 1];
    }
    
    public bool isEmpty()
    {
        return stack.Length == 0;
    }
}

class Queue<T>
{
    private T[] queue;

    public Queue(T[] queue)
    {
        this.queue = queue;
    }

    public void Put(T item)
    {
        queue = queue.Append(item).ToArray();
    }

    public T Get()
    {
        if (queue.Length == 0)
        {
            throw new Exception("Queue is empty");
        }
        
        T first = queue[0];
        T[] result = queue.Skip(1).ToArray();
        queue = result;
        
        return first;
    }

    public bool isEmpty()
    {
        return queue.Length == 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Stack:");
        Stack<int> stack = new Stack<int>([1, 2, 4]);
        stack.Push(5);
        stack.Push(6);
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.isEmpty());

        Console.WriteLine("\nQueue:");
        Queue<int> queue = new Queue<int>([1, 2, 4]);
        queue.Put(5);
        queue.Put(6);
        Console.WriteLine(queue.Get());
        Console.WriteLine(queue.isEmpty());
    }
}
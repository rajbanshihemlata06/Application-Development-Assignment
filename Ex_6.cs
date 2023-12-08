class Stack<T>
{
    List<T> stacklists = new List<T>();

    public void Push(T item)
    {
        Console.WriteLine(" Push method that adds an item of type T to the top of the stack.");
        
        stacklists.Add(item);
        Console.WriteLine("New item add" + item);

        DisplayStack();
    }

    public T Pop()
    {
        if (!stacklists.Any())
        {
            Console.WriteLine("Stack is empty");
        }

        Console.WriteLine("Pop method to remove top item of the stack");

        int lastIndex = stacklists.Count - 1;
        T poppedItem = stacklists[stacklists.Count - 1];
        stacklists.RemoveAt(lastIndex);
        
        Console.WriteLine("Last Item has been popped" + poppedItem);
        
        DisplayStack();
        return poppedItem;

    }

    public T Peek()
    {
        if (!stacklists.Any())
        {
            Console.WriteLine("stack is empty");

        }
        Console.WriteLine("Peek method to show top item of the stack without removing");

        var peekedData = stacklists[stacklists.Count - 1];

        Console.WriteLine("The top item of the stack without removing:" + peekedData);
        
        Console.WriteLine("Displaying stack list");
        
        DisplayStack();
        return peekedData;
    }

    public void isEmpty()
    {
        if (!stacklists.Any())
        {
            Console.WriteLine("True stack is empty");
        }
        else
        {
            Console.WriteLine("false stack is not empty");

        }
        Console.WriteLine();
    }

    public void DisplayStack()
    {
        if (!stacklists.Any())
        {
            Console.WriteLine("Empty Stack");
        }
        else
        {
            foreach (var i in stacklists)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine();
    }
}
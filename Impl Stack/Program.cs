using System;

public class Stack<T>
{
    private List<T> element = new List<T>();

    public void Push(T item)
    {
        element.Add(item);
    }

    public T Pop()
    {
        if (IsEmpty()) throw new InvalidOperationException("The stack is empty");

        T item = element[element.Count - 1];
        element.RemoveAt(element.Count - 1);
        return item;
    }

    public T Peek ()
    {
        if (IsEmpty()) throw new InvalidOperationException("The stack is empty");
        return element[element.Count - 1];
    }

    public bool IsEmpty()
    {
        return element.Count == 0;
    }
}

public class Program
{
    public static void Main ()
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        Console.WriteLine("Element on top : " + stack.Peek());
        Console.WriteLine("Elemento \r\nUnstacked : " + stack.Pop());
        Console.WriteLine("Element on top now: " + stack.Peek());
    }
}
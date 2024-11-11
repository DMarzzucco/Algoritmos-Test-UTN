using System;

public class Program
{
    public static int Fibonacci(int limit)
    {
        int n1 = 0;
        int n2 = 1;

        Console.WriteLine(n1);
        Console.WriteLine(n2);

        for (int i = n1 + n2; i < limit; i = n1 + n2)
        {
            Console.WriteLine(i);
            n1 = n2;
            n2 = i;
        }
        return n2;
    }

    public static void Main()
    {
        int Limit = 20;
        Fibonacci(Limit);
    }
}
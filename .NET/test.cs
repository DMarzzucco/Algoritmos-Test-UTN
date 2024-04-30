// Fibonacci
using System;

class Program
{
    static void Main(string[] args)
    {
        int limit = 20;
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
    }
}

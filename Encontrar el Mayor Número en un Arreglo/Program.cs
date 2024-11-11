using System;

public class Program
{
    public static int BigNumber(int[] number)
    {
        int mayor = number[0];
        foreach (int num in number)
        {
            if (num > mayor)
            {
                mayor = num;
            }
        }
        return mayor;
    }

    public static void Main()
    {
        int[] number = { 1, 2, 3, 434, 546, 342453, 43, 2342, };

        Console.WriteLine(BigNumber(number));
    }
}

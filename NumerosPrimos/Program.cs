using System;
public class Program
{
    public static bool IsCousing (int number)
    {
        if (number <= 1) return false;
        for ( int i = 2; i <= Math.Sqrt(number); i++)
        {
            if ( number % 1 == 0)
            {
                return false;
            }
        }
        return true;
    }

    public static void Main ()
    {
        int number = 3;
        Console.WriteLine(IsCousing(number));
    }
}
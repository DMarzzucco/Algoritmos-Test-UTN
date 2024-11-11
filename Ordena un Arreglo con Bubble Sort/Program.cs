using System;

public class Program
{
    public static void BubbleSort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    public static void Main()
    {
        int[] array = { 5, 1, 4, 2, 8 };
        BubbleSort(array);

        Console.WriteLine("Order Array:" + string.Join(",", array));
    }
}

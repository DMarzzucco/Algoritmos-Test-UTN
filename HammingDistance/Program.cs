using System;

public class Program
{
    public static int HammingDistance(string text1, string text2)
    {
        if (text1.Length != text2.Length) throw new Exception("The length is not the same");
        int dis = 0;

        for (int i = 0; i < text1.Length; i++)
        {
            if (text1[i] != text2[i]) dis++;
        }
        return dis;
    }
    public static int HammingDistanceWithEnumerableRanger(string text1, string text2)
    {
        if (text1.Length != text2.Length) throw new Exception("The length is not the same");
        return Enumerable.Range(0, text1.Length).Count(i => text1[i] != text2[i]);
    }


    public static void Main()
    {
        string text1 = "vanhowsow";
        string text2 = "vanekisow";

        Console.WriteLine($"The distance between text1 and text2 is {HammingDistance(text1, text2)}");
        Console.WriteLine($"The distance between text1 and text2 is {HammingDistanceWithEnumerableRanger(text1, text2)}");
    }
}

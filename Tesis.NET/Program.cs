using System;
using System.Text;

public class Program
{
    public static string InvertirCadena(string text)
    {
        StringBuilder textResult = new StringBuilder();
        for (int i = text.Length - 1; i >= 0; i--)
        {
            textResult.Append(text[i]);
        }
        return textResult.ToString();
    }

    public static void Main()
    {
        string text = "pato";
        Console.WriteLine(InvertirCadena(text));
    }
}

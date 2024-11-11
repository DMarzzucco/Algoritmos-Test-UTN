using System;
using System.Text.RegularExpressions;
public class Program
{
    public static int WordsCount(string text)
    {
        text = Regex.Replace(text, @"\s+", " ").Trim();

        int n = 0;
        var words = text.Split(' ');
        n = words.Length;

        return n;
    }
    public static void Main()
    {
        string text = "  a text   that   get   words";
        Console.WriteLine($"The number of words is: {WordsCount(text)}");
    }
}
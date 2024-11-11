using System;
using System.Text.RegularExpressions;
public class Program
{
    public static int CountCharacter(string pattern)
    {
        string text = "asdn1234nfasdnkwk?(32545wdsSDDSsd";

        var regex = new Regex(pattern);

        int n = regex.Matches(text).Count;
        return n;
    }
    public static void Main()
    {
        string patternLetters = @"[a-zA-Z]";
        string patternDigits = @"[0-9]";
        string patternSpaces = @"\s";
        string patternSpecials = @"[^a-zA-Z0-9]";

        Console.WriteLine($"Number of letters: {CountCharacter(patternLetters)}");
        Console.WriteLine($"Number of digits: {CountCharacter(patternDigits)}");
        Console.WriteLine($"Number of spaces: {CountCharacter(patternSpaces)}");
        Console.WriteLine($"Number of special characters: {CountCharacter(patternSpecials)}");
    }
}
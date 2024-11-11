using System;

public class Program
{

    public static int StringRepited(char character)
    {
        string text = "ianfonsjnoanSN124nf34njdna";
        int n = 0;

        foreach (var c in text)
        {
            if (c == character) n++;
        }

        return n;
    }
    public static int StringRepitedLINQ(char character)
    {
        string text = "ianfonsjnoanSN124nf34njdna";
        int n = 0;
        n = text.Where(c => c == character).Count();
        return n;
    }

    public static void Main()
    {
        char character = 'S';

        Console.WriteLine($"The {character} letter be repite {StringRepited(character)} times");
        Console.WriteLine($"The {character} letter be repite {StringRepitedLINQ(character)} times");

    }
}


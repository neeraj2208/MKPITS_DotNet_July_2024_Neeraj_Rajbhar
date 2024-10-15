using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int letterCount = 0;

        foreach (char c in input)
        {
            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
            {
                letterCount++;
            }
        }

        Console.WriteLine("Total number of alphabetic characters" +letterCount);
    }
}

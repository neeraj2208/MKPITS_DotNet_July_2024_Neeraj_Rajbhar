using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int[] charCount = new int[256];

        for (int i = 0; i < input.Length; i++)
        {
            charCount[input[i]]++;
        }

        char mostFrequentChar = ' '; 
        int maxCount = 0; 
        bool found = false;

        for (int i = 0; i < charCount.Length; i++)
        {
            if (charCount[i] > maxCount)
            {
                maxCount = charCount[i]; 
                mostFrequentChar = (char)i; 
                found = true; 
            }
        }

        if (found)
        {
            Console.WriteLine("The most frequent character is: "+ mostFrequentChar + "maxCount " +occurrences);
        }
        else
        {
            Console.WriteLine("No characters found.");
        }
    }
}

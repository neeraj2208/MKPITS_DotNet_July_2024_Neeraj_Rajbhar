using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int vowelCount = 0;
        int consonantCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];

            if (c >= 'A' && c <= 'Z')
            {
                c = (char)(c + 32); 
            }

            if (c >= 'a' && c <= 'z') 
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }
            }
        }

        Console.WriteLine("Number of vowels: " + vowelCount);
        Console.WriteLine("Number of consonants: " + consonantCount);
    }
}

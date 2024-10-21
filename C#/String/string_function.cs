using System;

class Program
{
    static void Main()
    {

        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        Console.WriteLine("Length of the string: " + input.Length);

        string upperCase = input.ToUpper();
        Console.WriteLine("Uppercase: " + upperCase);

        string lowerCase = input.ToLower();
        Console.WriteLine("Lowercase: " + lowerCase);

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        Console.WriteLine("Reversed string: " + reversed);

     
    }
}

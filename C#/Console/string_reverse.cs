using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter string value:");
        string str = Console.ReadLine();
        
        Console.WriteLine("String entered character-wise is:");
        for (int i = 0; i < str.Length; i++)
        {
            Console.WriteLine(str[i]);
        }

        Console.WriteLine("String entered in reverse order is:");
        for (int i = str.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(str[i]);
        }

        Console.Read();
    }
}

using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a positive number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            int negativeNumber = -number;
            Console.WriteLine("The negative of the number is: " + negativeNumber);
        }
        else
        {
            Console.WriteLine("The number entered is not positive.");
        }
    }
}

using System;


namespace expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, sum;
            Console.Write("Eenter x :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y :");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter z :");
            z = Convert.ToInt32(Console.ReadLine());
            sum = (x + y)*z;
            Console.Write("Total is " + sum);
            sum = x * y + y * z;
            Console.Write("Total is " + sum);

            Console.ReadKey();
        }
    }
}
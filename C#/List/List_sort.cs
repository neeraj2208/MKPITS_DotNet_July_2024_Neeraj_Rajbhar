using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace List_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 3, 8, 1, 9, 2 };

            numbers.Sort();
            Console.WriteLine("Ascending order:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Sort();
            numbers.Reverse();
            Console.WriteLine("\nDescending order:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("the elemnts in array are");
            for (int iterate = 0; iterate < n; iterate++)
            {
                array[iterate] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the element for search:");
            int search = Convert.ToInt32(Console.ReadLine());

            for (int iterate = 0; iterate < n; iterate++)
            {
                if (array[iterate] == search)
                {
                    Console.WriteLine("the position of " + search + " is " + iterate);
                    break;

                }
            }
            Console.ReadLine();
        }

    }
}
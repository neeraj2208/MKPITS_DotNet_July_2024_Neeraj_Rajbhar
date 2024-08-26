using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter lements of array:");
            int[] arrElemets = new int[5];

            for (int position = 0; position < 5; position++)
            {
                arrElemets[position] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("elements in array area: ");
            for (int position = 0; position < 5; position++)
            {
                Console.WriteLine(arrElemets[position]);
            }
            Console.ReadLine();
        }
    }
}
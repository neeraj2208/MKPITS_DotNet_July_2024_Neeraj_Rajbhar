using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_element_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.Write("Enter the number of elements in an array: ");
            n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements of an array:");
            for (int iterate = 0; iterate < n; iterate++)
            {
                arr[iterate] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int iterate = 0; iterate < n; iterate++)
            {
                sum = sum + arr[iterate];
            }
            Console.WriteLine("The sum of array :"+sum);
            Console.ReadLine(); 
        }

    }
}

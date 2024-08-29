using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicate_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("-----------Enter the elements in array--------------");
            for (int iterate = 0; iterate < n; iterate++)
            {
                arr[iterate] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Duplicate elements in array:");
            for (int iterate1 = 0; iterate1 < arr.Length; iterate1++)
            {
                for (int iterate2 = 0; iterate2 < iterate1; iterate2++)
                {

                    if (arr[iterate1] == arr[iterate2])
                    {
                        Console.WriteLine(arr[iterate1]);
                        break;
                    }

                }

            }
            Console.ReadLine();
        }
    }
}

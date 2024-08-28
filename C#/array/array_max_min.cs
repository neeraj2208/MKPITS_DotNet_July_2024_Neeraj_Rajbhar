using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_min_array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2,3,7,1,2,9,5,6 };

            int max = 0;
            int min =array [0];

            for (int iterate = 1; iterate < array.Length; iterate++)
            {
                if (array[iterate] > max)
                {
                    max = array[iterate];
                }
                else if (array[iterate] < min)
                {
                    min = array[iterate];
                }
            }

            Console.WriteLine("The Maximum Element is: " + max);
            Console.WriteLine("The Minimum element is: " + min);
            Console.ReadLine();   
        }
    }
}

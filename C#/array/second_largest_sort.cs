using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySecondLargest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int cnt = 0; cnt < 5; cnt++)
            {
                arr[cnt] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            int n = arr[arr.Length - 2];
            Console.WriteLine("Second Largest: " + n);
            Console.ReadKey();
        }
    }
}
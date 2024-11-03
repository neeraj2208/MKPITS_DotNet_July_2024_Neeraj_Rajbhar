using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClearMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Array.Clear(arr, 0, 5);
            for(int cnt=0;cnt<arr.Length;cnt++)
            {
                Console.WriteLine(arr[cnt]);
            }
            Console.ReadKey();
        }
    }
}
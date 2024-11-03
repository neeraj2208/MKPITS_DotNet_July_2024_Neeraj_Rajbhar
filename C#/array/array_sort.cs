using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySortMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9,8,7,6,5,4,3,2,1 };
            Array.Sort(arr);
            for(int cnt=0;cnt<arr.Length;cnt++)
            {
                Console.WriteLine(arr[cnt]);
            }
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndexOfMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9 };
            int l = Array.IndexOf(arr, 5);
            {
                Console.WriteLine("Index is " +l);
            }
            Console.ReadKey();
        }
    }
}
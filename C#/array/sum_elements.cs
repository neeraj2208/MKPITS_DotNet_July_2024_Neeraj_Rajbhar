using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySumElment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            int sum = 0;
            int i;
            for( i=0;i<3;i++)
            {
                Console.WriteLine("Enter Num:");
                num[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + num[i];
            }
            Console.Write("Sum of all elements stored in the array is : {0}", sum);
            
            Console.ReadKey();
        }
    }
}
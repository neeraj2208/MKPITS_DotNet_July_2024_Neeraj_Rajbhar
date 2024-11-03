using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySumUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            int counter;
            int sum = 0;
            for (counter = 0; counter < 3; counter++)
            {
                Console.WriteLine("Enter num:");
                num[counter] = Convert.ToInt32(Console.ReadLine());
            }
            for(counter=0;counter<3; counter++)
            {
                sum = sum + num[counter];
            }
            Console.WriteLine("Sum is {0}",sum);
            Console.ReadKey();
        }
    }
}
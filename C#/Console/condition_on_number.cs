using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.Write("Enter the value of M: ");
            m=Convert.ToInt32(Console.ReadLine());

            if (m > 0)
            {
                Console.WriteLine("the value of n is 1");
            }
            else if (m == 0)
            {
                Console.WriteLine("The value of n is 0");
            }
            else
            {
                Console.WriteLine("The value of n is -1");
            }
            Console.ReadLine();


        }
    }
}

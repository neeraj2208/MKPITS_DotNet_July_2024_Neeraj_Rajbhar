using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;
            Console.Write("Enter Num1: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("numbers are equal");
            }
            else
            {
                Console.WriteLine("Numbers are not equal");
            }

            Console.ReadLine();

        }
    }
}

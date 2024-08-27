using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter the First number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            if(num1>0)
            {
                Console.Write("The Number is positive");
            }
            else
            {
                Console.Write("The Number is negative");
            }

            Console.ReadLine();
        }
    }
}

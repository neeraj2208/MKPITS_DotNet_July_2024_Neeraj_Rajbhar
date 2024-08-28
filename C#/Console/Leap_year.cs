using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the year: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num%4 == 0)
            {
                Console.WriteLine(num + " is a leap year");
            }
            else
            {
                Console.WriteLine("These is not a leap year");
            }
            Console.ReadLine();
        }
    }
    }


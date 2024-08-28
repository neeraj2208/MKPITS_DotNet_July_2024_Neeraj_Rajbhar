using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace right_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter <= 5; counter++)
            {
                int x = 1;
                for (int number = 1; number <= counter; number++)
                {
                    Console.Write("1");
                    x++;
                }
                Console.WriteLine();
            }
            Console.Read();
        }

    }
}

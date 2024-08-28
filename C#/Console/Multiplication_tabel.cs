using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter <= 10; counter++)
            {
               
                for (int number = 1; number <= 10; number++)
                {
                    Console.Write(counter * number);
                    Console.Write("\t");
                }
                Console.WriteLine();
                
            }
            Console.Read();
        }
    }
}

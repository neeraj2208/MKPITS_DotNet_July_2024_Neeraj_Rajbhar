using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_even_natural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ven=0;
            int sum = 0;
            for (int num = 0; num < 10; num++)
            {
                ven = num * 2;
                Console.WriteLine(ven);
                sum = sum + ven;
            }
            Console.WriteLine("sum is "+sum);
            Console.Read();
        }
    }
}

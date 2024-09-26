using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,result=0;
            int count = 1;
            Console.WriteLine("Enter Num:");
            num = Convert.ToInt32(Console.ReadLine());

            while(count<=10)
            {
                result = num * count;
                Console.WriteLine("{0} x {1} = {2}", num, count, result);
                count++;
            }
            
            Console.ReadKey();
        }
    }
}
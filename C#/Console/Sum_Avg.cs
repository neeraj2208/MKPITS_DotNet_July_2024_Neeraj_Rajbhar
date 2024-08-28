using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace natural_sum_avg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num; 
            
            Console.Write("enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());
            int sum = 0, avg = 0;
            for (int counter = 0; counter <= num; counter++)
            {
                sum = sum + counter;
                avg = sum/num;
            }
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            Console.Read();
        }
        
    }
}

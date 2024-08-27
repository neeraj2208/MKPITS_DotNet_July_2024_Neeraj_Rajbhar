using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum=0;
            Console.Write("Enter the Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                sum=sum+i; 
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}

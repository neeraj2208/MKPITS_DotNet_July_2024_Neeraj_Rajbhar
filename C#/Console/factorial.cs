using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for(int num = 1; num <= n; num++)
            {
                fact= fact*num;      
            }
            Console.WriteLine("factorial of "+n+" is "+fact);

            Console.Read();
                
                
        }
    }
}

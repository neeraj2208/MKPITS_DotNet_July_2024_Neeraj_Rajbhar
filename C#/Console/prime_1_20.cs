using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilePrimeNum1to20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter = 2;
            int flag = 0;
            while(counter<20)
            {
                if(counter%2==0)
                {
                    flag = 1;
                    break;
                }
                counter++;
            }
            if(flag==0) 
            {
                Console.WriteLine("IT is prime Num");
            }
            else
            {
                Console.WriteLine("It is not prime");
            }
            Console.ReadKey();
        }
    }
}
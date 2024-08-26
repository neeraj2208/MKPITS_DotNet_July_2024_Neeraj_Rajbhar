using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] num = new int[10];
            Console.WriteLine("the numbers are:");
            for (int position = 0; position < 10; position++)
            {
                num[position] =  position + 1  ;
            }
           
            int sum = 0;
            for (int position = 0; position < num.Length; position++)
            {

                sum += num[position];
            }
            Console.Write(sum);
            Console.ReadLine();
        }
    }
}
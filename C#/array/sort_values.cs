using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStored3Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Enter Num:");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("num[{0}]={1}", i, num[i]);

            }
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            int rem;
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Enter Element");
                num[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.Write("The values store into the array are:");
            for(int i=2;i>=0;i--)
            {
                Console.Write("{0}",num[i]);
            }

            Console.ReadKey();
        }
    }
}
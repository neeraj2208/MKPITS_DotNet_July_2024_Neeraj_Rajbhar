using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFoundElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            int user;
            int flag = 0;
            Console.WriteLine("Enter num:");
            user = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<num.Length;i++)
            {
                if (user == num[i])
                {

                    flag = 1;
                    break;
                }

            }
            if(flag==1)
            {
                Console.WriteLine("num {0} found in array", user);
            }
            else
            {

                Console.WriteLine("num is not  found in array");
            }
            Console.ReadLine();

        }
    }
}
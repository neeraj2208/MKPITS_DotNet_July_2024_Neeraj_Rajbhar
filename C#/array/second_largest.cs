using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySecondLargest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]arr=new int[5];
            int max1,max2;
            for(int cnt=0;cnt<5;cnt++)
            {
                arr[cnt] = Convert.ToInt32(Console.ReadLine());
            }
            max1 = max2 = arr[0];
            for(int cnt=0;cnt<5;cnt++)
            {
                if (arr[cnt]>max1)
                {
                    max2 = max1;
                    max1 = arr[cnt];
                }
                else if (arr[cnt]>max2)
                {
                    max2 = arr[cnt];
                }
            }
            Console.WriteLine("First max is " + max1);
            Console.WriteLine("Second max is "+max2);
            
            Console.ReadKey();
        }
    }
}
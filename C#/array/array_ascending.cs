using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAscending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            
            int temp = 0;
            for(int cnt=0;cnt<5;cnt++)
            {
                arr1[cnt] = Convert.ToInt32(Console.ReadLine());
            
            }
            for(int cnt=0;cnt<5;cnt++)
            {
                for(int cnt1=0;cnt1<5;cnt1++)
                {
                    if (arr1[cnt] < arr1[cnt1])
                    {
                        temp = arr1[cnt];
                        arr1[cnt] = arr1[cnt1];
                        arr1[cnt1] = temp;
                    }
                }
            }
            for(int cnt=0;cnt<5;cnt++)
            {
                Console.WriteLine(arr1[cnt]);
            }
            Console.ReadKey();
        }
    }
}
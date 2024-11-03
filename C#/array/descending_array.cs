using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDescending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr =new int  [5];
            int temp = 0;
            Console.WriteLine("Enter Number:");
            for(int cnt=0;cnt<5;cnt++)
            {
                arr[cnt] = Convert.ToInt32(Console.ReadLine());
            }
            for(int cnt=0;cnt<5;cnt++)
            {
                for(int cnt1=0;cnt1<5;cnt1++)
                {
                    if (arr[cnt] > arr[cnt1])
                    {
                        temp = arr[cnt];
                        arr[cnt] = arr[cnt1];
                        arr[cnt1] = temp;
                    }
                }
            }
            for(int cnt=0;cnt<5;cnt++)
            {
                Console.Write(arr[cnt]);
            }
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUnique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int flag= 0;
            for(int cnt=0;cnt<5;cnt++)
            {
                arr[cnt] = Convert.ToInt32(Console.ReadLine());

            }
            for(int cnt=0;cnt<5;cnt++)
            {
                flag = 0;
                for(int cnt1=0;cnt1<5;cnt1++)
                {
                    if(cnt!=cnt1)
                    {
                        if (arr[cnt] == arr[cnt1])
                        {
                            flag++;
                            break;
                        }
                    }
                }
                if(flag==0) 
                {
                    Console.WriteLine("Unique Elements are :" + arr[cnt]);
                }
            }
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySumRow_Col
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] num = { { 2, 2 }, { 2, 2 } };
            for(int cnt=0; cnt < 2; cnt ++)
            {
                for(int cnt1 =0;cnt1 <2;cnt1++)
                {
                    num[cnt, cnt1] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int cnt=0;cnt<2; cnt++)
            {
                int sum = 0;
                for(int cnt1=0;cnt1<2;cnt1++)
                {
                    sum = sum + num[cnt, cnt1];
                }
                Console.WriteLine("Sum of row {0}",sum);
            }
            for(int cnt=0;cnt<2;cnt++)
            {
                int sum = 0;
                for (int cnt1 = 0; cnt1 < 2; cnt1++)
                {
                    sum = sum + num[cnt1, cnt];

                }
                Console.WriteLine("Sum of column {0}", sum);

            }
            Console.ReadKey();

        }
    }
}
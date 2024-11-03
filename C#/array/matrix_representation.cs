using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRowColumn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] num = { { 2, 3 }, { 2, 5 } };
            for(int row=0;row<2;row++)
            {
                for(int col=0;col<2;col++)
                {
                    Console.Write(num[row, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTranspose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = { { 1, 2 }, { 3, 4 } };
            int[,] arr2 = { { 5, 6 }, { 7, 8 } };
            int[,] arr3 = new int[2, 2] ;
            for(int row=0;row<2;row++)
            {
                for(int col=0;col<2;col++)
                {
                    arr3[row, col] = arr1[col, row] +arr2 [row, col];
                }
            }
            for(int row=0;row<2;row++)
            {
                for(int col=0;col<2;col++)
                {
                    Console.Write(arr3[row, col]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
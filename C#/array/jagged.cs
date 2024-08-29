using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrrayjagged
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] ladder = new int[3][];
            ladder[0] = new int[] { 10, 20 };
            ladder[1] = new int[] { 30, 40, 50 };
            ladder[2] = new int[] { 60, 70, 80, 90 };

            for (int row = 0; row < 3; row++)
            {
                
                for (int col= 0;col< ladder[row].Length;col++)
                {
                    Console.Write(ladder[row][col]+ "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}


        
    

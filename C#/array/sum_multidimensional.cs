using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_row_matrix_array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] array1 = new int[3, 5];

            
            for (int row = 0; row < 3; row++)
            {
                Console.WriteLine("********array" + (row+1) + "********");
                for (int col = 0; col < 5; col++)
                {
                    array1[row, col] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (int row = 0; row < 3; row++)
            {
                Console.WriteLine("***array" + (row + 1) + "*****");
                for (int col = 0; col < 5; col++)
                {
                    Console.Write(array1[row, col] + "\t");
                }
                Console.WriteLine();
            }
            
            for (int row = 0; row < 3; row++)
            {
                Console.WriteLine("The sum of array " + (row + 1) + " is ");
                int sum = 0;
                for (int col = 0; col < 5; col++)
                {
                    
                    sum += array1[row, col];  
                }
                Console.Write(sum);
                
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

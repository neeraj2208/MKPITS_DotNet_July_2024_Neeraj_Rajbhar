using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidimensionaltabelforeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabel");
            Console.Write("Enter Num1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Num2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int[,] arr1 = new int[4, 4];

            for (int row = 0; row < num1; row++)
            {
                for (int col = 0; col < num2; col++)
                {
                    arr1[row, col] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            //foreach (int var in arr1)
            //{
            //    foreach (int var2 in var)
            //    {
            //        Console.Write(var * var2 + "\t");
            //    }

            for (int var = 0; var < num1; var++)
            {
                for (int var2 = 0; var2 < num2; var2++)
                {
                    Console.Write(arr1[var, var2]);

                }
                Console.WriteLine();
            }
        Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidimensinolarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] Name = {{"A","B","C","D","E","F"},
                              {"G","H","I","J","K","L"},
                              {"M","N","O","P","Q","R"},
                              {"S","T","U","V","W","X"} };

            for (int row = 0; row < 4; row++) 
            {
                for (int col = 0; col < 6; col++)
                {
                    Console.Write(Name[row,col]+"\t");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    } }
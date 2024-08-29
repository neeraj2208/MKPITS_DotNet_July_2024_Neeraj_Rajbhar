using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrjagguser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] ladder = new int[3][];
            ladder[0]= new int[3];
            ladder[1]= new int[4];
            ladder[2]= new int[2];
            foreach(int[] row in ladder)
            {
                foreach(int col in row)
                {
                    Console.Write(col);
                }
             Console.WriteLine();   
            }
            Console.ReadLine();
        }
    }
}

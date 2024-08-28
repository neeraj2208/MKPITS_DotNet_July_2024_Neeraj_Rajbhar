using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyramidA_Z
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height;
            char currentchar= 'A';

            Console.Write("Enter the length of height: ");
            height = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(currentchar + " ");

                    if (currentchar == 'Z')
                    {
                        currentchar = 'A';
                    }
                    else
                    {
                        currentchar++;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

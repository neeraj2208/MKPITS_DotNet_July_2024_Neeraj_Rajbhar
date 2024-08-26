using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayfunctionuse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Name = new int[5];
            Console.WriteLine("enter the elements of array");

            for (int iterate = 0; iterate < 5; iterate++)
            {
                Name[iterate] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("*******The elements are******");
            for (int iterate = 0; iterate < 5; iterate++)
            {
                Console.WriteLine(Name[iterate]);
            }
            
            Console.Write("The Arithmatic operation are"+"\n");
            Console.Write(Name.Sum() + "\n");
            Console.Write(Name.Max()+"\n");
            Console.Write(Name.Min() + "\n");
            Console.Write(Name.Average() + "\n");
            Console.Write(Name.Reverse() + "\n");


            Console.ReadLine();
        }
    }
}


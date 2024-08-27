using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total, totmp;

            Console.Write("Enter the marks of Physics: ");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the marks of Maths: ");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the marks of Chemistry:");
            int chem = Convert.ToInt32(Console.ReadLine());

            total = math + phy + chem;
            totmp = math + phy;

            if (total >= 0 && totmp >= 0)
            {
                Console.Write("the student is eligible for admission.");

            }
            else
            {
                Console.Write("The student is not eligible for admission.");
            }
            Console.Read();
        }
    }
}


      
     
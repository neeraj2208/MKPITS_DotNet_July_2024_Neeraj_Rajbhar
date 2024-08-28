using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b, a, c, d, x, y,z,e;
            Console.Write("Enter the value of a :");
            a=Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of b :");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of c :");
            c = Convert.ToDouble(Console.ReadLine());

            d =(b*b) - (4*a*c);
            x = (-(b) + Math.Sqrt(d));
            y =( -(b) - Math.Sqrt(d));

            z = x / (2 * a);
            e = y / (2 * a);
            Console.Write(z);
            Console.WriteLine();
            Console.Write(e);
            Console.ReadLine();
            

        }
    }
}

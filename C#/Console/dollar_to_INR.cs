using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dollar;
            float INR;
            Console.Write("Enter the amount of dollar: ");
            dollar=Convert.ToInt32(Console.ReadLine());

            INR = 83 * dollar;
            Console.Write("The Inr Amount is: "+INR); 
            Console.ReadLine();


        }
    }
}

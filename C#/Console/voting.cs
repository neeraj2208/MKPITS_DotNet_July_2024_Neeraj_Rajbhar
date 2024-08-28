using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Enter the age of Candidate:");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("HE/SHE is eligible for voting");

            }
            else
            {
                Console.WriteLine("HE/SHE is not eligible for voting");
            }
            Console.ReadLine();
        }
    }
}

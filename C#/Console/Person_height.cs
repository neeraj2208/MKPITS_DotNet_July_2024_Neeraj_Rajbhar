using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height;
            Console.Write("Enter the Height of Person in centimeters :");
            height=Convert.ToInt32(Console.ReadLine());

            if (height > 0 && height <= 100)
            {
                Console.WriteLine("The height of person is too short");
            }
            else if (height >100 && height<=150)
            {
                Console.WriteLine("The person is Dwarf");
            }
            else
            {
                Console.WriteLine("The person is heighted");
            }
            Console.ReadLine();
        }
    }
}

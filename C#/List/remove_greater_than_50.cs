using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_remove_greaterThan50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                List<double> numbers = new List<double> { 12.5, 45.6, 67.8, 23.4, 89.0, 50.2 };
    
                numbers.RemoveAll(num => num > 50);
            
                Console.WriteLine("Numbers after removing those greater than 50:");
                foreach (double number in numbers)
                {
                    Console.WriteLine(number);
                }
                Console.ReadLine(); 
            }

        }
    }
}

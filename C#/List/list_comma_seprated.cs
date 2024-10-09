using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comma_seperated_string
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> fruits = new List<string> { "Apple", "Banana", "Orange", "Mango", "Grapes" };

            string result = string.Join(", ", fruits);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
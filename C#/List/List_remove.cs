using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Remove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string> { "Apple", "Banana", "Orange", "Mango", "Grapes" };

            string removefruit = "Orange";

            fruits.Remove(removefruit);

            // Print the updated list
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.ReadLine();
        }
    }
}
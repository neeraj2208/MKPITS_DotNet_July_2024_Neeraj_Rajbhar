using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RuntimePolymorphism_Colour
{
    class Animal
    {
        public string colour = "White";
    }
    class Dog:Animal
    {
        public string color = "Black";

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Console.WriteLine(a.colour);
            Console.ReadKey();
        }
    }
}
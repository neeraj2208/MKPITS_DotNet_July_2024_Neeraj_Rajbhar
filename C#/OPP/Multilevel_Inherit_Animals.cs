using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_Inherit_Animals
{
    class Animal
    {
        public void eat()
        {
            Console.WriteLine("Dog Eating....");
        }
    }
    class Dog:Animal
    {
        public void bark()
        {
            Console.WriteLine("Dog Bark....");

        }
    }
    class Babydog:Dog
    {
        public void weep()
        {
            Console.WriteLine("Dog Weep....");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Babydog b = new Babydog();
            b.eat();
            b.bark();
            b.weep();
            Console.ReadKey();
        }
    }
}
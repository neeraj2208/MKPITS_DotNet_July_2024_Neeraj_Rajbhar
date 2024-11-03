using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inherit_InheritMethods
{
    public class Dog
    {
        public void Bark()
        {
            Console.WriteLine("Dog  Bark now....");
        }
    }
    public class Derived:Dog
    {
        public void Eat()
        {
            Console.WriteLine("Dog  Eating now.....");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.Bark();
            d.Eat();
            Console.ReadKey();
        }
    }
}
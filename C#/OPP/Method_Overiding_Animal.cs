using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overiding_Animal
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Dog Eating");
        }
    }
    public class Dog:Animal
    {
        public override void eat()
        {
            Console.WriteLine("Dog Eating biscuit");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();
            a.eat();
            Console.ReadKey();
        }
    }
}
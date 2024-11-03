using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_AccessModifier
{ 
    class Person
    {
        protected string name;
    }
    class Employe:Person
    {
        public void data()
        {
            name = "Neeraj";
            Console.WriteLine("Name: " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe emp = new Employe();
            emp.data();
            Console.ReadKey();
        }
    }
}
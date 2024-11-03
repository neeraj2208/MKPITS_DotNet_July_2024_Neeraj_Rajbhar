using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_AccessModifier_Inheritance
{
     class Person
    {
        protected string name = "John";
        protected void data(string mess)
        {
            Console.WriteLine("Hello: " + mess);
        }
    }
     internal class Program:Person
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Name: " + p.name);
            p.data("Hey");
            Console.ReadKey();

        }
    }
}
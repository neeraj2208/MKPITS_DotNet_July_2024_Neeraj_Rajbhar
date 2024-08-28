using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Base
    {
        public void fnBase()
        {
            Console.WriteLine("I am  a base class");
        }
        public Base()
        {
            Console.WriteLine("I am a constructor");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Base @base = new Base(); //Constructor invoked
            @base.fnBase();
            Console.Read();
        }// acts like destructors
    }
}

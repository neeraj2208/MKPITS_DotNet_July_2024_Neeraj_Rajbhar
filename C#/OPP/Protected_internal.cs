using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_Internal
{
    class PInternal
    {
        protected internal string name = "Neeraj";
        protected internal void data(string name)
        {
            Console.WriteLine(name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PInternal p = new PInternal();
            Console.WriteLine(p.name);
            p.data("Chai");
            Console.ReadKey();
        }
    }
}
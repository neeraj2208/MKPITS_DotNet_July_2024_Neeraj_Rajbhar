using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_AccessModifier
{
    class Name
    {
        public string name="Akash";
        public void display(string mess)
        {
            Console.WriteLine("Hello " + mess);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Name n = new Name();
            Console.WriteLine(n.name);
            n.display("akash");
            Console.ReadKey();
        }
    }
}
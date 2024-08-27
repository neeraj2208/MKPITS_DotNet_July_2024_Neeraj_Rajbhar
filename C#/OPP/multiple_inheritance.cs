using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_multiple
{
    class Base
    {
        public void fnBase()
        {

        }

    }
    interface infBase
    {
        void fnInterface();
        void myInterface();
    }

    class Derived :Base,infBase
    {
        public void fnInterface()
        {

        }

        public void myInterface()

        {
            Console.WriteLine("neeraj");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.myInterface();
            Console.Read();
        }
    }

}
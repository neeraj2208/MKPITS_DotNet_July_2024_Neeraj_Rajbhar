using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_multilevel
{
    class Base
    {
        public string Name = "Neeraj";
        public void BaseFun()
        {
            Console.WriteLine("I am a Base class");
        }
    }
    class Intermediate : Base
    {
        public void IntermediateFun()
        {
            Console.WriteLine("I am a Intermediate class");
        }
    }
    class Derived : Intermediate
    {
        public void DerivedFun(int First, int Second)
        {
            int add = First + Second;   
            Console.WriteLine("Addition = "+ add);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any 2 numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Derived d = new Derived();  
            d.BaseFun();
            d.IntermediateFun();
            d.DerivedFun(num1,num2);
            Console.WriteLine(d.Name);
            Console.Read(); 
        }
    }
}

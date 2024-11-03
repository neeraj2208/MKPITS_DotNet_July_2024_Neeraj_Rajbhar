using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inherit_Student
{
    class person
    {
        public string name;
    }
    class student :person
    {
        public int rno;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.name = "Akash";
            s1.rno = 1;
            Console.WriteLine("Name " + s1.name);
            Console.WriteLine("Rno " + s1.rno);
            Console.ReadKey();
        }
    }
}
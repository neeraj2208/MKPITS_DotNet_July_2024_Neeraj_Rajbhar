using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorEmployeDisplay
{
    internal class Program
    {
        class Employe
        {
            int Number;
            string Name;
            string Designation;
            int Salary;
            public Employe()
            {
                Number = 123;
                Name = "Neeraj";
                Designation = "Manager";
                Salary=25000;
            }
            public void display()
            {
                Console.WriteLine("Employe Number: " + Number);
                Console.WriteLine("Employe Name: " + Name);
                Console.WriteLine("Employe Designation: "+Designation);
                Console.WriteLine("Employe Salary: " + Salary);
            }
        }
        static void Main(string[] args)
        {
            Employe e = new Employe();
            e.display();
            Console.ReadKey();
        }
    }
}
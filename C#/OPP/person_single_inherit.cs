using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inherit_Public_Person
{
    public class Person
    {
        public string Name;
        public string Adress;
    }
    public class Derived:Person
    {
        public int Id;
        public string Designation;
        public int Salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.Name = "suraj";
            d.Adress = "Nagpur";
            d.Id = 123;
            d.Designation = "Manager";
            d.Salary = 40000;
            Console.WriteLine("____Person Detail____");
            Console.WriteLine("Person Name: " + d.Name);
            Console.WriteLine("Person Adress: " + d.Adress);
            Console.WriteLine("Person Id: " + d.Id);
            Console.WriteLine("Person Designation: " + d.Designation);
            Console.WriteLine("Person Salary: " + d.Salary);
            Console.ReadKey();

        }
    }
}
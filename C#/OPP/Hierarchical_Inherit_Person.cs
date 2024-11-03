using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Inherit_Person
{
    class Person
    {
        public string Name;
        public string Address;


    }
    class Student:Person
    {
        public int Rno;
        public int Fees;
    }
    class Employe:Person
    {
        public int Id;
        public string Designation;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Neeraj";
            s.Address = "Nagpur";
            s.Rno = 123;
            s.Fees = 25000;
            Console.WriteLine("Student Name: " +s.Name);
            Console.WriteLine("Student Address: " + s.Address);
            Console.WriteLine("Student Rno: " + s.Rno);
            Console.WriteLine("Student Fes: " + s.Fees);

            Employe e = new Employe();
            e.Name = "Yash";
            e.Address = "Mumbai";
            e.Id = 456;
            e.Designation = "Manager";
            Console.WriteLine("Employe Name: " + e.Name);
            Console.WriteLine("Employe Address: " + e.Address);
            Console.WriteLine("Employe Id: " + e.Id);
            Console.WriteLine("Employe Designation: " + e.Designation);
            Console.ReadKey();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Inherit_Person
{
    public class Person
    {
        string Name;
        string Address;
        public void getperson(string Name,string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }
        public void getdisplay()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Address: " + Address);

        }


    }
    class Student : Person
    {
        int Rno;
        int Fees;
        public void getstudent(int Rno,int Fees)
        {
            this.Rno = Rno;
            this.Fees= Fees;
        }
        public void displaystudent()
        {
            Console.WriteLine("Rno " + Rno);
            Console.WriteLine("Fees: " + Fees);

        }
    }
    class Employe : Person
    {
        int Id;
        string Designation;
        public void getemploye(int Id, string Designation)
        {
            this.Id = Id;
            this.Designation = Designation;
        }
        public void displayemploye()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Designation: " + Designation);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.getperson("Neeraj", "Nagpur");
            s.getstudent(123, 20000);
            s.getdisplay();
            s.displaystudent();

            Employe e = new Employe();
            e.getperson("Arun", "Kolkata");
            e.getemploye(123, "Manager");
            e.getdisplay();
            e.displayemploye();
            Console.ReadKey();

        }
    }
}
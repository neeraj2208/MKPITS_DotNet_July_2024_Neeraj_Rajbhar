using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_Inherit_Person
{
    class Person
    {
        string name;
        string address;
        public void persondata(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        public void persondisplay()
        {
            Console.WriteLine("Person Name: " + name);
            Console.WriteLine("Person Adress: " + address);
        }
    }
    class Employe:Person
    {
        int salary;
        string designation;
        public void employedata(int salary,string designation)
        {
            this.salary = salary;
            this.designation = designation;
        }
        public void employedisplay()
        {
            Console.WriteLine("Employe Salary: " + salary);
            Console.WriteLine("Employe Designation: " + designation);
        }
    }
    class Parttime:Employe
    {
        int hours;
        public void parttimedata(int hours)
        {
            this.hours = hours;
        }
        public void parttimedisplay()
        {
            Console.WriteLine("Part time: " + hours);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Parttime p = new Parttime();
            p.persondata("Neeraj", "Nagpur");
            p.employedata(30000, "Manager");
            p.parttimedata(8);
            p.persondisplay();
            p.employedisplay();
            p.parttimedisplay();
            Console.ReadKey();
        }
    }
}
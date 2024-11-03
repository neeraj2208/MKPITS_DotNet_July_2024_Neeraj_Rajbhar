using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inherit_Protected_Employe
{
    class Employe
    {
        protected int id;
        protected string name;
    }
    class Programs:Employe
    {
        protected int  salary;
        public void getdata(int id,string name,int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine("Employe Id: " + id);
            Console.WriteLine("Employe Name: " + name);
            Console.WriteLine("Employe Salary: " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Programs p = new Programs();
            p.getdata(123, "Michael", 50000);
            p.display();
            Console.ReadKey();
        }
    }
}
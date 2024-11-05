using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor2_Parameter_Product
{
    internal class Program
    {
        class Employe
        {
            string Name;
            int Id;
            string Designation;
            int Salary;
            public Employe()
            {
                Name = "Neeraj";
                Id = 1;
                Designation = "Manager";
                Salary = 10000;
            }
            public Employe(string Name, int Id, string Designation, int Salary)
            {
                this.Name = Name;
                this.Id = Id;
                this.Designation = Designation;
                this.Salary = Salary;

            }
            public void display()
            {
                Console.WriteLine("Employe Name:" + Name);
                Console.WriteLine("Employe Id:" + Id);
                Console.WriteLine("Employe Price:" + Designation);
                Console.WriteLine("Employe Quantity:" + Salary);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employe Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Employe Id:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employe Price:");
            string designation = Console.ReadLine();

            Console.WriteLine("Enter Employe Quantity:");
            int salary = Convert.ToInt32(Console.ReadLine());


            Employe e = new Employe();
            e.display();
            Employe e2 = new Employe(name, id, designation, salary) ;
            e2.display();
            Console.ReadKey();
        }
    }
}
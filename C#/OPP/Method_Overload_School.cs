using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overload_School
{
    internal class Program
    {
        class School
        {
            int rno;
            string name;
            string course;
            int fees;
            public void getdata()
            {
                rno = 20;
                name = "Neeraj";
                course = "Dot Net";
                fees = 10000;
            }
            public void getdata(int rno,string name)
            {
                this.rno = rno;
                this.name = name;

            }
            public void getdata(int rno, string name,string course)
            {
                this.rno = rno;
                this.name = name;
                this.course = course;

            }
            public void getdata(int rno, string name,string course,int fees)
            {
                this.rno = rno;
                this.name = name;
                this.course = course;
                this.fees = fees;

            }

            public void display()
            {
                Console.WriteLine("Roll No: " + rno);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Course: " + course);
                Console.WriteLine("Fees: " + fees);
            }
        }
        static void Main(string[] args)
        {
            School std = new School();
            std.getdata();
            std.display();

            School std1 = new School();
            std1.getdata(25,"Neeraj");
            std1.display();

            School std2 = new School();
            std2.getdata(25, "Suraj");
            std2.display();

            School std3 = new School();
            std3.getdata(25, "Yash","Mechanical");
            std3.display();

            School std4 = new School();
            std4.getdata(25, "Lucky", "Electrical",20000);
            std4.display();
            Console.ReadKey();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inherit_ProtectedInternal
{
    public class Bank
    {
        string Name;
        int Accountno;
        protected internal void getdatabank(string Name,int Accountno)
        {
            this.Name = Name;
            this.Accountno = Accountno;
        }
        protected internal void displaybank()
        {
            Console.WriteLine("Bank name: " + Name);
            Console.WriteLine("Bank Accountno: " + Accountno);
        }
    }
    public class Person:Bank
    {
        string Name;
        int Number;
        public void getdataperson(string Name,int Number)
        {
            this.Name = Name;
            this.Number = Number;
        }
        public void displayperson()
        {
            Console.WriteLine("Person Name: " + Name);
            Console.WriteLine("Person Number: " + Number);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.getdatabank("Amit", 123);
            p.getdataperson("Bilesh", 456);
            p.displaybank();
            p.displayperson();
            Console.ReadKey();
        }
    }
}
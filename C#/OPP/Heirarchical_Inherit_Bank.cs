using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heirarchical_Inherit_Bank
{
    class Bank
    {
        public int actno;
        public int balance=1000;
        public void deposit(int amount)
        {
            Console.WriteLine("This amount will be only assume");
        }
    }
    class Current:Bank
    {
        public void deposit(int amount)
        {
             balance = balance + amount;
            Console.WriteLine("Your deposite balance is: " + balance);

        }
    }
    class Saving:Bank
    {
        public void deposit(int amount)
        {
            int intrest = 500;
            balance = balance + amount + intrest;
            Console.WriteLine("Your saving balance is: " + balance);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Current c = new Current();
            c.actno = 1;    
            c.deposit(500);

            Saving s = new Saving();
            s.actno = 2;
            s.deposit(500);

            Console.ReadKey();

            
        }
    }
}
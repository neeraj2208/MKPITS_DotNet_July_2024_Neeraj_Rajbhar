using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Bank
{
    abstract class Account
    {
        public abstract void deposit(int amount);
    }
    class Saving:Account
    {
        public override void deposit(int amount)
        {
            int balance = 1000;
            balance = balance + amount;
            Console.WriteLine("Balance is: " + balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = new Saving();
            act.deposit(500);
            Console.ReadKey();
        }
    }
}
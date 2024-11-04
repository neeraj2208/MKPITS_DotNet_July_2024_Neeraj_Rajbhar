using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_BankUserInput
{
    class Account
    {
        public int actno;
        public int balance = 1000;
        public virtual void deposit(int actno,int amt)
        {
            Console.WriteLine("Deposite Method of account of a class");
        }
        public void showbalance()
        {
            Console.WriteLine("Balance is: " + balance);
        }
    }
    class Current: Account
    {
        public override void deposit(int actno, int amt)
        {
            this.actno = actno;
            balance = balance + amt;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = new Current();
            Console.WriteLine("Enter Account Num: ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount: ");
            int amt = Convert.ToInt32(Console.ReadLine());
            act.deposit(actno, amt);
            act.showbalance();
            Console.ReadKey();
        }
    }
}
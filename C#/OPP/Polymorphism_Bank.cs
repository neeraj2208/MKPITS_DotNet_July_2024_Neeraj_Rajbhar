using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Bank
{
    class Account
    {
        public int actno;
        public int balance = 1000;
        public virtual string deposit(int actno,int amount)
        {
            return "Deposite method amount";
        }
        public string showbalance()
        {
            return "Balance is " + balance;
        }
        
    }
    class Current:Account
    {
        public override string deposit(int actno,int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "Amount deposite successful in current acount";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = new Current();
            string res = act.deposit(123, 2000);
            Console.WriteLine("Account number is: " + act.actno);
            Console.WriteLine(res);
            res=act.showbalance();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_account_oops
{
    public class Bankaccount
    {
        string Name;
        string AccouontNumbar;
        string AccountType;
        decimal Balance;

        public void AssignValues(string name, string accouontNumbar, string accountType, decimal balance)
        {
            Name = name;
            AccouontNumbar = accouontNumbar;
            AccountType = accountType;
            Balance = balance;
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Balance amount is : " + Balance);
            }
            else
            {
                Console.WriteLine("Insufficient bank bakance");
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine("Availabe amount is :" + Balance);
            }
            else
            {
                Console.WriteLine("Insufficient bank bakance");
            }
        }
        public void Display()
        {
            Console.WriteLine("Account holder name : " + Name);
            Console.WriteLine("Account holder Balance:  " + Balance);
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Bankaccount accountdetail = new Bankaccount();
                accountdetail.AssignValues("Neeraj", "34353557643", "Saving", 1000);
                accountdetail.Display();
                accountdetail.Deposit(1000);
                accountdetail.Withdraw(500);
                accountdetail.Display();
                Console.ReadLine();
            }
        }
    }
}
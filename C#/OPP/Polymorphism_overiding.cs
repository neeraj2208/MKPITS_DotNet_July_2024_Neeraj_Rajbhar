using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_overriding
{
    public class AccountHolder
    {
        int age=22;
        string Name="neeraj";
        // Function/Method Overloading (Static/Compile time Polymorphiism
        // function Overloading (Dynamic/RuntimePolymorphsm)

 
        public virtual void getDetails()
        {
            Console.WriteLine("Base Class Method");
        }
        public virtual void getDetails(string add)
        {
            //string address = add;
            Console.WriteLine(add);
        }
        public void getDetails(long contact)
        {
            Console.WriteLine(contact);
        }

    }
    class BankDetails : AccountHolder
    {
        public override void getDetails()
        {
            Console.WriteLine("Dervied class method");
        }

        internal class Program
        {

            static void Main(string[] args)
            {
                AccountHolder c = new AccountHolder();
                BankDetails ac = new BankDetails();
                c. getDetails();
                ac.getDetails();
                ac.getDetails(848381723);
                ac.getDetails("Nagpur");
                Console.ReadLine();
            }
        }
    }
}

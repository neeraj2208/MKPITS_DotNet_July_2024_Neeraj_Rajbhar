using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_1
{
   public class AccountHolder

    { 
        int age;
        string Name;
        public void getDetails()
        {
          Name =" Neeraj";
          age = 22 ;
          Console.WriteLine("Name of accountholder is  "+Name+ " and age of acc holder is " + age);

        }

        public void getDetails(int contact)
        {
            Console.WriteLine("Contact of accountholder " + contact );

        }
        public void getDetails(string address)
        {
            Console.WriteLine("Address of accountholder " + address);

        }
    }
internal class Program
    {


        static void Main(string[] args)
        {

        AccountHolder ac = new AccountHolder();
        ac.getDetails();
        ac.getDetails(34);
        ac.getDetails("Nagpur");
        Console.ReadLine();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_interest_oop
{
    public class  interest
    {
        public int Principal;
        public int Year;
        public float Rate;

        //public interest(int principal, int year, int rate) 
        //{
        //    Principal = principal;
        //    Year = year;
        //    Rate = rate;

        //}
        public interest(int principal, int year, float rate=2.5f)
        {
            Principal = principal;
            Year = year;
            Rate = rate;

        }
        public void simpleinterest()
        {
            float simpleinterest = (Principal * Year * Rate)/100  ;
            Console.WriteLine("Simple interest  = " + simpleinterest);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            interest Interest = new interest(100,23,4);
            Interest.simpleinterest();

            interest Interest1 = new interest(123,3,3);
            Interest1.simpleinterest();
            Console.ReadLine();
            
        }
    }
}


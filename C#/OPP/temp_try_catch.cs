using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    public class Temperaturex:ApplicationException
    {
        public Temperaturex(string mess):base(mess)
        {

        }
    }
    public class Temperature
    {
        public int temp;
        public void display(int t)
        {
            if(t==0)
            {
                throw (new Temperaturex("Zero Temperature found"));
            }
            else
            {
                Console.WriteLine("Temperature is: " + t);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature t = new Temperature();
            try
            {
                Console.WriteLine("Enter Temperature:");
                int temp = Convert.ToInt32(Console.ReadLine());
                t.display(temp);
            }
            catch(Temperaturex ee)
            {
                Console.WriteLine("Temperature isss:" + ee.Message);
            }
            Console.ReadKey();
        }
    }
}
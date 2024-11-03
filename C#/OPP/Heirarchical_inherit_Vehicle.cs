using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heirarchical_inherit_Vehicle
{
    class Vehicle
    {
        public void vehicle()
        {
            Console.WriteLine("Vehicle");
        }
    }
    class Car:Vehicle
    {
        public void car()
        {
            Console.WriteLine("Car Start....");
            Console.WriteLine("Car Stop.....");
        }
    }
    class Truck:Vehicle
    {
        public void truck()
        {
            Console.WriteLine("Truck Start...");
            Console.WriteLine("Truck Stop......");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.car();
            Truck t = new Truck();
            t.truck();
            Console.ReadKey();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheritance_Example
{
    class Vehicle
    {
        public int make;
        public int model;
    }
    class Car:Vehicle
    {
        public int Numdoors;
        public string fuel;
        public void getdata(int make,int model,int Numdoors,string fuel)
        {
            this.make = make;
            this.model = model;
            this.Numdoors = Numdoors;
            this.fuel = fuel;
        }
        public void display()
        {
            Console.WriteLine("Car Make: " + make);
            Console.WriteLine("Car Model: " + model);
            Console.WriteLine("Car Numdoors: " + Numdoors);
            Console.WriteLine("Car Fuel: " + fuel);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Console.WriteLine("Enter Make Date:");
            int make = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Model:");
            int model = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Numdoors:");
            int numdoors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Fuel Type");
            string fuel = Console.ReadLine();
        
            c.getdata(make, model, numdoors, fuel);
            c.display();
            Console.ReadKey();

        }
    }
}
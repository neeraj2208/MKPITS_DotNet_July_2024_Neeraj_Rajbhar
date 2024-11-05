using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Car
{
    internal class Program
    {
        class Car
        {
            public int price;
            public string brand;
            public Car(int price , string brand)
            {
                this.price = price;
                this.brand = brand;
            }
            public void display()
            {
                Console.WriteLine("Car price: " + price);
                Console.WriteLine("Car brand: " + brand);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Car price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Car Brand: ");
            string brand = Console.ReadLine();
            Car c1 = new Car(price,brand);
            c1.display();
            Console.ReadKey();
            

        }
    }
}
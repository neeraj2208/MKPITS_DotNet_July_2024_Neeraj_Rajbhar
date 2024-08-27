using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_shapes_oop
{
    class shape
    {
        double pi = 3.14;        
        public double area(double length, double breadth)
        {
            return length * breadth;

        }
        public double area(double radius)
        {
            return radius * radius * pi;

        }
        public double area(double baselength, int height)
        {
            return 0.5 * baselength * height;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            shape shapes = new shape();

            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double circleArea = shapes.area(radius);
            Console.WriteLine("The area of the circle is: " + circleArea);

           
            Console.Write("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the breadth of the rectangle: ");
            double breadth = Convert.ToDouble(Console.ReadLine());

            double rectangleArea = shapes.area(length, breadth); 
            Console.WriteLine($"The area of the rectangle  is: "+ rectangleArea);

            
            Console.Write("Enter the base of the triangle: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height of the triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double triangleArea = shapes.area(baseLength, height); 
            Console.WriteLine($"The area of the triangle is: "+ triangleArea);
            Console.ReadLine();
        }
    }
}

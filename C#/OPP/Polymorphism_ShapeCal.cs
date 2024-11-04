using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_ShapeCal
{
    class Shape
    {
        public int radius;
        public int rec;
        public float tri;
        public virtual void calculatearea(int n1, int n2)
        {
            Console.WriteLine("Shape class");
        }
        
    }
    class Rectangle:Shape
    {
        public override void calculatearea(int n1,int n2)
        {
             rec = n1 * n2;
            Console.WriteLine("Area of Rectangle is: " + rec);
        }
       
    }
    class Triangle:Shape
    {
        public override void calculatearea(int n1, int n2)
        {
             tri= 0.5f* n1 * n2;
            Console.WriteLine("Area of Triangle is: " + tri);
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter Length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Breadth: ");
            int breadth = Convert.ToInt32(Console.ReadLine());
            Shape r = new Rectangle();
            r.calculatearea(length, breadth);

            Console.WriteLine("Enter Base ");
            int based= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Shape t= new Triangle();
            t.calculatearea(based, height);
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation_OOP
{
        public class  ArithmaticOP
        {
            double num1;
            double num2;
        public ArithmaticOP(double Num1, double Num2)
        {
            num1 = Num1;
            num2 = Num2;
        }
        public void operation()
        {
            double add = num1 + num2;
            Console.WriteLine("ADDITION : " + add);
           
            double sub = num1 - num2;
            Console.WriteLine("SUBTRACTION : " + sub);
           
            double multi = num1 * num2;
            Console.WriteLine("MULTIPLICATION : " + multi);
           
            double div = num1 / num2;
            Console.WriteLine("DIVISION : " + div);
        }
            //public void Add()
            //{
            //    double add = num1 + num2;
            //    Console.WriteLine("ADDITION : " + add);
            //public void Subtract()
            //{
            //    double sub = num1 - num2;
            //    Console.WriteLine("SUBTRACTION : " + sub);
            //}
            //public void  Multiply()
            //{
            //    double multi = num1 * num2;
            //    Console.WriteLine("MULTIPLICATION : "+ multi);
            //}
            //public  void Division()
            //{
            //    double div = num1 / num2;
            //    Console.WriteLine("DIVISION : " + div );
            // }

        }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToInt32(Console.ReadLine());

            ArithmaticOP op = new ArithmaticOP(num1, num2);
            op.operation();
            //op.Add();
            //op.Subtract();
            //op.Multiply();
            //op.Division();     
            Console.ReadLine();
        }
    }
}

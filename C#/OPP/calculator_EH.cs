using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_3_Exception_Handling
{
    public class Calculator
    {
        // Properties
        public double Result { get; private set; }

        // Methods

        // Addition
        public void Add(double num)
        {
            Result += num;
        }

        // Subtraction
        public void Subtract(double num)
        {
            Result -= num;
        }

        // Multiplication
        public void Multiply(double num)
        {
            Result *= num;
        }

        // Division
        public void Divide(double num)
        {
            if (num != 0)
            {
                Result /= num;
            }
            else
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
        }

        // Clear the calculator result
        public void Clear()
        {
            Result = 0;
        }
    }

    // Example usage
    class Program
    {
        static void Main()
        {
  
            Calculator myCalculator = new Calculator();


            myCalculator.Add(5);
            Console.WriteLine("Result: " + myCalculator.Result);

            myCalculator.Subtract(2);
            Console.WriteLine("Result: " + myCalculator.Result);

            myCalculator.Multiply(3);
            Console.WriteLine("Result: " + myCalculator.Result);

            myCalculator.Divide(2);
            Console.WriteLine("Result: " + myCalculator.Result);

            myCalculator.Clear();
            Console.WriteLine("Result after clearing: " + myCalculator.Result);
            Console.ReadKey();
        }
    }

}
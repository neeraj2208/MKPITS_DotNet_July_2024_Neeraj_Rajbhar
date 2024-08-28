using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter num1: ");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine("The addition of two number is:"+sum);

            int sub = num1 - num2;
            Console.WriteLine("The subtraction of two number is:"+sub);

            int multi = num1 * num2;
            Console.WriteLine("The multiplication of two number is:"+multi);

             int Div = num1/num2;
            Console.WriteLine("The division of two number is:");
           


            Console.WriteLine("The modulus of two number is:");
            int mod = num1 % num2;

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_min_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 23, 45, 12, 67, 34, 89, 2, 56 };

            int max = numbers[0];
            int min = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                    max = number;
                if (number < min)
                    min = number;
            }

            Console.WriteLine("Maximum: "+ max +" Minimum:" + min);
            Console.ReadLine();
        }
    }
}

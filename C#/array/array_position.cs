using System;
using System.Net.Mime;

namespace Find_element_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag = 0, position = 0;
            Console.WriteLine("Enter Number to find in array");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] array = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < array.Length; i++)
            {
                if (num == array[i])
                {
                    flag++;
                    position = i + 1;
                }

            }
            if (flag == 1)
            {
                Console.WriteLine("Element found in Array= " + num + " on position= " + position);
            }
            else
            {
                Console.WriteLine("Not Spotted Here, Please Find Somewhere Else ");
            }


            Console.ReadKey();

        }
    }
}
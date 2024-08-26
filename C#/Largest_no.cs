using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_largest_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, largest, secondlargest, thirdlargest;
            Console.Write("Enter the number of elements in array: ");
            num = Convert.ToInt32(Console.ReadLine());   

            int[] arr = new int[num];

            Console.WriteLine("Enter the elemts in array");

            for (int iterate = 1; iterate < =num; iterate++)
            {
                arr[iterate] = Convert.ToInt32(Console.ReadLine());  
            }

            largest = 0;
            secondlargest = 0;
            thirdlargest = 0;

            for (int iterate = 1; iterate < num; iterate++)
            {
                if (arr[iterate] > largest)
                {
                    largest = arr[iterate];
                }
            }
            for (int iterate = 1; iterate < num; iterate++)
            {
                if (arr[iterate] > secondlargest && arr[iterate]<largest)
                {
                    secondlargest = arr[iterate];
                }
            }

            for (int iterate = 1; iterate < num; iterate++)
            {
                if (arr[iterate] > thirdlargest && arr[iterate] < secondlargest)
                {
                    thirdlargest = arr[iterate];
                }
            }


            Console.WriteLine("the largest elemet in the array is "+largest);
            Console.WriteLine("the second largest elemet in the array is " + secondlargest);
            Console.WriteLine("the third  largest elemet in the array is " + thirdlargest);


            Console.ReadLine();
        }
    }
}

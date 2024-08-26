using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr1=new ArrayList();
            arr1.Add(1);
            arr1.Add("Neeraj ");
            arr1.Add(1.8);
            arr1.Add(18);

            Console.WriteLine(arr1.Capacity);
            for (int index = 0; index < arr1.Capacity; index++)
            {
                Console.WriteLine(arr1[index]);
            }
            Console.ReadLine();



        }
    }
}

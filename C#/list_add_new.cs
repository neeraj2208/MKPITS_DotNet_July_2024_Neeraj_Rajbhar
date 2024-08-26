using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace arraylist1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr= new ArrayList();
            arr.Add("8-1=7");
            arr.Add("MS Dhoni");
            arr.Add("Back to pavilion");
            

            Console.WriteLine("Initial Count of array List:" + arr.Count);
            for(int iterate=0;iterate<arr.Count; iterate++)
            {
                Console.WriteLine(arr[iterate]);
            }
            arr.Add("greatest captain");
            arr.Add("of the era");
            Console.WriteLine("------New ArrayList-------");
            for(int index=0;index<arr.Count;index++)
                { Console.WriteLine(arr[index]); }
            Console.ReadLine();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array.empnumb
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string [] Employename = {"Neeraj","Suraj"};
            int[] employeID = { 1, 2 };

            Console.Write("Employee Name\t\t\t Employee ID");
            Console.Write("                               ");

            for(int i = 0; i < employeID.Length; i++) 
            { 
                Console.WriteLine(employeId[i])+"\t"+ Employename[i]);
            }     
            Console.ReadLine();
        }
    }
}

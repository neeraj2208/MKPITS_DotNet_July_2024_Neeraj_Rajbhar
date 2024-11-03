using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Out_Range_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            try
            {
                for (int i = 0; i <= 3; i++)
                    Console.WriteLine(arr[i]);
            }
            catch(IndexOutOfRangeException ee)
            {
                Console.WriteLine("Catch block is executing");
                Console.WriteLine(ee.ToString());
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Finally Block is executing");
            }
            Console.ReadKey();
        }
        
    }
}
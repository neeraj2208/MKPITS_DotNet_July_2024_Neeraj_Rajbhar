using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_userinput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> marks = new List<int>();
            int n = 234;
            while (n != 0)
            {
                Console.WriteLine("1.ADD\t0.terminate\t2.Insert\t3.Remove");

                int b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    marks.Add((Convert.ToInt32(Console.ReadLine())));
                }
                else if (b == 2)
                {
                    Console.Write("Enter the Position");
                    int z = Convert.ToInt32(Console.ReadLine());

                    marks.Insert(z, (Convert.ToInt32(Console.ReadLine())));
                }
                else if (b == 3)
                {

                    Console.WriteLine("Remove at position");
                    int k = Convert.ToInt32(Console.ReadLine());
                    marks.RemoveAt(k);
                }
                else
                {
                    n = 0;
                } 
            }
            foreach (int i in marks)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine(); 
        }
    }
}
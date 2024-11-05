using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overload_Addition
{
    internal class Program
    {
        class Addition
        {
            public void add(int n1,int n2)
            {
                int result = n1 + n2;
                Console.WriteLine(result);
            }
            public void add(float n1,float n2)
            {
                float result = n1 + n2;
                Console.WriteLine(result);
            }
        }
        static void Main(string[] args)
        {
            Addition a=new Addition();
            a.add(1,2);
            a.add(1.1f, 2.1f);
            Console.ReadKey();

        }
    }
}
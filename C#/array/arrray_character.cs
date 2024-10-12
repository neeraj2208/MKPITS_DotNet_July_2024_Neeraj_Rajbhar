using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] word = new char[3];
            int i;
            int sum = 0;
            for(i=0;i<3;i++)
            {
                Console.WriteLine("Enter Character");
                word[i] = Convert.ToChar(Console.ReadLine());
            }
            for(i=0;i<3;i++)
            {
                Console.WriteLine("Word is {0}", word[i]);
            }
            Console.ReadKey();

        }
    }
}
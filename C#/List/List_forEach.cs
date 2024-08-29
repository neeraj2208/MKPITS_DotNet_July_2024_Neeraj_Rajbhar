using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> marks = new List<int>() { 76, 99, 87, 70, 80, 85 };
            List<string> Subjects = new List<string>() { "English", "Maths", "Hindi", "Marathi", "Sanskrit", "History" };
            Subjects.Add("Chemistry");
            foreach (int mark in marks)
            {
                Console.WriteLine(mark);

            }
            Subjects.Remove("English");
            Subjects.Insert(0,"Biology");
            foreach (string sub in Subjects)
            {
                Console.WriteLine(sub);

            }
            Console.ReadLine();
        }
    }
}

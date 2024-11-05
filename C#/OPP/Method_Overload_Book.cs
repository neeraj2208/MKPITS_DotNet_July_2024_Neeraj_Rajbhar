using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overload_Book
{
    internal class Program
    {
        class Book
        {
            string Name;
            int Id;
            string Title;
            public void getdata()
            {
                Name = "John";
                Id = 123;
                Title = "First World War";
            }
            public void getdata(string Name,int Id,String Title) 
            {
                this.Name = Name;
                this .Id = Id;
                this .Title = Title;
            }
            public void display()
            {
                Console.WriteLine("Book Name: " + Name);
                Console.WriteLine("Book Id: " + Id);
                Console.WriteLine("Book Title: " + Title);
            }


        }
        static void Main(string[] args)
        {
            Book book = new Book();
            book.getdata();
            book.display();

            Book book1 = new Book();
            book1.getdata("Horrer", 123, "Jungle Book");
            book1.display();

            Book book2 = new Book();
            Console.WriteLine("Enter Book Name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Book Id: ");
            int Id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Book Title: ");
            string Title = Console.ReadLine();
            book2.getdata(Name, Id, Title);
            book2.display();
            Console.ReadKey();


        }
    }
}
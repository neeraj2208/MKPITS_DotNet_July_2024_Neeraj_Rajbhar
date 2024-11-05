using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Constructor2ParaBook
{
    internal class Program
    {
        class Book
        {
            int Id;
            string Title;
            string Author;
            int Price;
            public Book()
            {
                Id = 123;
                Title = "man of india";
                Author = "Suraj";
                Price = 250;
                
            }
            public Book(int id, string title, string author, int price)
            {
                this.Id = id;
                this.Title = title;
                this.Author = author;
                this.Price = price;
            }
            public void display()
            {
                Console.WriteLine("Book Id :" + Id);
                Console.WriteLine("Book Title :" + Title);
                Console.WriteLine("Book Author :" + Author);
                Console.WriteLine("Book Price :" + Price);

            }
        }
        static void Main(string[] args)
        {
            Book b = new Book();
            b.display();

            Book b1= new Book(123,"jsw","steel",256);
            b1.display();
            Console.ReadKey();
        }
    }
}
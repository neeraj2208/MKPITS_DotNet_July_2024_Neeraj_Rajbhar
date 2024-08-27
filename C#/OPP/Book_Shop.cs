using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_shop_oop
{
    public class BookShop
    {
        string Name;
        string Title;
        string Publisher;
        int Price;

        public void Assignvalues(string Name, string Title, string Publisher, int Price)
        {
            this.Name = Name;
            this.Title = Title;
            this.Publisher = Publisher;
            this.Price = Price;
        }
        public void DisplayValues()
        {
            Console.WriteLine("The name of Author is : " + Name);
            Console.WriteLine("Name of  Title  : " + Title);
            Console.WriteLine("The name of Publisher is : " + Publisher);
            Console.WriteLine("The Price is  : " + Price);
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                BookShop books = new BookShop();
                books.Assignvalues("Neeraj Chopra" , "From  Dreams to Gold", "Neeraj publication", 210);
                books.DisplayValues();
                Console.ReadLine();
            }
        }
    }
}
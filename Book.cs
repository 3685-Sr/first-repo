using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_3
{
    public class Book
    {   
        //fields - полета
        public string Title;
        public string Author;
        public int Pages;
        public double Price;

        //constructor - конструктор
        public Book(string title, string author, int pages, double price)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Price = price;
        }

        public void PrintBookData()
        {
            Console.WriteLine("Title:" + Title);
            Console.WriteLine("Author:" + Author);
            Console.WriteLine("Pages:" + Pages);
            Console.WriteLine("Price:" + Price);
        }
    }
}

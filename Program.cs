using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Under the yoke", "Ivan Vazov", 215, 18.50);
            Book book2 = new Book("Brothers Karamazov", "Fedor Dostoevskiy", 818, 35.99);
            Book book3 = new Book("Future", "Dimitriy Gluhovkiy", 389, 25.90);

            book1.PrintBookData();
            Console.WriteLine("============");
            book2.PrintBookData();
            Console.WriteLine("============");
            book3.PrintBookData();
            Console.WriteLine("============");
        }

    }
}
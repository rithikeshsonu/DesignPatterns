using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice.Exercises
{
    public class Book
    {
        public string Title;
        public string Author;
        public double Price;
        public string ISBN;

        public Book(string title, string author)
        {
            Author = author;
            Title = title;
        }
        public Book(string title, string author, double price, string isbn)
        {
            Title = title;
            Author = author;
            Price = price;
            ISBN = isbn;
        }
    }
}

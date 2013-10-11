using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Book
    {
        string title;
        string author;
        decimal price;

        public string Title { 
            get { return title;}            
        }

        public string Author {
            get { return author; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = Math.Round(value, 2); }
        }

        public Book(string title, string author, decimal price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }
    }
}

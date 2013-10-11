using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Movie
    {
        string title;
        string year;
        decimal price;

        public string Title { 
            get { return title;}            
        }

        public string Year {
            get { return year; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = Math.Round(value, 2); }
        }

        public Movie(string title, string year, decimal price)
        {
            this.title = title;
            this.year = year;
            this.price = price;
        }
    }
}

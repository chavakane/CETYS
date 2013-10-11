using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Movie
    {
        string title;
        Person director;
        decimal price;

        public string Title { 
            get { return title;}            
        }

        public Person Director {
            get { return director; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = Math.Round(value, 2); }
        }

        public Movie(string title, Person director, decimal price)
        {
            this.title = title;
            this.director = director;
            this.price = price;
        }
    }
}

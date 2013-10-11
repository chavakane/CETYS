using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Person
    {
        string name;
        DateTime birthday;
        string email;
        List<Book> bookCollection;

        public string Name { 
            get { return name; }
        }

        public DateTime Birthday { 
            get { return birthday; }
        }

        public string Email {
            get { return email; }
            set { email = value; }
        }

        public List<Book> BookCollection {
            get { return bookCollection; }            
        }

        public Person(string name, DateTime birthday, string email)
        {
            this.name = name;
            this.birthday = birthday;
            this.email = email;
            this.bookCollection = new List<Book>();
        }

        public void BuyBook(Book book)
        {
            this.bookCollection.Add(book);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExamples.Classes
{
    //Single Responsibility Principle
    public class Enemy
    {
        public string Name;
        public string[] Mision;
        public string Quote;
        public int Lives;

        public Enemy(string Name, string[] Mision, string Quote)
        {
            this.Name = Name;
            this.Mision = Mision;
            this.Quote = Quote;
            this.Lives = 4;
        }

        public void SayQuote()
        {
            Console.WriteLine("My name is {0}, {1}",this.Name,this.Quote);
        }

        public void Attack(Place place)
        {
            Console.WriteLine("{0} is attacking {1}, Powerpuffgirls, save us",this.Name,place.Name);
            place.inDanger = true;
        }
    }
}

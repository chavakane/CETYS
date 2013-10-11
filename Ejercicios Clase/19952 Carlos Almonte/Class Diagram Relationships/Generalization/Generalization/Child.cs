using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalization
{
    class Child : Parent
    {
        public int Mucks { get; set; }

        public Child(string name, string lastname, short age, int mucks)
            : base(name, lastname, age)
        {
            this.Mucks = mucks;
        }

        public override void Work()
        {
            if (base.Age >= 18)
                base.Work();
            else
            {
                Console.Write(Name + ": I'm too young to work");
                this.Play();
            }
        }

        public void Play()
        {
            Console.WriteLine(", playing with " + Mucks + " mucks!");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExamples.Classes
{
    public class Bubbles : PowerpuffGirl
    {
        public Bubbles(string Name, Enemy Enemy)
        {
            this.Name = Name;
            this.Enemy = Enemy;
        }

        public void UltrasonicScreams(Enemy enemy, Place place)
        {
            if (place.inDanger == true)
            {
                Console.WriteLine("Bubbles: Ahhhhhhhhh to call all the animals");
                if (enemy.Lives == 0)
                {
                    Console.WriteLine("{0} is defeated by {1}\n", enemy.Name, this.Name);
                    place.inDanger = false;

                }
                else if (enemy.Lives <= 4)
                {
                    Console.WriteLine("{0} is hurt, minus 1 live!!!", enemy.Name);
                    enemy.Lives--;

                }
            }
        }


        public void Omnilingualism()
        {
            Console.WriteLine("Bubbles: Understanding any language");
        }
    }
}


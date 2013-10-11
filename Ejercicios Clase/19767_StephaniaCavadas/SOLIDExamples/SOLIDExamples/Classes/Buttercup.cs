using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExamples.Classes
{
    class Buttercup : PowerpuffGirl
    {
        public Buttercup(string Name, Enemy Enemy)
        {
            this.Name = Name;
            this.Enemy = Enemy;
        }

        public void BlackHurricane(Enemy enemy, Place place)
        {
            if (place.inDanger == true)
            {
                Console.WriteLine("Buttercup: Black Hurricane to {0}!!!!", this.Enemy);
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

        public void Fireball(Enemy enemy, Place place)
        {
            if (place.inDanger == true)
            {

                Console.WriteLine("Buttercup: Throwing fireballs to {0}!!!!", enemy.Name);

                if (enemy.Lives == 0)
                {
                    Console.WriteLine("{0} is defeated by {1}\n", enemy.Name, enemy.Name);
                    place.inDanger = false;
                }

                else if (enemy.Lives <= 4)
                {
                    Console.WriteLine("{0} is burned, minus 1 live!!!", enemy.Name);
                    enemy.Lives--;
                }
            }

        }
    }
}

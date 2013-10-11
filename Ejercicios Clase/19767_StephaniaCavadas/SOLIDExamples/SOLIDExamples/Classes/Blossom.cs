using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExamples.Classes
{
    public class Blossom : PowerpuffGirl
    {
        public Blossom(string Name, Enemy Enemy)
        {
            this.Name = Name;
            this.Enemy = Enemy;
        }

        public void IceBreath(Enemy enemy, Place place)
        {
            if (place.inDanger == true)
            {
                Console.WriteLine("Blossom: Freezing {0}!!!!!", enemy.Name);
                if (enemy.Lives == 0)
                {
                    Console.WriteLine("{0} is defeated by {1}\n", enemy.Name, this.Name);
                    place.inDanger = false;
                }
                else if (enemy.Lives <= 4)
                {
                    Console.WriteLine("{0} is frozen, minus 1 live!!!", enemy.Name);
                    enemy.Lives--;
                }
                
            }
        }

        public void MicroscopicVision(string item)
        {
            Console.WriteLine("Blossom: Looking to {0} with my microscopic vision!!!!!", item);
        }
    }
}

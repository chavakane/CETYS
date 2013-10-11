/* Profe! trate de seguir un orden en el programa para que siguiera los principios SOLID, se me hizo de esta manera mas facil 
 * ya que puedo ordenar mi proyecto, estructurarlo, dejar que tenga la oportunidad de crecimiento despues y tenga las clases divididas,
 *para tener mas funcionalidad en el programa*/


using SOLIDExamples.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] MojojojoMisions = { "Kill the Powerpuff girls" };
                string[] FuzzyLumpkinsMisions = { "Protect his property" };
                string[] HimMisions = { "Harm the powerpuff girls" };

                Enemy MojoJojo = new Enemy("Mojo Jojo", MojojojoMisions, "Curseeees!!!");
                Enemy FuzzyLumpkins = new Enemy("Fuzzy Lumpkins", FuzzyLumpkinsMisions, "Aghh! is my property!!");
                Enemy Him = new Enemy("Him", HimMisions, "I'm evil, muahahaha");

                Place Saltadilla = new Place("Townsville", false,0);
                Place PokeyOaks = new Place("Pokey Oaks Kindergarten", false,1);
                Place House = new Place("House", false,2);

                Blossom blossom = new Blossom("Blossom", MojoJojo);
                Bubbles bubbles = new Bubbles("Bubbles", Him);
                Buttercup buttercup = new Buttercup("Buttercup", FuzzyLumpkins);

                for (int i  = 0; i  < 5; i ++)
                {
                    MojoJojo.Attack(Saltadilla);
                    blossom.IceBreath(MojoJojo, Saltadilla);
                }
                for (int i = 0; i < 5; i++)
                {
                    Him.Attack(PokeyOaks);
                    bubbles.UltrasonicScreams(Him,PokeyOaks);
                }
                for (int i = 0; i < 5; i++)
                {
                    FuzzyLumpkins.Attack(House);
                    buttercup.Fireball(FuzzyLumpkins, House);
                }
                Console.ReadLine();

            }


        }
    }
}

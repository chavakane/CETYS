using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadSeptiembre13
{
    class Pikachu : Pokemon
    {

        public Pikachu()
        {
            Nombre = "Pikachu";
        }

        //State
        public override int NumeroPokedex { get { return 25; } }
        
        //Behavior
        public override void Attack()
        {
            Console.WriteLine("Thunder!"); 
        }

        public override void Saludo()
        {
            base.Saludo();
            Console.WriteLine("Pikachu!!");
        }

    }
}

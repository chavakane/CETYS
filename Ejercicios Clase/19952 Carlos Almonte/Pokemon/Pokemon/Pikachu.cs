using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Pikachu : Pokemon
    {
        public Pikachu()
        {
            Nombre = "Pikachu";
        }

        public string Nombre
        {
            get { return base.Nombre.ToLower(); }
            set { base.Nombre = value; }
        }

        public override int NumeroDePokedex
        {
            get { return 25; }
        }

        public override void Ataque()
        {
            throw new NotImplementedException();
        }

        public override void Saludo()
        {
            base.Saludo();
            Console.WriteLine("pikapi!");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability
{
    //No me encargo de las ordenes, solo de producir la comida
    class Comida
    {
        

        public void ProducirHamburguesaCarne(string NombreOrden, string[] ExtraIngredientes) { }
        public void ProducirHamburguesaPollo(string NombreOrden, string[] ExtraIngredientes) { }
        public void FreirPapas(bool ContienenChili) { }
    }
}

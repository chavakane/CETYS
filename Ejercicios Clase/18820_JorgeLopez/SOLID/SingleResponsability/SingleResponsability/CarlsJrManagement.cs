using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability
{
    /*La intencion de la clase es poder tener todos los metodos necesarios para correr un carlitos
     pero seria mas facil si lo dividimos en departamentos. */
    class CarlsJrManagement
    {

        //Cajas
        public void TomarOrden();
        public void EntregarOrden();
        //Cocina
        public void ProducirHamburguesaCarne(string NombreOrden, string[] ExtraIngredientes) { }
        public void ProducirHamburguesaPollo(string NombreOrden, string[] ExtraIngredientes) { }
        public void FreirPapas(bool ContienenChili) { }
        //La Segnora que atiende nomas a los que quieren conitos
        public void PrepararMalteada(string Sabor) { }
        public void PrepararSmoothie(string Sabor) { }
        public void PrepararConoDeNieve(string Sabor) { }
    }
}

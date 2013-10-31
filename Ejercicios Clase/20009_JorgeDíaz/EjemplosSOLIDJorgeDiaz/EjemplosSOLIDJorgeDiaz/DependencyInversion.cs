using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosSOLIDJorgeDiaz
{
    /*
     * El principio pide que las clases de nivel alto
     * no dependan de clases de nivel bajo y que ambos niveles de clases
     * deben depender en abstracciones, pero la clase de nivel alto debe de depender de ellas indirectamente.
     */

    //abstraccion en interface
    interface IAbeja
    {
         void trabajar();
    }


    //clase de nivel bajo
    public class AbejaTrabajadora : IAbeja
    {

        public void trabajar()
        {
            // Trabaja la abeja
        }
    }

    //Clase de nivel Alto
    public class Abeja {
        IAbeja trabajadora;

        void ponerTrabajadora(IAbeja a)
        {
            trabajadora = a;
        }

        public void OrdenarATrabajarAbeja()
        {
            trabajadora.trabajar();
        }

    }

}

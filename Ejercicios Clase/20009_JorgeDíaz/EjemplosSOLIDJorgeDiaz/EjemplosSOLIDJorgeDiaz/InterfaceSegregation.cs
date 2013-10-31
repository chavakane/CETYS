using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosSOLIDJorgeDiaz
{

    // InterfaceSegregation dicta que los "clientes"
    // no deben ser forzados a depender en interfaces
    // que no van a utilizar, esto se refiere a no utilizar
    // interfaces con funciones demas que la clase que las implemente
    // no vaya a necesitar. Abajo se programo un mal ejemplo de una interfaz
    // que rompe este principio y luego se divide en dos y se aplica a unas clases.

    // Ejemplo de MALA INTERFAZ
    interface IMoverse
    {
        void Correr();
        void Volar();
    }

    interface ICorrer
    { 
        void Correr();
    }

    interface IVolar
    {
        void Volar();
    }


    public class Antilope: ICorrer
    {

        public void Correr()
        {
            // Correr a su manera
        }
    }

    public class Pato : ICorrer, IVolar
    {
        public void Volar()
        {
            //Como vuela el pato
        }

        public void Correr()
        {
           //Como correria el pato si puede.
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            //Association!
            
            Estadio objEstadio = new Estadio();
            Aficionado objAficionado = new Aficionado();

            objEstadio.Invitar(objAficionado);
            objAficionado.AsistirAEstadio(objEstadio);

            //Agregation!
            VendedorPizza objVendedorPizza = new VendedorPizza();

            objVendedorPizza.venderPizza(objEstadio);

            //Dependecy!
            objEstadio.ContarAficionados();

            //Generalization!
            HijaAficionado objHijaAficionado = new HijaAficionado();
            HijoAficionado objHijoAficionado = new HijoAficionado();

            objAficionado.equipo = "Xolos";
            objHijaAficionado.equipo = "Real Madrid...";
            objHijoAficionado.equipo = "Barcelona, el mejor equipo de la historia!";

            Console.Write("El papa es aficionado de {0}, la hija de {1} y el hijo de {2}\n", objAficionado.equipo, objHijaAficionado.equipo, objHijoAficionado.equipo);

            //Composition!

            Gradas objGradas = new Gradas();
            objGradas.existentes = true;

            objEstadio.Destruir(objGradas, objEstadio);
            if (objGradas.existentes == false)
            {
                Console.Write("Tambien murieron las gradas");
            }

            Console.ReadLine();
        }
    }
}

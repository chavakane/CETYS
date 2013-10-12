using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitectura_de_Software___Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Embarcacion Em = new Embarcacion("Perla Negra", "Jack Sparrow");
            Marino m1 = new Marino("Omar Olmos", Marino.tipo_marinero.Piloto);
            Marino m2 = new Marino("Jose Alamo", Marino.tipo_marinero.Mecanico);
            Em.Marinos.Add(m1);
            Em.Marinos.Add(m2);
            Console.WriteLine("Informacion Embarcacion:\n ");
            Console.WriteLine("Nombre Embarcacion: " + Em.Nombre);
            Console.WriteLine("\nTripulacion: ");
            Console.WriteLine("\nNombre Capitan: " + Em.Capitan.Nombre);
            foreach (var m in Em.Marinos)
            {
                Console.WriteLine("\nNombre Marino: " + m.Nombre);
                Console.WriteLine("Tipo Marino: " + m.TipoMarinero);

            }
            Console.WriteLine("\nPresinar enter para continuar...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Oh no!!! El "+Em.Nombre+" esta siendo atacado D:!!");
            Console.WriteLine("Presinar enter para continuar...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Es inevitable El " + Em.Nombre + " no soporto el ataque y se hundio..");
            Em = null;
            Console.WriteLine("Presinar enter para continuar...");
            Console.ReadLine();
            Console.Clear();
            try
            {
                Console.WriteLine(Em.Capitan.Nombre);
            }
            catch
            {
                Console.WriteLine("Como todo buen capitan, el capitan de este barco se hundio junto con su barco");
                Console.WriteLine("\nLos sobrevivientes son:");
                Console.WriteLine("\nNombre sobreviviente: " + m1.Nombre);
                Console.WriteLine("\nNombre sobreviviente: " + m2.Nombre);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

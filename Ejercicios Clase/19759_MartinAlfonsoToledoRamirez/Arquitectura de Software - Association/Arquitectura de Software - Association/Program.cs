using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitectura_de_Software___Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informacion:");
            Chef PrimerChef = new Chef("Chin Chon Papas");
            Cocina t = new Cocina(PrimerChef, "Primer Cocina", "China");
            Console.WriteLine("Nombre Cocinero: {0}\nNombre Cocina: {1}\nNombre Cocinero de Cocina: {2}\nNombre Estilo Cocina: {3}",
                PrimerChef.Nombre, t.Nombre, t.Cocinero.Nombre, t.Estilo);
            Console.WriteLine("Pulsa enter para continuar...");
            Console.ReadLine();
            t = null;
            Console.WriteLine("Oh no!! la cocina se ha incendiado D:!");
            Console.WriteLine("Pulsa enter para ver la informacion de la cocina de nuevo...");
            Console.ReadLine();
            try
            {
                Console.WriteLine("Nombre Cocinero: {0}\nNombre Cocina: {1}\nNombre Cocinero de Cocina: {2}\nNombre Estilo Cocina: {3}",
                PrimerChef.Nombre, t.Cocinero.Nombre, t.Nombre, t.Estilo);
            }
            catch
            {
                Console.WriteLine("No se puede ingresar la cocina dado que se incendio...");
                Console.WriteLine("Sin embargo el cocinero con el nombre de "+PrimerChef.Nombre+"\nesta feliz de no haber muerto en el incendio");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

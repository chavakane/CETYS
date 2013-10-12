using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitectura_de_Software___Dependency
{
    class Program
    {
        static void Main(string[] args)
        {
            Fax f = new Fax("El Fax number one");
            Documento d = new Documento("Hola profesor saludos :D!!!");
            Console.WriteLine("El fax con el nombre de "+f.Nombre+" ha recibido un mensaje");
            Console.WriteLine("Pulse enter para continuar...");
            Console.ReadLine();
            Console.WriteLine("Mensaje: "+f.imprimir(d));
            Console.WriteLine("Pulse enter para continuar...");
            Console.ReadLine();
            Console.WriteLine("Ha llegado otro mensaje");
            d.Mensaje = "Nos vemos en la clase profe :D!!";
            Console.WriteLine("Pulse enter para continuar...");
            Console.ReadLine();
            Console.WriteLine("Mensaje: " + f.imprimir(d));
            Console.ReadLine();
        }
    }
}

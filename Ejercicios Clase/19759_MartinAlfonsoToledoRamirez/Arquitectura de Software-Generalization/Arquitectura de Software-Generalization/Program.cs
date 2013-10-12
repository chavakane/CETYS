using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitectura_de_Software_Generalization
{
    class Program
    {
        static void Main(string[] args)
        {
            Maestro m = new Maestro("Chavacane","QWERTY123");
            Alumno a = new Alumno("Stephania",19767);

            Console.WriteLine("Informacion Maestro: ");
            Console.WriteLine("\nNombre: " + m.Nombre);
            Console.WriteLine("Clave Maestro: " + m.ClaveMaestro);

            Console.WriteLine("\nInformacion Alumno: ");
            Console.WriteLine("\nNombre: "+ a.Nombre);
            Console.WriteLine("Matricula: " + a.Matricula);
            Console.ReadLine();
        }
    }
}

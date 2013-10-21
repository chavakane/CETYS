using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLClassDiagramRelationshipsJorgeDiaz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generalizacion: Conserje es un Empleado

            Conserje conserje = new Conserje();
            conserje.ImprimirInfo();
            Console.ReadLine();


        }
    }
}

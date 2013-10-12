using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitectura_de_Software___Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Platillo P1 = new Platillo("Tacos de Pescado", 50, "Tres tacos de pescado con bebida incluida");
            Platillo P2 = new Platillo("Caldo Siete Mares", 60, "Caldo Siete Mares con bebida incluida");
            Platillo P3 = new Platillo("Agua-chile", 70, "Agua-chile con bebida incluida (bastante picoso)");
            Menu M1 = new Menu("Menu Mariscos", "Menu que contiene comida hecha con mariscos");
            M1.Platillos.Add(P1);
            M1.Platillos.Add(P2);
            M1.Platillos.Add(P3);
            M1.Platillos.Add(new Platillo("Coctel Mixto (Campechana)", 65, "Coctel con Camaron, Pulpo, Ostion y verdura (Bebida no incluida)"));
            Console.WriteLine("Informacion Menu:\n");
            int c = 1;
            foreach (Platillo p in M1.Platillos)
            {
                Console.WriteLine("Platillo numero " + c);
                Console.WriteLine("Nombre del Platillo: " + p.Nombre);
                Console.WriteLine("Precio del Platillo: " + p.Precio);
                Console.WriteLine("Descripcion del Platillo: " + p.Descripcion+"\n");
                c++;
            }
            Console.ReadLine();
        }
    }
}

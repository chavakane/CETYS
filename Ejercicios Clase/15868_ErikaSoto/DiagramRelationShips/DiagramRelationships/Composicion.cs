using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramRelationships
{
    class Composicion
    {

        public class Llantas
        {
            public void modelo(string modelo) { }
        }

        public class Puertas
        {
            public void abrir() { }
            public void cerrar() { }
        }

        public class Carrro
        {
            public Llantas[] llantas = new Llantas[4];
            public Puertas
              izq = new Puertas(),
              der = new Puertas(); 
           
            public Carrro()
            {
                for (int i = 0; i < 4; i++)
                    llantas[i] = new Llantas();
            }
            public static void main(String[] args)
            {
                Carrro car = new Carrro();
                car.llantas[0].modelo("sport");
            }
        }
    }
}

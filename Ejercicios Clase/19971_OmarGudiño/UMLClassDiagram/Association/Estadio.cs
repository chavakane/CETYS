using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    public class Estadio
    {
        public int aficionadosAdentro { get; set; }

        public void Invitar(Aficionado obj)
        {
            Console.Write("Estadio Parlante: Porfavor ven!\n");
        }

        public void Destruir(Gradas obj, Estadio estadio)
        {
            Console.Write("Estadio hico Selfdestruct: Destruyeron todo de todo\n");
            obj.existentes = false;
            estadio = null;
        }

        public void ContarAficionados()
        {
            Console.Write("Hay {0} aficionados adentro\n", aficionadosAdentro.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    public class Aficionado
    {
        public string equipo { get; set; }

        public void AsistirAEstadio(Estadio obj)
        {
            Console.Write("Aficionado: Creo que ire al estadio un ratillo\n");
            obj.aficionadosAdentro++;
        }
    }
}

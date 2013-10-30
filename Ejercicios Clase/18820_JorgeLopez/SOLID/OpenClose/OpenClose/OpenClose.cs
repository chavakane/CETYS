using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{

    /*De haber una especial o que se cambie el menu tendremos que meternos al codigo
     * responsable de las ordenes y modificarlo para que nuestra produccion de 
     * western bacons no se vea afectada. Por eso no conviene especificar  que haremos
     * de la manera en que se presenta aqui. Creo mejor regresar una Orden en lugar de regresar
     * un objeto derivado de orden o mejor aun delegarle la tarea a cada hamburguesa de encargarse 
     * de los detalles*/
    abstract class Orden
    {
        int numOrden;
    }

    class WesternBaconDoubleCheeseBurger : Orden
    {
        int numOrden = 1;
    }
    class BigCarl : Orden
    {
        int numOrden = 2;
    }

    class PrepararOrdenes
    {
        public Orden PrepararHamburguesa(int numOrden)
        {
            switch(numOrden)
            {
                case 1:
                    WesternBaconDoubleCheeseBurger hamburguer1 =  new WesternBaconDoubleCheeseBurger();
                    return hamburguer1;
                case 2:
                    BigCarl hamburguer2 = new BigCarl();
                    return hamburguer2;
                default:
                   WesternBaconDoubleCheeseBurger hamburguer3 =  new WesternBaconDoubleCheeseBurger();
                    return hamburguer3;
            }
        }
    }
}

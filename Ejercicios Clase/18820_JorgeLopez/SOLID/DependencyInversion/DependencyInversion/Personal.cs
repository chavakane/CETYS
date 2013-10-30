using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    /*Mu similar a OpenClose, porque ya no quemos lidiar con lo que esta
     establecido para el Manager, pero vemos que existe cierta redundancia.
     Si se implementa una interfaz podemos ahorrarnos lineas de codigo y 
     llamar a todos los trabajadores "ITrabajadores" que se pongan a chambear 
     con una sola linea.*/
    class Parrillero
    {
        public void Trabajar()
        { 
            /*Do some . . . DoubleDoubles*/
        }
    }
    class PapaFritero
    {
        public void Trabajar()
        {
            /*Do some . . . French Fries . . Animal Style */
        }
    }
    class InNOutManager
    {
        Parrillero estrella;
        public void PonerOrden(Parrillero p)
        {
            estrella = p;
            /*Quien anda de flojo ?*/
        }
        public void PonerOrden()
        {
            estrella.Trabajar();
            /*Orale a trabajars, hay hamburguesas ricas que hacer*/
        }
    }
}

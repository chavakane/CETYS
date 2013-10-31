using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosSOLIDJorgeDiaz
{
    //Single Responsibility Principle
    // Goomba solo se encarga de manejar los estados
    //  de un enemigo Goomba de Mario Bros.

    class Goomba
    {
        public int posicionX;
        public int posicionY;
        public bool estaVivo;

        public Goomba(int x, int y)
        {
            posicionX = x;
            posicionY = y;
            estaVivo = true;
        }

        public void moverse() 
        {
        // Logica de movimiento
        }
         
        
        
    }
}

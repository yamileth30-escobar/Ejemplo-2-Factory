using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_2.ObjetosSeguirReglas
{
    public class Rana_Toro : Reglas.IAcciones
    {
        public void comida()
        {
            Console.WriteLine("La rana toro está comiendo.");
        }

        public void Habla()
        {
            Console.WriteLine("La rana toro está croando.");
        }

        public void movimiento()
        {
            Console.WriteLine("La rana toro está saltando.");
        }
    }
}

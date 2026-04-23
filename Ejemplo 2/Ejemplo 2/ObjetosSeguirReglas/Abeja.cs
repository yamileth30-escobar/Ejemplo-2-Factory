using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_2.ObjetosSeguirReglas
{
    public class Abeja : Reglas.IAcciones
    {
        public void comida()
        {
            Console.WriteLine("La abeja está comiendo.");
        }

        public void Habla()
        {
            Console.WriteLine("La abeja está zumbando.");
        }

        public void movimiento()
        {
            Console.WriteLine("La abeja está volando.");
        }
    }
}

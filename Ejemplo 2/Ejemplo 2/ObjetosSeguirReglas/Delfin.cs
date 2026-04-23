using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_2.ObjetosSeguirReglas
{
    public class Delfin : Reglas.IAcciones
    {
                public void comida()
        {
            Console.WriteLine("Los delfines son carnívoros");
        }

        public void Habla()
        {
            Console.WriteLine("Los delfines emiten sonidos para comunicarse");
        }

        public void movimiento()
        {
            Console.WriteLine("Los delfines son nadadores ágiles");
        }
    }
}

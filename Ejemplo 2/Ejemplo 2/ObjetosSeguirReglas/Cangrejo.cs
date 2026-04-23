using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_2.ObjetosSeguirReglas
{
    public class Cangrejo : Reglas.IAcciones
    {
        public void comida()
        {
            Console.WriteLine("El cangrejo está comiendo.");
        }

        public void Habla()
        {
            Console.WriteLine("El cangrejo está haciendo sonidos.");
        }

        public void movimiento()
        {
            Console.WriteLine("El cangrejo está caminando de lado.");
        }
    }
}

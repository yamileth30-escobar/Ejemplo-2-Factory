using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Ejemplo_2.ObjetosSeguirReglas
{
    public class Humano : Reglas.IAcciones
    {
        public void comida()
        {
            Console.WriteLine("Los humanos son omnivoros");
        }

        public void Habla()
        {
            Console.WriteLine("El humano habla diversos idiomas segun su region");
        }

        public void movimiento()
        {
            Console.WriteLine("Hasta hace 200 year eran fisicamente activos");
        }
    }
}

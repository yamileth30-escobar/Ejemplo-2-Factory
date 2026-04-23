using Ejemplo_2.Reglas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_2.ObjetosSeguirReglas
{
    internal class Sope: Reglas.IAcciones
    {
        public void comida()
        {
            Console.WriteLine("Los sopes son alimentos típicos mexicanos");
        }

        public void Habla()
        {
            Console.WriteLine("Los sopes no hablan");
        }

        public void movimiento()
        {
            Console.WriteLine("Los sopes no se mueven");
        }
    }
}

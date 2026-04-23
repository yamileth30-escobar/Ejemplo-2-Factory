using Ejemplo_2.Seleccion_de_Animal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_2.FactoryClass
{
    public class CangrejoFactory : SeleccionAnimal
    {
        public override Reglas.IAcciones Selecionar()
        {
            return new ObjetosSeguirReglas.Cangrejo();
        }
    }
}

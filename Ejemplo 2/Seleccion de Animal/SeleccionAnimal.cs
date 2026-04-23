using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_2.Seleccion_de_Animal
{
    public abstract class SeleccionAnimal
    {
        public abstract Reglas.IAcciones Selecionar();
        public Reglas.IAcciones Actividad() {
            Reglas.IAcciones habilidad = Selecionar();
            habilidad.Habla();
            habilidad.movimiento();
            return habilidad;
        }
    }
}

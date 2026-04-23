using Ejemplo_2.FactoryClass;
using Ejemplo_2.Reglas;
using Ejemplo_2.Seleccion_de_Animal;

SeleccionAnimal seleccionar;
seleccionar = new HumanoFactory();
IAcciones habilidad = seleccionar.Selecionar();
seleccionar.Actividad();
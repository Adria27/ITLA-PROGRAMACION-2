using System;

namespace Miprimetrabajo.SubClases
{
    public class Docente : Miprimetrabajo.Empleado
    {
        public string Materia { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Materia: {Materia}");
        }
    }
}

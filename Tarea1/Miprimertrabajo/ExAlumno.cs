using System;

namespace Miprimetrabajo
{
    public class ExAlumno : MiembroDeLaComunidad
    {
        public DateTime FechaGraduacion { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Fecha de Graduación: {FechaGraduacion.ToShortDateString()}");
        }
    }
}

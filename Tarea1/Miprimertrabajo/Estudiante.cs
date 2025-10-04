using System;

namespace Miprimetrabajo
{
    public class Estudiante : MiembroDeLaComunidad
    {
        public double Promedio { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Promedio: {Promedio}");
        }
    }
}


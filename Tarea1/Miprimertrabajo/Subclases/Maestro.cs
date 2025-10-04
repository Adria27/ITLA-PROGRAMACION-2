using System;

namespace Miprimetrabajo.SubClases
{
    public class Maestro : Docente
    {
        public int AñosExperiencia { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Años de experiencia: {AñosExperiencia}");
        }
    }
}

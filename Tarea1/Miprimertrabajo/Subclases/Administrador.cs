using System;

namespace Miprimetrabajo.SubClases
{
    public class Administrador : Docente
    {
        public string NivelAdministrativo { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Nivel Administrativo: {NivelAdministrativo}");
        }
    }
}

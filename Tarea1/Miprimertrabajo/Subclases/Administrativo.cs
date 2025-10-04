using System;

namespace Miprimetrabajo.SubClases
{
    public class Administrativo : Miprimetrabajo.Empleado
    {
        public string Departamento { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Departamento: {Departamento}");
        }
    }
}

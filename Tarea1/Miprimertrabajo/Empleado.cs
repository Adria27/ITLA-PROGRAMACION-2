using System;

namespace Miprimetrabajo
{
    public class Empleado : MiembroDeLaComunidad
    {
        public decimal Salario { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Salario: {Salario}");
        }
    }
}

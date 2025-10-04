using System;

namespace Miprimetrabajo
{
    public class MiembroDeLaComunidad
    {
        public string Nombre { get; set; }
        public int Id { get; set; }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Miembro: {Nombre}, ID: {Id}");
        }
    }
}

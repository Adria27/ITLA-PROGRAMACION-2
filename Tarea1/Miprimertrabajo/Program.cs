using Miprimetrabajo;
using Miprimetrabajo.SubClases;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<MiembroDeLaComunidad> comunidad = new List<MiembroDeLaComunidad>();

        comunidad.Add(new Estudiante { Nombre = "Wil", Id = 1, Promedio = 9.9 });
        comunidad.Add(new Administrador { Nombre = "Cristiano", Id = 2, Salario = 50000, NivelAdministrativo = "Gerente", Materia = "Gestión" });
        comunidad.Add(new Maestro { Nombre = "Juan", Id = 3, Salario = 60000, Materia = "Software", AñosExperiencia = 1 });
        comunidad.Add(new ExAlumno { Nombre = "Robin", Id = 4, FechaGraduacion = new DateTime(2024, 8, 20) });
        comunidad.Add(new Administrativo { Nombre = "María", Id = 5, Salario = 40000, Departamento = "Recursos Humanos" });

        foreach (var miembro in comunidad)
        {
            miembro.MostrarInformacion();
            Console.WriteLine();
        }
    }
}

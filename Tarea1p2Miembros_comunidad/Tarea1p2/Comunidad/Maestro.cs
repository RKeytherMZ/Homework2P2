using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1p2.Comunidad
{
    public class Maestro: Docente
    {
        public int AñosDeExperiencia { get; set; }

        public Maestro(string nombre, string identificacion, string departamento, string asignatura, int añoExperiencia) : base (nombre, identificacion, departamento, asignatura) { 

            AñosDeExperiencia = añoExperiencia;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Maestro: {Nombre}, ID: {Identificacion}, Departamento: {Departamento}, Asignatura: {Asignatura}, Años de Experiencia: {AñosDeExperiencia}");
        }


    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1p2.comunidad
{
    public class Estudiante: MiembroDeLaComunidad
    {
        public string Carrera { get; set; }
        public int AñoIngreso { get; set; }

        public Estudiante(string nombre, string identificacion, string carrera, int añoIngreso): base(nombre, identificacion)
        {
            Nombre = nombre;
            Identificacion = identificacion;
            Carrera = carrera;
            AñoIngreso = añoIngreso;

        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Estudiante: {Nombre}, ID: {Identificacion}, Carrera: {Carrera}, Año Ingreso: {AñoIngreso}");
        }

    }
}

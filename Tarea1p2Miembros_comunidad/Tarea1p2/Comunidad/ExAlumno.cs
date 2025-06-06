using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1p2.comunidad
{
    public class ExAlumno: MiembroDeLaComunidad
    {
        public int AñoEgreso { get; set; }

        public ExAlumno(string nombre, String identificacion, int añoEgreso) : base (nombre, identificacion)
        {
            Nombre = nombre;
            Identificacion = identificacion;
            AñoEgreso = añoEgreso;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"ExAlumno: {Nombre}, ID: {Identificacion}, Año Egreso: {AñoEgreso}");
        }

    }
}

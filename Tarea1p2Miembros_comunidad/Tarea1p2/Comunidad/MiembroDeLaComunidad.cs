using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1p2.comunidad
{
     public abstract class MiembroDeLaComunidad
    {
        public string Nombre { get; set; }
        public string Identificacion { get; set; }

        public MiembroDeLaComunidad(string nombre, string identificacion) {
        
            Nombre = nombre;
            Identificacion = identificacion;
        }

        public abstract void MostrarInfo();


    }
}

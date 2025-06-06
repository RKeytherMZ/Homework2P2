using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1p2.comunidad;

namespace Tarea1p2.Comunidad
{
    public class Administrativo: Empleado
    {
        public string AreaAdministrativa { get; set; }

        public Administrativo(string areaAdministrativa, string nombre, string identificacion, string departamento) : base(nombre, identificacion, departamento)
        {
            AreaAdministrativa = areaAdministrativa;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Area Administrativa: {AreaAdministrativa}, Nombre: {Nombre} ID: {Identificacion}, Departamento: {Departamento}");
        }


    }
}

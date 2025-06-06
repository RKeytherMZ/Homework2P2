using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1p2.comunidad;

namespace Tarea1p2.Comunidad
{
    public class Docente: Empleado
    {
        public string Asignatura { get; set; }

     

        public Docente(string nombre, string identificacion, string asignatura, string departamento) : base(nombre, identificacion, departamento)
        {
            Asignatura = asignatura;
        }


        public override void MostrarInfo()
        {
            Console.WriteLine($"Docente: {Nombre}, ID: {Identificacion}, Asignatura: {Asignatura}, Departamento: {Departamento}");
        }


    }
}

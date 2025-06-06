using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1p2.Comunidad
{
    public class Administrador: Docente
    {
        public string Cargo { get; set; }

        public Administrador(string nombre, string identificacion, string departamento, string asignatura, string cargo)
        : base(nombre, identificacion, departamento, asignatura)
        {
            Cargo = cargo;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Administrador: {Nombre}, ID: {Identificacion}, Departamento: {Departamento}, Asignatura: {Asignatura}, Cargo: {Cargo}");
        }
       

    }
}

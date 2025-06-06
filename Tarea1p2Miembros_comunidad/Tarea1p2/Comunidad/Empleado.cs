using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1p2.comunidad
{
    public class Empleado : MiembroDeLaComunidad
    {
        public string Departamento { get; set; }
       
        public Empleado(string nombre, string identificacion, string departamento) : base(nombre, identificacion)
        {
           
            Departamento = departamento;

        }


        public override void MostrarInfo()
        {
            Console.WriteLine($"Empleado: {Nombre}, ID: {Identificacion}, Departamento: {Departamento}");
        }


    }
}

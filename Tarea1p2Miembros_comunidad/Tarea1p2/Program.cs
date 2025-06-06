using System;
using Tarea1p2.comunidad;
using Tarea1p2.Comunidad;

class Program
{
    static void Main()
    {
        
        Estudiante estudiante = new Estudiante("Juan Pablo Duarte", "E001", "Software", 2003);
        estudiante.MostrarInfo();

        Console.WriteLine("-------------------");

        
        Docente docente = new Docente("Tilina", "D002", "Informática", "POO");
        docente.MostrarInfo();

        Console.WriteLine("-------------------");

        
        Empleado empleado = new Empleado("Luis", "EMP003", "Administración");
        empleado.MostrarInfo();

        Console.WriteLine("-------------------");

        
        ExAlumno egresado = new ExAlumno("María", "EG004", 2020);
        egresado.MostrarInfo();

        Console.WriteLine("-------------------");

        Administrativo administrativo = new Administrativo("Control Interno", "Luis", "ADM001", "Recursos Humanos");
        administrativo.MostrarInfo();

        Console.WriteLine("-------------------");

        Administrador administrador = new Administrador("Pedro", "ADM05", "Contable", "Finanzas", "Presupuesto");
        administrador.MostrarInfo();

        Console.WriteLine("-------------------");

        Maestro maestro = new Maestro("Julia", "M06", "Ciencias", "Física", 12);
        maestro.MostrarInfo();


    }
}

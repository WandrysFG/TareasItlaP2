using Mapa_de_Clases.Entities;

namespace Mapa_de_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            var maestro = new Persona(1, "Ana", "Fernandez", 35, "Santo Domingo", "809-765-4321", "000-0000000-0",
                            new Maestro("Matematicas", "Secundaria", "Educacion", "2021-10-11", 65000));
            MostrarPersona(maestro);

            Console.WriteLine("\n-----------------------------\n");

            var estudiante = new Persona(2, "Carlos", "Lopez", 20, "Santiago", "809-123-4567", "001-1234567-8",
                            new Estudiante("Ingenieria en Software", 2023, 20242038));
            MostrarPersona(estudiante);

            Console.WriteLine("\n-----------------------------\n");

            var exAlumno = new Persona(3, "Luisa", "Martinez", 27, "La Vega", "809-888-9999", "002-9876543-2",
                            new ExAlumno(2020));
            MostrarPersona(exAlumno);

            Console.WriteLine("\n-----------------------------\n");

            var administrativo = new Persona(4, "Miguel", "Santos", 40, "San Cristobal", "809-321-4567", "003-5556667-3",
                            new Administrativo("Recursos Humanos", "Administracion", "2019-04-20", 45000));
            MostrarPersona(administrativo);

            Console.WriteLine("\n-----------------------------\n");

            var administrador = new Persona(5, "Elena", "Torres", 42, "Santiago", "809-444-7777", "004-7778889-0",
                            new Administrador("Tecnologia", "Coordinador Academico", "Direccion", "2018-02-10", 72000));
            MostrarPersona(administrador);
        }

        static void MostrarPersona(Persona persona)
        {
            Console.WriteLine($"ID: {persona.Id}");
            Console.WriteLine($"Nombre: {persona.Nombre} {persona.Apellido}");
            Console.WriteLine($"Edad: {persona.Edad}");
            Console.WriteLine($"Direccion: {persona.Direccion}");
            Console.WriteLine($"Telefono: {persona.Telefono}");
            Console.WriteLine($"Cedula: {persona.Cedula}");
            Console.WriteLine($"Rol: {persona.Rol.NombreRol}");

            switch (persona.Rol)
            {
                case Estudiante est:
                    Console.WriteLine($"Carrera: {est.Carrera}");
                    Console.WriteLine($"Año de Ingreso: {est.AñoIngreso}");
                    Console.WriteLine($"Matricula: {est.Matricula}");
                    break;

                case ExAlumno ex:
                    Console.WriteLine($"Año de Graduacion: {ex.AñoGraduacion}");
                    break;

                case Maestro maestro:
                    Console.WriteLine($"Area: {maestro.Area}");
                    Console.WriteLine($"Nivel: {maestro.Nivel}");
                    Console.WriteLine($"Departamento: {maestro.Departamento}");
                    Console.WriteLine($"Fecha de Contratacion: {maestro.FechaContratacion}");
                    Console.WriteLine($"Salario: {maestro.Salario:C}");
                    break;

                case Administrativo admin:
                    Console.WriteLine($"Funcion: {admin.Funcion}");
                    Console.WriteLine($"Departamento: {admin.Departamento}");
                    Console.WriteLine($"Fecha de Contratacion: {admin.FechaContratacion}");
                    Console.WriteLine($"Salario: {admin.Salario:C}");
                    break;

                case Administrador adm:
                    Console.WriteLine($"Area: {adm.Area}");
                    Console.WriteLine($"Cargo: {adm.Cargo}");
                    Console.WriteLine($"Departamento: {adm.Departamento}");
                    Console.WriteLine($"Fecha de Contratacion: {adm.FechaContratacion}");
                    Console.WriteLine($"Salario: {adm.Salario:C}");
                    break;

                default:
                    Console.WriteLine("Informacion especifica no disponible.");
                    break;
            }
        }
    }
}
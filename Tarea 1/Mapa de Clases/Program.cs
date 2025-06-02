using Mapa_de_Clases.Entities;

namespace Mapa_de_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo para prueba
            var maestro = new Persona
            {
                Id = 1,
                Nombre = "Ana",
                Apellido = "Fernandez",
                Edad = 35,
                Direccion = "Santo Domingo, Rep Dom",
                Telefono = "809-765-4321",
                Cedula = "000-0000000-0",
                Rol = new Maestro
                {
                    Area = "Matematicas",
                    Nivel = "Secundaria",
                    Departamento = "Educacion",
                    FechaContratacion = "2021-10-11",
                    Salario = 65000
                }
            };

            MostrarPersona(maestro);
        }

        static void MostrarPersona(Persona persona)
        {
            Console.WriteLine($"Nombre: {persona.Nombre} {persona.Apellido}");
            Console.WriteLine($"Edad: {persona.Edad}");
            Console.WriteLine($"Cedula: {persona.Cedula}");
            Console.WriteLine($"Rol: {persona.Rol.NombreRol}");

            if (persona.Rol is Maestro maestro)
            {
                Console.WriteLine($"Area: {maestro.Area}");
                Console.WriteLine($"Nivel: {maestro.Nivel}");
                Console.WriteLine($"Departamento: {maestro.Departamento}");
                Console.WriteLine($"Fecha de Contratacion: {maestro.FechaContratacion}");
                Console.WriteLine($"Salario: {maestro.Salario}");
            }
            else
            {
                Console.WriteLine("Informacion especifica no encontrada");
            }
        }
    }
}
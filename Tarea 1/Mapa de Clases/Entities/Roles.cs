using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapa_de_Clases.Entities
{
    public abstract class Roles
    {
        public abstract string NombreRol { get; }
    }

    public abstract class MiembroDeLaComunidad : Roles
    {
    }

    public class Estudiante : MiembroDeLaComunidad
    {
        public string Carrera { get; set; }
        public int AñoIngreso { get; set; }
        public int Matricula { get; set; }

        public override string NombreRol => "Estudiante";
    }

    public class ExAlumno : MiembroDeLaComunidad
    {
        public int AñoGraduacion { get; set; }

        public override string NombreRol => "ExAlumno";
    }

    public abstract class Empleado : MiembroDeLaComunidad
    {
        public string Departamento { get; set; }
        public string FechaContratacion { get; set; }
        public decimal Salario { get; set; }
    }

    public abstract class Docente : Empleado
    {
        public string Area { get; set; }
        public override string NombreRol => "Docente";
    }

    public class Administrativo : Empleado
    {
        public string Funcion { get; set; }
        public override string NombreRol => "Administrativo";
    }

    public class Maestro : Docente
    {
        public string Nivel { get; set; }
        public override string NombreRol => "Maestro";
    }

    public class Administrador : Docente
    {
        public string Cargo { get; set; }
        public override string NombreRol => "Administrador";
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StelarsBooks.API.Entities
{
    [Table("Usuarios")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Nombre { get; set; }

        [Required, StringLength(50)]
        public string Apellido { get; set; }

        [Required, StringLength(100), EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(255)]
        public string Contraseña { get; set; }

        [Required, StringLength(20)]
        public string TipoUsuario { get; set; } = "Lector";

        [Column(TypeName = "date")]
        public DateTime FechaRegistro { get; set; } = DateTime.Today;

        public bool Estado { get; set; } = true;
    }
}
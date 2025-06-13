using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StellarBoocks.API.DTOs
{
    public class CreateUserDto
    {
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

        public bool Estado { get; set; } = true;
    }

}
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StellarBoocks.API.DTOs
{
    public class UpdateUserDto : CreateUserDto
    {
        public int Id { get; set; }
    }

}
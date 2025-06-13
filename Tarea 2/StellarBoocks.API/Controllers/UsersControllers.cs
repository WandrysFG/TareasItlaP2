using Microsoft.AspNetCore.Mvc;
using StelarsBooks.API.Entities;
using StelarsBooks.API.Entities;

namespace StellarBoocks.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private List<User> _users;

        public UsersController() 
        { 
            _users = new List<User>();
            _users.Add(new User { Id = 1, Nombre = "Juan", Apellido = "Pérez", Email = "juan.perez@example.com", Contraseña = "123456", TipoUsuario = "Lector", FechaRegistro = DateTime.Today, Estado = true});
            _users.Add(new User { Id = 2, Nombre = "María", Apellido = "Gómez", Email = "maria.gomez@example.com", Contraseña = "abcdef", TipoUsuario = "Administrador", FechaRegistro = DateTime.Today, Estado = true });
            _users.Add(new User { Id = 3, Nombre = "Carlos", Apellido = "Ramírez", Email = "carlos.ramirez@example.com", Contraseña = "qwerty123", TipoUsuario = "Lector", FechaRegistro = DateTime.Today, Estado = false });
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_users);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetUserById(int id)
        {
            var user = _users.Where(u => u.Id == id).FirstOrDefault();
            if (user == null)
            {
                return NotFound($"User with ID {id} not found.");
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("User cannot be null.");
            }

            user.Id = _users.Count + 1;
            user.FechaRegistro = DateTime.Now;
            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("User is null or ID mismatch.");
            }

            var existingUser = _users.FirstOrDefault(u => u.Id == id);
            if (existingUser == null)
            {
                return NotFound($"User with ID {id} not found.");
            }

            existingUser.Nombre = user.Nombre;
            existingUser.Apellido = user.Apellido;
            existingUser.Email = user.Email;
            existingUser.Contraseña = user.Contraseña;
            existingUser.TipoUsuario = user.TipoUsuario;
            existingUser.Estado = user.Estado;

            return Ok(_users);
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound($"User with ID {id} not found.");
            }

            _users.Remove(user);
            return Ok(_users);
        }
    }
}

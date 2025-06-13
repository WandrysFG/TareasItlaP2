using Microsoft.AspNetCore.Mvc;
using StelarsBooks.API.Entities;
using StellarBoocks.API.Data;
using StellarBoocks.API.DTOs;

namespace StellarBoocks.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly StellarBocksApplicationDbContext _context;

        public UsersController(StellarBocksApplicationDbContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetUserById(int id)
        {
            var user = _context.Users.Where(u => u.Id == id).FirstOrDefault();
            if (user == null)
            {
                return NotFound($"User with ID {id} not found.");
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] CreateUserDto request)
        {
            if (request == null)
            {
                return BadRequest("User cannot be null.");
            }

            var user = new User
            {
                Nombre = request.Nombre,
                Apellido = request.Apellido,
                Email = request.Email,
                Contraseña = request.Contraseña,
                TipoUsuario = request.TipoUsuario,
                Estado = request.Estado,
                FechaRegistro = DateTime.UtcNow
            };

            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok(new {id = user.Id});
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] User request)
        {
            if (request == null)
            {
                return BadRequest("User is null or ID mismatch.");
            }

            var existingUser = _context.Users.FirstOrDefault(u => u.Id == id);
            if (existingUser == null)
            {
                return NotFound($"User with ID {id} not found.");
            }

            existingUser.Nombre = request.Nombre;
            existingUser.Apellido = request.Apellido;
            existingUser.Email = request.Email;
            existingUser.Contraseña = request.Contraseña;
            existingUser.TipoUsuario = request.TipoUsuario;
            existingUser.Estado = request.Estado;

            _context.Users.Update(existingUser);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteUser(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound($"User with ID {id} not found.");
            }

            _context.Users.Remove(user);
            _context.SaveChanges();
            return NoContent();
        }
    }
}

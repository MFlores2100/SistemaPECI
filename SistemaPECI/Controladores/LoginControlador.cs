using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaPECI.Client.Modelos;
using SistemaPECI.Data.Context;
using SistemaPECI.Seguridad;

namespace SistemaPECI.Controladores
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly DBContext _context;

        public LoginController(DBContext context)
        {
            _context = context; 
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            try
            {
                var usuario = await _context.Usuario.FirstOrDefaultAsync(u => u.Correo == model.Correo);

                if (usuario == null || usuario.Contrasenia != (model.Contraseña))
                    return Unauthorized("Credenciales inválidas");

                return Ok("Inicio de sesión exitoso"); //También se puede retornar JWT, cookie, etc.
            } 
            catch(Exception ex)
            {
                Console.WriteLine($"Error en Login: {ex.Message}");
                return StatusCode(500, "Error interno del servidor");
            }

        }
    }
}

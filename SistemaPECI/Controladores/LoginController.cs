using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SistemaPECI.Client.Modelos;
using SistemaPECI.Data.Context;
using SistemaPECI.Seguridad;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SistemaPECI.Controladores
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly DBContext _context;
        private readonly IConfiguration _configuration;

        public LoginController(DBContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            try
            {
                var usuario = await _context.Usuario.FirstOrDefaultAsync(u => u.Correo == model.Correo);

                if (usuario == null || usuario.Contrasenia != (model.Contraseña))
                    return Unauthorized("Credenciales inválidas");

                //Se genera el Token JWT
                var secretKey = _configuration["JwtSettings:SecretKey"];
                var key = Encoding.ASCII.GetBytes(secretKey ?? "ProyectoContinuidadTecnologica_PECI2025");
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[]
                    {
                        new Claim(ClaimTypes.Name, usuario.Correo),
                        new Claim(ClaimTypes.Role, usuario.Rol)
                    }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(
                        new SymmetricSecurityKey(key),
                        SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                var jwt = tokenHandler.WriteToken(token);

                return Ok(jwt); //Este es el Token que se retorna al cliente
            } 
            catch(Exception ex)
            {
                Console.WriteLine($"Error en Login: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                return StatusCode(500, "Error interno del servidor");
            }

        }
    }
}

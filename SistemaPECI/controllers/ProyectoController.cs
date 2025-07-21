using Microsoft.AspNetCore.Mvc;
using SistemaPECI.Data.Context;
using Microsoft.EntityFrameworkCore;


namespace SistemaPECI.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProyectoController : ControllerBase
    {
        private readonly DBContext _context;

        public ProyectoController(DBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetProyectos()
        {
            var proyectos = await _context.Proyecto
                                          .Include(p => p.Region)
                                          .ToListAsync();

            return Ok(proyectos);
        }
    }
}

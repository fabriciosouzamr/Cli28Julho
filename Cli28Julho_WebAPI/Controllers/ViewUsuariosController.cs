using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cli28Julho_WebAPI.Context;
using Cli28Julho_WebAPI.Model;
using Microsoft.AspNetCore.Cors;

namespace Cli28Julho_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CORSGS")]
    public class ViewUsuariosController : ControllerBase
    {
        private readonly AppDBContext _context;

        public ViewUsuariosController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/ViewUsuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ViewUsuario>>> GetUsuario()
        {
            return await _context.Usuario.OrderBy(p => p.NO_PESSOA).ToListAsync();
        }

        // GET: api/ViewUsuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ViewUsuario>> GetViewUsuario(int id)
        {
            var viewUsuario = await _context.Usuario.FindAsync(id);

            if (viewUsuario == null)
            {
                return NotFound();
            }

            return viewUsuario;
        }

    }
}

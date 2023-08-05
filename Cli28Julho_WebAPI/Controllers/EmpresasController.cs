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
    public class EmpresasController : ControllerBase
    {
        private readonly AppDBContext _context;

        public EmpresasController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Empresas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ViewEmpresa>>> GetEmpresas()
        {
            return await _context.Empresas.ToListAsync();
        }

        // GET: api/Empresas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ViewEmpresa>> GetEmpresa(int id)
        {
            var empresa = await _context.Empresas.FindAsync(id);

            if (empresa == null)
            {
                return NotFound();
            }

            return empresa;
        }

        private bool EmpresaExists(int id)
        {
            return _context.Empresas.Any(e => e.ID_EMPRESA == id);
        }
    }
}

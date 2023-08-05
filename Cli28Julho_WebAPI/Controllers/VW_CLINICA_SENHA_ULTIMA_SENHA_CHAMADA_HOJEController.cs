using System.Collections.Generic;
using System.Threading.Tasks;
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
    public class VW_CLINICA_SENHA_ULTIMA_SENHA_CHAMADA_HOJEController : ControllerBase
    {
        private readonly AppDBContext _context;

        public VW_CLINICA_SENHA_ULTIMA_SENHA_CHAMADA_HOJEController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/VW_CLINICA_SENHA_ULTIMA_SENHA_CHAMADA_HOJE
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VW_CLINICA_SENHA_ULTIMA_SENHA_CHAMADA_HOJE>>> GetClinicaSenhasSenhaChamada()
        {
            return await _context.ClinicaSenhasChamada.ToListAsync();
        }

        // GET: api/VW_CLINICA_SENHA_ULTIMA_SENHA_CHAMADA_HOJE/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VW_CLINICA_SENHA_ULTIMA_SENHA_CHAMADA_HOJE>> GetVW_CLINICA_SENHA_ULTIMA_SENHA_CHAMADA_HOJE(int id)
        {
            var VW_CLINICA_SENHA_ULTIMA_SENHA_CHAMADA_HOJE = await _context.ClinicaSenhasChamada.FindAsync(id);

            if (VW_CLINICA_SENHA_ULTIMA_SENHA_CHAMADA_HOJE == null)
            {
                return NotFound();
            }

            return VW_CLINICA_SENHA_ULTIMA_SENHA_CHAMADA_HOJE;
        }
    }
}

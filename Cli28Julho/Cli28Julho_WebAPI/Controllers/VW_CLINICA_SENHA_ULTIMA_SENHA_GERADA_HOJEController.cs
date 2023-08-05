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
    //[EnableCors("CORSGS")]
    public class VW_CLINICA_SENHA_ULTIMA_SENHA_GERADA_HOJEController : ControllerBase
    {
        private readonly AppDBContext _context;

        public VW_CLINICA_SENHA_ULTIMA_SENHA_GERADA_HOJEController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/VW_CLINICA_SENHA_ULTIMA_SENHA_GERADA_HOJE
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VW_CLINICA_SENHA_ULTIMA_SENHA_GERADA_HOJE>>> GetClinicaSenhasSenhaGerada()
        {
            return await _context.ClinicaSenhasGerada.ToListAsync();
        }

        // GET: api/VW_CLINICA_SENHA_ULTIMA_SENHA_GERADA_HOJE/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VW_CLINICA_SENHA_ULTIMA_SENHA_GERADA_HOJE>> GetVW_CLINICA_SENHA_ULTIMA_SENHA_GERADA_HOJE(int id)
        {
            var vW_CLINICA_SENHA_ULTIMA_SENHA_GERADA_HOJE = await _context.ClinicaSenhasGerada.FindAsync(id);

            if (vW_CLINICA_SENHA_ULTIMA_SENHA_GERADA_HOJE == null)
            {
                return NotFound();
            }

            return vW_CLINICA_SENHA_ULTIMA_SENHA_GERADA_HOJE;
        }
    }
}

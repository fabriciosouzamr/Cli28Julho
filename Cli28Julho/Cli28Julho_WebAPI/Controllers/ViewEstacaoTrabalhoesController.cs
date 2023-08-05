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
    //[EnableCors("CORSGS")]
    public class ViewEstacaoTrabalhoesController : ControllerBase
    {
        private readonly AppDBContext _context;

        public ViewEstacaoTrabalhoesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/ViewEstacaoTrabalhoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ViewEstacaoTrabalho>>> GetEstacaoTrabalhos()
        {
            return await _context.EstacaoTrabalhos.OrderBy(p => p.NO_ESTACAO).ToListAsync();
        }

        // GET: api/ViewEstacaoTrabalhoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ViewEstacaoTrabalho>> GetViewEstacaoTrabalho(int id)
        {
            var viewEstacaoTrabalho = await _context.EstacaoTrabalhos.FindAsync(id);

            if (viewEstacaoTrabalho == null)
            {
                return NotFound();
            }

            return viewEstacaoTrabalho;
        }
    }
}

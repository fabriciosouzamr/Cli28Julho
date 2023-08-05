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
    public class ClinicaSenhaChamadasController : ControllerBase
    {
        private readonly AppDBContext _context;

        public ClinicaSenhaChamadasController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/ClinicaSenhaChamadas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClinicaSenhaChamada>>> GetClinicaSenhaChamadas()
        {
            return await _context.ClinicaSenhaChamadas.ToListAsync();
        }

        // GET: api/ClinicaSenhaChamadas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClinicaSenhaChamada>> GetClinicaSenhaChamada(int id)
        {
            var clinicaSenhaChamada = await _context.ClinicaSenhaChamadas.FindAsync(id);

            if (clinicaSenhaChamada == null)
            {
                return NotFound();
            }

            return clinicaSenhaChamada;
        }

        // PUT: api/ClinicaSenhaChamadas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClinicaSenhaChamada(int id, ClinicaSenhaChamada clinicaSenhaChamada)
        {
            if (id != clinicaSenhaChamada.SQ_CLINICA_SENHA_CHAMADA)
            {
                return BadRequest();
            }

            _context.Entry(clinicaSenhaChamada).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClinicaSenhaChamadaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ClinicaSenhaChamadas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ClinicaSenhaChamada>> PostClinicaSenhaChamada(ClinicaSenhaChamada clinicaSenhaChamada)
        {
            _context.ClinicaSenhaChamadas.Add(clinicaSenhaChamada);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClinicaSenhaChamada", new { id = clinicaSenhaChamada.SQ_CLINICA_SENHA_CHAMADA }, clinicaSenhaChamada);
        }

        // DELETE: api/ClinicaSenhaChamadas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClinicaSenhaChamada(int id)
        {
            var clinicaSenhaChamada = await _context.ClinicaSenhaChamadas.FindAsync(id);
            if (clinicaSenhaChamada == null)
            {
                return NotFound();
            }

            _context.ClinicaSenhaChamadas.Remove(clinicaSenhaChamada);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClinicaSenhaChamadaExists(int id)
        {
            return _context.ClinicaSenhaChamadas.Any(e => e.SQ_CLINICA_SENHA_CHAMADA == id);
        }
    }
}

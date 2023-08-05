using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cli28Julho_WebAPI.Context;
using Cli28Julho_WebAPI.Model;
using Cli28Julho_WebAPI.Context.DirectAccess;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Cors;

namespace Cli28Julho_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CORSGS")]
    public class ClinicaSenhasController : ControllerBase
    {
        private readonly AppDBContext _context;

        public ClinicaSenhasController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/ClinicaSenhas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClinicaSenha>>> GetClinicaSenhas()
        {
            return await _context.ClinicaSenhas.ToListAsync();
        }

        // GET: api/ClinicaSenhas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClinicaSenha>> GetClinicaSenha(int id)
        {
            var clinicaSenha = await _context.ClinicaSenhas.FindAsync(id);

            if (clinicaSenha == null)
            {
                return NotFound();
            }

            return clinicaSenha;
        }

        // POST: api/ClinicaSenhas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<bool>> PostClinicaSenha(int idEmpresa)
        {
            bool Retorno = false;

            DBClinica conexao = new DBClinica(Cli28Julho_WebAPI.Properties.Resources.DefaultConnection);

            try
            {
                SqlCommand cmd = new SqlCommand("SP_CLINICA_SENHA_INS");
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_EMPRESA", idEmpresa);

                conexao.Conectar();

                cmd.ExecuteScalar();

                Retorno = true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexao.Desconectar();
            }

            return Retorno;
        }

        private bool ClinicaSenhaExists(int id)
        {
            return _context.ClinicaSenhas.Any(e => e.SQ_CLINICA_SENHA == id);
        }
    }
}

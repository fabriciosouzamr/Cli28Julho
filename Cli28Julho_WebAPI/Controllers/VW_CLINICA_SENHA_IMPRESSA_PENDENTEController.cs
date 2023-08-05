using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
    public class VW_CLINICA_SENHA_IMPRESSA_PENDENTEController : ControllerBase
    {
        private readonly AppDBContext _context;

        public VW_CLINICA_SENHA_IMPRESSA_PENDENTEController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/VW_CLINICA_SENHA_IMPRESSA_PENDENTE
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VW_CLINICA_SENHA_IMPRESSA_PENDENTE>>> GetVW_CLINICA_SENHA_IMPRESSA_PENDENTE()
        {
            return await _context.VW_CLINICA_SENHA_IMPRESSA_PENDENTE.ToListAsync();
        }

        // GET: api/VW_CLINICA_SENHA_IMPRESSA_PENDENTE/5
        [HttpGet("{iEmpresa}")]
//        public async Task<ActionResult<VW_CLINICA_SENHA_IMPRESSA_PENDENTE>> GetVW_CLINICA_SENHA_IMPRESSA_PENDENTE(int iEmpresa)
        public async Task<IQueryable<VW_CLINICA_SENHA_IMPRESSA_PENDENTE>> GetVW_CLINICA_SENHA_IMPRESSA_PENDENTE(int iEmpresa)
        {
            var vW_CLINICA_SENHA_IMPRESSA_PENDENTE = _context.VW_CLINICA_SENHA_IMPRESSA_PENDENTE.Where(P => P.ID_EMPRESA == iEmpresa);

            if (vW_CLINICA_SENHA_IMPRESSA_PENDENTE == null)
            {
                return (IQueryable<VW_CLINICA_SENHA_IMPRESSA_PENDENTE>)NotFound();
            }

            return vW_CLINICA_SENHA_IMPRESSA_PENDENTE;
        }

        // POST: api/VW_CLINICA_SENHA_IMPRESSA_PENDENTE
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<bool>> PostVW_CLINICA_SENHA_IMPRESSA_PENDENTE(int iSQ_CLINICA_SENHA)
        {
            bool Retorno = false;

            DBClinica conexao = new DBClinica(Cli28Julho_WebAPI.Properties.Resources.DefaultConnection);

            try
            {
                SqlCommand cmd = new SqlCommand("SP_CLINICA_SENHA_IMPRESSA_UPD");
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SQ_CLINICA_SENHA", iSQ_CLINICA_SENHA);

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
    }
}

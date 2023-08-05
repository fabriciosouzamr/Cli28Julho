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
    public class SistemasController : ControllerBase
    {
        private readonly AppDBContext _context;

        public SistemasController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Sistemas
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Sistema>>> GetSistema()
        //{
        //    return await _context.Sistema.ToListAsync();
        //}

        public  Sistema GetSistema()
        {
            return new Sistema() { CD_VERSAO = "01.00.000",  DT_VERSAO = new DateTime(2021, 11, 30) };
        }
    }
}

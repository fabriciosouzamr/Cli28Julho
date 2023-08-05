using Cli28Julho_WebAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cli28Julho_WebAPI.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<VW_CLINICA_SENHA_ULTIMA_SENHA_GERADA_HOJE> ClinicaSenhasGerada { get; set; }
        
        public DbSet<VW_CLINICA_SENHA_ULTIMA_SENHA_CHAMADA_HOJE> ClinicaSenhasChamada { get; set; }
        public DbSet<ClinicaSenha> ClinicaSenhas { get; set; }
        public DbSet<ClinicaSenhaChamada> ClinicaSenhaChamadas { get; set; }
        public DbSet<ViewEmpresa> Empresas { get; set; }
        public DbSet<ViewEstacaoTrabalho> EstacaoTrabalhos { get; set; }
        public DbSet<ViewUsuario> Usuario { get; set; }
        public DbSet<VW_CLINICA_SENHA_IMPRESSA_PENDENTE> VW_CLINICA_SENHA_IMPRESSA_PENDENTE { get; set; }
    }
}

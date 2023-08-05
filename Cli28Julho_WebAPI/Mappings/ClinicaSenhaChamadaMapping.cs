using Cli28Julho_WebAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cli28Julho_WebAPI.Mappings
{
    public class ClinicaSenhaChamadaMapping : IEntityTypeConfiguration<ClinicaSenhaChamada>
    {
        public void Configure(EntityTypeBuilder<ClinicaSenhaChamada> builder)
        {
            builder.HasKey(p => p.SQ_CLINICA_SENHA_CHAMADA);

            builder.ToTable("TB_CLINICA_SENHA_CHAMADA");
        }
    }
}

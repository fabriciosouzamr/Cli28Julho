using Cli28Julho_WebAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cli28Julho_WebAPI.Mappings
{
    public class ClinicaSenhaMapping : IEntityTypeConfiguration<ClinicaSenha>
    {
        public void Configure(EntityTypeBuilder<ClinicaSenha> builder)
        {
            builder.HasKey(p => p.SQ_CLINICA_SENHA);

            builder.ToTable("TB_CLINICA_SENHA");
        }
    }
}

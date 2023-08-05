using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cli28Julho_WebAPI.Model
{
    [Table("VW_EMPRESA_ESTACAO_GERACAO_SENHA")]
    public class ViewEstacaoTrabalho
    {
        [Key]
        public int SQ_EMPRESA_ESTACAO { get; set; }
        public string NO_ESTACAO { get; set; }
    }
}


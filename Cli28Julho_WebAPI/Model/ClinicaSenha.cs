using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cli28Julho_WebAPI.Model
{
    [Table("TB_CLINICA_SENHA")]
    public class ClinicaSenha
    {
        [Key]
        public int SQ_CLINICA_SENHA { get; set; }
        public int ID_EMPRESA { get; set; }
        public DateTime DH_CLINICA_SENHA { get; set; }
        public int NR_CLINICA_SENHA { get; set; }
        public int? ID_CAIXA_ATENDIMENTO { get; set; }
        public DateTime? DH_CHAMADA { get; set; }
        public int? ID_USUARIO { get; set; }
    }

    [Table("VW_CLINICA_SENHA_ULTIMA_SENHA_GERADA_HOJE")]
    public class VW_CLINICA_SENHA_ULTIMA_SENHA_GERADA_HOJE
    {
        [Key]
        public int ID_EMPRESA { get; set; }
        public int NR_CLINICA_SENHA { get; set; }
    }

    [Table("VW_CLINICA_SENHA_IMPRESSA_PENDENTE")]
    public class VW_CLINICA_SENHA_IMPRESSA_PENDENTE
    {
        [Key]
        public int SQ_CLINICA_SENHA { get; set; }
        public int ID_EMPRESA { get; set; }
        public int NR_CLINICA_SENHA { get; set; }
    }
}
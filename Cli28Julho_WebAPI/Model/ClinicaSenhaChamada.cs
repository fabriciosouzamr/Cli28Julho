using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cli28Julho_WebAPI.Model
{
    [Table("TB_CLINICA_SENHA_CHAMADA")]
    public class ClinicaSenhaChamada
    {
        [Key]
        public int SQ_CLINICA_SENHA_CHAMADA { get; set; }
        public int ID_CLINICA_SENHA { get; set; }
        public int ID_CAIXA_ATENDIMENTO { get; set; }
        public DateTime DH_CLINICA_SENHA_CHAMADA { get; set; }
        public int ID_USUARIO { get; set; }
    }

    [Table("VW_CLINICA_SENHA_ULTIMA_SENHA_CHAMADA_HOJE")]
    public class VW_CLINICA_SENHA_ULTIMA_SENHA_CHAMADA_HOJE
    {
        [Key]
        public int ID_EMPRESA { get; set; }
        public DateTime DT_CLINICA_SENHA { get; set; }
        public int NR_CLINICA_SENHA { get; set; }
        public string NO_CAIXA_ATENDIMENTO { get; set; }
        public int ID_CAIXA_ATENDIMENTO { get; set; }
        public string NO_PESSOA { get; set; }
        public string NO_FANTASIA_REDUZIDO { get; set; }
        public string DS_LOCALIZACAO { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cli28Julho_WebAPI.Model
{
    [Table("VW_EMPRESA")]
    public class ViewEmpresa
    {
        [Key]
        public int ID_EMPRESA { get; set; }
        public string NO_EMPRESA { get; set; }

        public string DS_MENSAGEM_IMPRESSAO_SENHA { get; set; }
    }
}

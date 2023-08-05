using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cli28Julho_WebAPI.Model
{
    [Table("VW_SEG_USUARIO")]
    public class ViewUsuario
    {
        [Key]
        public int ID_USUARIO { get; set; }
        public string NO_PESSOA { get; set; }
        public string NO_PESSOA_REDUZIDO { get; set; }
        public string DS_SENHA { get; set; }
    }
}

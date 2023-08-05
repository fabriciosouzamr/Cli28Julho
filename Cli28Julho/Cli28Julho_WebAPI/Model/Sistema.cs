using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cli28Julho_WebAPI.Model
{
    public class Sistema
    {
        [Key]
        public String CD_VERSAO { get; set; }
        public DateTime DT_VERSAO { get; set; }
    }
}

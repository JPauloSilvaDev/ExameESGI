using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteAdmissao.Models
{
    public class Cargo_Vencimentos
    {
        [Key]
        public int Cargo_ID { get; set; }
        public int Vencimento_ID { get; set; }

    }
}
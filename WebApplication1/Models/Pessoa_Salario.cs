using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteAdmissao.Models
{
    public class Pessoa_Salario
    {

        [Key]
        public int Pessoa_ID { get; set; }
        public string Nome_Pessoa { get; set; }
        public string Nome_Cargo { get; set; }
        public decimal Salario { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteAdmissao.Models
{
    public class Cargo
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
    }
}
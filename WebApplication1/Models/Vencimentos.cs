using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteAdmissao.Models
{
    public class Vencimentos
    {

        [Key]
        public int ID { get; set; }
        public string Descricao { get; set; }
        public int Valor { get; set; }
        public string Tipo { get; set; }
    
    }
}
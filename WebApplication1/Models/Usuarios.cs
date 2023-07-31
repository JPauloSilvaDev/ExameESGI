using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteAdmissao.Models
{
    public class Usuarios
    {
        [Key]
        public int UserID { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}
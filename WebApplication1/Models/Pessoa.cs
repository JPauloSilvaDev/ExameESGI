using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteAdmissao.Models
{
    public class Pessoa
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Pais { get; set; }
        public string Usuario { get; set; }
        public string Telefone { get; set; }
        public string Data_Nascimento { get; set; }
        public int Cargo_ID { get; set; }

    }
}
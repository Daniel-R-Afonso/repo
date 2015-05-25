using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Utilizador
    {
        public int IdUtilizador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Genero { get; set; }
        public decimal Classificacao { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public int? NAulas { get; set; }
        public int? NTestes { get; set; }
    }
}
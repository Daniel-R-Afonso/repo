using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Utilizador
    {
        [Key]
        public int IdUtilizador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Genero { get; set; }
        public decimal? Classificacao { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public int? NAulas { get; set; }
        public int? NTestes { get; set; }
        public virtual ICollection<AulasConcelho> AulasConcelho { get; set; }
        public virtual ICollection<AulasDistrito> AulasDistrito { get; set; }
        public virtual ICollection<PerguntasUtilizador> PerguntasUtilizador { get; set; }
        public virtual ICollection<AvatarUtilizador> AvatarUtilizador { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeoAcademy.Models
{
    public class Utilizador
    {
        [Key]
        public int UtilizadorID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Genero { get; set; }
        public int Pontos { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public int NumAulas { get; set; }
        public int NumTestes { get; set; }

        //public virtual ICollection<PerguntasUtilizador> PerguntasUtilizador { get; set; }
        //public virtual ICollection<AvatarUtilizador> AvatarUtilizador { get; set; }

        
    }
}
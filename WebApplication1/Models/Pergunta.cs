using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeoAcademy.Models
{
    public class Pergunta
    {
        [Key]
        public int IdPergunta { get; set; }
        public string Descricao { get; set; }
        public int IdDistrito { get; set; }
        public int IdConceho { get; set; }
        public virtual ICollection<PerguntasUtilizador> PerguntasUtilizador { get; set; }
    }
}
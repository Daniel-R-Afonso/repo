using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeoAcademy.Models
{
    public class PerguntasUtilizador
    {
        [Key]
        [Column(Order = 1)] 
        public int IdUtilizador { get; set; }
        [Key]
        [Column(Order = 2)] 
        public int IdPergunta { get; set; }
        public DateTime Data { get; set; }
        public bool Cotacao { get; set; }    
    }
}
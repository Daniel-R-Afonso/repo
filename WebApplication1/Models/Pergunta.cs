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
        public int PerguntaID { get; set; }
        public string Descricao { get; set; }
        public int Distrito { get; set; }
        public int ConceLho { get; set; }
        public string RespostaCorrecta { get; set;}
        public string RespostaErrada1 {get;set;}
        public string RespostaErrada2 {get;set;}
        public string RespostaErrada3 {get;set;}    
    }
   //     public virtual ICollection<PerguntasUtilizador> PerguntasUtilizador { get; set; }
 }

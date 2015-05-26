using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Distrito
    {
        [Key]
        public int IdDistrito { get; set; }
        public string Nome { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public virtual ICollection<AulasDistrito> AulasDistrito { get; set; }
    }
}
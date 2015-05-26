using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Avatar
    {
        [Key]
        public int IdAvatar { get; set; }
        public string Descricao { get; set; }
        public string CodigoHTML { get; set; }
        public string Achivement { get; set; }
        public virtual ICollection<AvatarUtilizador> AvatarUtilizador { get; set; }
    }
}
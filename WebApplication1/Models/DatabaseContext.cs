using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DatabaseContext: DbContext
    {
        public DbSet<AulasConcelho> AulasConcelhos { get; set; }
        public DbSet<AulasDistrito> AulasDistritos { get; set; }
        public DbSet<Avatar> Avatars { get; set; }
        public DbSet<AvatarUtilizador> AvatarUtilizadors { get; set; }
        public DbSet<Concelho> Concelhos { get; set; }
        public DbSet<Distrito> Distritos { get; set; }
        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<PerguntasUtilizador> PerguntasUtilizadors { get; set; }
        public DbSet<Utilizador> Utilizadors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
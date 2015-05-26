using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var Utilizador = new List<Utilizador>{
                new Utilizador{Nome="Daniel Afonso",DataNascimento=DateTime.Parse("1991-01-20"),Email="daniel_afonso@me.com",Genero="Masculino",Password="12345678"},
                new Utilizador{Nome="Rui Sousa",DataNascimento=DateTime.Parse("1991-01-20"),Email="daniel_afonso@me.com",Genero="Masculino",Password="12345678"},
                new Utilizador{Nome="Mario Pinto",DataNascimento=DateTime.Parse("1991-01-20"),Email="daniel_afonso@me.com",Genero="Masculino",Password="12345678"}
            };
            foreach (var temp in Utilizador)
            {
                context.Utilizadors.Add(temp);
            }
            context.SaveChanges();


            var Distrito = new List<Distrito>{
                new Distrito{Nome="Viana do Castelo",Longitude="Longitude",Latitude="Latitude"}
            };
            foreach (var temp in Distrito)
            {
                context.Distritos.Add(temp);
            }
            context.SaveChanges();

            var concelhos = new List<Concelho>{
                new Concelho{Nome="Viana do Castelo",Longitude="Longitude",Latitude="Latitude",IdDistrito=1,Descricao="População: 100.000"},
                new Concelho{Nome="Ponte do Lima",Longitude="Longitude",Latitude="Latitude",IdDistrito=1,Descricao="População: 80.000"},
                new Concelho{Nome="Barcelos",Longitude="Longitude",Latitude="Latitude",IdDistrito=1,Descricao="População: 80.000"},
                new Concelho{Nome="Esposende",Longitude="Longitude",Latitude="Latitude",IdDistrito=1,Descricao="População: 30.000"}
            };
            foreach (var temp in concelhos) {
                context.Concelhos.Add(temp);
            }
            context.SaveChanges();

            var Avatar = new List<Avatar>{
                new Avatar{Descricao="Avatar1",CodigoHTML="Codigo",Achivement="Achivement" }
            };
            foreach (var temp in Avatar)
            {
                context.Avatars.Add(temp);
            }
            context.SaveChanges();


            var Pergunta = new List<Pergunta>{
                new Pergunta{IdConceho=1,IdDistrito=1,Descricao="Pergunta 1"}
            };
            foreach (var temp in Pergunta)
            {
                context.Perguntas.Add(temp);
            }
            context.SaveChanges();


            var AulasConcelho = new List<AulasConcelho>{
                new AulasConcelho{IdUtilizador=1,IdConcelho=1,Data=DateTime.Parse("2015-05-05")}
            };
            foreach (var temp in AulasConcelho)
            {
                context.AulasConcelhos.Add(temp);
            }
            context.SaveChanges();


            var AulasDistrito = new List<AulasDistrito>{
                new AulasDistrito{IdUtilizador=1,IdDistrito=1,Data=DateTime.Parse("2015-05-05")}
            };
            foreach (var temp in AulasDistrito)
            {
                context.AulasDistritos.Add(temp);
            }
            context.SaveChanges();


            var AvatarUtilizador = new List<AvatarUtilizador>{
                new AvatarUtilizador{IdAvatar=1,IdUtilizador=1,Data=DateTime.Parse("2015-05-05")}
            };
            foreach (var temp in AvatarUtilizador)
            {
                context.AvatarUtilizadors.Add(temp);
            }
            context.SaveChanges();
        
        }
    }
}
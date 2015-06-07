﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GeoAcademy.Models
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var Utilizador = new List<Utilizador>{
                new Utilizador{Nome="Daniel Afonso",DataNascimento=DateTime.Parse("1991-01-20"),Email="daniel_afonso@me.com",Idade=20,Genero="true",Password="12345678",NumTestes=30,NumAulas=20,Pontos=100},
                new Utilizador{Nome="Rui Sousa",DataNascimento=DateTime.Parse("1991-01-20"),Email="daniel_afonso@me.com",Idade=20,Genero="true",Password="12345678",NumTestes=50,NumAulas=10,Pontos=200},
                new Utilizador{Nome="Mario Pinto",DataNascimento=DateTime.Parse("1991-01-20"),Email="daniel_afonso@me.com",Idade=20,Genero="true",Password="12345678",NumTestes=5,NumAulas=2,Pontos=5}
            };
            foreach (var temp in Utilizador)
            {
                context.Utilizadors.Add(temp);
            }
            context.SaveChanges();
        /*
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

            var AvatarUtilizador = new List<AvatarUtilizador>{
                new AvatarUtilizador{IdAvatar=1,IdUtilizador=1,Data=DateTime.Parse("2015-05-05")}
            };
            foreach (var temp in AvatarUtilizador)
            {
                context.AvatarUtilizadors.Add(temp);
            }
            context.SaveChanges();
        */
        }
    }
}
using System;
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
                new Utilizador{Nome="Mario Pinto",DataNascimento=DateTime.Parse("1991-01-20"),Email="daniel_afonso@me.com",Idade=20,Genero="true",Password="12345678",NumTestes=5,NumAulas=2,Pontos=5},
                new Utilizador{Nome="Paulo Cardoso",DataNascimento=DateTime.Parse("1992-05-11"),Email="pcardoso.lei@gmail.com",Idade=23,Genero="true",Password="1234512",NumTestes=300,NumAulas=300,Pontos=1000},
                new Utilizador{Nome="Luis Brito",DataNascimento=DateTime.Parse("1990-12-12"),Email="fossil@gmail.com",Idade=27,Genero="true",Password="1234512",NumTestes=50,NumAulas=20,Pontos=2000},
               new Utilizador{Nome="Enriqueta Silva",DataNascimento=DateTime.Parse("1993-12-12"),Email="enriqueta@gmail.com",Idade=20,Genero="false",Password="123423512",NumTestes=55,NumAulas=25,Pontos=2500}    
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

            */
            var Pergunta = new List<Pergunta>{
                new Pergunta{Descricao="Qual a area de Braga?",Distrito=1,RespostaCorrecta="183,4 km2", RespostaErrada1="200,3 km2", RespostaErrada2="180km2",RespostaErrada3="190km2"},
                new Pergunta{Descricao="Qual destes concelhos não pertence a Braga?",Distrito=1,RespostaCorrecta="Paços de Ferreira",RespostaErrada1="Barcelos",RespostaErrada2="Braga",RespostaErrada3="Esposende"},
                new Pergunta{Descricao="Qual destes monumentos pertence a Braga?",Distrito=1,RespostaCorrecta="Bom Jesus",RespostaErrada1="Mosteiro dos Jerónimos",RespostaErrada2="Santa Luzia",RespostaErrada3="Torre dos Clérigos"}
            };
            foreach (var temp in Pergunta)
            {
                context.Perguntas.Add(temp);
            }
            context.SaveChanges();
            
            /*
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
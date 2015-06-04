using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private DatabaseContext db = new DatabaseContext();
        public ActionResult Testes()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //var Utilizadores = db.Utilizadors.ToList<Utilizador>();
            var Utilizadores = db.Utilizadors.ToList();
            var Lit = db.Concelhos.ToList();
            return View(Lit);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.ImageURL = "~/Images/portugal23.gif";

            return View();
        }

        public ActionResult getDistrict(int IdDistrict)
        {
            //Response.Write(DistrictName);
            Debug.WriteLine(IdDistrict);
            var Distrito = db.Distritos.Find(IdDistrict);
            ViewBag.Title = Distrito.Nome;
            List<Concelho> Lista = db.Concelhos.SqlQuery("Select * from Concelho where IdDistrito='"+IdDistrict+"'").ToList();
            List<Concelho> Lita = db.Concelhos.SqlQuery("Select * from Concelho").ToList();
            var Lit = db.Concelhos.ToList();
            var ListaConcelhos = db.Concelhos.Where(s => s.IdDistrito == IdDistrict);
            return View("~/Views/Home/getDistrict.cshtml", Lit);

            //return View(Distrito);
        }

        public ActionResult getConcelho(int IdConcelho)
        {
            //Response.Write(DistrictName);
            Debug.WriteLine(IdConcelho);
            var Concelho = db.Concelhos.Find(IdConcelho);
            return View("~/Views/Home/getDistrict.cshtml", Concelho);

            //return View(Distrito);
        }
    }
}
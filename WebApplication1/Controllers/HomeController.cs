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
        
        public ActionResult Ranking()
        {
            return View();
        }

        public ActionResult Testes()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Perfil()
        {
            return View();

        }
        public ActionResult Aulas()
        {
            return View();
        }



    }
}
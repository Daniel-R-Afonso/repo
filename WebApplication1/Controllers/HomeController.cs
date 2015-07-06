using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeoAcademy.Models;

namespace GeoAcademy.Controllers
{
    public class HomeController : Controller
    {
        private DatabaseContext db = new DatabaseContext();
        
        public ActionResult Ranking()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Aulas()
        {
            return View();
        }



    }
}
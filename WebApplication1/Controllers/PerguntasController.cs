using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GeoAcademy.Models;

namespace GeoAcademy.Controllers
{
    public class PerguntasController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Perguntas
        public ActionResult Index()
        {
            return View(db.Perguntas.ToList());
        }

        public ActionResult Testes()
        {
            var questions = db.Perguntas.ToArray();
            return View(questions);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

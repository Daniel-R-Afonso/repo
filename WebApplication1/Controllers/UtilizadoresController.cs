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
    public class UtilizadoresController : Controller
    {
        private DatabaseContext db = new DatabaseContext();      

        public ActionResult Ranking(string sortOrder)
        {
            var users = from s in db.Utilizadors
                           select s;
            switch (sortOrder)
            {
                case "num_Pontos":
                    users = users.OrderByDescending(s => s.Pontos);
                    break;
                case "num_Testes":
                    users = users.OrderByDescending(s => s.NumTestes);
                    break;
                default:
                    users = users.OrderByDescending(s => s.Pontos);
                    break;
            }
            return View(users.ToList());
        }

        // GET: Utilizadores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utilizador utilizador = db.Utilizadors.Find(id);
            if (utilizador == null)
            {
                return HttpNotFound();
            }
            return View(utilizador);
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

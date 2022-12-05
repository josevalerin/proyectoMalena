using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TiendaVideojuegos.Models;

namespace TiendaVideojuegos.Controllers
{
    public class VENTASController : Controller
    {
        private TiendaVideojuegosEntities db = new TiendaVideojuegosEntities();

        // GET: VENTAS
        public ActionResult Index()
        {
            var vENTA = db.VENTA.Include(v => v.PRODUCTOS).Include(v => v.USUARIOS);
            return View(vENTA.ToList());
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

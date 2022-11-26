using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaVideojuegos.Models;
using System.Data.Entity;
using System.Net;

namespace TiendaVideojuegos.Controllers
{
    public class HomeController : Controller
    {
        private TiendaVideojuegosEntities db = new TiendaVideojuegosEntities();

        public ActionResult Index()
        {
            var productos = db.PRODUCTOS.Include(p => p.CATEGORIAS).Include(p => p.MARCAS);
            return View(productos.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCTOS productos = db.PRODUCTOS.Find(id);
            if (productos == null)
            {
                return HttpNotFound();
            }
            return View(productos);
        }

        public ActionResult Consolas()
        {
            var consolas = db.PRODUCTOS.Where(x => x.ID_CATEGORIA == 2);
            return View(consolas.ToList());
        }

        public ActionResult Accesorios()
        {
            var accesorios = db.PRODUCTOS.Where(x => x.ID_CATEGORIA == 3);
            return View(accesorios.ToList());
        }

        public ActionResult Videojuegos()
        {
            var videojuegos = db.PRODUCTOS.Where(x => x.ID_CATEGORIA == 1);
            return View(videojuegos);
        }
    }
}
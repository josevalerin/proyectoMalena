using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TiendaVideojuegos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Consolas()
        {
            return View();
        }

        public ActionResult Accesorios()
        {
            return View();
        }

        public ActionResult Videojuegos()
        {
            return View();
        }
    }
}
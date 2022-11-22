using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TiendaVideojuegos.Controllers
{
    public class UsuarioController : Controller
    {
      
        public ActionResult InicioSesion()
        {
            return View();
        }

        public ActionResult Registro()
        {
            return View();
        }
    }
}
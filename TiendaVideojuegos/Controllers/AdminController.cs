using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Net;
using System.Web.Mvc;
using TiendaVideojuegos.Models;

namespace TiendaVideojuegos.Controllers
{
    public class AdminController : Controller
    {

        // GET: Admin
        public ActionResult Admin()
        {
            return View();
        }

    }
}
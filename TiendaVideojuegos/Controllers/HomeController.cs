using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.Security;
using TiendaVideojuegos.Models;

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


        public ActionResult InicioSesion()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult InicioSesion(USUARIOS user)
        {
            if (ModelState.IsValid)
            {
                bool IsValidUser = db.USUARIOS
               .Any(u => u.CORREO_ELECTRONICO.ToLower() == user
               .CORREO_ELECTRONICO.ToLower() && user
               .CLAVE == user.CLAVE);

                if (IsValidUser)
                {
                    FormsAuthentication.SetAuthCookie(user.CORREO_ELECTRONICO, false);
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError("", "invalid Username or Password");
            return View();
        }

        public ActionResult Registro()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registro(USUARIOS registerUser)
        {
            if (ModelState.IsValid)
            {
                registerUser.ID_ROL = 2;
                db.USUARIOS.Add(registerUser);
                db.SaveChanges();
                return RedirectToAction("InicioSesion");

            }

            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
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
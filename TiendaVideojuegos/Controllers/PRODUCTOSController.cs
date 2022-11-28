using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using TiendaVideojuegos.Models;

namespace TiendaVideojuegos.Controllers
{
    public class PRODUCTOSController : Controller
    {
        private TiendaVideojuegosEntities db = new TiendaVideojuegosEntities();

        // GET: PRODUCTOS
        public ActionResult Index()
        {
            var pRODUCTOS = db.PRODUCTOS.Include(p => p.CATEGORIAS).Include(p => p.MARCAS);
            return View(pRODUCTOS.ToList());
        }

        // GET: PRODUCTOS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCTOS pRODUCTOS = db.PRODUCTOS.Find(id);
            if (pRODUCTOS == null)
            {
                return HttpNotFound();
            }
            return View(pRODUCTOS);
        }

        // GET: PRODUCTOS/Create
        public ActionResult Create()
        {
            ViewBag.ID_CATEGORIA = new SelectList(db.CATEGORIAS, "ID_CATEGORIA", "NOMBRE_CATEGORIA");
            ViewBag.ID_MARCA = new SelectList(db.MARCAS, "ID_MARCA", "NOMBRE_MARCA");
            return View();
        }

        // POST: PRODUCTOS/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PRODUCTO,ID_CATEGORIA,ID_MARCA,NOMBRE_PRODUCTO,IMAGEN_PRODUCTO,DESCRIPCION_PRODUCTO,CANTIDAD_PRODCUTO,PRECIO,DESCUENTO,DESTACADO")] PRODUCTOS pRODUCTOS)
        {
            if (ModelState.IsValid)
            {
                db.PRODUCTOS.Add(pRODUCTOS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_CATEGORIA = new SelectList(db.CATEGORIAS, "ID_CATEGORIA", "NOMBRE_CATEGORIA", pRODUCTOS.ID_CATEGORIA);
            ViewBag.ID_MARCA = new SelectList(db.MARCAS, "ID_MARCA", "NOMBRE_MARCA", pRODUCTOS.ID_MARCA);
            return View(pRODUCTOS);
        }

        // GET: PRODUCTOS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCTOS pRODUCTOS = db.PRODUCTOS.Find(id);
            if (pRODUCTOS == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_CATEGORIA = new SelectList(db.CATEGORIAS, "ID_CATEGORIA", "NOMBRE_CATEGORIA", pRODUCTOS.ID_CATEGORIA);
            ViewBag.ID_MARCA = new SelectList(db.MARCAS, "ID_MARCA", "NOMBRE_MARCA", pRODUCTOS.ID_MARCA);
            return View(pRODUCTOS);
        }

        // POST: PRODUCTOS/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PRODUCTO,ID_CATEGORIA,ID_MARCA,NOMBRE_PRODUCTO,IMAGEN_PRODUCTO,DESCRIPCION_PRODUCTO,CANTIDAD_PRODCUTO,PRECIO,DESCUENTO,DESTACADO")] PRODUCTOS pRODUCTOS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRODUCTOS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_CATEGORIA = new SelectList(db.CATEGORIAS, "ID_CATEGORIA", "NOMBRE_CATEGORIA", pRODUCTOS.ID_CATEGORIA);
            ViewBag.ID_MARCA = new SelectList(db.MARCAS, "ID_MARCA", "NOMBRE_MARCA", pRODUCTOS.ID_MARCA);
            return View(pRODUCTOS);
        }

        // GET: PRODUCTOS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCTOS pRODUCTOS = db.PRODUCTOS.Find(id);
            if (pRODUCTOS == null)
            {
                return HttpNotFound();
            }
            return View(pRODUCTOS);
        }

        // POST: PRODUCTOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRODUCTOS pRODUCTOS = db.PRODUCTOS.Find(id);
            db.PRODUCTOS.Remove(pRODUCTOS);
            db.SaveChanges();
            return RedirectToAction("Index");
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

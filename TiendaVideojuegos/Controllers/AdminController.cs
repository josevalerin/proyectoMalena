using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaVideojuegos.Clases;
using TiendaVideojuegos.Models;
namespace TiendaVideojuegos.Controllers
{
    public class AdminController : Controller
    {

        ProductoClase producto = new ProductoClase();

        // GET: Admin
        public ActionResult Admin()
        {
            return View();
        }

        // GET: Producto
        public ActionResult Producto()
        {
            IEnumerable<PRODUCTOS> lst = producto.Consultar();
            return View(lst);
        }

        public ActionResult GuardarProducto(PRODUCTOS modelo)
        {
            return View(modelo);
        }

        public ActionResult Nuevo(PRODUCTOS modelo)
        {
            producto.Guardar(modelo);
            return View("GuardarProducto", modelo);
        }

        public ActionResult ModificarProducto(int ID_PRODUCTO)
        {
            PRODUCTOS modelo = producto.Consultar(ID_PRODUCTO);
            return View(modelo);
        }

        public ActionResult Cambiar(PRODUCTOS modelo)
        {
            producto.Modificar(modelo);
            return View("ModificarProducto", modelo);
        }


        public ActionResult DetalleProducto(int ID_PRODUCTO)
        {
            PRODUCTOS modelo = producto.Consultar(ID_PRODUCTO);
            return View(modelo);
        }


        public ActionResult EliminarProducto(int ID_PRODUCTO)
        {
            PRODUCTOS modelo = new PRODUCTOS
            {
               ID_PRODUCTO = ID_PRODUCTO
            };
            producto.Eliminar(modelo);
            IEnumerable<PRODUCTOS> lst = producto.Consultar();
            return View("Producto", lst);
        }
    }
}
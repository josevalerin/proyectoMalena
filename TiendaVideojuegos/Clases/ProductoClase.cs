using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaVideojuegos.Models;
namespace TiendaVideojuegos.Clases
{
    public class ProductoClase
    {

        public IEnumerable<PRODUCTOS> Consultar()
        {
            using (TiendaVideojuegosEntities db = new TiendaVideojuegosEntities())
            {
                return db.PRODUCTOS.ToList();
            }
        }
        public void Guardar(PRODUCTOS modelo)
        {
            using (TiendaVideojuegosEntities db = new TiendaVideojuegosEntities())
            {
                db.PRODUCTOS.Add(modelo);
                db.SaveChanges();
            }
        }

        public void Modificar(PRODUCTOS modelo)
        {
            using (TiendaVideojuegosEntities db = new TiendaVideojuegosEntities())
            {
                db.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Eliminar(PRODUCTOS modelo)
        {
            using (TiendaVideojuegosEntities db = new TiendaVideojuegosEntities())
            {
                db.Entry(modelo).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public PRODUCTOS Consultar(int id)
        {
            using (TiendaVideojuegosEntities db = new TiendaVideojuegosEntities())
            {
                return db.PRODUCTOS.FirstOrDefault(x => x.ID_PRODUCTO == id);
            }
        }

    }
}
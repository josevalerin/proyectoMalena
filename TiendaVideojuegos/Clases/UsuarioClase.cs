using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaVideojuegos.Models;

namespace TiendaVideojuegos.Clases
{
    public class UsuarioClase
    {
        public IEnumerable<USUARIOS> Consultar()
        {
            using (TiendaVideojuegosEntities db = new TiendaVideojuegosEntities())
            {
                return db.USUARIOS.ToList();
            }
        }
        public void Guardar(USUARIOS modelo)
        {
            using (TiendaVideojuegosEntities db = new TiendaVideojuegosEntities())
            {
                db.USUARIOS.Add(modelo);
                db.SaveChanges();
            }
        }

        public void Modificar(USUARIOS modelo)
        {
            using (TiendaVideojuegosEntities db = new TiendaVideojuegosEntities())
            {
                db.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Eliminar(USUARIOS modelo)
        {
            using (TiendaVideojuegosEntities db = new TiendaVideojuegosEntities())
            {
                db.Entry(modelo).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public USUARIOS Consultar(int id)
        {
            using (TiendaVideojuegosEntities db = new TiendaVideojuegosEntities())
            {
                return db.USUARIOS.FirstOrDefault(x => x.ID_USUARIO == id);
            }
        }


    }
}
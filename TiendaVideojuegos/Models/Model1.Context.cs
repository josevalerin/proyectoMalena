﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiendaVideojuegos.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TiendaVideojuegosEntities : DbContext
    {
        public TiendaVideojuegosEntities()
            : base("name=TiendaVideojuegosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CANTONES> CANTONES { get; set; }
        public virtual DbSet<CATEGORIAS> CATEGORIAS { get; set; }
        public virtual DbSet<DIRECCIONES> DIRECCIONES { get; set; }
        public virtual DbSet<MARCAS> MARCAS { get; set; }
        public virtual DbSet<PRODUCTOS> PRODUCTOS { get; set; }
        public virtual DbSet<PROVINCIAS> PROVINCIAS { get; set; }
        public virtual DbSet<ROLES> ROLES { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
        public virtual DbSet<VENTA> VENTA { get; set; }
    }
}
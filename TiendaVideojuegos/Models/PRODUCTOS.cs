//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class PRODUCTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCTOS()
        {
            this.VENTA = new HashSet<VENTA>();
        }
    
        public int ID_PRODUCTO { get; set; }
        public int ID_CATEGORIA { get; set; }
        public int ID_MARCA { get; set; }
        public string NOMBRE_PRODUCTO { get; set; }
        public string IMAGEN_PRODUCTO { get; set; }
        public string DESCRIPCION_PRODUCTO { get; set; }
        public int CANTIDAD_PRODCUTO { get; set; }
        public int PRECIO { get; set; }
        public Nullable<int> DESCUENTO { get; set; }
        public Nullable<bool> DESTACADO { get; set; }
    
        public virtual CATEGORIAS CATEGORIAS { get; set; }
        public virtual MARCAS MARCAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENTA> VENTA { get; set; }
    }
}

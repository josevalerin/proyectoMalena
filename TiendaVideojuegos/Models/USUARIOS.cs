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
    
    public partial class USUARIOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIOS()
        {
            this.VENTA = new HashSet<VENTA>();
        }
    
        public int ID_USUARIO { get; set; }
        public int ID_ROL { get; set; }
        public Nullable<int> ID_DIRECCION { get; set; }
        public string CEDULA { get; set; }
        public string NOMBRE_USUARIO { get; set; }
        public string CLAVE { get; set; }
        public string NOMBRE_COMPLETO { get; set; }
        public string CORREO_ELECTRONICO { get; set; }
        public string TELEFONO { get; set; }
    
        public virtual ROLES ROLES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENTA> VENTA { get; set; }
    }
}
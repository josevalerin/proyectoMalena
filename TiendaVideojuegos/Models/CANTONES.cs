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
    
    public partial class CANTONES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CANTONES()
        {
            this.DIRECCIONES = new HashSet<DIRECCIONES>();
        }
    
        public int ID_CANTON { get; set; }
        public int ID_PROVINCIA { get; set; }
        public string CANTON { get; set; }
    
        public virtual PROVINCIAS PROVINCIAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIRECCIONES> DIRECCIONES { get; set; }
    }
}

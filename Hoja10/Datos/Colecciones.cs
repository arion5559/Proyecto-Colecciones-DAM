//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hoja10.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Colecciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Colecciones()
        {
            this.RelColecArt = new HashSet<RelColecArt>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoDeArticulo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelColecArt> RelColecArt { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MaterialTec.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROMOCION
    {
        public PROMOCION()
        {
            this.PRODUCTO_PROMOCION = new HashSet<PRODUCTO_PROMOCION>();
        }
    
        public int ID { get; set; }
        public string TITULO { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<int> AUTORIZADO { get; set; }
        public System.DateTime FECHA_INICIAL { get; set; }
        public System.DateTime FECHA_FINAL { get; set; }
        public Nullable<int> ACTIVO { get; set; }
    
        public virtual ICollection<PRODUCTO_PROMOCION> PRODUCTO_PROMOCION { get; set; }
    }
}

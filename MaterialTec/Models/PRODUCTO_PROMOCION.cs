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
    
    public partial class PRODUCTO_PROMOCION
    {
        public int ID { get; set; }
        public int DESCUENTO { get; set; }
        public int PLUS { get; set; }
        public Nullable<int> ACTIVE { get; set; }
        public System.DateTime CREATED_AT { get; set; }
        public int FK_TIPO_PROMOCION { get; set; }
        public int FK_PROMOCION { get; set; }
        public int FK_PRODUCTO { get; set; }
    
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual PROMOCION PROMOCION { get; set; }
        public virtual TIPO_PROMOCION TIPO_PROMOCION { get; set; }
    }
}
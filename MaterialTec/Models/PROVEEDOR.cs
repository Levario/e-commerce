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
    
    public partial class PROVEEDOR
    {
        public PROVEEDOR()
        {
            this.PEDIDO_PROVEEDOR = new HashSet<PEDIDO_PROVEEDOR>();
        }
    
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string RFC { get; set; }
    
        public virtual ICollection<PEDIDO_PROVEEDOR> PEDIDO_PROVEEDOR { get; set; }
    }
}
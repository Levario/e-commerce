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
    
    public partial class USUARIO
    {
        public USUARIO()
        {
            this.CHATs = new HashSet<CHAT>();
            this.CHATs1 = new HashSet<CHAT>();
            this.DIRECCIONs = new HashSet<DIRECCION>();
            this.ORDENs = new HashSet<ORDEN>();
            this.PEDIDO_PROVEEDOR = new HashSet<PEDIDO_PROVEEDOR>();
        }
    
        public int ID { get; set; }
        public string USERNAME { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string PASSWORD { get; set; }
        public int TEL { get; set; }
        public string EMAIL { get; set; }
        public int ACTIVO { get; set; }
        public int FK_ID_ROLE { get; set; }
        public System.DateTime CREATED_AT { get; set; }
    
        public virtual ICollection<CHAT> CHATs { get; set; }
        public virtual ICollection<CHAT> CHATs1 { get; set; }
        public virtual ICollection<DIRECCION> DIRECCIONs { get; set; }
        public virtual ICollection<ORDEN> ORDENs { get; set; }
        public virtual ICollection<PEDIDO_PROVEEDOR> PEDIDO_PROVEEDOR { get; set; }
        public virtual ROL ROL { get; set; }
    }
}
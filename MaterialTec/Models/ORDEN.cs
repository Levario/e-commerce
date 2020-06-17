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
    
    public partial class ORDEN
    {
        public ORDEN()
        {
            this.ORDEN_PRODUCTO = new HashSet<ORDEN_PRODUCTO>();
        }
    
        public int ID { get; set; }
        public double TOTAL { get; set; }
        public double SUBTOTAL { get; set; }
        public Nullable<int> PAGADO { get; set; }
        public Nullable<double> DESCUENTO { get; set; }
        public string NUMERO_GUIA { get; set; }
        public System.DateTime CREATED_AT { get; set; }
        public int FK_CLIENT { get; set; }
        public int FK_METODO_PAGO { get; set; }
    
        public virtual METODO_PAGO METODO_PAGO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<ORDEN_PRODUCTO> ORDEN_PRODUCTO { get; set; }
    }
}
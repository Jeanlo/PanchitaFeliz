//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaModelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDENES
    {
        public ORDENES()
        {
            this.FACTURAS = new HashSet<FACTURAS>();
            this.ORDENES1 = new HashSet<ORDENES>();
            this.ORDENESPLATOS = new HashSet<ORDENESPLATOS>();
            this.ORDENESEMPLEADOPLATOS = new HashSet<ORDENESEMPLEADOPLATOS>();
            this.MESAS = new HashSet<MESAS>();
        }
    
        public decimal CODIGOORDEN { get; set; }
        public Nullable<decimal> CLIENTE { get; set; }
        public Nullable<decimal> ESTADO { get; set; }
        public Nullable<decimal> COSTOTOTAL { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public Nullable<decimal> HORA { get; set; }
        public Nullable<decimal> MINUTO { get; set; }
        public Nullable<decimal> SEGUNDO { get; set; }
        public Nullable<decimal> SUBORDEN { get; set; }
        public Nullable<decimal> MESERO { get; set; }
    
        public virtual CLIENTES_RESTAURANTE CLIENTES_RESTAURANTE { get; set; }
        public virtual EMPLEADOS EMPLEADOS { get; set; }
        public virtual ESTADOORDENES ESTADOORDENES { get; set; }
        public virtual ICollection<FACTURAS> FACTURAS { get; set; }
        public virtual ICollection<ORDENES> ORDENES1 { get; set; }
        public virtual ORDENES ORDENES2 { get; set; }
        public virtual ICollection<ORDENESPLATOS> ORDENESPLATOS { get; set; }
        public virtual ICollection<ORDENESEMPLEADOPLATOS> ORDENESEMPLEADOPLATOS { get; set; }
        public virtual ICollection<MESAS> MESAS { get; set; }
    }
}
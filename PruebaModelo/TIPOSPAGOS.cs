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
    
    public partial class TIPOSPAGOS
    {
        public TIPOSPAGOS()
        {
            this.FACTURAS = new HashSet<FACTURAS>();
        }
    
        public decimal CODIGOTIPOPAGO { get; set; }
    
        public virtual ICollection<FACTURAS> FACTURAS { get; set; }
    }
}
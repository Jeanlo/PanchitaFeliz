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
    
    public partial class CARGOS
    {
        public CARGOS()
        {
            this.EMPLEADOS = new HashSet<EMPLEADOS>();
            this.ORDENESEMPLEADOPLATOS = new HashSet<ORDENESEMPLEADOPLATOS>();
        }
    
        public decimal CODIGOCARGO { get; set; }
    
        public virtual ICollection<EMPLEADOS> EMPLEADOS { get; set; }
        public virtual ICollection<ORDENESEMPLEADOPLATOS> ORDENESEMPLEADOPLATOS { get; set; }
    }
}

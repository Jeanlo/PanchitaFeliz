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
    
    public partial class UNIDADES
    {
        public UNIDADES()
        {
            this.RECETASINGREDIENTES = new HashSet<RECETASINGREDIENTES>();
        }
    
        public decimal CODIGOUNIDAD { get; set; }
    
        public virtual ICollection<RECETASINGREDIENTES> RECETASINGREDIENTES { get; set; }
    }
}
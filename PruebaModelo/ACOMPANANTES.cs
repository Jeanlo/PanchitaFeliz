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
    
    public partial class ACOMPANANTES : OBJETOS
    {
        public ACOMPANANTES()
        {
            this.DISTRIBUIDORES = new HashSet<DISTRIBUIDORES>();
            this.MENUS = new HashSet<MENUS>();
        }
    
        public string NOMBRE { get; set; }
    
        public virtual ICollection<DISTRIBUIDORES> DISTRIBUIDORES { get; set; }
        public virtual ICollection<MENUS> MENUS { get; set; }
    }
}

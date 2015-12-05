using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanchitaFeliz_ModeloServicio.ServiceReference1
{
    public partial class OBJETOSINVENTARIOS
    {
        #region "Constructores"

        public OBJETOSINVENTARIOS()
        {

        }

        public OBJETOSINVENTARIOS(decimal objeto, decimal inventario, decimal cantidad, decimal unidades)
        {
            OBJETO = objeto;
            INVENTARIO = inventario;
            CANTIDAD = cantidad;
            UNIDADES = unidades;
        }
        public OBJETOSINVENTARIOS(decimal objeto, decimal inventario)
        {
            OBJETO = objeto;
            INVENTARIO = inventario;
        }

        #endregion        
    }
}

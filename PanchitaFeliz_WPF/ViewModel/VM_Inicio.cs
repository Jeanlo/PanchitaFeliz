using PanchitaFeliz_ModeloServicio.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanchitaFeliz_WPF.ViewModel
{
    public class VM_Inicio
    {
        #region "Atributos"

        public ServicioClient Client = new ServicioClient();

        public ObservableCollection<PERSONAS> ListadoPersonas { get; set; }

        #endregion

        #region "Constructores"

        public VM_Inicio()
        {
            ListadoPersonas = Client.ObtenerPersonas();
        }

        #endregion
    }
}

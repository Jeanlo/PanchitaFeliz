using PanchitaFeliz_ModeloServicio.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF.ViewModel
{
    public class VM_Ventas : VM_General
    {
        #region "Atributos"

        public ObservableCollection<ORDENES> ListadoOrdenes { get; set; }

        public ORDENES NuevaOrden { get; set; }

        public ObservableCollection<FACTURAS> ListadoFacturas { get; set; }

        public FACTURAS NuevaFactura { get; set; }

        #endregion

        #region "Comandos"


        #region "AccederCommand"

        public ICommand GuardarNuevaOrdenCommand { get; set; }

        public void CrearGuardarNuevaOrdenCommand()
        {
            GuardarNuevaOrdenCommand = new RelayCommand((arg) => GuardarNuevaOrden());
        }

        public void GuardarNuevaOrden()
        {
            Client.GuardarNuevaOrden(NuevaOrden);
            MessageBox.Show("¡Se ha insertado correctamente una nueva orden!");
        }

        #endregion


        #endregion

        #region "Constructores"

        public VM_Ventas()
        {
            CrearGuardarNuevaOrdenCommand();
            NuevaFactura = new FACTURAS();
            NuevaOrden = new ORDENES();
            ListadoFacturas = Client.ObtenerFacturas();
            ListadoOrdenes = Client.ObtenerOrdenes();
        }

        #endregion
    }
}

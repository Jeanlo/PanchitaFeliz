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
    public class VM_Cocina : VM_General
    {
        #region "Atributos"

        public PLATOS NuevoPlato { get; set; }

        public ObservableCollection<PLATOS> ListadoPlatos { get; set; }

        #endregion

        #region "Comandos"

        #region "AccederCommand"

        public ICommand GuardarNuevoPlatoCommand { get; set; }

        public void CrearGuardarNuevoPlatoCommand()
        {
            GuardarNuevoPlatoCommand = new RelayCommand((arg) => GuardarNuevoPlato());
        }

        public void GuardarNuevoPlato()
        {
            Client.GuardarNuevoPlato(NuevoPlato);
            MessageBox.Show("¡Se ha insertado correctamente un nuevo platillo!");
        }

        #endregion

        #endregion

        #region "Constructores"

        public VM_Cocina()
        {
            CrearGuardarNuevoPlatoCommand();
            NuevoPlato = new PLATOS();
            ListadoPlatos = Client.ObtenerPlatos();
        }

        #endregion
    }
}

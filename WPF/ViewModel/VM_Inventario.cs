using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanchitaFeliz_ModeloServicio.ServiceReference1;
using System.Collections.ObjectModel;
using WPF;
using System.Windows.Input;
using System.Windows;

namespace WPF.ViewModel
{
    public class VM_Inventario : VM_General
    {
        #region "Atributos"

        public ObservableCollection<OBJETOSINVENTARIOS> ListadoObjetos { get; set; }

        public ObservableCollection<INGREDIENTES> ListadoIngredientes { get; set; }

        public ObservableCollection<ACOMPANANTES> ListadoAcompanantes { get; set; }
        
        private ObservableCollection<OBJETOSINVENTARIOS> listadoObjetosRecibiendo;

        public ObservableCollection<OBJETOSINVENTARIOS> ListadoObjetosRecibiendo
        {
            get { return listadoObjetosRecibiendo; }
            set { EstablecerPropiedad(ref listadoObjetosRecibiendo, value); }
        }


        public INGREDIENTES IngredienteActual { get; set; }

        public ACOMPANANTES AcompananteActual { get; set; }

        public int CantidadIngredientes { get; set; }

        public int CantidadAcompanantes { get; set; }

        #endregion

        #region "Comandos"

        #region "AccederCommand"

        public ICommand AgregarObjetosCommand { get; set; }

        public void CrearAgregarObjetosCommand()
        {
            AgregarObjetosCommand = new RelayCommand((arg) => AgregarObjetos(arg));
        }

        public void AgregarObjetos(Object arg)
        {
            if (arg.ToString() == "ingrediente")
                ListadoObjetosRecibiendo.Add(new OBJETOSINVENTARIOS(IngredienteActual.CODIGOOBJETO, 1, CantidadIngredientes, 1));
            if (arg.ToString() == "acompanante")
                ListadoObjetosRecibiendo.Add(new OBJETOSINVENTARIOS(AcompananteActual.CODIGOOBJETO, 1, CantidadAcompanantes, 1));
        }

        #endregion

        #region "AccederCommand"

        public ICommand GuardarObjetosRecibidosCommand { get; set; }

        public void CrearGuardarObjetosRecibidosCommand()
        {
            GuardarObjetosRecibidosCommand = new RelayCommand((arg) => GuardarObjetosRecibidos());
        }

        public void GuardarObjetosRecibidos()
        {
            Client.GuardarObjetosRecibidos(ListadoObjetosRecibiendo);
            MessageBox.Show("¡Objetos recibidos correctamente en el inventario!");
        }

        #endregion

        #endregion

        #region "Constructores"

        public VM_Inventario()
        {
            CrearAgregarObjetosCommand();
            CrearGuardarObjetosRecibidosCommand();
            ListadoObjetosRecibiendo = new ObservableCollection<OBJETOSINVENTARIOS>();
            ListadoObjetos = Client.ObtenerObjetosDelInventario();
            ListadoIngredientes = Client.ObtenerIngredientes();
            ListadoAcompanantes = Client.ObtenerAcompanantes();
        }

        #endregion
    }
}

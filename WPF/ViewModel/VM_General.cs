using PanchitaFeliz_ModeloServicio.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF;

namespace WPF.ViewModel
{
    public class VM_General : Notificador
    {
        #region "Atributos"

        public ServicioClient Client = new ServicioClient();

        #endregion

        #region "Constructores"

        public VM_General()
        {
            CrearCambiarVentanaCommand();
        }

        #endregion

        #region "Comandos"

        #region "AccederCommand"

        public ICommand CambiarVentanaCommand { get; set; }

        public void CrearCambiarVentanaCommand()
        {
            CambiarVentanaCommand = new RelayCommand((arg) => CambiarVentana(arg));
        }

        public void CambiarVentana(Object arg)
        {
            if (arg == null)
                return;

            string source = arg.ToString();
            string[] separador = new String[] { "," };
            //[0] = Ventana a abrir, [1] = Ventana a cerrar
            string[] resultado = source.Split(separador, StringSplitOptions.None);
            Window ventana = null;

            //Este Switch de abrir la ventana deseada.
            switch (resultado[0])
            {
                case "ventas":
                    ventana = new Ventas();
                    break;

                case "administracion":
                    ventana = new Administracion();
                    break;

                case "cocina":
                    ventana = new Cocina();
                    break;

                case "inventario":
                    ventana = new Inventario();
                    break;
            }

            //Este Switch se encarga de cerrar la ventana cuando se abre otra.
            switch (resultado[1])
            {
                case "ventas":
                    Ventas.EstaVentana.Close();
                    break;

                case "administracion":
                    Administracion.EstaVentana.Close();
                    break;

                case "cocina":
                    Cocina.EstaVentana.Close();
                    break;

                case "inventario":
                    Inventario.EstaVentana.Close();
                    break;
            }

            ventana.Show();
        }

        #endregion

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    public abstract class Notificador : INotifyPropertyChanged
    {

        #region "Interfaces"

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropiedadCambiada(String nombrePropiedad = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged(this, new PropertyChangedEventArgs(nombrePropiedad));
        }

        public void EstablecerPropiedad<T>(ref T campoPrivado, T nuevoValor, [CallerMemberName] String nombrePropiedad = "")
        {
            if (EqualityComparer<T>.Default.Equals(campoPrivado, nuevoValor))
                return;

            campoPrivado = nuevoValor;
            OnPropiedadCambiada(nombrePropiedad);
        }

        #endregion
    }
}

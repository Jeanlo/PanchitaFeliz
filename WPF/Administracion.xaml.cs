using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF.ViewModel;

namespace WPF
{
    /// <summary>
    /// Lógica de interacción para Ventas.xaml
    /// </summary>
    public partial class Administracion : Window
    {
        public static Window EstaVentana { get; set; }
        public VM_Administracion VM { get; set; }
        public Administracion()
        {
            InitializeComponent();
            EstaVentana = this;
            VM = new VM_Administracion();
            DataContext = VM;
        }
    }
}

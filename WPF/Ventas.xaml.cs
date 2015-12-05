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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF.ViewModel;

namespace WPF
{
    /// <summary>
    /// Lógica de interacción para Ventas.xaml
    /// </summary>
    public partial class Ventas : Window
    {
        public static Window EstaVentana { get; set; }
        public VM_Ventas VM { get; set; }

        public Ventas()
        {
            InitializeComponent();
            EstaVentana = this;
            VM = new VM_Ventas();
            DataContext = VM;
        }
    }
}

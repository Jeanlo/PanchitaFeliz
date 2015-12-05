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
    /// Lógica de interacción para Inventario.xaml
    /// </summary>
    public partial class Inventario : Window
    {
        public static Window EstaVentana { get; set; }
        public VM_Inventario VM { get; set; }
        public Inventario()
        {
            InitializeComponent();
            EstaVentana = this;
            VM = new VM_Inventario();
            DataContext = VM;
        }
    }
}

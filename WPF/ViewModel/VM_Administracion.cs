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
    public class VM_Administracion : VM_General
    {
        #region "Atributos"

        public ObservableCollection<MESAS> ListadoMesas { get; set; }

        public MESAS NuevaMesa { get; set; }

        public ObservableCollection<EMPLEADOS> ListadoEmpleados { get; set; }

        public EMPLEADOS NuevoEmpleado { get; set; }

        public ObservableCollection<SEXOS> ListadoSexos { get; set; }

        public SEXOS NuevoSexo { get; set; }

        public ObservableCollection<CARGOS> ListadoCargos { get; set; }

        public CARGOS NuevoCargo { get; set; }

        public ObservableCollection<TIPOSPAGOS> ListadoTiposPago { get; set; }

        public TIPOSPAGOS NuevoTipoPago { get; set; }

        public ObservableCollection<UNIDADES> ListadoUnidades { get; set; }

        public UNIDADES NuevaUnidad { get; set; }

        public ObservableCollection<ESTADOORDENES> ListadoEstados { get; set; }

        public ESTADOORDENES NuevoEstado { get; set; }

        public ObservableCollection<CLIENTES_RESTAURANTE> ListadoClientes { get; set; }

        public CLIENTES_RESTAURANTE NuevoCliente { get; set; }

        #endregion

        #region "Comandos"

        #region "AccederCommand"

        public ICommand GuardarNuevaMesaCommand { get; set; }

        public void CrearGuardarNuevaMesaCommand()
        {
            GuardarNuevaMesaCommand = new RelayCommand((arg) => GuardarNuevaMesa());
        }

        public void GuardarNuevaMesa()
        {
            Client.GuardarNuevaMesa(NuevaMesa);
            MessageBox.Show("¡Se ha insertado correctamente una nueva mesa!");
        }

        #endregion

        #region "AccederCommand"

        public ICommand GuardarNuevaUnidadCommand { get; set; }

        public void CrearGuardarNuevaUnidadCommand()
        {
            GuardarNuevaUnidadCommand = new RelayCommand((arg) => GuardarNuevaUnidad());
        }

        public void GuardarNuevaUnidad()
        {
            Client.GuardarNuevaUnidad(NuevaUnidad);
            MessageBox.Show("¡Se ha insertado correctamente una nueva unidad!");
        }

        #endregion

        #region "AccederCommand"

        public ICommand GuardarNuevoSexoCommand { get; set; }

        public void CrearGuardarNuevoSexoCommand()
        {
            GuardarNuevoSexoCommand = new RelayCommand((arg) => GuardarNuevoSexo());
        }

        public void GuardarNuevoSexo()
        {
            Client.GuardarNuevoSexo(NuevoSexo);
            MessageBox.Show("¡Se ha insertado correctamente una nuevo sexo!");
        }

        #endregion

        #region "AccederCommand"

        public ICommand GuardarNuevoCargoCommand { get; set; }

        public void CrearGuardarNuevoCargoCommand()
        {
            GuardarNuevoCargoCommand = new RelayCommand((arg) => GuardarNuevoCargo());
        }

        public void GuardarNuevoCargo()
        {
            Client.GuardarNuevoCargo(NuevoCargo);
            MessageBox.Show("¡Se ha insertado correctamente una nuevo cargo!");
        }

        #endregion

        #region "AccederCommand"

        public ICommand GuardarNuevoTipoPagoCommand { get; set; }

        public void CrearGuardarNuevoTipoPagoCommand()
        {
            GuardarNuevoTipoPagoCommand = new RelayCommand((arg) => GuardarNuevoTipoPago());
        }

        public void GuardarNuevoTipoPago()
        {
            Client.GuardarNuevoTipoPago(NuevoTipoPago);
            MessageBox.Show("¡Se ha insertado correctamente una nuevo tipo de pago!");
        }

        #endregion

        #region "AccederCommand"

        public ICommand GuardarNuevoEstadoCommand { get; set; }

        public void CrearGuardarNuevoEstadoCommand()
        {
            GuardarNuevoEstadoCommand = new RelayCommand((arg) => GuardarNuevoEstado());
        }

        public void GuardarNuevoEstado()
        {
            Client.GuardarNuevoEstado(NuevoEstado);
            MessageBox.Show("¡Se ha insertado correctamente una nuevo estado de orden!");
        }

        #endregion

        #region "AccederCommand"

        public ICommand GuardarNuevoEmpleadoCommand { get; set; }

        public void CrearGuardarNuevoEmpleadoCommand()
        {
            GuardarNuevoEmpleadoCommand = new RelayCommand((arg) => GuardarNuevoEmpleado());
        }

        public void GuardarNuevoEmpleado()
        {
            Client.GuardarNuevoEmpleado(NuevoEmpleado);
            MessageBox.Show("¡Se ha insertado correctamente un nuevo empleado!");
        }

        #endregion

        #region "AccederCommand"

        public ICommand GuardarNuevoClienteCommand { get; set; }

        public void CrearGuardarNuevoClienteCommand()
        {
            GuardarNuevoClienteCommand = new RelayCommand((arg) => GuardarNuevoCliente());
        }

        public void GuardarNuevoCliente()
        {
            Client.GuardarNuevoCliente(NuevoCliente);
            MessageBox.Show("¡Se ha insertado correctamente un nuevo cliente!");
        }

        #endregion

        #endregion

        #region "Constructores"

        public VM_Administracion()
        {
            CrearGuardarNuevoEmpleadoCommand();
            CrearGuardarNuevoClienteCommand();
            CrearGuardarNuevaMesaCommand();
            CrearGuardarNuevaUnidadCommand();
            CrearGuardarNuevoCargoCommand();
            CrearGuardarNuevoEstadoCommand();
            CrearGuardarNuevoSexoCommand();
            CrearGuardarNuevoTipoPagoCommand();
            ListadoEmpleados = Client.ObtenerEmpleados();
            NuevoEmpleado = new EMPLEADOS();
            ListadoMesas = Client.ObtenerMesas();
            NuevaMesa = new MESAS();
            ListadoSexos = Client.ObtenerSexos();
            NuevoSexo = new SEXOS();
            ListadoCargos = Client.ObtenerCargos();
            NuevoCargo = new CARGOS();
            ListadoEstados = Client.ObtenerEstados();
            NuevoEstado = new ESTADOORDENES();
            ListadoUnidades = Client.ObtenerUnidades();
            NuevaUnidad = new UNIDADES();
            ListadoTiposPago = Client.ObtenerTiposPago();
            NuevoTipoPago = new TIPOSPAGOS();
            ListadoClientes = Client.ObtenerClientes();
            NuevoCliente = new CLIENTES_RESTAURANTE();
        }

        #endregion
    }
}

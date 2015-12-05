using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using PruebaModelo;
using System.Collections.ObjectModel;

namespace PanchitaFeliz_Servicio
{
    [ServiceContract]
    public interface IServicio
    {
        [OperationContract]
        IEnumerable<PERSONAS> ObtenerPersonas();

        [OperationContract]
        IEnumerable<FACTURAS> ObtenerFacturas();

        [OperationContract]
        IEnumerable<ORDENES> ObtenerOrdenes();

        [OperationContract]
        IEnumerable<INGREDIENTES> ObtenerIngredientes();

        [OperationContract]
        IEnumerable<PLATOS> ObtenerPlatos();

        [OperationContract]
        IEnumerable<EMPLEADOS> ObtenerEmpleados();

        [OperationContract]
        IEnumerable<CLIENTES_RESTAURANTE> ObtenerClientes();

        [OperationContract]
        IEnumerable<ACOMPANANTES> ObtenerAcompanantes();

        [OperationContract]
        IEnumerable<OBJETOSINVENTARIOS> ObtenerObjetosDelInventario();

        [OperationContract]
        IEnumerable<MESAS> ObtenerMesas();

        [OperationContract]
        IEnumerable<SEXOS> ObtenerSexos();

        [OperationContract]
        IEnumerable<UNIDADES> ObtenerUnidades();

        [OperationContract]
        IEnumerable<CARGOS> ObtenerCargos();

        [OperationContract]
        IEnumerable<ESTADOORDENES> ObtenerEstados();

        [OperationContract]
        IEnumerable<TIPOSPAGOS> ObtenerTiposPago();

        [OperationContract]
        void GuardarObjetosRecibidos(ObservableCollection<OBJETOSINVENTARIOS> nuevosObjetosRecibidos);

        [OperationContract]
        void GuardarNuevoPlato(PLATOS nuevoPlato);

        [OperationContract]
        void GuardarNuevaMesa(MESAS nuevaMesa);

        [OperationContract]
        void GuardarNuevoSexo(SEXOS nuevoSexo);

        [OperationContract]
        void GuardarNuevoCargo(CARGOS nuevoCargo);

        [OperationContract]
        void GuardarNuevoEstado(ESTADOORDENES nuevoEstado);

        [OperationContract]
        void GuardarNuevaUnidad(UNIDADES nuevaUnidad);

        [OperationContract]
        void GuardarNuevoTipoPago(TIPOSPAGOS nuevoTipoPago);

        [OperationContract]
        void GuardarNuevoCliente(CLIENTES_RESTAURANTE nuevoCliente);

        [OperationContract]
        void GuardarNuevoEmpleado(EMPLEADOS nuevoEmpleado);

        [OperationContract]
        void GuardarNuevaOrden(ORDENES nuevaOrden);
    }
}

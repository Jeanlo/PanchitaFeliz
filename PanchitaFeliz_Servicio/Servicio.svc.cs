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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Servicio : IServicio
    {        
        public readonly Entities PanchitaFeliz_Entities = new Entities();

        public IEnumerable<PERSONAS> ObtenerPersonas()
        {
            var respuesta = PanchitaFeliz_Entities.PERSONAS.Where(per => per.CODIGOPERSONA > 0);
            return respuesta;
        }
        
        public IEnumerable<FACTURAS> ObtenerFacturas()
        {
            var respuesta = PanchitaFeliz_Entities.FACTURAS.Where(fac => fac.CODIGOFACTURA > 0);
            return respuesta;
        }
        
        public IEnumerable<ORDENES> ObtenerOrdenes()
        {
            var respuesta = PanchitaFeliz_Entities.ORDENES.Where(ord => ord.CODIGOORDEN > 0);
            return respuesta;
        }

        public IEnumerable<ACOMPANANTES> ObtenerAcompanantes()
        {
            var respuesta = PanchitaFeliz_Entities.ACOMPANANTES.Where(aco => aco.CODIGOOBJETO > 0);
            return respuesta;
        }

        public IEnumerable<CLIENTES_RESTAURANTE> ObtenerClientes()
        {
            var respuesta = PanchitaFeliz_Entities.CLIENTES_RESTAURANTE.Where(cli => cli.CODIGOPERSONA > 0);
            return respuesta;
        }

        public IEnumerable<EMPLEADOS> ObtenerEmpleados()
        {
            var respuesta = PanchitaFeliz_Entities.EMPLEADOS.Where(emp => emp.CODIGOPERSONA > 0);
            return respuesta;
        }

        public IEnumerable<INGREDIENTES> ObtenerIngredientes()
        {
            var respuesta = PanchitaFeliz_Entities.INGREDIENTES.Where(ing => ing.CODIGOOBJETO > 0);
            return respuesta;
        }

        public IEnumerable<PLATOS> ObtenerPlatos()
        {
            var respuesta = PanchitaFeliz_Entities.PLATOS.Where(pla => pla.CODIGOOBJETO > 0);
            return respuesta;
        }

        public IEnumerable<MESAS> ObtenerMesas()
        {
            var respuesta = PanchitaFeliz_Entities.MESAS.Where(mes => mes.NUMEROMESAS > 0);
            return respuesta;
        }

        public IEnumerable<OBJETOSINVENTARIOS> ObtenerObjetosDelInventario()
        {
            var respuesta = PanchitaFeliz_Entities.OBJETOSINVENTARIOS.Where(obj => obj.OBJETO > 0);
            return respuesta;
        }
        
        public IEnumerable<SEXOS> ObtenerSexos()
        {
            var respuesta = PanchitaFeliz_Entities.SEXOS.Where(sex => sex.CODIGOSEXO > 0);
            return respuesta;
        }

        public IEnumerable<UNIDADES> ObtenerUnidades()
        {

            var respuesta = PanchitaFeliz_Entities.UNIDADES.Where(uni => uni.CODIGOUNIDAD > 0);
            return respuesta;
        }

        public IEnumerable<CARGOS> ObtenerCargos()
        {

            var respuesta = PanchitaFeliz_Entities.CARGOS.Where(car => car.CODIGOCARGO > 0);
            return respuesta;
        }

        public IEnumerable<ESTADOORDENES> ObtenerEstados()
        {

            var respuesta = PanchitaFeliz_Entities.ESTADOORDENES.Where(est => est.CODIGOESTADO > 0);
            return respuesta;
        }

        public IEnumerable<TIPOSPAGOS> ObtenerTiposPago()
        {
            var respuesta = PanchitaFeliz_Entities.TIPOSPAGOS.Where(tip => tip.CODIGOTIPOPAGO > 0);
            return respuesta;

        }

        public void GuardarObjetosRecibidos(ObservableCollection<OBJETOSINVENTARIOS> nuevosObjetosRecibidos)
        {
            var viejos = ObtenerObjetosDelInventario();
            foreach (OBJETOSINVENTARIOS obj in nuevosObjetosRecibidos)
            {
                OBJETOSINVENTARIOS objeto;
                try
                {
                    objeto = viejos.First(ob => ob.OBJETO == obj.OBJETO && ob.INVENTARIO == obj.INVENTARIO);
                    objeto.CANTIDAD += obj.CANTIDAD;
                    objeto.INVENTARIO = obj.INVENTARIO;
                    objeto.OBJETO = obj.OBJETO;
                    objeto.UNIDADES = obj.UNIDADES;
                }
                catch
                {
                    objeto = new OBJETOSINVENTARIOS();
                    objeto.CANTIDAD = obj.CANTIDAD;
                    objeto.INVENTARIO = obj.INVENTARIO;
                    objeto.OBJETO = obj.OBJETO;
                    objeto.UNIDADES = obj.UNIDADES;
                    PanchitaFeliz_Entities.OBJETOSINVENTARIOS.Add(objeto);
                }
            }

            PanchitaFeliz_Entities.SaveChanges();
        }

        public void GuardarNuevoPlato(PLATOS nuevoPlato)
        {
            PLATOS plato = new PLATOS();
            plato.CODIGOOBJETO = nuevoPlato.CODIGOOBJETO;
            plato.COSTOMANOFACTURA = nuevoPlato.COSTOMANOFACTURA;
            plato.NOMBRE = nuevoPlato.NOMBRE;
            PanchitaFeliz_Entities.PLATOS.Add(plato);
            PanchitaFeliz_Entities.SaveChanges();
        }

        public void GuardarNuevaMesa(MESAS nuevaMesa)
        {
            MESAS mesa = new MESAS();
            mesa.NUMEROMESAS = nuevaMesa.NUMEROMESAS;
            PanchitaFeliz_Entities.MESAS.Add(mesa);
            PanchitaFeliz_Entities.SaveChanges();
        }

        public void GuardarNuevoSexo(SEXOS nuevoSexo)
        {
            SEXOS sexo = new SEXOS();
            sexo.CODIGOSEXO = nuevoSexo.CODIGOSEXO;
            PanchitaFeliz_Entities.SEXOS.Add(sexo);
            PanchitaFeliz_Entities.SaveChanges();
        }

        public void GuardarNuevoCargo(CARGOS nuevoCargo)
        {
            CARGOS cargo = new CARGOS();
            cargo.CODIGOCARGO = nuevoCargo.CODIGOCARGO;
            PanchitaFeliz_Entities.CARGOS.Add(cargo);
            PanchitaFeliz_Entities.SaveChanges();
        }

        public void GuardarNuevoEstado(ESTADOORDENES nuevoEstado)
        {
            ESTADOORDENES estado = new ESTADOORDENES();
            estado.CODIGOESTADO = nuevoEstado.CODIGOESTADO;
            PanchitaFeliz_Entities.ESTADOORDENES.Add(estado);
            PanchitaFeliz_Entities.SaveChanges();
        }

        public void GuardarNuevaUnidad(UNIDADES nuevaUnidad)
        {
            UNIDADES unidad = new UNIDADES();
            unidad.CODIGOUNIDAD = nuevaUnidad.CODIGOUNIDAD;
            PanchitaFeliz_Entities.UNIDADES.Add(unidad);
            PanchitaFeliz_Entities.SaveChanges();
        }

        public void GuardarNuevoTipoPago(TIPOSPAGOS nuevoTipoPago)
        {
            TIPOSPAGOS tipoPago = new TIPOSPAGOS();
            tipoPago.CODIGOTIPOPAGO = nuevoTipoPago.CODIGOTIPOPAGO;
            PanchitaFeliz_Entities.TIPOSPAGOS.Add(tipoPago);
            PanchitaFeliz_Entities.SaveChanges();
        }

        public void GuardarNuevoEmpleado(EMPLEADOS nuevoEmpleado)
        {
            EMPLEADOS empleado = new EMPLEADOS();
            empleado.APELLIDO = nuevoEmpleado.APELLIDO;
            empleado.CARGO = nuevoEmpleado.CARGO;
            empleado.CODIGOPERSONA = nuevoEmpleado.CODIGOPERSONA;
            empleado.DOCUMENTOIDENTIDAD = nuevoEmpleado.DOCUMENTOIDENTIDAD;
            empleado.NOMBRE = nuevoEmpleado.NOMBRE;
            empleado.SEXO = nuevoEmpleado.SEXO;
            empleado.TELEFONO = nuevoEmpleado.TELEFONO;
            PanchitaFeliz_Entities.EMPLEADOS.Add(empleado);
            PanchitaFeliz_Entities.SaveChanges();
        }


        public void GuardarNuevoCliente(CLIENTES_RESTAURANTE nuevoCliente)
        {
            CLIENTES_RESTAURANTE cliente = new CLIENTES_RESTAURANTE();
            cliente.APELLIDO = nuevoCliente.APELLIDO;
            cliente.CODIGOPERSONA = nuevoCliente.CODIGOPERSONA;
            cliente.DOCUMENTOIDENTIDAD = nuevoCliente.DOCUMENTOIDENTIDAD;
            cliente.NOMBRE = nuevoCliente.NOMBRE;
            cliente.TELEFONO = nuevoCliente.TELEFONO;
            PanchitaFeliz_Entities.CLIENTES_RESTAURANTE.Add(cliente);
            PanchitaFeliz_Entities.SaveChanges();
        }

        public void GuardarNuevaOrden(ORDENES nuevaOrden)
        {
            ORDENES orden = new ORDENES();
            orden.CLIENTE = nuevaOrden.CLIENTE;
            orden.CODIGOORDEN = nuevaOrden.CODIGOORDEN;
            orden.COSTOTOTAL = nuevaOrden.COSTOTOTAL;
            orden.MESERO = nuevaOrden.MESERO;
            orden.HORA = nuevaOrden.HORA;
            orden.MINUTO = nuevaOrden.MINUTO;
            orden.SEGUNDO = nuevaOrden.SEGUNDO;
            if(nuevaOrden.SUBORDEN != 0)
                orden.SUBORDEN = nuevaOrden.SUBORDEN;
            orden.FECHA = nuevaOrden.FECHA;
            PanchitaFeliz_Entities.ORDENES.Add(orden);
            PanchitaFeliz_Entities.SaveChanges();
        }
    }
}

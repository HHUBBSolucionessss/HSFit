using System;
using System.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GYM.Clases
{
    public class Privilegios
    {
        #region Eventos

        public event EventHandler PrivilegesChanged;

        protected virtual void OnPrivilegesChanged(EventArgs e)
        {
            if (PrivilegesChanged != null)
            {
                _idUsuario = idUsuario;
                _crearApartado = crearApartado;
                _estadoApartado = estadoApartado;
                _caja = caja;
                _banco = banco;
                _boveda = boveda;
                _movimientoCaja = movimientoCaja;
                _movimientoBanco = movimientoBanco;
                _movimientoBoveda = movimientoBoveda;
                _abrirCerrarCaja = abrirCerrarCaja;
                _cortesCaja = cortesCaja;
                _crearCliente = crearCliente;
                _modificarCliente = modificarCliente;
                _eliminarCliente = eliminarCliente;
                _crearCompra = crearCompra;
                _visualizarCompra = visualizarCompra;
                _cancelarCompra = cancelarCompra;
                _devolucionCompra = devolucionCompra;
                _configGeneral = configGeneral;
                _configCorreo = configCorreo;
                _configBaseDatos = configBaseDatos;
                _configImpresion = configImpresion;
                _crearSucursal = crearSucursal;
                _modificarSucursal = modificarSucursal;
                _eliminarSucursal = eliminarSucursal;
                _cambiarSucursal = cambiarSucursal;
                _crearProducto = crearProducto;
                _modificarProducto = modificarProducto;
                _eliminarProducto = eliminarProducto;
                _imprimirTicket = imprimirTicket;
                _modificarCantProducto = modificarCantProducto;
                _modificarPrecioVentaProducto = modificarPrecioVentaProducto;
                _crearPromocion = crearPromocion;
                _modificarPromocion = modificarPromocion;
                _eliminarPromocion = eliminarPromocion;
                _crearProveedor = crearProveedor;
                _modificarProveedor = modificarProveedor;
                _eliminarProveedor = eliminarProveedor;
                _nominas = nominas;
                _administrarPagoTrabajador = administrarPagoTrabajador;
                _crearTrabajador = crearTrabajador;
                _modificarTrabajador = modificarTrabajador;
                _eliminarTrabajador = eliminarTrabajador;
                _crearTraspaso = crearTraspaso;
                _estadoTraspaso = estadoTraspaso;
                _crearUsuario = crearUsuario;
                _modificarUsuario = modificarUsuario;
                _eliminarUsuario = eliminarUsuario;
                _reestablecerUsuario = reestablecerUsuario;
                _administrarPermisos = administrarPermisos;
                _crearVenta = crearVenta;
                _cancelarVenta = cancelarVenta;
                _devolucionVenta = devolucionVenta;
                _reporteVentaPeriodo = reporteVentaPeriodo;
                _reporteVentaSucursal = reporteVentaSucursal;
                _reporteCompraPeriodo = reporteCompraPeriodo;
                _reporteCompraSucursal = reporteCompraSucursal;
                _reporteGeneral = reporteGeneral;
                _reinicioBase = reinicioBase;
                _inventarioFisico = inventarioFisico;
                PrivilegesChanged(this, e);
            }
        }

        #endregion

        #region Propiedades
        private int idUsuario;
        private bool crearApartado;
        private bool estadoApartado;
        private bool caja;
        private bool banco;
        private bool boveda;
        private bool movimientoCaja;
        private bool movimientoBanco;
        private bool movimientoBoveda;
        private bool abrirCerrarCaja;
        private bool cortesCaja;
        private bool crearCliente;
        private bool modificarCliente;
        private bool eliminarCliente;
        private bool crearCompra;
        private bool visualizarCompra;
        private bool cancelarCompra;
        private bool devolucionCompra;
        private bool configGeneral;
        private bool configCorreo;
        private bool configBaseDatos;
        private bool configImpresion;
        private bool crearSucursal;
        private bool modificarSucursal;
        private bool eliminarSucursal;
        private bool cambiarSucursal;
        private bool crearProducto;
        private bool modificarProducto;
        private bool eliminarProducto;
        private bool imprimirTicket;
        private bool modificarCantProducto;
        private bool modificarPrecioVentaProducto;
        private bool crearPromocion;
        private bool modificarPromocion;
        private bool eliminarPromocion;
        private bool crearProveedor;
        private bool modificarProveedor;
        private bool eliminarProveedor;
        private bool nominas;
        private bool administrarPagoTrabajador;
        private bool crearTrabajador;
        private bool modificarTrabajador;
        private bool eliminarTrabajador;
        private bool crearTraspaso;
        private bool estadoTraspaso;
        private bool crearUsuario;
        private bool modificarUsuario;
        private bool eliminarUsuario;
        private bool reestablecerUsuario;
        private bool administrarPermisos;
        private bool crearVenta;
        private bool cancelarVenta;
        private bool devolucionVenta;
        private bool reporteVentaPeriodo;
        private bool reporteVentaSucursal;
        private bool reporteCompraPeriodo;
        private bool reporteCompraSucursal;
        private bool reporteGeneral;
        private bool reinicioBase;
        private bool inventarioFisico;

        public int IDUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public bool CrearApartado
        {
            get { return crearApartado; }
            set { crearApartado = value; }
        }

        public bool EstadoApartado
        {
            get { return estadoApartado; }
            set { estadoApartado = value; }
        }

        public bool Caja
        {
            get { return caja; }
            set { caja = value; }
        }

        public bool Banco
        {
            get { return banco; }
            set { banco = value; }
        }

        public bool Boveda
        {
            get { return boveda; }
            set { boveda = value; }
        }

        public bool MovimientoCaja
        {
            get { return movimientoCaja; }
            set { movimientoCaja = value; }
        }

        public bool MovimientoBanco
        {
            get { return movimientoBanco; }
            set { movimientoBanco = value; }
        }

        public bool MovimientoBoveda
        {
            get { return movimientoBoveda; }
            set { movimientoBoveda = value; }
        }

        public bool AbrirCerrarCaja
        {
            get { return abrirCerrarCaja; }
            set { abrirCerrarCaja = value; }
        }

        public bool CortesCaja
        {
            get { return cortesCaja; }
            set { cortesCaja = value; }
        }

        public bool CrearCliente
        {
            get { return crearCliente; }
            set { crearCliente = value; }
        }

        public bool ModificarCliente
        {
            get { return modificarCliente; }
            set { modificarCliente = value; }
        }

        public bool EliminarCliente
        {
            get { return eliminarCliente; }
            set { eliminarCliente = value; }
        }

        public bool CrearCompra
        {
            get { return crearCompra; }
            set { crearCompra = value; }
        }

        public bool VisualizarCompra
        {
            get { return visualizarCompra; }
            set { visualizarCompra = value; }
        }

        public bool CancelarCompra
        {
            get { return cancelarCompra; }
            set { cancelarCompra = value; }
        }

        public bool DevolucionCompra
        {
            get { return devolucionCompra; }
            set { devolucionCompra = value; }
        }

        public bool ConfigGeneral
        {
            get { return configGeneral; }
            set { configGeneral = value; }
        }

        public bool ConfigCorreo
        {
            get { return configCorreo; }
            set { configCorreo = value; }
        }

        public bool ConfigBaseDatos
        {
            get { return configBaseDatos; }
            set { configBaseDatos = value; }
        }

        public bool ConfigImpresion
        {
            get { return configImpresion; }
            set { configImpresion = value; }
        }

        public bool CrearSucursal
        {
            get { return crearSucursal; }
            set { crearSucursal = value; }
        }

        public bool ModificarSucursal
        {
            get { return modificarSucursal; }
            set { modificarSucursal = value; }
        }

        public bool EliminarSucursal
        {
            get { return eliminarSucursal; }
            set { eliminarSucursal = value; }
        }

        public bool CambiarSucursal
        {
            get { return cambiarSucursal; }
            set { cambiarSucursal = value; }
        }

        public bool CrearProducto
        {
            get { return crearProducto; }
            set { crearProducto = value; }
        }

        public bool ModificarProducto
        {
            get { return modificarProducto; }
            set { modificarProducto = value; }
        }

        public bool EliminarProducto
        {
            get { return eliminarProducto; }
            set { eliminarProducto = value; }
        }

        public bool ImprimirTicket
        {
            get { return imprimirTicket; }
            set { imprimirTicket = value; }
        }

        public bool ModificarCantProducto
        {
            get { return modificarCantProducto; }
            set { modificarCantProducto = value; }
        }

        public bool ModificarPrecioVentaProducto
        {
            get { return modificarPrecioVentaProducto; }
            set { modificarPrecioVentaProducto = value; }
        }
        
        public bool CrearPromocion
        {
            get { return crearPromocion; }
            set { crearPromocion = value; }
        }

        public bool ModificarPromocion
        {
            get { return modificarPromocion; }
            set { modificarPromocion = value; }
        }

        public bool EliminarPromocion
        {
            get { return eliminarPromocion; }
            set { eliminarPromocion = value; }
        }

        public bool CrearProveedor
        {
            get { return crearProveedor; }
            set { crearProveedor = value; }
        }

        public bool ModificarProveedor
        {
            get { return modificarProveedor; }
            set { modificarProveedor = value; }
        }

        public bool EliminarProveedor
        {
            get { return eliminarProveedor; }
            set { eliminarProveedor = value; }
        }

        public bool Nomina
        {
            get { return nominas; }
            set { nominas = value; }
        }

        public bool AdministrarPagoTrabajador
        {
            get { return administrarPagoTrabajador; }
            set { administrarPagoTrabajador = value; }
        }

        public bool CrearTrabajador
        {
            get { return crearTrabajador; }
            set { crearTrabajador = value; }
        }

        public bool ModificarTrabajador
        {
            get { return modificarTrabajador; }
            set { modificarTrabajador = value; }
        }

        public bool EliminarTrabajador
        {
            get { return eliminarTrabajador; }
            set { eliminarTrabajador = value; }
        }

        public bool CrearTraspaso
        {
            get { return crearTraspaso; }
            set { crearTraspaso = value; }
        }

        public bool EstadoTraspaso
        {
            get { return estadoTraspaso; }
            set { estadoTraspaso = value; }
        }

        public bool CrearUsuario
        {
            get { return crearUsuario; }
            set { crearUsuario = value; }
        }

        public bool ModificarUsuario
        {
            get { return modificarUsuario; }
            set { modificarUsuario = value; }
        }

        public bool EliminarUsuario
        {
            get { return eliminarUsuario; }
            set { eliminarUsuario = value; }
        }

        public bool ReestablecerUsuario
        {
            get { return reestablecerUsuario; }
            set { reestablecerUsuario = value; }
        }

        public bool AdministrarPermisos
        {
            get { return administrarPermisos; }
            set { administrarPermisos = value; }
        }

        public bool CrearVenta
        {
            get { return crearVenta; }
            set { crearVenta = value; }
        }

        public bool CancelarVenta
        {
            get { return cancelarVenta; }
            set { cancelarVenta = value; }
        }

        public bool DevolucionVenta
        {
            get { return devolucionVenta; }
            set { devolucionVenta = value; }
        }

        public bool ReporteVentaPeriodo
        {
            get { return reporteVentaPeriodo; }
            set { reporteVentaPeriodo = value; }
        }

        public bool ReporteVentaSucursal
        {
            get { return reporteVentaSucursal; }
            set { reporteVentaSucursal = value; }
        }

        public bool ReporteCompraPeriodo
        {
            get { return reporteCompraPeriodo; }
            set { reporteCompraPeriodo = value; }
        }

        public bool ReporteCompraSucursal
        {
            get { return reporteCompraSucursal; }
            set { reporteCompraSucursal = value; }
        }

        public bool ReporteGeneral
        {
            get { return reporteGeneral; }
            set { reporteGeneral = value; }
        }

        public bool ReinicioBase
        {
            get { return reinicioBase; }
            set { reinicioBase = value; }
        }

        public bool InventarioFisico
        {
            get { return inventarioFisico; }
            set { inventarioFisico = value; }
        }
        #endregion

        #region PropiedadesUsuarioActual
        private static int _idUsuario;
        private static bool _crearApartado;
        private static bool _estadoApartado;
        private static bool _caja;
        private static bool _banco;
        private static bool _boveda;
        private static bool _movimientoCaja;
        private static bool _movimientoBanco;
        private static bool _movimientoBoveda;
        private static bool _abrirCerrarCaja;
        private static bool _cortesCaja;
        private static bool _crearCliente;
        private static bool _modificarCliente;
        private static bool _eliminarCliente;
        private static bool _crearCompra;
        private static bool _visualizarCompra;
        private static bool _cancelarCompra;
        private static bool _devolucionCompra;
        private static bool _configGeneral;
        private static bool _configCorreo;
        private static bool _configBaseDatos;
        private static bool _configImpresion;
        private static bool _crearSucursal;
        private static bool _modificarSucursal;
        private static bool _eliminarSucursal;
        private static bool _cambiarSucursal;
        private static bool _crearProducto;
        private static bool _modificarProducto;
        private static bool _eliminarProducto;
        private static bool _imprimirTicket;
        private static bool _modificarCantProducto;
        private static bool _modificarPrecioVentaProducto;
        private static bool _crearPromocion;
        private static bool _modificarPromocion;
        private static bool _eliminarPromocion;
        private static bool _crearProveedor;
        private static bool _modificarProveedor;
        private static bool _eliminarProveedor;
        private static bool _nominas;
        private static bool _administrarPagoTrabajador;
        private static bool _crearTrabajador;
        private static bool _modificarTrabajador;
        private static bool _eliminarTrabajador;
        private static bool _crearTraspaso;
        private static bool _estadoTraspaso;
        private static bool _crearUsuario;
        private static bool _modificarUsuario;
        private static bool _eliminarUsuario;
        private static bool _reestablecerUsuario;
        private static bool _administrarPermisos;
        private static bool _crearVenta;
        private static bool _cancelarVenta;
        private static bool _devolucionVenta;
        private static bool _reporteVentaPeriodo;
        private static bool _reporteVentaSucursal;
        private static bool _reporteCompraPeriodo;
        private static bool _reporteCompraSucursal;
        private static bool _reporteGeneral;
        private static bool _reinicioBase;
        private static bool _inventarioFisico;

        public static int _IDUsuario
        {
            get { return _idUsuario; }
        }

        public static bool _CrearApartado
        {
            get { return _crearApartado; }
        }

        public static bool _EstadoApartado
        {
            get { return _estadoApartado; }
        }

        public static bool _Caja
        {
            get { return _caja; }
        }

        public static bool _Banco
        {
            get { return _banco; }
        }

        public static bool _Boveda
        {
            get { return _boveda; }
        }

        public static bool _MovimientoCaja
        {
            get { return _movimientoCaja; }
        }

        public static bool _MovimientoBanco
        {
            get { return _movimientoBanco; }
        }

        public static bool _MovimientoBoveda
        {
            get { return _movimientoBoveda; }
        }

        public static bool _AbrirCerrarCaja
        {
            get { return _abrirCerrarCaja; }
        }

        public static bool _CortesCaja
        {
            get { return _cortesCaja; }
        }

        public static bool _CrearCliente
        {
            get { return _crearCliente; }
        }

        public static bool _ModificarCliente
        {
            get { return _modificarCliente; }
        }

        public static bool _EliminarCliente
        {
            get { return _eliminarCliente; }
        }

        public static bool _CrearCompra
        {
            get { return _crearCompra; }
        }

        public static bool _VisualizarCompra
        {
            get { return _visualizarCompra; }
        }

        public static bool _CancelarCompra
        {
            get { return _cancelarCompra; }
        }

        public static bool _DevolucionCompra
        {
            get { return _devolucionCompra; }
        }

        public static bool _ConfigGeneral
        {
            get { return _configGeneral; }
        }

        public static bool _ConfigCorreo
        {
            get { return _configCorreo; }
        }

        public static bool _ConfigBaseDatos
        {
            get { return _configBaseDatos; }
        }

        public static bool _ConfigImpresion
        {
            get { return _configImpresion; }
        }

        public static bool _CrearSucursal
        {
            get { return _crearSucursal; }
        }

        public static bool _ModificarSucursal
        {
            get { return _modificarSucursal; }
        }

        public static bool _EliminarSucursal
        {
            get { return _eliminarSucursal; }
        }

        public static bool _CambiarSucursal
        {
            get { return _cambiarSucursal; }
        }

        public static bool _CrearProducto
        {
            get { return _crearProducto; }
        }

        public static bool _ModificarProducto
        {
            get { return _modificarProducto; }
        }

        public static bool _EliminarProducto
        {
            get { return _eliminarProducto; }
        }

        public static bool _ImprimirTicket
        {
            get { return _imprimirTicket; }
        }

        public static bool _ModificarCantProducto
        {
            get { return _modificarCantProducto; }
        }

        public static bool _ModificarPrecioVentaProducto
        {
            get { return _modificarPrecioVentaProducto; }
        }
        
        public static bool _CrearPromocion
        {
            get { return _crearPromocion; }
        }

        public static bool _ModificarPromocion
        {
            get { return _modificarPromocion; }
        }

        public static bool _EliminarPromocion
        {
            get { return _eliminarPromocion; }
        }

        public static bool _CrearProveedor
        {
            get { return _crearProveedor; }
        }

        public static bool _ModificarProveedor
        {
            get { return _modificarProveedor; }
        }

        public static bool _EliminarProveedor
        {
            get { return _eliminarProveedor; }
        }

        public static bool _Nomina
        {
            get { return _nominas; }
        }

        public static bool _AdministrarPagoTrabajador
        {
            get { return _administrarPagoTrabajador; }
        }

        public static bool _CrearTrabajador
        {
            get { return _crearTrabajador; }
        }

        public static bool _ModificarTrabajador
        {
            get { return _modificarTrabajador; }
        }

        public static bool _EliminarTrabajador
        {
            get { return _eliminarTrabajador; }
        }

        public static bool _CrearTraspaso
        {
            get { return _crearTraspaso; }
        }

        public static bool _EstadoTraspaso
        {
            get { return _estadoTraspaso; }
        }

        public static bool _CrearUsuario
        {
            get { return _crearUsuario; }
        }

        public static bool _ModificarUsuario
        {
            get { return _modificarUsuario; }
        }

        public static bool _EliminarUsuario
        {
            get { return _eliminarUsuario; }
        }

        public static bool _ReestablecerUsuario
        {
            get { return _reestablecerUsuario; }
        }

        public static bool _AdministrarPermisos
        {
            get { return _administrarPermisos; }
        }

        public static bool _CrearVenta
        {
            get { return _crearVenta; }
        }

        public static bool _CancelarVenta
        {
            get { return _cancelarVenta; }
        }

        public static bool _DevolucionVenta
        {
            get { return _devolucionVenta; }
        }

        public static bool _ReporteVentaPeriodo
        {
            get { return _reporteVentaPeriodo; }
        }

        public static bool _ReporteVentaSucursal
        {
            get { return _reporteVentaSucursal; }
        }

        public static bool _ReporteCompraPeriodo
        {
            get { return _reporteCompraPeriodo; }
        }

        public static bool _ReporteCompraSucursal
        {
            get { return _reporteCompraSucursal; }
        }

        public static bool _ReporteGeneral
        {
            get { return _reporteGeneral; }
        }
        public static bool _ReinicioBase
        {
            get { return _reinicioBase; }
        }
        public static bool _InventarioFisico
        {
            get { return _inventarioFisico; }
        }
                

        
        #endregion

        #region Cantidades
        async public static Task<int> CantidadPrivilegios()
        {
            int cant = 0;
            try
            {
                Task t = new Task(() =>
                {
                    string sql = "SELECT COUNT(id_usuario) AS c FROM privilegio";
                    DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["c"] != DBNull.Value)
                        {
                            cant = int.Parse(dr["cant"].ToString());
                        }
                        else
                        {
                            cant = 0;
                        }
                    }
                });
                t.Start();
                await t;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cant;
        }
        #endregion

        #region Sin Privilegios

        async public static Task<bool> UsuarioTienePrivilegios(int idUsuario)
        {
            bool tiene = false;
            try
            {
                Task t = new Task(() =>
                {
                    MySqlCommand sql = new MySqlCommand();
                    sql.CommandText = "SELECT id_usuario FROM privilegio WHERE id_usuario=?id_usuario";
                    sql.Parameters.AddWithValue("?id_usuario", idUsuario);
                    DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["id_usuario"] != DBNull.Value)
                        {
                            tiene = true;
                        }
                    }
                });
                t.Start();
                await t;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tiene;
        }

        async public static Task AsignarTodosPermisos(int idUsuario)
        {
            try
            {
                Task t = new Task(() =>
                {
                    Privilegios p = new Privilegios();
                    p.IDUsuario = idUsuario;
                    p.CrearApartado = true;
                    p.EstadoApartado = true;
                    p.Caja = true;
                    p.Banco = true;
                    p.Boveda = true;
                    p.MovimientoCaja = true;
                    p.MovimientoBanco = true;
                    p.MovimientoBoveda = true;
                    p.AbrirCerrarCaja = true;
                    p.CortesCaja = true;
                    p.CrearCliente = true;
                    p.ModificarCliente = true;
                    p.EliminarCliente = true;
                    p.CrearCompra = true;
                    p.VisualizarCompra = true;
                    p.CancelarCompra = true;
                    p.DevolucionCompra = true;
                    p.ConfigGeneral = true;
                    p.ConfigCorreo = true;
                    p.ConfigBaseDatos = true;
                    p.ConfigImpresion = true;
                    p.CrearSucursal = true;
                    p.ModificarSucursal = true;
                    p.EliminarSucursal = true;
                    p.CambiarSucursal = true;
                    p.CrearProducto = true;
                    p.ModificarProducto = true;
                    p.EliminarProducto = true;
                    p.ImprimirTicket = true;
                    p.ModificarCantProducto = true;
                    p.modificarPrecioVentaProducto = true;
                    p.CrearPromocion = true;
                    p.ModificarPromocion = true;
                    p.EliminarPromocion = true;
                    p.CrearProveedor = true;
                    p.ModificarProveedor = true;
                    p.EliminarProveedor = true;
                    p.Nomina = true;
                    p.AdministrarPagoTrabajador = true;
                    p.CrearTrabajador = true;
                    p.ModificarTrabajador = true;
                    p.EliminarTrabajador = true;
                    p.CrearTraspaso = true;
                    p.EstadoTraspaso = true;
                    p.CrearUsuario = true;
                    p.ModificarUsuario = true;
                    p.EliminarUsuario = true;
                    p.ReestablecerUsuario = true;
                    p.AdministrarPermisos = true;
                    p.CrearVenta = true;
                    p.CancelarVenta = true;
                    p.DevolucionVenta = true;
                    p.ReporteVentaPeriodo = true;
                    p.ReporteVentaSucursal = true;
                    p.ReporteCompraPeriodo = true;
                    p.ReporteCompraSucursal = true;
                    p.ReporteGeneral = true;
                    p.reinicioBase = false;
                    p.inventarioFisico = false;
                    #pragma warning disable CS4014 // Ya que no se esperaba esta llamada, la ejecución del método actual continúa antes de que se complete la llamada
                    p.InsertarEditar();
                    #pragma warning restore CS4014 // Ya que no se esperaba esta llamada, la ejecución del método actual continúa antes de que se complete la llamada
                });
                t.Start();
                await t;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        public Privilegios()
        {
            if (Usuario.CantidadUsuarios > 0)
            {
                InicializarPrivilegios();
            }
            else
            {
                PrivilegiosPrimerUsuario();
            }
        }

        public Privilegios(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        private void InicializarPrivilegios()
        {
            crearApartado = true;
            estadoApartado = false;
            caja = true;
            banco = false;
            boveda = false;
            movimientoCaja = true;
            movimientoBanco = false;
            movimientoBoveda = false;
            abrirCerrarCaja = true;
            cortesCaja = true;
            crearCliente = true;
            modificarCliente = true;
            eliminarCliente = false;
            crearCompra = false;
            visualizarCompra = false;
            cancelarCompra = false;
            devolucionCompra = false;
            configGeneral = true;
            configCorreo = false;
            configBaseDatos = false;
            configImpresion = true;
            crearSucursal = false;
            modificarSucursal = false;
            eliminarSucursal = false;
            cambiarSucursal = false;
            crearProducto = true;
            modificarProducto = false;
            eliminarProducto = false;
            imprimirTicket = true;
            modificarCantProducto = false;
            modificarPrecioVentaProducto = false;
            crearPromocion = true;
            modificarPromocion = false;
            eliminarPromocion = false;
            crearProveedor = true;
            modificarProveedor = false;
            eliminarProveedor = false;
            nominas = false;
            administrarPagoTrabajador = false;
            crearTrabajador = true;
            modificarTrabajador = false;
            eliminarTrabajador = false;
            crearTraspaso = true;
            estadoTraspaso = false;
            crearUsuario = true;
            modificarUsuario = false;
            eliminarUsuario = false;
            reestablecerUsuario = false;
            administrarPermisos = false;
            crearVenta = true;
            cancelarVenta = false;
            devolucionVenta = false;
            reporteVentaPeriodo = true;
            reporteVentaSucursal = false;
            reporteCompraPeriodo = true;
            reporteCompraSucursal = false;
            reporteGeneral = false;
            reinicioBase = false;
            inventarioFisico = false;
        }

        private void PrivilegiosPrimerUsuario()
        {
            crearApartado = true;
            estadoApartado = true;
            caja = true;
            banco = true;
            boveda = true;
            movimientoCaja = true;
            movimientoBanco = true;
            movimientoBoveda = true;
            abrirCerrarCaja = true;
            cortesCaja = true;
            crearCliente = true;
            modificarCliente = true;
            eliminarCliente = true;
            crearCompra = true;
            visualizarCompra = true;
            cancelarCompra = true;
            devolucionCompra = true;
            configGeneral = true;
            configCorreo = true;
            configBaseDatos = true;
            configImpresion = true;
            crearSucursal = true;
            modificarSucursal = true;
            eliminarSucursal = true;
            cambiarSucursal = true;
            crearProducto = true;
            modificarProducto = true;
            eliminarProducto = true;
            imprimirTicket = true;
            modificarCantProducto = true;
            modificarPrecioVentaProducto = true;
            crearPromocion = true;
            modificarPromocion = true;
            eliminarPromocion = true;
            crearProveedor = true;
            modificarProveedor = true;
            eliminarProveedor = true;
            nominas = true;
            administrarPagoTrabajador = true;
            crearTrabajador = true;
            modificarTrabajador = true;
            eliminarTrabajador = true;
            crearTraspaso = true;
            estadoTraspaso = true;
            crearUsuario = true;
            modificarUsuario = true;
            eliminarUsuario = true;
            reestablecerUsuario = true;
            administrarPermisos = true;
            crearVenta = true;
            cancelarVenta = true;
            devolucionVenta = true;
            reporteVentaPeriodo = true;
            reporteVentaSucursal = true;
            reporteCompraPeriodo = true;
            reporteCompraSucursal = true;
            reporteGeneral = true;
            reinicioBase = false;
            inventarioFisico = false;
        }
        
        async public Task ObtenerDatos()
        {
            try
            {
                Task t = new Task(() =>
                {
                    MySqlCommand sql = new MySqlCommand();
                    sql.CommandText = "SELECT * FROM privilegio WHERE id_usuario=?id_usuario";
                    sql.Parameters.AddWithValue("?id_usuario", idUsuario);
                    DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                    foreach (DataRow dr in dt.Rows)
                    {
                        crearApartado = (bool)dr["crear_apartado"];
                        estadoApartado = (bool)dr["estado_apartado"];
                        caja = (bool)dr["abrir_caja"];
                        banco = (bool)dr["abrir_banco"];
                        boveda = (bool)dr["abrir_boveda"];
                        movimientoCaja = (bool)dr["movimiento_caja"];
                        movimientoBanco = (bool)dr["movimiento_banco"];
                        movimientoBoveda = (bool)dr["movimiento_boveda"];
                        abrirCerrarCaja = (bool)dr["abrir_cerrar_caja"];
                        cortesCaja = (bool)dr["cortes_caja"];
                        crearCliente = (bool)dr["crear_cliente"];
                        modificarCliente = (bool)dr["modificar_cliente"];
                        eliminarCliente = (bool)dr["eliminar_cliente"];
                        crearCompra = (bool)dr["crear_compra"];
                        visualizarCompra = (bool)dr["visualizar_compra"];
                        cancelarCompra = (bool)dr["cancelar_compra"];
                        devolucionCompra = (bool)dr["devolucion_compra"];
                        configGeneral = (bool)dr["config_general"];
                        configCorreo = (bool)dr["config_correo"];
                        configBaseDatos = (bool)dr["config_base_datos"];
                        configImpresion = (bool)dr["config_impresion"];
                        crearSucursal = (bool)dr["crear_sucursal"];
                        modificarSucursal = (bool)dr["modificar_sucursal"];
                        eliminarSucursal = (bool)dr["eliminar_sucursal"];
                        cambiarSucursal = (bool)dr["cambiar_sucursal"];
                        crearProducto = (bool)dr["crear_producto"];
                        modificarProducto = (bool)dr["modificar_producto"];
                        eliminarProducto = (bool)dr["eliminar_producto"];
                        imprimirTicket = (bool)dr["ticket_producto"];
                        modificarCantProducto = (bool)dr["modificar_cant_producto"];
                        modificarPrecioVentaProducto = (bool)dr["modificar_precio_venta_producto"];
                        crearPromocion = (bool)dr["crear_promocion"];
                        modificarPromocion = (bool)dr["modificar_promocion"];
                        eliminarPromocion = (bool)dr["eliminar_promocion"];
                        crearProveedor = (bool)dr["crear_proveedor"];
                        modificarProveedor = (bool)dr["modificar_proveedor"];
                        eliminarProveedor = (bool)dr["eliminar_proveedor"];
                        nominas = (bool)dr["nominas"];
                        administrarPagoTrabajador = (bool)dr["administrar_pago_trabajador"];
                        crearTrabajador = (bool)dr["crear_trabajador"];
                        modificarTrabajador = (bool)dr["modificar_trabajador"];
                        eliminarTrabajador = (bool)dr["eliminar_trabajador"];
                        crearTraspaso = (bool)dr["crear_traspaso"];
                        estadoTraspaso = (bool)dr["estado_traspaso"];
                        crearUsuario = (bool)dr["crear_usuario"];
                        modificarUsuario = (bool)dr["modificar_usuario"];
                        eliminarUsuario = (bool)dr["eliminar_usuario"];
                        reestablecerUsuario = (bool)dr["reestablecer_usuario"];
                        administrarPermisos = (bool)dr["administrar_permisos_usuario"];
                        crearVenta = (bool)dr["crear_venta"];
                        cancelarVenta = (bool)dr["cancelar_venta"];
                        devolucionVenta = (bool)dr["devolucion_venta"];
                        reporteVentaPeriodo = (bool)dr["venta_periodo"];
                        reporteVentaSucursal = (bool)dr["venta_sucursal"];
                        reporteCompraPeriodo = (bool)dr["compra_periodo"];
                        reporteCompraSucursal = (bool)dr["compra_sucursal"];
                        reporteGeneral = (bool)dr["reporte_general"];
                        reinicioBase = (bool)dr["reiniciar_base"];
                        inventarioFisico = (bool)dr["inventario_fisico"];
                    }
                });
                t.Start();
                await t;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async public Task InsertarEditar()
        {
            try
            {
                Task t = new Task(() =>
                {
                    MySqlCommand sql = new MySqlCommand();
                    sql.CommandText = "INSERT INTO privilegio (id_usuario, crear_apartado, estado_apartado, abrir_caja, abrir_banco, abrir_boveda, movimiento_caja, movimiento_banco, movimiento_boveda, abrir_cerrar_caja, cortes_caja, crear_cliente, modificar_cliente, eliminar_cliente, crear_compra, visualizar_compra, cancelar_compra, devolucion_compra, config_general, config_correo, config_base_datos, config_impresion, crear_sucursal, modificar_sucursal, eliminar_sucursal, cambiar_sucursal, crear_producto, modificar_producto, eliminar_producto, ticket_producto, modificar_cant_producto, modificar_precio_venta_producto, crear_promocion, modificar_promocion, eliminar_promocion, crear_proveedor, modificar_proveedor, eliminar_proveedor, nominas, administrar_pago_trabajador, crear_trabajador, modificar_trabajador, eliminar_trabajador, crear_traspaso, estado_traspaso, crear_usuario, modificar_usuario, eliminar_usuario, reestablecer_usuario, administrar_permisos_usuario, crear_venta, cancelar_venta, devolucion_venta, venta_periodo, venta_sucursal, compra_periodo, compra_sucursal, reporte_general, reiniciar_base, inventario_fisico) " +
                        "VALUES (?id_usuario, ?crear_apartado, ?estado_apartado, ?abrir_caja, ?abrir_banco, ?abrir_boveda, ?movimiento_caja, ?movimiento_banco, ?movimiento_boveda, ?abrir_cerrar_caja, ?cortes_caja, ?crear_cliente, ?modificar_cliente, ?eliminar_cliente, ?crear_compra, ?visualizar_compra, ?cancelar_compra, ?devolucion_compra, ?config_general, ?config_correo, ?config_base_datos, ?config_impresion, ?crear_sucursal, ?modificar_sucursal, ?eliminar_sucursal, ?cambiar_sucursal, ?crear_producto, ?modificar_producto, ?eliminar_producto, ?ticket_producto, ?modificar_cant_producto, ?modificar_precio_venta_producto, ?crear_promocion, ?modificar_promocion, ?eliminar_promocion, ?crear_proveedor, ?modificar_proveedor, ?eliminar_proveedor, ?nominas, ?administrar_pago_trabajador, ?crear_trabajador, ?modificar_trabajador, ?eliminar_trabajador, ?crear_traspaso, ?estado_traspaso, ?crear_usuario, ?modificar_usuario, ?eliminar_usuario, ?reestablecer_usuario, ?administrar_permisos_usuario, ?crear_venta, ?cancelar_venta, ?devolucion_venta, ?venta_periodo, ?venta_sucursal, ?compra_periodo, ?compra_sucursal, ?reporte_general,?reiniciar_base,?inventario_fisico)" +
                        "ON DUPLICATE KEY UPDATE crear_apartado=?crear_apartado, estado_apartado=?estado_apartado, abrir_caja=?abrir_caja, abrir_banco=?abrir_banco, abrir_boveda=?abrir_boveda, movimiento_caja=?movimiento_caja, movimiento_banco=?movimiento_banco, movimiento_boveda=?movimiento_boveda, abrir_cerrar_caja=?abrir_cerrar_caja, cortes_caja=?cortes_caja, crear_cliente=?crear_cliente, modificar_cliente=?modificar_cliente, eliminar_cliente=?eliminar_cliente, crear_compra=?crear_compra, visualizar_compra=?visualizar_compra, cancelar_compra=?cancelar_compra, devolucion_compra=?devolucion_compra, config_general=?config_general, config_correo=?config_correo, config_base_datos=?config_base_datos, config_impresion=?config_impresion, crear_sucursal=?crear_sucursal, modificar_sucursal=?modificar_sucursal, eliminar_sucursal=?eliminar_sucursal, cambiar_sucursal=?cambiar_sucursal, crear_producto=?crear_producto, modificar_producto=?modificar_producto, eliminar_producto=?eliminar_producto, ticket_producto=?ticket_producto, " +
                        "modificar_cant_producto=?modificar_cant_producto, modificar_precio_venta_producto=?modificar_precio_venta_producto, crear_promocion=?crear_promocion, modificar_promocion=?modificar_promocion, eliminar_promocion=?eliminar_promocion, crear_proveedor=?crear_proveedor, modificar_proveedor=?modificar_proveedor, eliminar_proveedor=?eliminar_proveedor, nominas=?nominas, administrar_pago_trabajador=?administrar_pago_trabajador, crear_trabajador=?crear_trabajador, modificar_trabajador=?modificar_trabajador, eliminar_trabajador=?eliminar_trabajador, crear_traspaso=?crear_traspaso, estado_traspaso=?estado_traspaso, crear_usuario=?crear_usuario, modificar_usuario=?modificar_usuario, eliminar_usuario=?eliminar_usuario, reestablecer_usuario=?reestablecer_usuario, administrar_permisos_usuario=?administrar_permisos_usuario, crear_venta=?crear_venta, cancelar_venta=?cancelar_venta, devolucion_venta=?devolucion_venta, venta_periodo=?venta_periodo, venta_sucursal=?venta_sucursal, compra_periodo=?compra_periodo, compra_sucursal=?compra_sucursal, reporte_general=?reporte_general,reiniciar_base=?reiniciar_base,inventario_fisico=?inventario_fisico;";
                    sql.Parameters.AddWithValue("?id_usuario", idUsuario);
                    sql.Parameters.AddWithValue("?crear_apartado", crearApartado);
                    sql.Parameters.AddWithValue("?estado_apartado", estadoApartado);
                    sql.Parameters.AddWithValue("?abrir_caja", caja);
                    sql.Parameters.AddWithValue("?abrir_banco", banco);
                    sql.Parameters.AddWithValue("?abrir_boveda", boveda);
                    sql.Parameters.AddWithValue("?movimiento_caja", movimientoCaja);
                    sql.Parameters.AddWithValue("?movimiento_banco", movimientoBanco);
                    sql.Parameters.AddWithValue("?movimiento_boveda", movimientoBoveda);
                    sql.Parameters.AddWithValue("?abrir_cerrar_caja", abrirCerrarCaja);
                    sql.Parameters.AddWithValue("?cortes_caja", cortesCaja);
                    sql.Parameters.AddWithValue("?crear_cliente", crearCliente);
                    sql.Parameters.AddWithValue("?modificar_cliente", modificarCliente);
                    sql.Parameters.AddWithValue("?eliminar_cliente", eliminarCliente);
                    sql.Parameters.AddWithValue("?crear_compra", crearCompra);
                    sql.Parameters.AddWithValue("?visualizar_compra", visualizarCompra);
                    sql.Parameters.AddWithValue("?cancelar_compra", cancelarCompra);
                    sql.Parameters.AddWithValue("?devolucion_compra", devolucionCompra);
                    sql.Parameters.AddWithValue("?config_general", configGeneral);
                    sql.Parameters.AddWithValue("?config_correo", configCorreo);
                    sql.Parameters.AddWithValue("?config_base_datos", configBaseDatos);
                    sql.Parameters.AddWithValue("?config_impresion", configImpresion);
                    sql.Parameters.AddWithValue("?crear_sucursal", crearSucursal);
                    sql.Parameters.AddWithValue("?modificar_sucursal", modificarSucursal);
                    sql.Parameters.AddWithValue("?eliminar_sucursal", eliminarSucursal);
                    sql.Parameters.AddWithValue("?cambiar_sucursal", cambiarSucursal);
                    sql.Parameters.AddWithValue("?crear_producto", crearProducto);
                    sql.Parameters.AddWithValue("?modificar_producto", modificarProducto);
                    sql.Parameters.AddWithValue("?eliminar_producto", eliminarProducto);
                    sql.Parameters.AddWithValue("?ticket_producto", imprimirTicket);
                    sql.Parameters.AddWithValue("?modificar_cant_producto", modificarCantProducto);
                    sql.Parameters.AddWithValue("?modificar_precio_venta_producto", modificarPrecioVentaProducto);
                    sql.Parameters.AddWithValue("?crear_promocion", crearPromocion);
                    sql.Parameters.AddWithValue("?modificar_promocion", modificarPromocion);
                    sql.Parameters.AddWithValue("?eliminar_promocion", eliminarPromocion);
                    sql.Parameters.AddWithValue("?crear_proveedor", crearProveedor);
                    sql.Parameters.AddWithValue("?modificar_proveedor", modificarProveedor);
                    sql.Parameters.AddWithValue("?eliminar_proveedor", eliminarProveedor);
                    sql.Parameters.AddWithValue("?nominas", nominas);
                    sql.Parameters.AddWithValue("?administrar_pago_trabajador", administrarPagoTrabajador);
                    sql.Parameters.AddWithValue("?crear_trabajador", crearTrabajador);
                    sql.Parameters.AddWithValue("?modificar_trabajador", modificarTrabajador);
                    sql.Parameters.AddWithValue("?eliminar_trabajador", eliminarTrabajador);
                    sql.Parameters.AddWithValue("?crear_traspaso", crearTraspaso);
                    sql.Parameters.AddWithValue("?estado_traspaso", estadoTraspaso);
                    sql.Parameters.AddWithValue("?crear_usuario", crearUsuario);
                    sql.Parameters.AddWithValue("?modificar_usuario", modificarUsuario);
                    sql.Parameters.AddWithValue("?eliminar_usuario", eliminarUsuario);
                    sql.Parameters.AddWithValue("?reestablecer_usuario", reestablecerUsuario);
                    sql.Parameters.AddWithValue("?administrar_permisos_usuario", administrarPermisos);
                    sql.Parameters.AddWithValue("?crear_venta", crearVenta);
                    sql.Parameters.AddWithValue("?cancelar_venta", cancelarVenta);
                    sql.Parameters.AddWithValue("?devolucion_venta", devolucionVenta);
                    sql.Parameters.AddWithValue("?venta_periodo", reporteVentaPeriodo);
                    sql.Parameters.AddWithValue("?venta_sucursal", reporteVentaSucursal);
                    sql.Parameters.AddWithValue("?compra_periodo", reporteCompraPeriodo);
                    sql.Parameters.AddWithValue("?compra_sucursal", reporteCompraSucursal);
                    sql.Parameters.AddWithValue("?reporte_general", reporteGeneral);
                    sql.Parameters.AddWithValue("?reiniciar_base", reinicioBase);
                    sql.Parameters.AddWithValue("?inventario_fisico", inventarioFisico);
                    ConexionBD.EjecutarConsulta(sql);
                });
                t.Start();
                await t;
                if (Usuario.IDUsuarioActual == IDUsuario)
                {
                    OnPrivilegesChanged(EventArgs.Empty);
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*
        async public Task Editar()
        {
            try
            {
                Task t = new Task(() =>
                {
                    MySqlCommand sql = new MySqlCommand();
                    sql.CommandText = "UPDATE privilegio SET crear_apartado=?crear_apartado, estado_apartado=?estado_apartado, abrir_caja=?abrir_caja, abrir_banco=?abrir_banco, movimiento_caja=?movimiento_caja, movimiento_banco=?movimiento_banco, abrir_cerrar_caja=?abrir_cerrar_caja, cortes_caja=?cortes_caja, crear_cliente=?crear_cliente, modificar_cliente=?modificar_cliente, eliminar_cliente=?eliminar_cliente, crear_compra=?crear_compra, visualizar_compra=?visualizar_compra, cancelar_compra=?cancelar_compra, devolucion_compra=?devolucion_compra, config_general=?config_general, config_correo=?config_correo, config_base_datos=?config_base_datos, config_impresion=?config_impresion, crear_sucursal=?crear_sucursal, modificar_sucursal=?modificar_sucursal, eliminar_sucursal=?eliminar_sucursal, cambiar_sucursal=?cambiar_sucursal, crear_cotizacion=?crear_cotizacion, crear_producto=?crear_producto, modificar_producto=?modificar_producto, eliminar_producto=?eliminar_producto, ticket_producto=?ticket_producto, " +
                        "modificar_cant_producto=?modificar_cant_producto, crear_promocion=?crear_promocion, modificar_promocion=?modificar_promocion, eliminar_promocion=?eliminar_promocion, crear_proveedor=?crear_proveedor, modificar_proveedor=?modificar_proveedor, eliminar_proveedor=?eliminar_proveedor, administrar_horarios_trabajador=?administrar_horarios_trabajador, administrar_pago_trabajador=?administrar_pago_trabajador, crear_trabajador=?crear_trabajador, modificar_trabajador=?modificar_trabajador, eliminar_trabajador=?eliminar_trabajador, crear_traspaso=?crear_traspaso, estado_traspaso=?estado_traspaso, crear_usuario=?crear_usuario, modificar_usuario=?modificar_usuario, eliminar_usuario=?eliminar_usuario, reestablecer_usuario=?reestablecer_usuario, administrar_permisos_usuario=?administrar_permisos_usuario, crear_venta=?crear_venta, cancelar_venta=?cancelar_venta, devolucion_venta=?devolucion_venta WHERE id_usuario=?id_usuario";
                    sql.Parameters.AddWithValue("?id_usuario", idUsuario);
                    sql.Parameters.AddWithValue("?crear_apartado", crearApartado);
                    sql.Parameters.AddWithValue("?estado_apartado", estadoApartado);
                    sql.Parameters.AddWithValue("?abrir_caja", caja);
                    sql.Parameters.AddWithValue("?abrir_banco", banco);
                    sql.Parameters.AddWithValue("?movimiento_caja", movimientoCaja);
                    sql.Parameters.AddWithValue("?movimiento_banco", movimientoBanco);
                    sql.Parameters.AddWithValue("?abrir_cerrar_caja", abrirCerrarCaja);
                    sql.Parameters.AddWithValue("?cortes_caja", cortesCaja);
                    sql.Parameters.AddWithValue("?crear_cliente", crearCliente);
                    sql.Parameters.AddWithValue("?modificar_cliente", modificarCliente);
                    sql.Parameters.AddWithValue("?eliminar_cliente", eliminarCliente);
                    sql.Parameters.AddWithValue("?crear_compra", crearCompra);
                    sql.Parameters.AddWithValue("?visualizar_compra", visualizarCompra);
                    sql.Parameters.AddWithValue("?cancelar_compra", cancelarCompra);
                    sql.Parameters.AddWithValue("?devolucion_compra", devolucionCompra);
                    sql.Parameters.AddWithValue("?config_general", configGeneral);
                    sql.Parameters.AddWithValue("?config_correo", configCorreo);
                    sql.Parameters.AddWithValue("?config_base_datos", configBaseDatos);
                    sql.Parameters.AddWithValue("?config_impresion", configImpresion);
                    sql.Parameters.AddWithValue("?crear_sucursal", crearSucursal);
                    sql.Parameters.AddWithValue("?modificar_sucursal", modificarSucursal);
                    sql.Parameters.AddWithValue("?eliminar_sucursal", eliminarSucursal);
                    sql.Parameters.AddWithValue("?cambiar_sucursal", cambiarSucursal);
                    sql.Parameters.AddWithValue("?crear_cotizacion", crearCotizacion);
                    sql.Parameters.AddWithValue("?crear_producto", crearProducto);
                    sql.Parameters.AddWithValue("?modificar_producto", modificarProducto);
                    sql.Parameters.AddWithValue("?eliminar_producto", eliminarProducto);
                    sql.Parameters.AddWithValue("?ticket_producto", imprimirTicket);
                    sql.Parameters.AddWithValue("?modificar_cant_producto", modificarCantProducto);
                    sql.Parameters.AddWithValue("?crear_promocion", crearPromocion);
                    sql.Parameters.AddWithValue("?modificar_promocion", modificarPromocion);
                    sql.Parameters.AddWithValue("?eliminar_promocion", eliminarPromocion);
                    sql.Parameters.AddWithValue("?crear_proveedor", crearProveedor);
                    sql.Parameters.AddWithValue("?modificar_proveedor", modificarProveedor);
                    sql.Parameters.AddWithValue("?eliminar_proveedor", eliminarProveedor);
                    sql.Parameters.AddWithValue("?administrar_horarios_trabajador", administrarHorarioTrabajador);
                    sql.Parameters.AddWithValue("?administrar_pago_trabajador", administrarPagoTrabajador);
                    sql.Parameters.AddWithValue("?crear_trabajador", crearTrabajador);
                    sql.Parameters.AddWithValue("?modificar_trabajador", modificarTrabajador);
                    sql.Parameters.AddWithValue("?eliminar_trabajador", eliminarTrabajador);
                    sql.Parameters.AddWithValue("?crear_traspaso", crearTraspaso);
                    sql.Parameters.AddWithValue("?estado_traspaso", estadoTraspaso);
                    sql.Parameters.AddWithValue("?crear_usuario", crearUsuario);
                    sql.Parameters.AddWithValue("?modificar_usuario", modificarUsuario);
                    sql.Parameters.AddWithValue("?eliminar_usuario", eliminarUsuario);
                    sql.Parameters.AddWithValue("?reestablecer_usuario", reestablecerUsuario);
                    sql.Parameters.AddWithValue("?administrar_permisos_usuario", administrarPermisos);
                    sql.Parameters.AddWithValue("?crear_venta", crearVenta);
                    sql.Parameters.AddWithValue("?cancelar_venta", cancelarVenta);
                    sql.Parameters.AddWithValue("?devolucion_venta", devolucionVenta);
                    ConexionBD.EjecutarConsulta(sql);
                });
                t.Start();
                await t;
                if (Usuario.IDUsuarioActual == IDUsuario)
                {
                    OnPrivilegesChanged(EventArgs.Empty);
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        */

        async public static Task PrivilegiosUsuario(int idUsuario)
        {
            try
            {
                Task<bool> u = Privilegios.UsuarioTienePrivilegios(idUsuario);
                await u;
                if (u.Result)
                {
                    Task t = new Task(() =>
                    {
                        MySqlCommand sql = new MySqlCommand();
                        sql.CommandText = "SELECT * FROM privilegio WHERE id_usuario=?id_usuario";
                        sql.Parameters.AddWithValue("?id_usuario", idUsuario);
                        DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                        foreach (DataRow dr in dt.Rows)
                        {
                            _crearApartado = (bool)dr["crear_apartado"];
                            _estadoApartado = (bool)dr["estado_apartado"];
                            _caja = (bool)dr["abrir_caja"];
                            _banco = (bool)dr["abrir_banco"];
                            _boveda = (bool)dr["abrir_boveda"];
                            _movimientoCaja = (bool)dr["movimiento_caja"];
                            _movimientoBanco = (bool)dr["movimiento_banco"];
                            _movimientoBoveda = (bool)dr["movimiento_boveda"];
                            _abrirCerrarCaja = (bool)dr["abrir_cerrar_caja"];
                            _cortesCaja = (bool)dr["cortes_caja"];
                            _crearCliente = (bool)dr["crear_cliente"];
                            _modificarCliente = (bool)dr["modificar_cliente"];
                            _eliminarCliente = (bool)dr["eliminar_cliente"];
                            _crearCompra = (bool)dr["crear_compra"];
                            _visualizarCompra = (bool)dr["visualizar_compra"];
                            _cancelarCompra = (bool)dr["cancelar_compra"];
                            _devolucionCompra = (bool)dr["devolucion_compra"];
                            _configGeneral = (bool)dr["config_general"];
                            _configCorreo = (bool)dr["config_correo"];
                            _configBaseDatos = (bool)dr["config_base_datos"];
                            _configImpresion = (bool)dr["config_impresion"];
                            _crearSucursal = (bool)dr["crear_sucursal"];
                            _modificarSucursal = (bool)dr["modificar_sucursal"];
                            _eliminarSucursal = (bool)dr["eliminar_sucursal"];
                            _cambiarSucursal = (bool)dr["cambiar_sucursal"];
                            _crearProducto = (bool)dr["crear_producto"];
                            _modificarProducto = (bool)dr["modificar_producto"];
                            _eliminarProducto = (bool)dr["eliminar_producto"];
                            _imprimirTicket = (bool)dr["ticket_producto"];
                            _modificarCantProducto = (bool)dr["modificar_cant_producto"];
                            _modificarPrecioVentaProducto = (bool)dr["modificar_precio_venta_producto"];
                            _crearPromocion = (bool)dr["crear_promocion"];
                            _modificarPromocion = (bool)dr["modificar_promocion"];
                            _eliminarPromocion = (bool)dr["eliminar_promocion"];
                            _crearProveedor = (bool)dr["crear_proveedor"];
                            _modificarProveedor = (bool)dr["modificar_proveedor"];
                            _eliminarProveedor = (bool)dr["eliminar_proveedor"];
                            _nominas = (bool)dr["nominas"];
                            _administrarPagoTrabajador = (bool)dr["administrar_pago_trabajador"];
                            _crearTrabajador = (bool)dr["crear_trabajador"];
                            _modificarTrabajador = (bool)dr["modificar_trabajador"];
                            _eliminarTrabajador = (bool)dr["eliminar_trabajador"];
                            _crearTraspaso = (bool)dr["crear_traspaso"];
                            _estadoTraspaso = (bool)dr["estado_traspaso"];
                            _crearUsuario = (bool)dr["crear_usuario"];
                            _modificarUsuario = (bool)dr["modificar_usuario"];
                            _eliminarUsuario = (bool)dr["eliminar_usuario"];
                            _reestablecerUsuario = (bool)dr["reestablecer_usuario"];
                            _administrarPermisos = (bool)dr["administrar_permisos_usuario"];
                            _crearVenta = (bool)dr["crear_venta"];
                            _cancelarVenta = (bool)dr["cancelar_venta"];
                            _devolucionVenta = (bool)dr["devolucion_venta"];
                            _reporteVentaPeriodo = (bool)dr["venta_periodo"];
                            _reporteVentaSucursal = (bool)dr["venta_sucursal"];
                            _reporteCompraPeriodo = (bool)dr["compra_periodo"];
                            _reporteCompraSucursal = (bool)dr["compra_sucursal"];
                            _reporteGeneral = (bool)dr["reporte_general"];
                            _reinicioBase = (bool)dr["reiniciar_base"];
                            _inventarioFisico = (bool)dr["inventario_fisico"];
                        }
                    });
                    t.Start();
                    await t;
                }
                else
                {
                    await Privilegios.AsignarTodosPermisos(idUsuario);
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

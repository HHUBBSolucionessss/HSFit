using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace GYM

{
    class Venta
    {
        #region Propiedades Venta
        private int id;
        private int numSocio;
        private bool cancelada;
        private bool abierta = false;
        private decimal subtotal;
        private decimal impuesto;
        private decimal descuento;
        private decimal total;
        private decimal saldo;
        private TipoPago tipo;
        private string terminacionTarjeta;
        private string terminalTarjeta;
        private decimal cargoTarjeta;
        private string folioDeposito;
        private bool aPagos;
        private int createUser;
        private DateTime createTime;
        private int updateUser;
        private DateTime updateTime;
        private int cancelUser;
        private DateTime cancelTime;

        public int IDVenta
        {
            get { return id; }
            set { id = value; }
        }
        public int NumSocio
        {
            get { return numSocio; }
            set { numSocio = value; }
        }


        public bool Cancelada
        {
            get { return cancelada; }
            set { cancelada = value; }
        }

        public bool Abierta
        {
            get { return abierta; }
            set { abierta = value; }
        }

        public decimal Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public decimal Impuesto
        {
            get { return impuesto; }
            set { impuesto = value; }
        }

        public decimal Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public TipoPago Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public bool APagos
        {
            get { return aPagos; }
            set { aPagos = value; }
        }
        
        public string TerminacionTarjeta
        {
            get { return terminacionTarjeta; }
            set { terminacionTarjeta = value; }
        }

        public string TerminalTarjeta
        {
            get { return terminalTarjeta; }
            set { terminalTarjeta = value; }
        }

        public decimal CargoTarjeta
        {
            get { return cargoTarjeta; }
            set { cargoTarjeta = value; }
        }

        public string FolioDeposito
        {
            get { return folioDeposito; }
            set { folioDeposito = value; }
        }
        
        public int CreateUser
        {
            get { return createUser; }
        }

        public DateTime CreateTime
        {
            get { return createTime; }
        }

        public int UpdateUser
        {
            get { return updateUser; }
        }

        public DateTime UpdateTime
        {
            get { return updateTime; }
        }

        public int CancelUser
        {
            get { return cancelUser; }
        }

        public DateTime CancelTime
        {
            get { return cancelTime; }
        }
        #endregion
         
        #region Propiedades Venta Detallada
        private List<int> idP;
        private List<int> cantidad;
        private List<decimal> precio;
        private List<decimal> descuentoP;
    

        public List<int> IDProductos
        {
            get { return idP; }
            set { idP = value; }
        }

        public List<int> Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public List<decimal> Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public List<decimal> DescuentoProducto
        {
            get { return descuentoP; }
            set { descuentoP = value; }
        }

        #endregion

        /// <summary>
        /// Inicializa la instancia de la clase Venta
        /// </summary>
        public Venta()
        {
            InicializarVentaDetallada();
        }

        /// <summary>
        /// Inicializa la instancia de la clase Venta
        /// </summary>
        /// <param name="idVenta">ID de la venta</param>
        public Venta(int idVenta)
        {
            id = idVenta;
            InicializarVenta();
            InicializarVentaDetallada();
        }

        #region Métodos Venta
        /// <summary>
        /// Método que inicializa las propiedades de la clase Venta
        /// </summary>
        private void InicializarVenta()
        {
            numSocio = 0;
            cancelada = false;
            abierta = true;
            subtotal = 0;
            impuesto = 0;
            descuento = 0;
            total = 0;
        }

        private int IDVenta()
        {
            int id = 1;
            try
            {
                string sql = "SELECT MAX(id) AS i FROM venta";
                DataTable dt = Clases.ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["i"] == DBNull.Value)
                        id = 1;
                    else
                        id = (int.Parse(dr["i"].ToString()) + 1);
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                throw;
            }
            return id;
        }

        /// <summary>
        /// Inserta una nueva venta y asigna el ID de la venta
        /// </summary>
        public void NuevaVenta()
        {
            try
            {
                id = IDVenta();
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO venta (id, tipo_pago, create_user, create_time) VALUES (?id, ?id_sucursal, ?id_vendedor, ?tipo_pago, ?create_user, NOW())";
                sql.Parameters.AddWithValue("?id", IDVenta());
                sql.Parameters.AddWithValue("?tipo_pago", TipoPago.Efectivo);   
                sql.Parameters.AddWithValue("?create_user", Clases.Usuario.IDUsuarioActual);
                Clases.ConexionBD.EjecutarConsulta(sql);
                InicializarVenta();
                InicializarVentaDetallada();
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

        /// <summary>
        /// Recupera los datos de la venta
        /// </summary>
        public void RecuperarVenta()
        {
               try
               {
                   MySqlCommand sql = new MySqlCommand();
                   sql.CommandText = "SELECT * FROM venta WHERE id=?id";
                   sql.Parameters.AddWithValue("?id", id);
                   sql.Parameters.AddWithValue("?id_sucursal", Config.idSucursal);
                   DataTable dt = Clases.ConexionBD.EjecutarConsultaSelect(sql);
                   foreach (DataRow dr in dt.Rows)
                   {
                       cancelada = (bool)dr["cancelada"];
                       abierta = (bool)dr["abierta"];
                       subtotal = (decimal)dr["subtotal"];
                       impuesto = (decimal)dr["impuesto"];
                       descuento = (decimal)dr["descuento"];
                       total = (decimal)dr["total"];
                       saldo = (decimal)dr["saldo"];
                       tipo = (TipoPago)Enum.Parse(typeof(TipoPago), dr["tipo_pago"].ToString());
                       terminacionTarjeta = dr["terminacion_tarjeta"].ToString();
                       terminalTarjeta = dr["terminal_tarjeta"].ToString();
                       cargoTarjeta = (decimal)dr["cargo_tarjeta"];
                       folioDeposito = dr["folio_deposito"].ToString();
                       aPagos = (bool)dr["a_pagos"];
                       createUser = (int)dr["create_user"];
                       createTime = (DateTime)dr["create_time"];
                       if (dr["update_user"] != DBNull.Value)
                           updateUser = (int)dr["update_user"];
                       else
                           updateUser = 0;
                       if (dr["update_time"] != DBNull.Value)
                           updateTime = (DateTime)dr["update_time"];
                       else
                           updateTime = new DateTime();
                       if (dr["cancel_user"] != DBNull.Value)
                           cancelUser = (int)dr["cancel_user"];
                       else
                           cancelUser = 0;
                       if (dr["cancel_time"] != DBNull.Value)
                           cancelTime = (DateTime)dr["cancel_time"];
                       else
                           cancelTime = new DateTime();
                       RecuperarVentaDetallada();
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

        /// <summary>
        /// Inserta todos los datos de una venta
        /// </summary>
        public void DatosVenta()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE venta SET id_cliente=?id_cliente, id_vendedor=?id_vendedor, abierta=?abierta, subtotal=?subtotal, impuesto=?impuesto, descuento=?descuento, " +
                    "total=?total, saldo=?saldo, tipo_pago=?tipo_pago, terminacion_tarjeta=?terminacion_tarjeta, terminal_tarjeta=?terminal_tarjeta, cargo_tarjeta=?cargo_tarjeta, folio_deposito=?folio_deposito, a_pagos=?a_pagos, update_user=?update_user, update_time=NOW() WHERE id=?id AND id_sucursal=?id_sucursal";
                sql.Parameters.AddWithValue("?id_cliente", idC);
                sql.Parameters.AddWithValue("?id_vendedor", idV);
                sql.Parameters.AddWithValue("?abierta", abierta);
                sql.Parameters.AddWithValue("?subtotal", subtotal);
                sql.Parameters.AddWithValue("?impuesto", impuesto);
                sql.Parameters.AddWithValue("?descuento", descuento);
                sql.Parameters.AddWithValue("?total", total);
                sql.Parameters.AddWithValue("?saldo", saldo);
                sql.Parameters.AddWithValue("?tipo_pago", tipo);
                sql.Parameters.AddWithValue("?terminacion_tarjeta", terminacionTarjeta);
                sql.Parameters.AddWithValue("?terminal_tarjeta", terminalTarjeta);
                sql.Parameters.AddWithValue("?cargo_tarjeta", cargoTarjeta);
                sql.Parameters.AddWithValue("?folio_deposito", folioDeposito);
                sql.Parameters.AddWithValue("?a_pagos", aPagos);
                sql.Parameters.AddWithValue("?update_user", Usuario.IDUsuarioActual);
                sql.Parameters.AddWithValue("?id", id);
                sql.Parameters.AddWithValue("?id_sucursal", idS);
                ConexionBD.EjecutarConsulta(sql);
                if (ExisteDetallada(id))
                {
                    EliminarDetallada(id);
                    InsertarProductos();
                }
                else
                {
                    InsertarProductos();
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

        public static void CancelarVenta(int id)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE venta SET cancelada=?cancelada, cancel_user=?cancel_user, cancel_time=NOW() WHERE id=?id AND id_sucursal=?id_sucursal";
                sql.Parameters.AddWithValue("?cancelada", true);
                sql.Parameters.AddWithValue("?cancel_user", Usuario.IDUsuarioActual);
                sql.Parameters.AddWithValue("?id", id);
                sql.Parameters.AddWithValue("?id_sucursal", Config.idSucursal);
                ConexionBD.EjecutarConsulta(sql);
                CancelarDetallada(id);
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

        public static void SumarVentaAPagos(int id, decimal abono)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE venta SET abonado=abonado+'" + abono.ToString() + "' WHERE id=?id AND id_sucursal=?id_sucursal";
                sql.Parameters.AddWithValue("?id", id);
                sql.Parameters.AddWithValue("?id_sucursal", Config.idSucursal);
                ConexionBD.EjecutarConsulta(sql);
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

        #region Métodos Venta Detallada
        /// <summary>
        /// Inicializa las propiedades que esten relacionadas con la venta detallada
        /// </summary>
        private void InicializarVentaDetallada()
        {
            idP = new List<int>();
            cantidad = new List<int>();
            precio = new List<decimal>();
            descuentoP = new List<decimal>();
            unidad = new List<Unidades>();
            paquete = new List<bool>();
            promocion = new List<int>();
            cantApartado = new List<int>();
        }

        private bool ExisteDetallada(int idVenta)
        {
            bool existe = false;
            try
            {
                string sql = "SELECT id_venta, id_sucursal FROM venta_detallada WHERE id_venta='" + idVenta.ToString() + "' AND id_sucursal='" + Config.idSucursal.ToString() + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                if (dt.Rows.Count > 0)
                {
                    existe = true;
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
            return existe;
        }

        private void EliminarDetallada(int idVenta)
        {
            try
            {
                string sql = "DELETE FROM venta_detallada WHERE id_venta='" + idVenta.ToString() + "' AND id_sucursal='" + Config.idSucursal.ToString() + "'";
                ConexionBD.EjecutarConsulta(sql);
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

        /// <summary>
        /// Inserta los productos de la venta en la base de datos, y en caso de estar ya, los actualiza
        /// </summary>
        private void InsertarProductos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                for (int i = 0; i < idP.Count; i++)
                {
                    sql.CommandText = "INSERT INTO venta_detallada (id_venta, id_producto, id_sucursal, cant, precio, descuento, unidad, paquete, id_promocion) " +
                    "VALUES (?id_venta, ?id_producto, ?id_sucursal, ?cant, ?precio, ?descuento, ?unidad, ?paquete, ?promocion) " +
                    "ON DUPLICATE KEY UPDATE cant=?cant, precio=?precio, descuento=?descuento, unidad=?unidad, paquete=?paquete, id_promocion=?promocion;";
                    sql.Parameters.AddWithValue("?id_venta", id);
                    sql.Parameters.AddWithValue("?id_producto", idP[i]);
                    sql.Parameters.AddWithValue("?id_sucursal", Config.idSucursal);
                    sql.Parameters.AddWithValue("?cant", cantidad[i]);
                    sql.Parameters.AddWithValue("?precio", precio[i]);
                    sql.Parameters.AddWithValue("?descuento", descuentoP[i]);
                    sql.Parameters.AddWithValue("?unidad", unidad[i]);
                    sql.Parameters.AddWithValue("?paquete", paquete[i]);
                    sql.Parameters.AddWithValue("?promocion", promocion[i]);
                    ConexionBD.EjecutarConsulta(sql);
                    sql.Parameters.Clear();
                    if (this.abierta == false)
                    {
                        Inventario.CambiarCantidadInventario(idP[i], (cantidad[i] - cantApartado[i]) * -1, Config.idSucursal);
                        Promociones.CambiarExistencias(promocion[i], cantidad[i] * -1);
                    }
                }
                InicializarVentaDetallada();
            }
            catch (MySqlException ex)
            {
                InicializarVentaDetallada();
                throw ex;
            }
            catch (Exception ex)
            {
                InicializarVentaDetallada();
                throw ex;
            }
        }

        /// <summary>
        /// Recupera los datos de los productos de la venta detallada
        /// </summary>
        private void RecuperarVentaDetallada()
        {
            InicializarVentaDetallada();
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM venta_detallada WHERE id_venta=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = Clases.ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idP.Add((int)dr["id_producto"]);
                    cantidad.Add((int)dr["cant"]);
                    precio.Add((decimal)dr["precio"]);
                    descuentoP.Add((decimal)dr["descuento"]);
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

        private static void CancelarDetallada(int id)
        {
            try
            {
                Venta v = new Venta(id);
                v.RecuperarVenta();
                for (int i = 0; i < v.IDProductos.Count; i++)
                {
                    Clases.Inventario.CambiarCantidadInventario(v.IDProductos[i], v.Cantidad[i]);
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
        #endregion
    }
}

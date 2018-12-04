using MySql.Data.MySqlClient;
using System;
using System.Data;


namespace GYM.Clases
{
    public class Boveda
    {
        #region Propiedades Boveda
        private int id;
        private decimal efectivo;
        private string descripcion;
        //private MovimientoCaja tipoMovimiento;
        private int create_user;
        private DateTime createTime;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public decimal Efectivo
        {
            get { return efectivo; }
            set { efectivo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

       /* public MovimientoCaja TipoMovimiento
        {
            get { return tipoMovimiento; }
            set { tipoMovimiento = value; }
        }*/

        public int CreateUser
        {
            get { return create_user; }
        }

        public DateTime CreateTime
        {
            get { return createTime; }
        }
        #endregion

        #region Totales Boveda
        private static decimal totalEfe = -1;

        /// <summary>
        /// Obtiene el total del efectivo que hay actualmente en caja
        /// </summary>
        public static decimal TotalEfectivo
        {
            get
            {
                if (totalEfe < 0)
                    Totales();
                return totalEfe;
            }
        }
        
        /// <summary>
        /// Método que obtiene los totales de boveda
        /// </summary>
        private static void Totales()
        {
            try
            {
                string sql = "SELECT SUM(efectivo) AS e FROM boveda";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["e"] != DBNull.Value)
                        totalEfe = (decimal)dr["e"];
                    else
                        totalEfe = 0M;
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

        /// <summary>
        /// Inicializa la instancia de la clase Caja
        /// </summary>
        public Boveda()
        {

        }

        /// <summary>
        /// Método que inserta un nuevo movimiento en la base de datos con los datos de las propiedades
        /// </summary>
        public void InsertarMovimiento()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO boveda (efectivo, descripcion, tipo_movimiento, create_user, create_time) " +
                    "VALUES (?efectivo, ?descripcion, ?tipo_movimiento, ?create_user, NOW())";
                sql.Parameters.AddWithValue("?efectivo", efectivo);
                sql.Parameters.AddWithValue("?descripcion", descripcion);
               // sql.Parameters.AddWithValue("?tipo_movimiento", tipoMovimiento);
                sql.Parameters.AddWithValue("?create_user", Usuario.IDUsuarioActual);
                ConexionBD.EjecutarConsulta(sql);
                Totales();
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

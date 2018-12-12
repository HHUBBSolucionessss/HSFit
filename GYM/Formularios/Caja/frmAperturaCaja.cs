using System;
using System.Data;
using System.Windows.Forms;

namespace GYM.Formularios.Caja
{
    public partial class frmAperturaCaja : Form
    {
        decimal efectivoCaja;
        frmCaja frm = null;

        #region Instancia
        private static frmAperturaCaja frmInstancia;

        /// <summary>
        /// Obtiene o establece la variable de instancia de clase para controlar la apertura de formulario.
        /// </summary>
        public static frmAperturaCaja Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmAperturaCaja();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmAperturaCaja();
                return frmInstancia;

            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        public frmAperturaCaja()
        {
            InitializeComponent();

        }

        public frmAperturaCaja(frmCaja frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void AbrirCaja()
        {
            try
            {
                decimal efectivo = 0;
                if (txtEfectivo.Text.Trim() != "")
                    efectivo = decimal.Parse(txtEfectivo.Text);
                MySql.Data.MySqlClient.MySqlCommand sql = new MySql.Data.MySqlClient.MySqlCommand();
                sql.CommandText = "INSERT INTO caja (efectivo, tipo_movimiento, fecha, descripcion, create_user_id, create_time) VALUES (?, ?, NOW(), ?, ?, NOW())";
                sql.Parameters.AddWithValue("@efectivo", efectivo.ToString("0.00"));
                sql.Parameters.AddWithValue("@tipo_movimiento", 0);
                sql.Parameters.AddWithValue("@descripcion", "APERTURA DE CAJA");
                sql.Parameters.AddWithValue("@create_user", frmMain.id);
                Clases.ConexionBD.EjecutarConsulta(sql);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al tratar conectar con la base de datos.", ex);
            }
            catch (FormatException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El formato ingresado en efectivo no es correcto, verifíquelo.", ex);
            }
            catch (OverflowException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido una sobrecarga al querer convertir en decimal.", ex);
            }
            catch (ArgumentNullException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El argumento ingresado es nulo.", ex);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void CambiarEstadoCaja()
        {
            try
            {
                Clases.ConfiguracionXML.GuardarConfiguracion("caja", "estado", true.ToString());
            }
            catch (System.Xml.XmlException ex)
            {
                MessageBox.Show("Ha ocurrido un error al querer guardar en el archivo XML. Mensaje de error:" + ex.Message + "\nNúmero de linea y posición: " + ex.LineNumber + ", " + ex.LinePosition,
                    "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.IO.PathTooLongException ex)
            {
                Clases.FuncionesGenerales.MensajeError("La ruta del directorio es muy larga.", ex);
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El directorio del archivo de configuración no se encontró.", ex);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se encontro el archivo de configuración.", ex);
            }
            catch (System.IO.IOException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error de E/S.", ex);
            }
            catch (InvalidOperationException ex)
            {
                Clases.FuncionesGenerales.MensajeError("La llamada al método no se pudo efectuar porque el estado actual del objeto no lo permite.", ex);
            }
            catch (NotSupportedException ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se pudo leer o modificar la secuencia de datos.", ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El sistema ha negado el acceso al archivo de configuración.\nPuede deberse a un error de E/S o a un error de seguridad.", ex);
            }
            catch (System.Security.SecurityException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error de seguridad.", ex);
            }
            catch (ArgumentNullException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El método no acepta referencias nulas.", ex);
            }
            catch (ArgumentException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El argumento que se pasó al método no es aceptado por este.", ex);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void CargarEfectivoCaja()
        {
            try
            {
                string sql = "SELECT SUM(efectivo) AS tot FROM caja";
                DataTable dt = Clases.ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["tot"] != DBNull.Value)
                        efectivoCaja = decimal.Parse(dr["tot"].ToString());
                }
                lblEfectivoCaja.Text = efectivoCaja.ToString("C2");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al tratar conectar con la base de datos.", ex);
            }
            catch (FormatException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El formato ingresado en efectivo no es correcto, verifíquelo.", ex);
            }
            catch (OverflowException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido una sobrecarga al querer convertir en decimal.", ex);
            }
            catch (ArgumentNullException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El argumento ingresado es nulo.", ex);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void CalcularTotal()
        {
            try
            {
                if (txtEfectivo.Text != "")
                {
                    decimal total = efectivoCaja + decimal.Parse(txtEfectivo.Text);
                    lblTotal.Text = total.ToString("C2");
                }
                else
                    lblTotal.Text = lblEfectivoCaja.Text;
            }
            catch (FormatException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El formato ingresado en efectivo no es correcto, verifíquelo.", ex);
            }
            catch (OverflowException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido una sobrecarga al querer convertir en decimal.", ex);
            }
            catch (ArgumentNullException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El argumento ingresado es nulo.", ex);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void ObtenerNombreUsuario()
        {
            try
            {
                string sql = "SELECT userName FROM usuarios WHERE id='" + frmMain.id.ToString() + "'";
                DataTable dt = Clases.ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                    lblAtiende.Text = dr["userName"].ToString();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al tratar conectar con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void frmAbrirCaja_Load(object sender, EventArgs e)
        {
            try
            {
                Clases.FuncionesGenerales.CargarInterfaz(this);
                ObtenerNombreUsuario();
                CargarEfectivoCaja();
                CalcularTotal();
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEfectivo.Text.Trim() != "")
                {
                    if (!(decimal.Parse(txtEfectivo.Text) < 0))
                    {
                        AbrirCaja();
                        Clases.Caja.CambiarEstadoCaja(true);
                        if (this.frm != null)
                        {
                            frm.CargarTotalCaja();
                            frm.CargarVentas(DateTime.Now, DateTime.Now);
                        }
                        MessageBox.Show("Se ha abierto la caja con éxito.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("El dinero a ingresar a la caja debe ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AbrirCaja();
                    Clases.Caja.CambiarEstadoCaja(true);
                    if (this.frm != null)
                    {
                        frm.CargarTotalCaja();
                        frm.CargarVentas(DateTime.Now, DateTime.Now);
                    }
                    this.Close();
                }
            }
            catch (FormatException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El formato ingresado en efectivo no es correcto, verifíquelo.", ex);
            }
            catch (OverflowException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido una sobrecarga al querer convertir en decimal.", ex);
            }
            catch (ArgumentNullException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El argumento ingresado es nulo.", ex);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void txtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Clases.FuncionesGenerales.VerificarEsNumero(ref sender, ref e, false);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

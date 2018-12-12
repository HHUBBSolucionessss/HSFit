using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM.Formularios.Caja
{
    public partial class frmMovimientoCaja : Form
    {
        decimal totalEfe;
        Movimiento tipoMovimiento;
        frmCaja frm = null;
    
        public Movimiento TipoMovimiento
        {
            get { return tipoMovimiento; }
            set { tipoMovimiento = value; }
        }

        public frmCaja Caja
        {
            get { return frm; }
            set { frm = value; }
        }

        #region Instancia
        private static frmMovimientoCaja frmInstancia;
        public static frmMovimientoCaja Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmMovimientoCaja();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmMovimientoCaja();
                return frmInstancia;

            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        public enum Movimiento
        {
            Entrada = 0, 
            Salida = 1
        }

        public frmMovimientoCaja()
        {
            InitializeComponent();

        }

        private void IngresarMovimiento()
        {
            try
            {
                decimal efectivo = 0;
                if (tipoMovimiento == Movimiento.Entrada)
                    efectivo = decimal.Parse(txtEfectivo.Text);
                else
                    efectivo = decimal.Parse(txtEfectivo.Text) * -1;
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO caja (efectivo, tipo_movimiento, fecha, descripcion, create_user_id, create_time) VALUES (?, ?, NOW(), ?, ?, NOW())";
                sql.Parameters.AddWithValue("@efectivo", efectivo.ToString("0.00"));
                sql.Parameters.AddWithValue("@tipoMovimiento", tipoMovimiento);
                sql.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                sql.Parameters.AddWithValue("@create_user_id", frmMain.id);
                Clases.ConexionBD.EjecutarConsulta(sql);
            }
            catch (MySqlException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de conectar con la base de datos.", ex);
            }
            catch (FormatException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de dar formato a una variable.", ex);
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
            catch (MySqlException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de conectar con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void ObtenerTotalCaja()
        {
            try
            {
                string sql = "SELECT SUM(efectivo) AS ef FROM caja";
                DataTable dt = Clases.ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                    totalEfe = decimal.Parse(dr["ef"].ToString());
            }
            catch (MySqlException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de conectar con la base de datos.", ex);
            }
            catch (FormatException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de dar formato a una variable.", ex);
            }
            catch (OverflowException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un desbordamiento.", ex);
            }
            catch (ArgumentNullException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ningún método en ObtenerTotalCaja admite argumentos nulos.", ex);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void frmEntradaSalida_Load(object sender, EventArgs e)
        {
            try
            {
                Clases.FuncionesGenerales.CargarInterfaz(this);
                if (tipoMovimiento == Movimiento.Entrada)
                {
                    this.Text = "Entrada";
                    lblEfectivo.Text += "ingresar";
                }
                else
                {
                    this.Text = "Salida";
                    lblEfectivo.Text += "retirar";
                    ObtenerTotalCaja();
                }
                ObtenerNombreUsuario();
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEfectivo.Text == "")
                {
                    MessageBox.Show("Debes ingresar una cantidad de efectivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtDescripcion.Text == "")
                {
                    MessageBox.Show("Debes ingresar una descripción del movimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (tipoMovimiento == Movimiento.Salida && decimal.Parse(txtEfectivo.Text) > totalEfe)
                {
                    MessageBox.Show("No puedes retirar mas efectivo del que se encuentra en caja.\nEl efectivo total en caja es: " + totalEfe.ToString("C2"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                IngresarMovimiento();
                if (frm != null)
                {
                    frm.CargarTotalCaja();
                    frm.CargarVentas(DateTime.Now, DateTime.Now);
                }
                ImprimirTicket();
                this.Close();
            }
            catch (InvalidEnumArgumentException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Las enumeraciones dadas a los mensajes no son válidas.", ex);
            }
            catch (ObjectDisposedException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al llamar un método en un objeto desechado.", ex);
            }
            catch (InvalidOperationException ex)
            {
                Clases.FuncionesGenerales.MensajeError("La llamada a un método dentro del evento Click del botón Aceptar no fue válida ya que el estado actual del objeto no lo permite.", ex);
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

        private void txtEfectivo_LostFocus(object sender, EventArgs e)
        {
            try
            {
                if (txtEfectivo.Text != "")
                    if (txtEfectivo.Text.Contains('.') == false)
                        txtEfectivo.Text = decimal.Parse(txtEfectivo.Text).ToString("0.00");
            }
            catch (FormatException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de dar formato a una variable.", ex);
            }
            catch (OverflowException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un desbordamiento.", ex);
            }
            catch (ArgumentNullException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ningún método en el evento LostFocus del cuadro de texto de Efectivo admite argumentos nulos.", ex);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }


        private void ImprimirTicket()
        {
            try
            {
                if (Clases.ConfiguracionXML.ExisteConfiguracion("ticket", "imprimir"))
                    if (bool.Parse(Clases.ConfiguracionXML.LeerConfiguración("ticket", "imprimir")))
                        if (Clases.ConfiguracionXML.ExisteConfiguracion("ticket", "preguntar"))
                        {
                            if (bool.Parse(Clases.ConfiguracionXML.LeerConfiguración("ticket", "preguntar")))
                            {
                                if (MessageBox.Show("¿Deseas imprimir el ticket del movimiento en caja?", "HS FIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                    (new Clases.CTicket()).ImprimirMovimientoCaja();
                            }
                            else
                                (new Clases.CTicket()).ImprimirMovimientoCaja();
                        }
                        else
                            (new Clases.CTicket()).ImprimirMovimientoCaja();
            }
            catch (System.Xml.XmlException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al querer leer el archivo de configuración.\nLinea de error y posición: " + ex.LineNumber + ", " + ex.LinePosition + ".", ex);
            }
            catch (System.IO.PathTooLongException ex)
            {
                Clases.FuncionesGenerales.MensajeError("La ruta del archivo de configuración es muy larga.", ex);
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                Clases.FuncionesGenerales.MensajeError("La ruta del archivo de configuración no se encontró.", ex);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El archivo de configuración no fue encontrado.", ex);
            }
            catch (System.IO.IOException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error de E/S.", ex);
            }
            catch (NotSupportedException ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se admite la llamada al método invocado, o se ha intentado leer, buscar o escribir en una secuencia que no lo admite.", ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El sistema operativo a denegado el acceso a un método de E/S o ha ocurrido un tipo de seguridad concreto.", ex);
            }
            catch (System.Security.SecurityException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error de seguridad.", ex);
            }
            catch (FormatException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al dar formato a una variable.", ex);
            }
            catch (OverflowException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un desbordamiento.", ex);
            }
            catch (ArgumentNullException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ningún método llamado en el evento Load admite argumentos nulos.", ex);
            }
            catch (ArgumentException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error en un método llamado en el evento Load.", ex);
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

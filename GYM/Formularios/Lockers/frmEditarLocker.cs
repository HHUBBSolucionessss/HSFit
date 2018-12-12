using GYM.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM.Formularios
{
    public partial class frmEditarLocker : Form
    {
        delegate void AbrirMSGBox(string mensaje, Exception ex);
        FrmLockers frm;
        DataTable dt = new DataTable();
        int idLocker, numSocio = 0;
        string ultimoFolio = "";

        public frmEditarLocker(FrmLockers frm, int idLocker)
        {
            InitializeComponent();

            this.frm = frm;
            this.idLocker = idLocker;
            cboTipoPago.SelectedIndex = 0;
            UltimoFolio();
            ConfigFolio();
            ObtenerSocioAsignado();
        }

        private void ConfigFolio()
        {
            if (ConfiguracionXML.ExisteConfiguracion("membresia", "folio"))
            {
                if (bool.Parse(ConfiguracionXML.LeerConfiguración("membresia", "folio")) == true)
                {
                    txtFolio.Text = ultimoFolio;
                    txtFolio.Enabled = false;
                }
                else
                {
                    txtFolio.Enabled = true;
                }
            }
            else
                txtFolio.Enabled = true;
        }

        private void UltimoFolio()
        {
            try
            {
                string sql = "SELECT MAX(id) AS i FROM registro_locker";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["i"] != DBNull.Value)
                        ultimoFolio = ((int)dr["i"] + 1).ToString();
                    else
                        ultimoFolio = "1";
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.MensajeError("Ocurrió un error al generar el nuevo folio. No se ha podido conectar con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.MensajeError("Ocurrió un error al generar el nuevo folio. Ocurrió un error genérico.", ex);
            }
        }
        private void ObtenerSocioAsignado()
        {
            try
            {
                string sql = "SELECT l.numSocio as numSocio,rl.nom_persona as nombre from locker as l inner join registro_locker as rl on (l.id=rl.locker_id) WHERE l.id="+idLocker;
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["numSocio"]==DBNull.Value)
                    {
                        lblSocio.Text = dr["nombre"].ToString();
                    } 
                    else
                    {
                        numSocio = (int)dr["numSocio"];
                        CargarNombreMiembro();

                    }
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.MensajeError("Ocurrió un error al generar el nuevo folio. No se ha podido conectar con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.MensajeError("Ocurrió un error al generar el nuevo folio. Ocurrió un error genérico.", ex);
            }



        }

        private void CargarNombreMiembro()
        {
            try
            {
                string sql = "SELECT nombre, apellidos FROM miembros WHERE numSocio='" + numSocio.ToString() + "'";
                DataTable dt = Clases.ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                    lblSocio.Text = dr["nombre"].ToString() + " " + dr["apellidos"].ToString();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de conectar con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }


        private bool ExisteFolio(string folio)
        {
            bool existe = false;
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT folio_remision FROM registro_locker WHERE folio_remision=?folio";
                sql.Parameters.AddWithValue("?folio", folio);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                if (dt.Rows.Count > 0)
                    existe = true;
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.MensajeError("No se pudo comprobar el estado del folio. No se pudo establecer la conexión con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.MensajeError("No se pudo comprobar el estado del folio. Ocurrió un error genérico.", ex);
            }
            return existe;
        }

       

        private bool ValidarCampos()
        {      
            if (txtFolio.Text.Trim() == "")
            {
                MessageBox.Show("El campo \"Folio\" es obligatorio.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtPrecio.Text.Trim() == "")
            {
                MessageBox.Show("El campo \"Precio\" es obligatorio.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                if (decimal.Parse(txtPrecio.Text) <= 0)
                {
                    MessageBox.Show("El campo \"Precio\" no puede ser menor o igual a cero.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            if (cboTipoPago.SelectedIndex == 1)
            {
                if (txtTerminación.Text.Trim() == "")
                {
                    MessageBox.Show("En una venta con tarjeta, debes ingresar el campo \"Terminación de tarjeta\".", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        private void InsertarLocker()
        {
            try
            {
                //Actualizamos los datos del locker
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE locker SET fecha_fin=?fecha_fin,fecha_ini=?fecha_ini, estado=?estado, update_user_id=?update_user_id, update_time=NOW() WHERE id=?id";
                sql.Parameters.AddWithValue("?numSocio", numSocio);
                sql.Parameters.AddWithValue("?fecha_fin", dtpFechaFin.Value);
                sql.Parameters.AddWithValue("?fecha_ini", dtpFechaIni.Value);
                sql.Parameters.AddWithValue("?estado", FrmLockers.EstadoLocker.Pendiente);
                sql.Parameters.AddWithValue("?update_user_id", frmMain.id);
                sql.Parameters.AddWithValue("?id", idLocker);
                ConexionBD.EjecutarConsulta(sql);
                sql.Parameters.Clear();
                //Insertamos el registro de lockers
                sql.CommandText = "INSERT INTO registro_locker (locker_id, nom_persona, fecha_fin, fecha_ini, descripcion, tipo_pago, precio, terminacion, folio_remision, folio_ticket, create_user_id, create_time) " +
                    "VALUES (?locker_id, ?nom_persona, ?fecha_fin, ?fecha_ini, ?descripcion, ?tipo_pago, ?precio, ?terminacion, ?folio_remision, ?folio_ticket, ?create_user_id, NOW())";
                sql.Parameters.AddWithValue("?locker_id", idLocker);
                sql.Parameters.AddWithValue("?nom_persona", lblSocio.Text);
                sql.Parameters.AddWithValue("?fecha_fin", dtpFechaFin.Value);
                sql.Parameters.AddWithValue("?fecha_ini", dtpFechaIni.Value);
                sql.Parameters.AddWithValue("?descripcion", txtDescripcion.Text);
                sql.Parameters.AddWithValue("?tipo_pago", cboTipoPago.SelectedIndex);
                sql.Parameters.AddWithValue("?precio", txtPrecio.Text);
                if (cboTipoPago.SelectedIndex == 1)
                {
                    sql.Parameters.AddWithValue("?terminacion", txtTerminación.Text);
                    sql.Parameters.AddWithValue("?folio_ticket", txtFolioTicket.Text);
                }
                else
                {
                    sql.Parameters.AddWithValue("?terminacion", DBNull.Value);
                    sql.Parameters.AddWithValue("?folio_ticket", DBNull.Value);
                }
                sql.Parameters.AddWithValue("?folio_remision", txtFolio.Text);
                sql.Parameters.AddWithValue("?create_user_id", frmMain.id);
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

        private void InsertarCaja()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO caja (efectivo, tarjeta, tipo_movimiento, fecha, descripcion, create_user_id, create_time) " +
                    "VALUES (?efectivo, ?tarjeta, ?tipo_movimiento, NOW(), ?descripcion, ?create_user_id, NOW())";
                if (cboTipoPago.SelectedIndex == 0)
                {
                    sql.Parameters.AddWithValue("?efectivo", decimal.Parse(txtPrecio.Text));
                    sql.Parameters.AddWithValue("?tarjeta", 0M);
                }
                else
                {
                    sql.Parameters.AddWithValue("?efectivo", 0M);
                    sql.Parameters.AddWithValue("?tarjeta", decimal.Parse(txtPrecio.Text));
                }
                sql.Parameters.AddWithValue("?tipo_movimiento", 0);
                sql.Parameters.AddWithValue("?descripcion", "RENTA DE LOCKER CON FOLIO "+txtFolio.Text+" A "+lblSocio.Text);
                sql.Parameters.AddWithValue("?create_user_id", frmMain.id);
                ConexionBD.EjecutarConsulta(sql);
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.MensajeError("Hubo un error al registrar el movimiento en la caja. La conexión con la base de datos no se ha podido realizar.", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.MensajeError("Hubo un error al registrar el movimiento en la caja. Ha ocurrido un error genérico.", ex);
            }
        }

        private void ImprimirTicket()
        {
            try
            {
                if (Clases.ConfiguracionXML.ExisteConfiguracion("ticket", "imprimir"))
                {
                    if (bool.Parse(Clases.ConfiguracionXML.LeerConfiguración("ticket", "imprimir")))
                    {
                        if (Clases.ConfiguracionXML.ExisteConfiguracion("ticket", "preguntar"))
                        {
                            if (bool.Parse(Clases.ConfiguracionXML.LeerConfiguración("ticket", "preguntar")))
                            {
                                if (MessageBox.Show("¿Deseas imprimir el ticket de la asignación de locker?", "HS FIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    (new Clases.CTicket()).ImprimirTicketLocker(idLocker);
                                    (new Clases.CTicket()).ImprimirTicketLocker(idLocker);
                                }
                            }
                            else
                            {
                                (new Clases.CTicket()).ImprimirTicketLocker(idLocker);
                                (new Clases.CTicket()).ImprimirTicketLocker(idLocker);
                            }
                        }
                        else
                        {
                            (new Clases.CTicket()).ImprimirTicketLocker(idLocker);
                            (new Clases.CTicket()).ImprimirTicketLocker(idLocker);
                        }
                    }
                }
            }
            catch (System.Xml.XmlException ex)
            {
                MessageBox.Show("Ha ocurrido un error al querer leer del archivo XML. Mensaje de error:" + ex.Message + "\nNúmero de linea y posición: " + ex.LineNumber + ", " + ex.LinePosition,
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



        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, false);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Clases.Caja.EstadoCaja())
                {
                    if (ValidarCampos())
                    {
                        InsertarLocker();
                        InsertarCaja();
                        ImprimirTicket();
                        MessageBox.Show("El locker ha sido asignado a " + lblSocio.Text + ".", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm.BuscarLockers();
                        this.Close();
                    }
                }
                else
                {
                    if (MessageBox.Show("No puedes realizar operaciones de venta si la caja esta cerrada.\n¿Deseas abrirla?", "HS FIT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    {
                        (new Formularios.Caja.frmAperturaCaja()).ShowDialog(this);
                        btnAceptar.PerformClick();
                    }
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.MensajeError("No se ha podido asignar el locker. No se pudo conectar con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.MensajeError("No se ha podido asignar el locker. Ha ocurrido un error genérico.", ex);
            }
        }

       

        private void cboTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoPago.SelectedIndex == 0)
            {
                txtFolioTicket.Enabled = txtTerminación.Enabled = false;
            }
            else if (cboTipoPago.SelectedIndex == 1)
            {
                txtFolioTicket.Enabled = txtTerminación.Enabled = true;
            }
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaFin.Value.AddMonths(1);
        }

       

        private void txtFolio_LostFocus(object sender, EventArgs e)
        {
            //if (ExisteFolio(txtFolio.Text))
            //{
            //    MessageBox.Show("El folio ingresado ya existe, ingrese otro para poder continuar.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtFolio.Focus();
            //    txtFolio.SelectAll();
            //}
        }

        private void frmEditarLocker_Load(object sender, EventArgs e)
        {
            dtpFechaFin.Value.AddMonths(1);
        }

       
    }
}

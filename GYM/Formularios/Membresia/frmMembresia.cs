using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using GYM.Clases;

namespace GYM.Formularios.Membresia
{
    public partial class frmMembresia : Form
    {
        DataTable dt = new DataTable();
        int numSocio = 0, sexo;

        #region Instancia
        private static frmMembresia frmInstancia;
        public static frmMembresia Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmMembresia();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmMembresia();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        public frmMembresia()
        {
            InitializeComponent();

        }

        #region Metodos

        private int PreciosH()
        {
            int cant = 0;
            try
            {
                string sql = "SELECT COUNT(id) AS i FROM precio_membresia WHERE sexo=0";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["i"] != DBNull.Value)
                        cant = int.Parse(dr["i"].ToString());
                }
            }
            catch
            {
            }
            return cant;
        }

        private int PreciosM()
        {
            int cant = 0;
            try
            {
                string sql = "SELECT COUNT(id) AS i FROM precio_membresia WHERE sexo=1";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["i"] != DBNull.Value)
                        cant = int.Parse(dr["i"].ToString());
                }
            }
            catch
            {
            }
            return cant;
        }



        private void BuscarMiembros(string textoBusqueda)
        {
            dgvPersonas.Rows.Clear();
            try
            {
                //Fecha_fin
                string sql = "SELECT mi.numSocio, mi.nombre, mi.apellidos, mi.telefono, mi.celular, mi.genero, me.estado, me.fecha_ini, me.fecha_fin AS fecha FROM miembros AS mi LEFT JOIN membresias AS me ON (mi.numSocio=me.numSocio) WHERE mi.numSocio='" + textoBusqueda + "' OR mi.nombre LIKE '%" + textoBusqueda + "%' OR mi.apellidos LIKE '%" + textoBusqueda + "%'";
                dt = ConexionBD.EjecutarConsultaSelect(sql);                
            }
            catch (MySqlException ex)
            {
                CFuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de conectar con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                CFuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                int activas=0, inactivas = 0, rechazadas=0, pendientes = 0, sinInfo=0;
                foreach (DataRow dr in dt.Rows)
                {
                    string status = null;
                    string fecha = null;
                    string fechaIni = null;
                    DateTime fechaI;

                    if (dr["estado"] != DBNull.Value)
                    {
                        Clases.Membresia.EstadoMembresia es = (Clases.Membresia.EstadoMembresia)Enum.Parse(typeof(Clases.Membresia.EstadoMembresia), dr["estado"].ToString());
                        if (es == Clases.Membresia.EstadoMembresia.Inactiva)
                        {
                            status = "Inactivo";
                            inactivas++;
                        }
                        else if (es == Clases.Membresia.EstadoMembresia.Activa)
                        {
                            status = "Activo";
                            activas++;
                        }
                        else if (es == Clases.Membresia.EstadoMembresia.Pendiente)
                        {
                            status = "Pendiente";
                            pendientes++;
                        }
                        else if (es == Clases.Membresia.EstadoMembresia.Rechazada)
                        {
                            status = "Rechazada";
                            rechazadas++;
                        }
                    }
                    else
                    {
                        status = "Sin información";
                        sinInfo++;
                    }
                    if (dr["fecha"] != DBNull.Value)
                        fecha = DateTime.Parse(dr["fecha"].ToString()).ToString("dd") + " de " + DateTime.Parse(dr["fecha"].ToString()).ToString("MMMM") + " del " + DateTime.Parse(dr["fecha"].ToString()).ToString("yyyy");
                    else
                        fecha = "No especificada";
                    if (dr["fecha_ini"] != DBNull.Value)
                    {
                        fechaI = DateTime.Parse(dr["fecha_ini"].ToString());
                        fechaIni = fechaI.ToString("dd") + " de " + fechaI.ToString("MMMM") + " del " + fechaI.ToString("yyyy");
                    }
                    else
                        fechaIni = "Sin información";
                    dgvPersonas.Rows.Add(new object[] { (int)dr["numSocio"], dr["nombre"].ToString() + " " + dr["apellidos"].ToString(), status, fechaIni, fecha, dr["genero"] });
                    Application.DoEvents();
                    lblActivas.Text = activas.ToString();
                    lblInactivas.Text = inactivas.ToString();
                    lblRechazadas.Text = rechazadas.ToString();
                    lblPendientes.Text = pendientes.ToString();
                    lblSininfo.Text = sinInfo.ToString();

                }

                
            }
            catch (FormatException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de dar formato a una variable.", ex);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("El argumento dado en algún método se ha salido del rango.", ex);
            }
            catch (ArgumentNullException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Algún método llamado en buscar miembros no admite argumentos nulos.", ex);
            }
            catch (Exception ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void EstadoPendiente(string numSocio)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE membresias SET estado=?estado WHERE numSocio=?numSocio";
                sql.Parameters.AddWithValue("?estado", Clases.Membresia.EstadoMembresia.Pendiente);
                sql.Parameters.AddWithValue("?numSocio", numSocio);
                ConexionBD.EjecutarConsulta(sql);
            }
            catch (MySqlException ex)
            {
                CFuncionesGenerales.MensajeError("No se ha podido cambiar el estado de la membresía. Ocurrió un error al conectar con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                CFuncionesGenerales.MensajeError("No se ha podido cambiar el estado de la membresía. Ha ocurrido un error genérico.", ex);
            }
        }
        #endregion

        #region Eventos
        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (numSocio != 0)
                {
                    if (!Clases.Membresia.TieneMembresia(numSocio))
                    {
                        if (sexo == 0)
                        {
                            if (PreciosH() == 0)
                            {
                                MessageBox.Show("No tienes precios para hombres configurados. Es necesario configurarlos para asignar una membresía.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        else
                        {
                            if (PreciosM() == 0)
                            {
                                MessageBox.Show("No tienes precios para mujeres configurados. Es necesario configurarlos para asignar una membresía.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        (new frmNuevaMembresia(numSocio, sexo)).ShowDialog(this);
                    }
                    else
                    {
                        if (MessageBox.Show("El socio seleccionado ya tiene una membresía.\n¿Deseas renovarla?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                        {
                            btnEditar.PerformClick();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de conectar con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (numSocio != 0)
                {
                    if (Clases.Membresia.TieneMembresia(numSocio))
                    {
                        if (sexo == 0)
                        {
                            if (PreciosH() == 0)
                            {
                                MessageBox.Show("No tienes precios para hombres configurados. Es necesario configurarlos para asignar una membresía.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        else
                        {
                            if (PreciosM() == 0)
                            {
                                MessageBox.Show("No tienes precios para mujeres configurados. Es necesario configurarlos para asignar una membresía.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        (new frmEditarMembresia(numSocio, sexo)).ShowDialog(this);
                    }
                    else
                    {
                        if (MessageBox.Show("El socio seleccionado no tiene una membresía.\n¿Desea generar una nueva membresía?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                        {
                            btnNuevo.PerformClick();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de conectar con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void frmMembresia_Shown(object sender, EventArgs e)
        {
            txtBusqueda.Focus();
        }
        #endregion

        private void frmMembresia_Load(object sender, EventArgs e)
        {
            if (frmMain.nivelUsuario == 3)
                btnPendiente.Visible = true;
            else
                btnPendiente.Visible = false;
        }

        private void dgvPersonas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                numSocio = int.Parse(dgvPersonas[0, e.RowIndex].Value.ToString());
                sexo = (int)dgvPersonas[5, e.RowIndex].Value;
            }
            catch
            {
            }
        }

        private void btnPendiente_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.CurrentRow != null)
            {
                if (dgvPersonas[2, dgvPersonas.CurrentRow.Index].Value.ToString() == "Activo")
                {
                    DialogResult r = MessageBox.Show("¿Realmente desea cambiar el estado de la membresía de " + dgvPersonas[1, dgvPersonas.CurrentRow.Index].Value.ToString() + " a pendiente?", "HS FIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r ==DialogResult.Yes)
                    {
                        EstadoPendiente(numSocio.ToString());
                        dgvPersonas[2, dgvPersonas.CurrentRow.Index].Value = "Pendiente";
                    }
                }
                else if (dgvPersonas[2, dgvPersonas.CurrentRow.Index].Value.ToString() == "Rechazada")
                {
                    MessageBox.Show("Para reactivar la membresía de " + dgvPersonas[1, dgvPersonas.CurrentRow.Index].Value.ToString() + " es necesario renovar la membresía");
                }
            }
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            BuscarMiembros(e.Argument.ToString());
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tmrEspera.Enabled = false;
            CFuncionesGenerales.frmEsperaClose();
            System.Threading.Thread.Sleep(300);
            LlenarDataGrid();
            txtBusqueda.Enabled = true;
            CFuncionesGenerales.HabilitarBotonCerrar(this);
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            CFuncionesGenerales.frmEspera("Espere, buscando socios", this);
        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.CurrentRow != null)
            {
                if (MessageBox.Show("¿Deseas reimprimir la membresia del socio: " + numSocio + "?", "HS FIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    ImprimirTicket(numSocio);
                }
            }
        }

        private void ImprimirTicket(int numeroSocio)
        {
            try
            {
                if (Clases.CConfiguracionXML.ExisteConfiguracion("ticket", "imprimir"))
                {
                    if (bool.Parse(Clases.CConfiguracionXML.LeerConfiguración("ticket", "imprimir")))
                    {
                        if (Clases.CConfiguracionXML.ExisteConfiguracion("ticket", "preguntar"))
                        {
                            if (bool.Parse(Clases.CConfiguracionXML.LeerConfiguración("ticket", "preguntar")))
                            {
                                if (MessageBox.Show("¿Deseas imprimir el ticket de la membresía del socio: " + numeroSocio + "?", "HS FIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    (new Clases.CTicket()).ImprimirTicketMembresia(numeroSocio);
                                    (new Clases.CTicket()).ImprimirTicketMembresia(numeroSocio);
                                }
                            }
                            else
                            {
                                (new Clases.CTicket()).ImprimirTicketMembresia(numeroSocio);
                                (new Clases.CTicket()).ImprimirTicketMembresia(numeroSocio);
                            }
                        }
                        else
                        {
                            (new Clases.CTicket()).ImprimirTicketMembresia(numeroSocio);
                            (new Clases.CTicket()).ImprimirTicketMembresia(numeroSocio);
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
                Clases.CFuncionesGenerales.MensajeError("La ruta del directorio es muy larga.", ex);
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("El directorio del archivo de configuración no se encontró.", ex);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("No se encontro el archivo de configuración.", ex);
            }
            catch (System.IO.IOException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un error de E/S.", ex);
            }
            catch (InvalidOperationException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("La llamada al método no se pudo efectuar porque el estado actual del objeto no lo permite.", ex);
            }
            catch (NotSupportedException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("No se pudo leer o modificar la secuencia de datos.", ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("El sistema ha negado el acceso al archivo de configuración.\nPuede deberse a un error de E/S o a un error de seguridad.", ex);
            }
            catch (System.Security.SecurityException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un error de seguridad.", ex);
            }
            catch (ArgumentNullException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("El método no acepta referencias nulas.", ex);
            }
            catch (ArgumentException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("El argumento que se pasó al método no es aceptado por este.", ex);
            }
            catch (Exception ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }


        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!bgwBusqueda.IsBusy)
                {
                    txtBusqueda.Enabled = false;
                    CFuncionesGenerales.DeshabilitarBotonCerrar(this);
                    tmrEspera.Enabled = true;
                    bgwBusqueda.RunWorkerAsync(txtBusqueda.Text);
                }
            }
        }
    }
}

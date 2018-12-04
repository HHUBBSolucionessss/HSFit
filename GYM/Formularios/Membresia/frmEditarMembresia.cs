using GYM.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GYM.Formularios.Membresia
{
    public partial class frmEditarMembresia : Form
    {
        Dictionary<int, decimal> preciosM = new Dictionary<int, decimal>();
        Dictionary<int, string> descripcionM = new Dictionary<int, string>();
        int numSocio, sexo, idPromo = -1;
        string ultimoFolio = "";
        DateTime fechaIni, fechaFin;
        Clases.Membresia.EstadoMembresia es;
        Clases.Membresia mem;
        CRegistro_membresias rMem;

        #region Metodos
        public frmEditarMembresia(int numSocio, int sexo)
        {
            InitializeComponent();
            CFuncionesGenerales.CargarInterfaz(this);
            this.numSocio = numSocio;
            this.sexo = sexo;
            mem = new Clases.Membresia(numSocio);
            rMem = new CRegistro_membresias();
            UltimoFolio();
            ConfigFolio();
            PreciosMembresias();
        }

        private void ConfigFolio()
        {
            if (CConfiguracionXML.ExisteConfiguracion("membresia", "folio"))
            {
                if (bool.Parse(CConfiguracionXML.LeerConfiguración("membresia", "folio")) == true)
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
                string sql = "SELECT MAX(id) AS i FROM registro_membresias";
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
                CFuncionesGenerales.MensajeError("Ocurrió un error al generar el nuevo folio. No se ha podido conectar con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                CFuncionesGenerales.MensajeError("Ocurrió un error al generar el nuevo folio. Ocurrió un error genérico.", ex);
            }
        }

        private void PreciosMembresias()
        {
            try
            {
                string sql = "SELECT id, precio, descripcion FROM precio_membresia WHERE sexo='" + sexo.ToString() + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    preciosM.Add((int)dr["id"], (decimal)dr["precio"]);
                    descripcionM.Add((int)dr["id"], dr["descripcion"].ToString());
                }
            }
            catch (MySqlException ex)
            {
                CFuncionesGenerales.MensajeError("No se ha podido cargar el precio de la duración seleccionada. Ocurrió un error al conectar la base de datos.", ex);
            }
            catch (Exception ex)
            {
                CFuncionesGenerales.MensajeError("No se ha podido cargar el precio de la duración seleccionada. Ocurrió un error genérico.", ex);
            }
        }

        private void MostrarDatosMembresia()
        {
            try
            {
                if (mem.Estado == Clases.Membresia.EstadoMembresia.Activa || mem.Estado == Clases.Membresia.EstadoMembresia.Pendiente)
                {
                    fechaIni = mem.FechaInicio;
                    dtpFechaInicio.Value = mem.FechaInicio;
                    dtpFechaInicio.Enabled = false;

                }
                es = mem.Estado;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                CFuncionesGenerales.MensajeError("El valor dado a superado el rango esperado.", ex);
            }
        }

        private void CargarNombreMiembro()
        {
            try
            {
                string sql = "SELECT nombre, apellidos FROM miembros WHERE numSocio='" + numSocio.ToString() + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                    lblNombreMiembro.Text = dr["nombre"].ToString() + " " + dr["apellidos"].ToString();
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

        public void AsignarPromocion(int duracion, decimal precio, string descripcion)
        {
            btnQuitarPromo.Enabled = true;
            lblPrecio.Text = precio.ToString("C2");
            txtDescripcion.Text = descripcion;
            cbxTipo.SelectedIndex = duracion;
            cbxTipo.Enabled = false;
        }

        private void QuitarPromoción()
        {
            lblPrecio.Text = "$0.00";
            btnQuitarPromo.Enabled = false;
            txtDescripcion.Text = "";
            cbxTipo.Enabled = true;
            cbxTipo.SelectedIndex = -1;
        }

        public void AsignarPromocionHorario(int id, int duracion, decimal precio, string descripcion)
        {
            idPromo = id;
            lblPrecio.Text = precio.ToString("C2");
            btnQuitarPromo.Enabled = true;
            txtDescripcion.Text = descripcion;
            cbxTipo.SelectedIndex = duracion;
            cbxTipo.Enabled = false;
        }

        private void QuitarPromocionHorario()
        {
            idPromo = -1;
            lblPrecio.Text = "$0.00";
            btnQuitarPromo.Enabled = false;
            txtDescripcion.Text = "";
            cbxTipo.Enabled = true;
            cbxTipo.SelectedIndex = -1;
        }

        private string ObtenerNombreUsuario(int idUsuario)
        {
            string valor = "Sin información.";
            try
            {
                string sql = "SELECT userName FROM usuarios WHERE id='" + idUsuario.ToString() + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                    valor = dr["userName"].ToString();
            }
            catch (MySqlException ex)
            {
                CFuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de conectar con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                CFuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
            return valor;
        }

        private bool ValidarDatos()
        {
            if (cbxTipo.SelectedIndex < 0)
            {
                MessageBox.Show("Debes seleccionar un tipo de membresía", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (cbxTipoPago.SelectedIndex < 0)
            {
                MessageBox.Show("Debes seleccionar un tipo de pago", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxTipoPago.Focus();
                return false;
            }
            if (lblPrecio.Text == "$0.00")
            {
                MessageBox.Show("Debes ingresar el precio que pagará el miembro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtFolio.Text == "")
            {
                MessageBox.Show("Debes ingresar el folio de remisión", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtTerminacion.Text == "" && cbxTipoPago.SelectedIndex == 1)
            {
                MessageBox.Show("Debes ingresar una terminacion de tarjeta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTerminacion.Focus();
                return false;
            }
            if (txtFolioTicket.Text == "" && cbxTipoPago.SelectedIndex == 1)
            {
                MessageBox.Show("Debes ingresar el folio del ticket de pago", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFolioTicket.Focus();
                return false;
            }
            if (cbxTipoPago.SelectedIndex==2)
            {
                ;

                if (decimal.Parse(txtEfectivo.Text) + decimal.Parse(txtTarjeta.Text) < decimal.Parse(lblPrecio.Text, System.Globalization.NumberStyles.Currency))
                {
                    MessageBox.Show("El monto en efectivo más el monto en tarjeta debe de ser igual al precio de la membresia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                
            }
            return true;
        }

        private void AgregarMovimientoCaja()
        {
            decimal ef= 0, ta = 0;
            try
            {
                if (cbxTipoPago.SelectedIndex == 0)
                    ef = decimal.Parse(lblPrecio.Text, System.Globalization.NumberStyles.Currency);
                else if (cbxTipoPago.SelectedIndex == 1)
                {
                    ta = decimal.Parse(lblPrecio.Text, System.Globalization.NumberStyles.Currency);
                }
                else
                {
                    ef = decimal.Parse(txtEfectivo.Text);
                    ta = decimal.Parse(txtTarjeta.Text);
                }
                    
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO caja (id_membresia, efectivo, tarjeta, tipo_movimiento, fecha, descripcion, create_user_id, create_time) VALUES (?, ?, ?, ?, ?, ?, ?, NOW())";
                sql.Parameters.AddWithValue("@id_membresia", rMem.IDMembresia);
                sql.Parameters.AddWithValue("@efectivo", ef);
                sql.Parameters.AddWithValue("@tarjeta", ta);
                sql.Parameters.AddWithValue("@tipo_movimiento", 0);
                sql.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                sql.Parameters.AddWithValue("@descripcion", "RENOVACIÓN DE MEMBRESÍA CON FOLIO "+txtFolio.Text +" AL SOCIO "+lblNombreMiembro.Text);
                sql.Parameters.AddWithValue("@create_user_id", frmMain.id);
                ConexionBD.EjecutarConsulta(sql);
            }
            catch (MySqlException ex)
            {
                CFuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de conectar con la base de datos.", ex);
            }
            catch (FormatException ex)
            {
                CFuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de dar formato a una variable.", ex);
            }
            catch (OverflowException ex)
            {
                CFuncionesGenerales.MensajeError("Ha ocurrido un desbordamiento.", ex);
            }
            catch (ArgumentNullException ex)
            {
                CFuncionesGenerales.MensajeError("Algún método llamado en AgregarMovimientoCaja no admite argumentos nulos.", ex);
            }
            catch (Exception ex)
            {
                CFuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void ImprimirTicket()
        {
            try
            {
                if (CConfiguracionXML.ExisteConfiguracion("ticket", "imprimir"))
                {
                    if (bool.Parse(CConfiguracionXML.LeerConfiguración("ticket", "imprimir")))
                    {
                        if (CConfiguracionXML.ExisteConfiguracion("ticket", "preguntar"))
                        {
                            if (bool.Parse(CConfiguracionXML.LeerConfiguración("ticket", "preguntar")))
                            {
                                if (MessageBox.Show("¿Deseas imprimir el ticket de la membresía?", "HS FIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    (new CTicket()).ImprimirTicketMembresia(numSocio);
                                   (new  CTicket()).ImprimirTicketMembresia(numSocio);
                                }
                            }
                            else
                            {
                                (new CTicket()).ImprimirTicketMembresia(numSocio);
                               (new CTicket()).ImprimirTicketMembresia(numSocio);
                            }
                        }
                        else
                        {
                            (new CTicket()).ImprimirTicketMembresia(numSocio);
                           (new CTicket()).ImprimirTicketMembresia(numSocio);
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
                CFuncionesGenerales.MensajeError("La ruta del directorio es muy larga.", ex);
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                CFuncionesGenerales.MensajeError("El directorio del archivo de configuración no se encontró.", ex);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                CFuncionesGenerales.MensajeError("No se encontro el archivo de configuración.", ex);
            }
            catch (System.IO.IOException ex)
            {
                CFuncionesGenerales.MensajeError("Ha ocurrido un error de E/S.", ex);
            }
            catch (InvalidOperationException ex)
            {
                CFuncionesGenerales.MensajeError("La llamada al método no se pudo efectuar porque el estado actual del objeto no lo permite.", ex);
            }
            catch (NotSupportedException ex)
            {
                CFuncionesGenerales.MensajeError("No se pudo leer o modificar la secuencia de datos.", ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                CFuncionesGenerales.MensajeError("El sistema ha negado el acceso al archivo de configuración.\nPuede deberse a un error de E/S o a un error de seguridad.", ex);
            }
            catch (System.Security.SecurityException ex)
            {
                CFuncionesGenerales.MensajeError("Ha ocurrido un error de seguridad.", ex);
            }
            catch (ArgumentNullException ex)
            {
                CFuncionesGenerales.MensajeError("El método no acepta referencias nulas.", ex);
            }
            catch (ArgumentException ex)
            {
                CFuncionesGenerales.MensajeError("El argumento que se pasó al método no es aceptado por este.", ex);
            }
            catch (Exception ex)
            {
                CFuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }
        #endregion

        #region Eventos
        private void frmEditarMembresia_Load(object sender, EventArgs e)
        {
            try
            {
                pcbSocio.Image = global::Socio.ObtenerImagenSocio(numSocio);              
                mem.ObtenerDatosMiembro();
                MostrarDatosMembresia();
                CargarNombreMiembro();
                Clases.Membresia.EstadoMembresia es = Clases.Membresia.EstadoActualMembresia(numSocio);
                if (es == Clases.Membresia.EstadoMembresia.Inactiva || es == Clases.Membresia.EstadoMembresia.Rechazada)
                    dtpFechaInicio.Enabled = true;
            }
            catch (MySqlException ex)
            {
                CFuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de conectar con la base de datos.", ex);
            }
            catch (InvalidCastException ex)
            {
                CFuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de realizar la conversión de una variable.", ex);
            }
            catch (FormatException ex)
            {
                CFuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de dar formato a una variable.", ex);
            }
            catch (OverflowException ex)
            {
                CFuncionesGenerales.MensajeError("Ha ocurrido un desbordamiento.", ex);
            }
            catch (ArgumentNullException ex)
            {
                CFuncionesGenerales.MensajeError("Algún método llamado en el evento Load no admite argumentos nulos.", ex);
            }
            catch (Exception ex)
            {
                CFuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Clases.Caja.EstadoCaja())
                {
                    if (ValidarDatos())
                    {

                        mem.Estado = Clases.Membresia.EstadoMembresia.Pendiente;
                        mem.IDPromocion = idPromo;
                        mem.FechaFin = fechaFin;
                        mem.FechaInicio = dtpFechaInicio.Value;
                        mem.UpdateUser = frmMain.id;
                        rMem.CreateUser = frmMain.id;
                        rMem.Precio = decimal.Parse(lblPrecio.Text, System.Globalization.NumberStyles.Currency);
                        rMem.IDMembresia = mem.IDMembresia;
                        rMem.Descripcion = txtDescripcion.Text;
                        rMem.FechaFin = fechaFin;
                        rMem.FechaInicio = dtpFechaInicio.Value;
                        rMem.FolioRemision = txtFolio.Text;
                        rMem.Tipo = cbxTipoPago.SelectedIndex + 1;
                        if (txtTerminacion.Text.Trim() != "")
                            rMem.Terminacion = txtTerminacion.Text;
                        else
                            rMem.Terminacion = "0";
                        if (txtFolioTicket.Text.Trim() != "")
                            rMem.FolioTicket = txtFolioTicket.Text;
                        else
                            rMem.FolioTicket = "0";
                        mem.EditarMembresia();
                        rMem.InsertarRegistroMembresias();
                        AgregarMovimientoCaja();
                        MessageBox.Show("Membresía renovada", "Membresías", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ImprimirTicket();
                        global::Socio.ObtenerHuellas();
                        Close();
                    }
                }
                else
                {
                    if (MessageBox.Show("No puedes realizar operaciones de venta si la caja esta cerrada.\n¿Deseas abrirla?", "HS FIT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    {
                        (new Caja.frmAperturaCaja()).ShowDialog(this);
                        btnAceptar.PerformClick();
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
               CFuncionesGenerales.MensajeError("La ruta del directorio es muy larga.", ex);
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                CFuncionesGenerales.MensajeError("El directorio del archivo de configuración no se encontró.", ex);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                CFuncionesGenerales.MensajeError("No se encontro el archivo de configuración.", ex);
            }
            catch (System.IO.IOException ex)
            {
                CFuncionesGenerales.MensajeError("Ha ocurrido un error de E/S.", ex);
            }
            catch (InvalidOperationException ex)
            {
                CFuncionesGenerales.MensajeError("La llamada al método no se pudo efectuar porque el estado actual del objeto no lo permite.", ex);
            }
            catch (NotSupportedException ex)
            {
                CFuncionesGenerales.MensajeError("No se pudo leer o modificar la secuencia de datos.", ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                CFuncionesGenerales.MensajeError("El sistema ha negado el acceso al archivo de configuración.\nPuede deberse a un error de E/S o a un error de seguridad.", ex);
            }
            catch (System.Security.SecurityException ex)
            {
                CFuncionesGenerales.MensajeError("Ha ocurrido un error de seguridad.", ex);
            }
            catch (ArgumentNullException ex)
            {
                CFuncionesGenerales.MensajeError("El método no acepta referencias nulas.", ex);
            }
            catch (ArgumentException ex)
            {
                CFuncionesGenerales.MensajeError("El argumento que se pasó al método no es aceptado por este.", ex);
            }
            catch (Exception ex)
            {
                CFuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipo.SelectedIndex == -1 || btnQuitarPromo.Enabled == true)
            {
                dtpFechaInicio_ValueChanged(dtpFechaInicio, new EventArgs());
                return;
            }
            if (preciosM.ContainsKey(cbxTipo.SelectedIndex))
            {
                Fechas(dtpFechaInicio.Enabled);
            }
            else
            {
                MessageBox.Show("El precio de esa duración no ha sido configurado.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                for (int i = 0; i < cbxTipo.Items.Count; i++)
                {
                    if (preciosM.ContainsKey(i))
                    {
                        cbxTipo.SelectedIndex = i;
                        break;
                    }
                }
            }
            lblPrecio.Text = preciosM[cbxTipo.SelectedIndex].ToString("C2");
            txtDescripcion.Text = descripcionM[cbxTipo.SelectedIndex];  
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            Fechas(dtpFechaInicio.Enabled);
            
        }

        private void Fechas(bool noEsMembresiaActiva)
        {
            if (noEsMembresiaActiva)
            {
                switch (cbxTipo.SelectedIndex)
                {
                    case 0:
                        fechaFin = dtpFechaInicio.Value.AddDays(7);
                        lblFechaFin.Text = dtpFechaInicio.Value.AddDays(7).ToString("dd") + " de " + dtpFechaInicio.Value.AddDays(7).ToString("MMMM") + " del " + dtpFechaInicio.Value.AddDays(7).ToString("yyyy");
                        break;
                    case 1:
                        fechaFin = dtpFechaInicio.Value.AddMonths(1);
                        lblFechaFin.Text = dtpFechaInicio.Value.AddMonths(1).ToString("dd") + " de " + dtpFechaInicio.Value.AddMonths(1).ToString("MMMM") + " del " + dtpFechaInicio.Value.AddMonths(1).ToString("yyyy");
                        break;
                    case 2:
                        fechaFin = dtpFechaInicio.Value.AddMonths(2);
                        lblFechaFin.Text = dtpFechaInicio.Value.AddMonths(2).ToString("dd") + " de " + dtpFechaInicio.Value.AddMonths(2).ToString("MMMM") + " del " + dtpFechaInicio.Value.AddMonths(2).ToString("yyyy");
                        break;
                    case 3:
                        fechaFin = dtpFechaInicio.Value.AddMonths(3);
                        lblFechaFin.Text = dtpFechaInicio.Value.AddMonths(3).ToString("dd") + " de " + dtpFechaInicio.Value.AddMonths(3).ToString("MMMM") + " del " + dtpFechaInicio.Value.AddMonths(3).ToString("yyyy");
                        break;
                    case 4:
                        fechaFin = dtpFechaInicio.Value.AddMonths(4);
                        lblFechaFin.Text = dtpFechaInicio.Value.AddMonths(4).ToString("dd") + " de " + dtpFechaInicio.Value.AddMonths(4).ToString("MMMM") + " del " + dtpFechaInicio.Value.AddMonths(4).ToString("yyyy");
                        break;
                    case 5:
                        fechaFin = dtpFechaInicio.Value.AddMonths(5);
                        lblFechaFin.Text = dtpFechaInicio.Value.AddMonths(5).ToString("dd") + " de " + dtpFechaInicio.Value.AddMonths(5).ToString("MMMM") + " del " + dtpFechaInicio.Value.AddMonths(5).ToString("yyyy");
                        break;
                    case 6:
                        fechaFin = dtpFechaInicio.Value.AddMonths(6);
                        lblFechaFin.Text = dtpFechaInicio.Value.AddMonths(6).ToString("dd") + " de " + dtpFechaInicio.Value.AddMonths(6).ToString("MMMM") + " del " + dtpFechaInicio.Value.AddMonths(6).ToString("yyyy");
                        break;
                    case 7:
                        fechaFin = dtpFechaInicio.Value.AddMonths(7);
                        lblFechaFin.Text = dtpFechaInicio.Value.AddMonths(7).ToString("dd") + " de " + dtpFechaInicio.Value.AddMonths(7).ToString("MMMM") + " del " + dtpFechaInicio.Value.AddMonths(7).ToString("yyyy");
                        break;
                    case 8:
                        fechaFin = dtpFechaInicio.Value.AddMonths(8);
                        lblFechaFin.Text = dtpFechaInicio.Value.AddMonths(8).ToString("dd") + " de " + dtpFechaInicio.Value.AddMonths(8).ToString("MMMM") + " del " + dtpFechaInicio.Value.AddMonths(8).ToString("yyyy");
                        break;
                    case 9:
                        fechaFin = dtpFechaInicio.Value.AddMonths(9);
                        lblFechaFin.Text = dtpFechaInicio.Value.AddMonths(9).ToString("dd") + " de " + dtpFechaInicio.Value.AddMonths(9).ToString("MMMM") + " del " + dtpFechaInicio.Value.AddMonths(9).ToString("yyyy");
                        break;
                    case 10:
                        fechaFin = dtpFechaInicio.Value.AddMonths(10);
                        lblFechaFin.Text = dtpFechaInicio.Value.AddMonths(10).ToString("dd") + " de " + dtpFechaInicio.Value.AddMonths(10).ToString("MMMM") + " del " + dtpFechaInicio.Value.AddMonths(10).ToString("yyyy");
                        break;
                    case 11:
                        fechaFin = dtpFechaInicio.Value.AddMonths(11);
                        lblFechaFin.Text = dtpFechaInicio.Value.AddMonths(11).ToString("dd") + " de " + dtpFechaInicio.Value.AddMonths(11).ToString("MMMM") + " del " + dtpFechaInicio.Value.AddMonths(11).ToString("yyyy");
                        break;
                    case 12:
                        fechaFin = dtpFechaInicio.Value.AddYears(1);
                        lblFechaFin.Text = dtpFechaInicio.Value.AddYears(1).ToString("dd") + " de " + dtpFechaInicio.Value.AddYears(1).ToString("MMMM") + " del " + dtpFechaInicio.Value.AddYears(1).ToString("yyyy");
                        break;
                    default:
                        fechaFin = new DateTime();
                        lblFechaFin.Text = "";
                        break;
                }
            }
            else
            {
                switch (cbxTipo.SelectedIndex)
                {
                    case 0:
                        fechaFin = mem.FechaFin.AddDays(7);
                        lblFechaFin.Text = mem.FechaFin.AddDays(7).ToString("dd") + " de " + mem.FechaFin.AddDays(7).ToString("MMMM") + " del " + mem.FechaFin.AddDays(7).ToString("yyyy");
                        break;
                    case 1:
                        fechaFin = mem.FechaFin.AddMonths(1);
                        lblFechaFin.Text = mem.FechaFin.AddMonths(1).ToString("dd") + " de " + mem.FechaFin.AddMonths(1).ToString("MMMM") + " del " + mem.FechaFin.AddMonths(1).ToString("yyyy");
                        break;
                    case 2:
                        fechaFin = mem.FechaFin.AddMonths(2);
                        lblFechaFin.Text = mem.FechaFin.AddMonths(2).ToString("dd") + " de " + mem.FechaFin.AddMonths(2).ToString("MMMM") + " del " + mem.FechaFin.AddMonths(2).ToString("yyyy");
                        break;
                    case 3:
                        fechaFin = mem.FechaFin.AddMonths(3);
                        lblFechaFin.Text = mem.FechaFin.AddMonths(3).ToString("dd") + " de " + mem.FechaFin.AddMonths(3).ToString("MMMM") + " del " + mem.FechaFin.AddMonths(3).ToString("yyyy");
                        break;
                    case 4:
                        fechaFin = mem.FechaFin.AddMonths(4);
                        lblFechaFin.Text = mem.FechaFin.AddMonths(4).ToString("dd") + " de " + mem.FechaFin.AddMonths(4).ToString("MMMM") + " del " + mem.FechaFin.AddMonths(4).ToString("yyyy");
                        break;
                    case 5:
                        fechaFin = mem.FechaFin.AddMonths(5);
                        lblFechaFin.Text = mem.FechaFin.AddMonths(5).ToString("dd") + " de " + mem.FechaFin.AddMonths(5).ToString("MMMM") + " del " + mem.FechaFin.AddMonths(5).ToString("yyyy");
                        break;
                    case 6:
                        fechaFin = mem.FechaFin.AddMonths(6);
                        lblFechaFin.Text = mem.FechaFin.AddMonths(6).ToString("dd") + " de " + mem.FechaFin.AddMonths(6).ToString("MMMM") + " del " + mem.FechaFin.AddMonths(6).ToString("yyyy");
                        break;
                    case 7:
                        fechaFin = mem.FechaFin.AddMonths(7);
                        lblFechaFin.Text = mem.FechaFin.AddMonths(7).ToString("dd") + " de " + mem.FechaFin.AddMonths(7).ToString("MMMM") + " del " + mem.FechaFin.AddMonths(7).ToString("yyyy");
                        break;
                    case 8:
                        fechaFin = mem.FechaFin.AddMonths(8);
                        lblFechaFin.Text = mem.FechaFin.AddMonths(8).ToString("dd") + " de " + mem.FechaFin.AddMonths(8).ToString("MMMM") + " del " + mem.FechaFin.AddMonths(8).ToString("yyyy");
                        break;
                    case 9:
                        fechaFin = mem.FechaFin.AddMonths(9);
                        lblFechaFin.Text = mem.FechaFin.AddMonths(9).ToString("dd") + " de " + mem.FechaFin.AddMonths(9).ToString("MMMM") + " del " + mem.FechaFin.AddMonths(9).ToString("yyyy");
                        break;
                    case 10:
                        fechaFin = mem.FechaFin.AddMonths(10);
                        lblFechaFin.Text = mem.FechaFin.AddMonths(10).ToString("dd") + " de " + mem.FechaFin.AddMonths(10).ToString("MMMM") + " del " + mem.FechaFin.AddMonths(10).ToString("yyyy");
                        break;
                    case 11:
                        fechaFin = mem.FechaFin.AddMonths(11);
                        lblFechaFin.Text = mem.FechaFin.AddMonths(11).ToString("dd") + " de " + mem.FechaFin.AddMonths(11).ToString("MMMM") + " del " + mem.FechaFin.AddMonths(11).ToString("yyyy");
                        break;
                    case 12:
                        fechaFin = mem.FechaFin.AddYears(1);
                        lblFechaFin.Text = mem.FechaFin.AddYears(1).ToString("dd") + " de " + mem.FechaFin.AddYears(1).ToString("MMMM") + " del " + mem.FechaFin.AddYears(1).ToString("yyyy");
                        break;
                    default:
                        fechaFin = new DateTime();
                        lblFechaFin.Text = "";
                        break;
                }
            }
        }

        private void cbxTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoPago.SelectedIndex == 0)
            {
                txtTerminacion.Enabled = false;
                txtFolioTicket.Enabled = false;
                lblEfectivo.Visible = false;
                lblTarjeta.Visible = false;
                txtTarjeta.Visible = false;
                txtEfectivo.Visible = false;
                txtEfectivo.Text = "";
                txtTarjeta.Text = "";
            }
            else if (cbxTipoPago.SelectedIndex == 1)
            {
                txtFolioTicket.Enabled = true;
                txtTerminacion.Enabled = true;
                lblEfectivo.Visible = false;
                lblTarjeta.Visible = false;
                txtTarjeta.Visible = false;
                txtEfectivo.Visible = false;
                txtEfectivo.Text = "";
                txtTarjeta.Text = "";
            }
            else
            {
                txtFolioTicket.Enabled = true;
                txtTerminacion.Enabled = true;
                lblEfectivo.Visible = true;
                lblTarjeta.Visible = true;
                txtTarjeta.Visible = true;
                txtEfectivo.Visible = true;

            }
        } 
        #endregion    

        private void btnAsignarPromo_Click(object sender, EventArgs e)
        {
            (new frmAsignarPromo(this, sexo)).ShowDialog(this);
        }

        private void btnQuitarPromo_Click(object sender, EventArgs e)
        {
            QuitarPromoción();
        }

        private void frmEditarMembresia_KeyPress(object sender, KeyPressEventArgs e)
        {
            CFuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM.Formularios.POS
{
    public partial class frmReimprimirVenta : Form
    {

        int folio;
        DataTable dt = new DataTable();
        public frmReimprimirVenta()
        {
            InitializeComponent();

        }


        private void BuscarVentaFolio(string folio)
        {
            try
            {
                int fol;
                int.TryParse(folio, out fol);
                string sql = "SELECT id, fecha, total, estado, abierta FROM venta WHERE id='" + fol.ToString() + "' AND abierta=0";
                dt = Clases.ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de buscar la venta.", ex);
            }
            catch (Exception ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void BuscarVentaFechas(DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                MySql.Data.MySqlClient.MySqlCommand sql = new MySql.Data.MySqlClient.MySqlCommand();
                sql.CommandText = "SELECT id, fecha, total, estado, abierta FROM venta WHERE (fecha BETWEEN ? AND ?) AND abierta=0";
                //Recuerda que en cualquier gestor de base de datos, las fechas van en orden yyyy-MM-dd,
                //y así te quitas muchos pedos Chava u.u
                sql.Parameters.AddWithValue("@fechaIni", fechaIni.ToString("yyyy-MM-dd") + " 00:00:00");
                sql.Parameters.AddWithValue("@fechaFin", fechaFin.ToString("yyyy-MM-dd") + " 23:59:59");
                dt = Clases.ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de buscar la venta.", ex);
            }
            catch (Exception ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }


        private void LlenarDataGrid()
        {
            try
            {
                folio = 0;
                dgvVentas.Rows.Clear();
                string estaAbierta = "";
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["estado"].ToString() == "1")
                        estaAbierta = "Normal";
                    else
                        estaAbierta = "Cancelada";
                    dgvVentas.Rows.Add(new object[] { int.Parse(dr["id"].ToString()).ToString("00000000"), DateTime.Parse(dr["fecha"].ToString()), decimal.Parse(dr["total"].ToString()), estaAbierta });
                    if (dr["estado"].ToString() == "0")
                    {
                        dgvVentas.Rows[dgvVentas.RowCount - 1].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                        dgvVentas.Rows[dgvVentas.RowCount - 1].DefaultCellStyle.ForeColor = Color.FromArgb(150, 0, 0);
                        dgvVentas.Rows[dgvVentas.RowCount - 1].DefaultCellStyle.SelectionBackColor = Color.FromArgb(150, 0, 0);
                        dgvVentas.Rows[dgvVentas.RowCount - 1].DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                    }
                }
            }
            catch (FormatException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de dar formato a una variable.", ex);
            }
            catch (OverflowException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un desbordamiento.", ex);
            }
            catch (ArgumentNullException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Algún método invocado en LlenarDataGrid no admite argumentos nulos.", ex);
            }
            catch (Exception ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }


        private void ImprimirTicket(int folioTicket)
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
                                if (MessageBox.Show("¿Deseas imprimir el ticket de esta venta?", "HS FIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    (new Clases.CTicket()).ImprimirTicketVenta(folioTicket);
                                }
                            }
                            else
                            {
                                (new Clases.CTicket()).ImprimirTicketVenta(folioTicket);                              
                            }
                        }
                        else
                        {
                            (new Clases.CTicket()).ImprimirTicketVenta(folioTicket);
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

        private void txtFolio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!bgwBusqueda.IsBusy)
                {
                    tmrEspera.Enabled = true;
                    txtFolio.Enabled = false;
                    btnBuscar.Enabled = false;
                    GYM.Clases.CFuncionesGenerales.DeshabilitarBotonCerrar(this);
                    bgwBusqueda.RunWorkerAsync(new object[] { txtFolio.Text });
                }
            }
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            Array a = (Array)e.Argument;
            switch (a.Length)
            {
                case 1:
                    BuscarVentaFolio(a.GetValue(0).ToString());
                    break;
                case 2:
                    BuscarVentaFechas((DateTime)a.GetValue(0), (DateTime)a.GetValue(1));
                    break;
            }
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            GYM.Clases.CFuncionesGenerales.HabilitarBotonCerrar(this);
            btnBuscar.Enabled = true;
            txtFolio.Enabled = true;
            tmrEspera.Enabled = false;
            GYM.Clases.CFuncionesGenerales.frmEsperaClose();
            LlenarDataGrid();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            GYM.Clases.CFuncionesGenerales.frmEspera("Espere, buscando ventas", this);
        }

        private void dgvVentas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                folio = int.Parse(dgvVentas[0, e.RowIndex].Value.ToString());
            }
            catch (FormatException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("No se pudo convertir el valor del folio a int. El formato no es correcto.", ex);
            }
            catch (OverflowException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("No se pudo convertir el valor del folio a int. Ha ocurrido un desbordamiento.", ex);
            }
            catch (ArgumentNullException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("No se pudo convertir el valor del folio a int. El argumento dado es nulo.", ex);
            }
            catch (Exception ex)
            {
                Clases.CFuncionesGenerales.MensajeError("No se pudo convertir el valor del folio a int. Ha ocurrido un error genérico.", ex);
            }
        }

        private void dtpFechas_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtpFechaInicio.Value > dtpFechaFin.Value)
                    dtpFechaInicio.Value = dtpFechaFin.Value.AddDays(-1);
                if (dtpFechaFin.Value < dtpFechaInicio.Value)
                    dtpFechaFin.Value = dtpFechaInicio.Value.AddDays(1);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("La fecha ingresada se ha salido del rango admitido.", ex);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                if (MessageBox.Show("¿Deseas reimprimir la venta con folio: "+folio+"?", "HS FIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    ImprimirTicket(folio);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!bgwBusqueda.IsBusy)
            {
                tmrEspera.Enabled = true;
                btnBuscar.Enabled = false;
                txtFolio.Enabled = false;
                GYM.Clases.CFuncionesGenerales.DeshabilitarBotonCerrar(this);
                bgwBusqueda.RunWorkerAsync(new object[] { dtpFechaInicio.Value, dtpFechaFin.Value });
            }
        }

        private void frmReimprimirVenta_Load(object sender, EventArgs e)
        {
            try
            {
                Clases.CFuncionesGenerales.CargarInterfaz(this);
                BuscarVentaFechas(DateTime.Now, DateTime.Now);
            }
            catch (Exception ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

    }
}

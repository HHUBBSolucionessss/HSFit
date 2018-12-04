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

namespace GYM.Formularios.Reportes
{
    public partial class frmNuevosSocios : Form
    {
        DataTable dt;
        delegate void Mensajes(string mensaje);

        #region Instancia
        private static frmNuevosSocios frmInstancia;
        public static frmNuevosSocios Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmNuevosSocios();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmNuevosSocios();
                return frmInstancia;

            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion
   
        public frmNuevosSocios()
        {
            InitializeComponent();

        }
        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!bgwBusqueda.IsBusy)
            {
                tmrConteo.Enabled = true;
                btnBuscar.Enabled = false;
                CFuncionesGenerales.DeshabilitarBotonCerrar(this);
                bgwBusqueda.RunWorkerAsync(new object[] { dtpFechaInicio.Value, dtpFechaFin.Value });
            }

        }

        private void tmrConteo_Tick(object sender, EventArgs e)
        {
            tmrConteo.Enabled = false;
            CFuncionesGenerales.frmEspera("Espere, búscando socios...", this);
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tmrConteo.Enabled = false;
            CFuncionesGenerales.frmEsperaClose();
            LlenarDataGrid();
            CFuncionesGenerales.HabilitarBotonCerrar(this);
            btnBuscar.Enabled = true;
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] a = (object[])e.Argument;
            BuscarMembresias((DateTime)a[0],(DateTime)a[1]);
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvPersonas.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dgvPersonas.Rows.Add(new object[] { dr["numSocio"], dr["descripcion"].ToString(), (decimal)dr["precio"], (DateTime)dr["create_time"], (DateTime)dr["fecha_ini"], (DateTime)dr["fecha_fin"], CFuncionesGenerales.NombreUsuario(dr["create_user_id"].ToString())});
                    Application.DoEvents();
                }
            }
            catch (Exception ex)
            {
                CFuncionesGenerales.MensajeError("No se ha podido mostrar la información. ", ex);
            }
        }
        private void BuscarMembresias(DateTime fechaIni, DateTime fechaFin)
        {
            Mensajes e = new Mensajes(Mensaje);
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT (SELECT numSocio FROM membresias WHERE id=c.id_membresia) AS numSocio, c.descripcion, rm.precio,rm.create_time,rm.fecha_ini,rm.fecha_fin,rm.create_user_id  FROM caja AS c INNER JOIN registro_membresias as rm ON(c.id_membresia=rm.membresia_id)"+
                                    "WHERE c.create_time BETWEEN ?fechaIni AND ?fechaFin AND c.descripcion LIKE '%NUEVA MEMBRESÍA%'";
                
                
                
                
                //SELECT rm.membresia_id,m.numSocio,rm.fecha_ini,rm.fecha_fin,rm.descripcion,rm.precio,rm.create_time,rm.create_user_id FROM registro_membresias AS rm INNER JOIN membresias AS m ON (rm.membresia_id=m.id)" +
                //                 "WHERE rm.create_time BETWEEN ?fechaIni AND ?fechaFin GROUP BY rm.membresia_id HAVING COUNT(*) = 1 ;";
                sql.Parameters.AddWithValue("?fechaIni", fechaIni.ToString("yyyy/MM/dd") + " 00:00:00");
                sql.Parameters.AddWithValue("?fechaFin", fechaFin.ToString("yyyy/MM/dd") + " 23:59:59");
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException)
            {
                tmrConteo.Enabled = false;
                CFuncionesGenerales.frmEsperaClose();
            }
            catch (Exception)
            {
                tmrConteo.Enabled = false;
                CFuncionesGenerales.frmEsperaClose();
            }
        }
    }
}

using GYM.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace GYM.Formularios.Socio
{
    public partial class frmSocios : Form
    {
        int numSocio = 0;
        DataTable dt = new DataTable();

        #region Instancia
        private static frmSocios frmInstancia;
        public static frmSocios Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmSocios();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmSocios();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        #region Metodos

        private void Imagen(Image img)
        {
            pcbSocio.Image = img;
        }

        public frmSocios()
        {
            InitializeComponent();

        }

        private void BuscarMiembros(string busqueda)
        {
            dgvPersonas.Rows.Clear();
            try
            {
                string sql = "SELECT numSocio, nombre, apellidos, telefono, celular, fecha_nac FROM miembros WHERE numSocio='" + busqueda + "' OR nombre LIKE '%" + busqueda + "%' OR apellidos LIKE '%" + busqueda + "%'";
                dt = ConexionBD.EjecutarConsultaSelect(sql);

            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.MensajeError("Ha ocurrido un error al buscar los socios. No se ha podido conectar a la base de datos.", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.MensajeError("Ha ocurrido un error genérico al buscar los socios. ", ex);
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string tel=null, cel=null, fecha=null;
                    if (dr["telefono"] != DBNull.Value)
                        tel = dr["telefono"].ToString();
                    if (dr["celular"] != DBNull.Value)
                        cel = dr["celular"].ToString();
                    if (dr["telefono"].ToString().Equals("0"))
                        tel = "No especificado";
                    if (dr["celular"].ToString().Equals("0"))
                        cel = "No especificado";
                    if (dr["fecha_nac"] != DBNull.Value)
                        fecha = fecha = DateTime.Parse(dr["fecha_nac"].ToString()).ToString("dd") + " de " + DateTime.Parse(dr["fecha_nac"].ToString()).ToString("MMMM");
                    dgvPersonas.Rows.Add(new object[] { (int)dr["numSocio"], dr["nombre"].ToString() + " " + dr["apellidos"].ToString(), tel, cel, DateTime.Parse(dr["fecha_nac"].ToString()) });
                    Application.DoEvents();
                } 
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        #endregion

        #region Eventos
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            (new frmNuevoSocio()).ShowDialog(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (numSocio != 0)
                (new frmEditarSocio(numSocio)).ShowDialog(this);
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !bgwBusqueda.IsBusy)
            {
                tmrEspera.Enabled = true;
                bgwBusqueda.RunWorkerAsync(txtBusqueda.Text);
                txtBusqueda.Enabled = false;
                FuncionesGenerales.DeshabilitarBotonCerrar(this);
            }
        }
        #endregion


        private void frmMiembros_Load(object sender, EventArgs e)
        {

            FuncionesGenerales.CargarInterfaz(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPersonas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                numSocio = int.Parse(dgvPersonas[0, e.RowIndex].Value.ToString());
            }
            catch
            {
            }
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            BuscarMiembros(e.Argument.ToString());
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
            LlenarDataGrid();
            txtBusqueda.Enabled = true;
            FuncionesGenerales.HabilitarBotonCerrar(this);
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, buscando socios", this);
        }

        private void bgwImagen_DoWork(object sender, DoWorkEventArgs e)
        {
            if (pcbSocio.InvokeRequired)
            {
                try
                {
                    pcbSocio.Image = global::Socio.ObtenerImagenSocio(numSocio);
                }
                catch
                {
                }
            }
        }

        private void dgvPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPersonas.CurrentRow != null)
                if (!bgwImagen.IsBusy)
                    bgwImagen.RunWorkerAsync();
        }
    }
}

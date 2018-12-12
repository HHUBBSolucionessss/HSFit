using GYM.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GYM.Formularios.POS
{
    public partial class frmCancelarVenta : Form
    {
        int folio;
        DataTable dt = new DataTable();

        public frmCancelarVenta()
        {
            InitializeComponent();

        }

        private void CancelarVenta(string folio)
        {
            CambiarColorDataGrid();
            string sql = "UPDATE venta SET estado=0 WHERE id='" + folio + "'";
            Clases.ConexionBD.EjecutarConsulta(sql);
            RegresarInventario(folio);
            RegresarCaja();
        }

        private void RegresarInventario(string folio)
        {
            try
            {
                List<string> prod = new List<string>();
                List<int> cant = new List<int>();
                string sql = "SELECT id_producto, cantidad FROM venta_detallada WHERE id_venta='" + folio + "'";
                DataTable dt = Clases.ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    prod.Add(dr["id_producto"].ToString());
                    cant.Add(Convert.ToInt32(dr["cantidad"]));
                }
                RegresarInventario(prod, cant, folio);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de conectar con la base de datos.", ex);
            }
            catch (FormatException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de dar formato a una variable.", ex);
            }
            catch (InvalidCastException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de convertir una variable.", ex);
            }
            catch (ArgumentNullException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El argumento dado al método es nulo.", ex);
            }
        }

        private void RegresarInventario(List<string> prods, List<int> cants, string folio)
        {
            try
            {
                string sql;
                for (int i = 0; i < prods.Count; i++)
                {
                    sql = "UPDATE venta_detallada SET cantidad=0 WHERE id_producto='" + prods[i] + "' AND id_venta='" + folio + "'";
                    Clases.ConexionBD.EjecutarConsulta(sql);
                    Clases.Producto.AgregarInventarioMostrador(prods[i].ToString(), cants[i]);
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de regresar los productos al inventario.", ex);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
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
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de buscar la venta.", ex);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void BuscarVentaFechas(DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                MySql.Data.MySqlClient.MySqlCommand sql = new MySql.Data.MySqlClient.MySqlCommand();
                sql.CommandText = "SELECT id, fecha, total, estado, abierta FROM venta WHERE (fecha BETWEEN ? AND ?) AND abierta=0";
                //Recuerda que en cualquier gestor de base de datos, las fechas van en orden yyyy-MM-dd,
                sql.Parameters.AddWithValue("@fechaIni", fechaIni.ToString("yyyy-MM-dd") + " 00:00:00");
                sql.Parameters.AddWithValue("@fechaFin", fechaFin.ToString("yyyy-MM-dd") + " 23:59:59");
                dt = Clases.ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de buscar la venta.", ex);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void CambiarColorDataGrid()
        {
            dgvVentas.Rows[dgvVentas.CurrentRow.Index].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvVentas.Rows[dgvVentas.CurrentRow.Index].DefaultCellStyle.ForeColor = Color.FromArgb(150, 0, 0);
            dgvVentas.Rows[dgvVentas.CurrentRow.Index].DefaultCellStyle.SelectionBackColor = Color.FromArgb(150, 0, 0);
            dgvVentas.Rows[dgvVentas.CurrentRow.Index].DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvVentas[3, dgvVentas.CurrentRow.Index].Value = "Cancelada";
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
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al tratar de dar formato a una variable.", ex);
            }
            catch (OverflowException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un desbordamiento.", ex);
            }
            catch (ArgumentNullException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Algún método invocado en LlenarDataGrid no admite argumentos nulos.", ex);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
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
                    FuncionesGenerales.DeshabilitarBotonCerrar(this);
                    bgwBusqueda.RunWorkerAsync(new object[] { txtFolio.Text });
                }
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
                Clases.FuncionesGenerales.MensajeError("La fecha ingresada se ha salido del rango admitido.", ex);
            }
        }

        private void frmCancelarVenta_Load(object sender, EventArgs e)
        {
            try
            {
                Clases.FuncionesGenerales.CargarInterfaz(this);
                BuscarVentaFechas(DateTime.Now, DateTime.Now);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                if (dgvVentas.CurrentRow.Cells["Estado"].Value.ToString() != "Cancelada")
                {
                    if (MessageBox.Show("¿Realmente deseas cancelar la venta con folio " + folio + "?", "HS FIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {
                        CancelarVenta(folio.ToString());
                    }
                }
            }
        }

        private void RegresarCaja()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM venta WHERE id=?id";
                sql.Parameters.AddWithValue("?id", folio);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    sql.Parameters.Clear();
                    sql.CommandText = "INSERT INTO caja (efectivo, tarjeta, tipo_movimiento, fecha, descripcion, create_user_id, create_time) " +
                        "VALUES (?efectivo, ?tarjeta, ?tipo_movimiento, NOW(), ?descripcion, ?create_user_id, NOW())";
                    if (dr["tipo_pago"].ToString() == "0")
                    {
                        sql.Parameters.AddWithValue("?efectivo", decimal.Parse(dr["total_efectivo"].ToString()) * -1);
                        sql.Parameters.AddWithValue("?tarjeta", 0);
                    }
                    else if (dr["tipo_pago"].ToString() == "1")
                    {
                        sql.Parameters.AddWithValue("?efectivo", 0);
                        sql.Parameters.AddWithValue("?tarjeta", decimal.Parse(dr["total_tarjeta"].ToString()) * -1);
                    }
                    else if (dr["tipo_pago"].ToString() == "2")
                    {
                        sql.Parameters.AddWithValue("?efectivo", decimal.Parse(dr["total_efectivo"].ToString()) * -1);
                        sql.Parameters.AddWithValue("?tarjeta", decimal.Parse(dr["total_tarjeta"].ToString()) * -1);
                    }
                    else
                    {
                        sql.Parameters.AddWithValue("?efectivo", decimal.Parse(dr["total"].ToString()) * -1);
                        sql.Parameters.AddWithValue("?tarjeta", decimal.Parse(dr["total"].ToString()) * -1);
                    }
                    sql.Parameters.AddWithValue("?tipo_movimiento", 1);
                    sql.Parameters.AddWithValue("?descripcion", "SE HA CANCELADO LA VENTA CON FOLIO: " + folio);
                    sql.Parameters.AddWithValue("?create_user_id", frmMain.id);
                    ConexionBD.EjecutarConsulta(sql);
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.MensajeError("No se ha registrado el movimiento en caja. Ocurrió un error al conectar con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.MensajeError("No se ha registrado el movimiento en caja. Ocurrió un error genérico.", ex);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvVentas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                folio = int.Parse(dgvVentas[0, e.RowIndex].Value.ToString());
            }
            catch (FormatException ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se pudo convertir el valor del folio a int. El formato no es correcto.", ex);
            }
            catch (OverflowException ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se pudo convertir el valor del folio a int. Ha ocurrido un desbordamiento.", ex);
            }
            catch (ArgumentNullException ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se pudo convertir el valor del folio a int. El argumento dado es nulo.", ex);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se pudo convertir el valor del folio a int. Ha ocurrido un error genérico.", ex);
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
            FuncionesGenerales.HabilitarBotonCerrar(this);
            btnBuscar.Enabled = true;
            txtFolio.Enabled = true;
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
            LlenarDataGrid();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, buscando ventas", this);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!bgwBusqueda.IsBusy)
            {
                tmrEspera.Enabled = true;
                btnBuscar.Enabled = false;
                txtFolio.Enabled = false;
                FuncionesGenerales.DeshabilitarBotonCerrar(this);
                bgwBusqueda.RunWorkerAsync(new object[] { dtpFechaInicio.Value, dtpFechaFin.Value });
            }
        }
    }
}

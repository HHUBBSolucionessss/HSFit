﻿using GYM.Clases;
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

namespace GYM.Formularios.Membresia
{
    public partial class frmAsignarPromo : Form
    {
        frmNuevaMembresia frmN = null;
        frmEditarMembresia frmE = null;
        int genero, id;

        decimal precio;
        List<int> duraciones = new List<int>();

        public frmAsignarPromo(frmNuevaMembresia frm, int genero)
        {
            InitializeComponent();
            cboTipoPromo.SelectedIndex = 0;
            this.genero = genero;
            this.frmN = frm;
            FuncionesGenerales.CargarInterfaz(this);
        }

        public frmAsignarPromo(frmEditarMembresia frm, int genero)
        {
            InitializeComponent();
            cboTipoPromo.SelectedIndex = 0;
            this.genero = genero;
            this.frmE = frm;
            FuncionesGenerales.CargarInterfaz(this);
        }

        private void BuscarPromociones()
        {
            try
            {
                dgvPromociones.Columns[1].Visible = false;
                dgvPromociones.Columns[2].Visible = false;
                duraciones.Clear();
                dgvPromociones.Rows.Clear();
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id, descripcion, precio, duracion FROM promocion WHERE (fecha_inicio<=?fecha AND fecha_fin>=?fecha) AND genero=?genero";
                sql.Parameters.AddWithValue("?fecha", DateTime.Now.ToString("yyyy/MM/dd"));
                sql.Parameters.AddWithValue("?genero", genero);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    string duracion = "";
                    decimal precio = (decimal)dr["precio"];
                    duraciones.Add((int)dr["duracion"]);
                    switch ((int)dr["duracion"])
                    {
                        case 0:
                            duracion = "Semanal";
                            break;
                        case 1:
                            duracion = "Un mes";
                            break;
                        case 2:
                            duracion = "Dos meses";
                            break;
                        case 3:
                            duracion = "Tres meses";
                            break;
                        case 4:
                            duracion = "Cuatro meses";
                            break;
                        case 5:
                            duracion = "Cinco meses";
                            break;
                        case 6:
                            duracion = "Seis meses";
                            break;
                        case 7:
                            duracion = "Siete meses";
                            break;
                        case 8:
                            duracion = "Ocho meses";
                            break;
                        case 9:
                            duracion = "Nueve meses";
                            break;
                        case 10:
                            duracion = "Diez meses";
                            break;
                        case 11:
                            duracion = "Once meses";
                            break;
                        case 12:
                            duracion = "Doce meses";
                            break;
                    }
                    dgvPromociones.Rows.Add(new object[] { dr["id"], "", "", dr["descripcion"].ToString(), precio, duracion });
                    dgvPromociones_RowEnter(dgvPromociones, new DataGridViewCellEventArgs(0, 0));
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.MensajeError("No se ha podido buscar las promociones. No se pudo conectar con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.MensajeError("No se ha podido buscar las promociones. Ocurrió un error genérico.", ex);
            }
        }

        private void BuscarPromocionesHorario()
        {
            try
            {
                dgvPromociones.Columns[1].Visible = true;
                dgvPromociones.Columns[2].Visible = true;
                duraciones.Clear();
                dgvPromociones.Rows.Clear();
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id, hora_inicio, hora_fin, descripcion, precio, duracion FROM promocion_horario WHERE genero=?genero";
                sql.Parameters.AddWithValue("?genero", genero);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    string duracion = "";
                    decimal precio = (decimal)dr["precio"];
                    duraciones.Add((int)dr["duracion"]);
                    //Clases.Enumeraciones.Duracion dm = (Clases.Enumeraciones.Duracion)Enum.Parse(typeof(Clases.Enumeraciones.Duracion), dr["duracion"].ToString());
                    switch ((int)dr["duracion"])
                    {
                        case 0:
                            duracion = "Semanal";
                            break;
                        case 1:
                            duracion = "Un mes";
                            break;
                        case 2:
                            duracion = "Dos meses";
                            break;
                        case 3:
                            duracion = "Tres meses";
                            break;
                        case 4:
                            duracion = "Cuatro meses";
                            break;
                        case 5:
                            duracion = "Cinco meses";
                            break;
                        case 6:
                            duracion = "Seis meses";
                            break;
                        case 7:
                            duracion = "Siete meses";
                            break;
                        case 8:
                            duracion = "Ocho meses";
                            break;
                        case 9:
                            duracion = "Nueve meses";
                            break;
                        case 10:
                            duracion = "Diez meses";
                            break;
                        case 11:
                            duracion = "Once meses";
                            break;
                        case 12:
                            duracion = "Doce meses";
                            break;
                    }
                    dgvPromociones.Rows.Add(new object[] { dr["id"], DateTime.Parse("01-01-0001 " + dr["hora_inicio"].ToString()), DateTime.Parse("01-01-0001 " + dr["hora_fin"].ToString()), dr["descripcion"].ToString(), precio, duracion });
                    dgvPromociones_RowEnter(dgvPromociones, new DataGridViewCellEventArgs(0, 0));
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.MensajeError("No se ha podido buscar las promociones. No se pudo conectar con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.MensajeError("No se ha podido buscar las promociones. Ocurrió un error genérico.", ex);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvPromociones.CurrentRow != null)
            {
                if (cboTipoPromo.SelectedIndex == 0)
                {
                    if (frmN != null)
                        frmN.AsignarPromocion(duraciones[dgvPromociones.CurrentRow.Index], precio, dgvPromociones[3, dgvPromociones.CurrentRow.Index].Value.ToString());
                    else if (frmE != null)
                        frmE.AsignarPromocion(duraciones[dgvPromociones.CurrentRow.Index], precio, dgvPromociones[3, dgvPromociones.CurrentRow.Index].Value.ToString());
                }
                else
                {
                    if (frmN != null)
                        frmN.AsignarPromocionHorario(id, duraciones[dgvPromociones.CurrentRow.Index], precio, dgvPromociones[3, dgvPromociones.CurrentRow.Index].Value.ToString());
                    else
                        frmE.AsignarPromocionHorario(id, duraciones[dgvPromociones.CurrentRow.Index], precio, dgvPromociones[3, dgvPromociones.CurrentRow.Index].Value.ToString());
                }
                MessageBox.Show("Se ha asignado la promoción correctamente.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                this.Close();
        }

        private void frmAsignarPromo_Load(object sender, EventArgs e)
        {
            BuscarPromociones();
        }

        private void cboTipoPromo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipoPromo.SelectedIndex)
            {
                case 0:
                    BuscarPromociones();
                    break;
                case 1:
                    BuscarPromocionesHorario();
                    break;
            }
        }

        private void dgvPromociones_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPromociones.CurrentRow != null)
                {
                    id = (int)dgvPromociones[0, dgvPromociones.CurrentRow.Index].Value;
                    precio = decimal.Parse(dgvPromociones[4, e.RowIndex].Value.ToString(), System.Globalization.NumberStyles.Currency);
                }
            }
            catch
            {
            }
        }
    }
}

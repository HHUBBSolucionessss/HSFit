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

namespace GYM.Formularios
{
    public partial class frmLockers : Form
    {
        private int numLocker;
        private int idLocker = 0;
        DateTime fechaIni, fechaFin;

        #region Instancia
        private static frmLockers frmInstancia;
        public static frmLockers Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmLockers();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmLockers();
                return frmInstancia;

            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        public enum EstadoLocker
        {
            Ocupado = 0,
            Pendiente = 1,
            Desocupado = 2,
            Rechazado = 3
        }

        public int NumeroLocker
        {
            get { return numLocker; }
            set { numLocker = value; }
        }
        
        public frmLockers()
        {
            InitializeComponent();

        }

        public void BuscarLockers()
        {
            try
            {
                dgvLockers.Rows.Clear();
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT l.id, l.num, l.estado,l.fecha_fin,l.fecha_ini, r.nom_persona, s.nombre, s.apellidos, s.telefono, s.celular FROM locker AS l LEFT JOIN miembros AS s ON (l.numSocio=s.numSocio) LEFT JOIN registro_locker AS r ON (l.id=r.locker_id)";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    string nombre = "Sin información", tel = "Sin información", estado = "", fecha_ini = null, fecha_fin = null;
                    DateTime fechaI,fechaF;
                    if (dr["estado"].ToString() == "0")
                        estado = "Ocupado";
                    else if (dr["estado"].ToString() == "1")
                        estado = "Pendiente";
                    else if (dr["estado"].ToString() == "2")
                        estado = "Desocupado";
                    else if (dr["estado"].ToString() == "3")
                        estado = "Rechazado";
                    if (dr["nombre"] != DBNull.Value)
                    {
                        nombre = dr["nombre"].ToString() + " " + dr["apellidos"].ToString();
                        if (dr["telefono"].ToString().Trim() != "" && dr["celular"].ToString().Trim() != "")
                            tel = dr["telefono"].ToString() + ", " + dr["celular"].ToString();
                        else if (dr["telefono"].ToString().Trim() != "")
                            tel = dr["telefono"].ToString();
                        else if (dr["celular"].ToString().Trim() != "")
                            tel = dr["celular"].ToString();
                    }
                    else if (dr["nom_persona"] != DBNull.Value)
                    {
                        nombre = dr["nom_persona"].ToString();
                    }
                    if (dr["fecha_fin"] != DBNull.Value)
                    {
                        fechaF = DateTime.Parse(dr["fecha_fin"].ToString());
                        fecha_fin = fechaF.ToString("dd") + " de " + fechaF.ToString("MMMM") + " del " + fechaF.ToString("yyyy");
                    }
                    else
                        fecha_fin = "Sin información";

                    if (dr["fecha_ini"] != DBNull.Value)
                    {
                        fechaI = DateTime.Parse(dr["fecha_ini"].ToString());
                        fecha_ini = fechaI.ToString("dd") + " de " + fechaI.ToString("MMMM") + " del " + fechaI.ToString("yyyy");
                    }
                    else
                    fecha_ini = "Sin información";

                    dgvLockers.Rows.Add(new object[] { dr["id"], (int)dr["num"], nombre, tel, estado,fecha_ini,fecha_fin });
                }
            }
            catch (MySqlException ex)
            {
                CFuncionesGenerales.MensajeError("No se han podido cargar los lockers. No se pudo conectar a la base de datos.", ex);
            }
            catch (InvalidOperationException ex)
            {
                CFuncionesGenerales.MensajeError("No se han podido cargar los lockers. La operación no se pudo completar debido al estado actual del control DataGridView.", ex);
            }
            catch (ArgumentNullException ex)
            {
                CFuncionesGenerales.MensajeError("No se han podido cargar los lockers. El argumento dado es nulo y el control DataGridView no lo admite.", ex);
            }
            catch (Exception ex)
            {
                CFuncionesGenerales.MensajeError("No se han podido cargar los lockers. Ha ocurrido un error genérico.", ex);
            }
        }

        private void InsertarLocker()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO locker (numSocio, num,fecha_ini,fecha_fin, estado, create_time, create_user_id) " +
                    "VALUES (?numSocio, ?num,?fecha_ini,?fecha_fin, ?estado, NOW(), ?create_user_id)";
                sql.Parameters.AddWithValue("?numSocio", 0);
                sql.Parameters.AddWithValue("?num", this.NumeroLocker);
                sql.Parameters.AddWithValue("?fecha_ini", DBNull.Value);
                sql.Parameters.AddWithValue("?fecha_fin", DBNull.Value);
                sql.Parameters.AddWithValue("?estado", EstadoLocker.Desocupado);
                sql.Parameters.AddWithValue("?create_user_id", frmMain.id);
                ConexionBD.EjecutarConsulta(sql);
            }
            catch (MySqlException ex)
            {
                CFuncionesGenerales.MensajeError("No se ha podido crear el locker. No se pudo conectar con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                CFuncionesGenerales.MensajeError("No se ha podido crear el locker. Ha ocurrido un error genérico.", ex);
            }
        }

        private void EditarLocker()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE locker SET num=?num WHERE id=?id";
                sql.Parameters.AddWithValue("?num", this.NumeroLocker);
                sql.Parameters.AddWithValue("?id", this.idLocker);
                ConexionBD.EjecutarConsulta(sql);
            }
            catch (MySqlException ex)
            {
                CFuncionesGenerales.MensajeError("No se ha podido editar el locker. No se pudo conectar con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                CFuncionesGenerales.MensajeError("No se ha podido editar el locker. Ha ocurrido un error genérico.", ex);
            }
        }

        private void EliminarLocker()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SET foreign_key_checks=0; DELETE FROM locker WHERE id=?id; SET foreign_key_checks=1;";
                sql.Parameters.AddWithValue("?id", this.idLocker);
                ConexionBD.EjecutarConsulta(sql);
            }
            catch (MySqlException ex)
            {
                CFuncionesGenerales.MensajeError("No se ha podido eliminar el locker. No se pudo conectar con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                CFuncionesGenerales.MensajeError("No se ha podido eliminar el locker. Ha ocurrido un error genérico.", ex);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if ((new frmNumeroLocker(this)).ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                InsertarLocker();
            BuscarLockers();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idLocker > 0)
            {
                if ((new frmNumeroLocker(this, this.numLocker)).ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    EditarLocker();
                BuscarLockers();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idLocker > 0)
            {
                if (MessageBox.Show("¿Deseas realmente eliminar el locker?\n(No se podrá recuperar)", "HS FIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    EliminarLocker();
                BuscarLockers();
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (dgvLockers.CurrentRow != null)
            {
                string estadoLocker = dgvLockers[4, dgvLockers.CurrentRow.Index].Value.ToString();
                if (idLocker > 0)
                {
                    if (estadoLocker != "Pendiente" && estadoLocker != "Ocupado")
                    {
                        (new frmAsignarLocker(this, idLocker)).ShowDialog(this);
                        BuscarLockers();
                    }
                    else
                    {
                        if (MessageBox.Show("El locker seleccionado ya esta ocupado.\n¿Deseas asignarlo de nuevo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                        {
                            (new frmEditarLocker(this, idLocker)).ShowDialog(this);
                        }
                    }
                }
            }
        }

        private void frmLockers_Load(object sender, EventArgs e)
        {
            BuscarLockers();
        }

        private void dgvLockers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idLocker = (int)dgvLockers[0, e.RowIndex].Value;
                numLocker = (int)dgvLockers[1, e.RowIndex].Value;
            }
            catch
            {
            }
        }
    }
}

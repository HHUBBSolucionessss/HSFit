using GYM.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GYM.Formularios
{
    public partial class frmNumeroLocker : Form
    {
        FrmLockers frm;

        public frmNumeroLocker(FrmLockers frm, string numLocker)
        {
            InitializeComponent();

            DialogResult = DialogResult.Cancel;
            this.frm = frm;
            txtNumLocker.Text = numLocker.ToString();
        }

        private void txtNumLocker_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private bool ExisteLocker(string numLocker)
        {
            bool existe = false;
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id FROM locker WHERE num=?num LIMIT 1";
                sql.Parameters.AddWithValue("?num", numLocker);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                    existe = true;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return existe;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Es correcta la información?", "HS FIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtNumLocker.Text != "")
                {
                    if (!ExisteLocker(txtNumLocker.Text))
                    {
                        frm.NumeroLocker = txtNumLocker.Text;
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("El número de locker ingresado ya existe. Ingresa otro.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Debes ingresar el número de locker.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM.Formularios.PuntoDeVenta
{
    public partial class frmVisita : Form
    {
        public frmVisita()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chbTarjeta_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                //if (!(decimal.Parse(lblTotal.Text, System.Globalization.NumberStyles.Currency) >= 100))
                //{
                //    if (chbTarjeta.Checked)
                //    {
                //        chbTarjeta.Checked = false;
                //        MessageBox.Show("La venta debe ser mayor a $100 para que se pueda efectuar con tarjeta", "GymCSY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //    return;
                //}
                if (chbTarjeta.Checked)
                {
                    pnlTarjeta.Visible = true;
                }
                else
                {
                    pnlTarjeta.Visible = false;
                }
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
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
                Clases.CFuncionesGenerales.MensajeError("Algún método llamado en el evento CheckedChanged del CheckBox Tarjeta no admite argumentos nulos.", ex);
            }
            catch (Exception ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }
    }
}

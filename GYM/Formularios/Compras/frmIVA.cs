﻿using GYM.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM.Formularios.Compras
{
    public partial class frmIVA : Form
    {
        frmNuevaCompra frm;

        public frmIVA(frmNuevaCompra frm)
        {
            InitializeComponent();

            this.frm = frm;
            txtIVA.Text = frm.IVA.ToString();
        }

        private void txtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                frm.IVA = int.Parse(txtIVA.Text);
                MessageBox.Show("Se ha modificado el I.V.A. correctamente.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (FormatException ex)
            {
                FuncionesGenerales.MensajeError("No se ha modificado el valor del I.V.A. El número dado no es válido.", ex);
            }
            catch (OverflowException ex)
            {
                FuncionesGenerales.MensajeError("No se ha modificado el valor del I.V.A. El número dado excede el valor máxico.", ex);
            }
            catch (ArgumentNullException ex)
            {
                FuncionesGenerales.MensajeError("No se ha modificado el valor del I.V.A. El argumento dado es nulo.", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.MensajeError("No se ha modificado el valor del I.V.A. Ha ocurrido un error genérico.", ex);
            }
        }

    }
}

using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GYM.Formularios.POS
{
    public partial class frmCobrar : Form
    {
        int id;
        frmPuntoVenta frm;
        decimal total, saldo;
        decimal totalPorcentaje = 0;
        decimal tarjeta = 0M;
        TipoPago t;

        List<int> idCuenta = new List<int>();
        List<string> nombreBeneficiarios = new List<string>();
        List<string> nombreBancos = new List<string>();


        public frmCobrar(frmPuntoVenta frm, int id, decimal total)
        {
            InitializeComponent();
            this.frm = frm;
            this.id = id;
            this.total = total;
            lblTotal.Text = total.ToString("C2");
            cboTipoPago.SelectedIndex = 0;
            CalcularCambio();
        }

        private void DatosCuentas()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id, clabe, banco, beneficiario FROM cuenta WHERE tipo=?tipo";
                sql.Parameters.AddWithValue("?tipo", TipoCuenta.Sucursal);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idCuenta.Add((int)dr["id"]);
                    cboNumCuenta.Items.Add(dr["clabe"] + "/" + dr["banco"].ToString());
                    nombreBeneficiarios.Add(dr["beneficiario"].ToString());
                    nombreBancos.Add(dr["banco"].ToString());
                }
                cboNumCuenta.SelectedIndex = 0;
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar los datos de las cuentas. No se ha podido conectar a la base de datos.", Config.shrug, ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar los datos de las cuentas.", Config.shrug, ex);
            }
        }

        private void CalcularCambio()
        {
            decimal efectivo, cambio = 0M;
            decimal.TryParse(txtEfectivo.Text, out efectivo);
            cambio = total - efectivo;
            if (cambio > 0)
            {
                lblECambio.Text = "Falta:";
                lblCambio.BackColor = Colores.Error;
                lblCambio.Text = cambio.ToString("C2");
            }
            else
            {
                lblECambio.Text = "Cambio:";
                lblCambio.BackColor = Colores.Exito;
                lblCambio.Text = (cambio * -1).ToString("C2");
            }
        }

        private void CalcularCambioMixto()
        {
            decimal efectivo, cambio = 0M, cargo = 0M;
            decimal.TryParse(txtEfectivo.Text, out efectivo);
            if (txtPorcentajeImpuesto.Text != "")
            {
                cargo = (total * (decimal.Parse(txtPorcentajeImpuesto.Text) / 100)); 
                totalPorcentaje = total + cargo;
            }
            else
            {
                cargo = 0;
                totalPorcentaje = total;
            }

            if (efectivo > (total + cargo))
            {
                txtEfectivo.Text = (total + cargo).ToString();
                txtEfectivo.SelectionStart = txtEfectivo.Text.Length;
                return;
            }
            tarjeta = (total + cargo) - efectivo;
            cambio = (total + cargo) - tarjeta - efectivo;
            lblTarjetaMixto.Text = tarjeta.ToString("C2");
            if (cambio > 0)
            {
                lblECambio.Text = "Falta:";
                lblCambio.BackColor = Colores.Error;
                lblCambio.Text = cambio.ToString("C2");
            }
            else
            {
                lblECambio.Text = "Cambio:";
                lblCambio.BackColor = Colores.Exito;
                lblCambio.Text = (cambio * -1).ToString("C2");
            }
            lblCargo.Text = cargo.ToString("C2");
            lblSubtotal.Text = total.ToString("C2");
            lblTotal.Text = totalPorcentaje.ToString("C2");
        }

        private void QuitarEfectivo()
        {
            lblEEfectivo.Enabled = false;
            txtEfectivo.Enabled = false;
            txtEfectivo.Text = "0.00";
            lblCambio.Text = "$0.00";
            lblCambio.BackColor = Colores.Exito;
            lblECambio.Text = "Cambio:";
        }

        private void MovimientoCaja()
        {
            try
            {
                Caja c = new Caja();
                c.Descripcion = "VENTA MOSTRADOR CON FOLIO " + id.ToString();
                if (cboTipoPago.SelectedIndex == 0)
                {
                    c.Efectivo = total;
                    c.Voucher = 0M;
                }
                else if (cboTipoPago.SelectedIndex == 1 || cboTipoPago.SelectedIndex == 2)
                {
                    c.Efectivo = 0M;
                    c.Voucher = totalPorcentaje;
                }
                else if (cboTipoPago.SelectedIndex == 3)
                {
                    decimal efectivo;
                    decimal.TryParse(txtEfectivo.Text, out efectivo);
                    c.Efectivo = efectivo;
                    c.Voucher = decimal.Parse(lblTarjetaMixto.Text, System.Globalization.NumberStyles.Currency);
                }
                else if(cboTipoPago.SelectedIndex == 4)
                {
                    c.Efectivo = 0M;
                    c.Voucher = totalPorcentaje;
                }
                c.TipoMovimiento = EC_Admin.MovimientoCaja.Entrada;
                c.Tipo_Pago = t;
                c.IDSucursal = Config.idSucursal;
                c.RegistrarMovimiento();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MovimientoBanco()
        {
            try
            {
                Banco b = new Banco();
                b.IDCuenta = idCuenta[cboNumCuenta.SelectedIndex];
                b.Descripcion = "VENTA MOSTRADOR CON FOLIO " + id.ToString();
                b.TipoMovimiento = EC_Admin.MovimientoCaja.Entrada;
                if (t == TipoPago.Mixto)
                    b.Total = tarjeta;
                else
                    b.Total = totalPorcentaje;
                b.Tipo_Pago = t;
                b.RegistrarMovimiento();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ImprimirTicket()
        {
            try
            {
                Ticket t = new Ticket();
                t.TicketVenta(id, this.t, decimal.Parse(lblCambio.Text, System.Globalization.NumberStyles.Currency));
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al imprimir el ticket. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al imprimir el ticket.", "Admin CSY", ex);
            }
        }

        private void frmCobrar_Load(object sender, EventArgs e)
        {
            DatosCuentas();
            txtEfectivo.Select();
            cboTipoPago.SelectedIndex = 0;
            if (total < 0)
            {
                cboTipoPago.Enabled = false;
            }
        }

        private void cboTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipoPago.SelectedIndex)
            {
                case 0:
                    txtPorcentajeImpuesto.Text = "0.00";
                    
                    btnCredito.Visible = true;
                    lblEEfectivo.Enabled = true;
                    txtEfectivo.Enabled = true;
                    lblESubtotal.Visible = lblSubtotal.Visible = lblECargo.Visible = lblCargo.Visible = false;
                    lblTotal.Top = lblETotal.Top = lblEEfectivo.Top;
                    lblETarjetaMixto.Visible = lblTarjetaMixto.Visible = txtDatos.Visible = lblEDatos.Visible = txtPorcentajeImpuesto.Visible = lblEPorcentajeImpuesto.Visible = lblEFolioTerminal.Visible = txtFolioTerminal.Visible = false;
                    CalcularCambio();
                    t = TipoPago.Efectivo;
                    this.Size = new Size(682, 330);
                    txtEfectivo.Select();
                    grbCuentas.Visible = false;
                    break;
                //case 1:
                //    QuitarEfectivo();
                //    lblEDatos.Text = "Núm. de cheque";
                //    txtDatos.Visible = lblEDatos.Visible = true;
                //    break;
                case 1:
                    QuitarEfectivo();
                    btnCredito.Visible = false;
                    this.Size = new Size(682, 390);
                    lblEDatos.Text = "Núm. de tarjeta";
                    lblEFolioTerminal.Text = "Folio terminal";
                    lblESubtotal.Visible = lblSubtotal.Visible = lblECargo.Visible = lblCargo.Visible = true;
                    lblTotal.Top = 189;
                    lblETotal.Top = 189;
                    lblETarjetaMixto.Visible = lblTarjetaMixto.Visible = txtDatos.Visible = lblEDatos.Visible = txtPorcentajeImpuesto.Visible = lblEPorcentajeImpuesto.Visible = lblEFolioTerminal.Visible = txtFolioTerminal.Visible = true;
                    txtPorcentajeImpuesto.Text = "0";
                    t = TipoPago.Crédito;
                    txtPorcentajeImpuesto_TextChanged(txtPorcentajeImpuesto, new EventArgs());
                    grbCuentas.Visible = true;
                    break;
                case 2:
                    QuitarEfectivo();
                    btnCredito.Visible = false;
                    this.Size = new Size(682, 390);
                    lblEDatos.Text = "Núm. de tarjeta";
                    lblEFolioTerminal.Text = "Folio terminal";
                    lblESubtotal.Visible = lblSubtotal.Visible = lblECargo.Visible = lblCargo.Visible = true;
                    lblTotal.Top = 189;
                    lblETotal.Top = 189;
                    lblETarjetaMixto.Visible = lblTarjetaMixto.Visible = txtDatos.Visible = lblEDatos.Visible = txtPorcentajeImpuesto.Visible = lblEPorcentajeImpuesto.Visible = lblEFolioTerminal.Visible = txtFolioTerminal.Visible = true;
                    txtPorcentajeImpuesto.Text = "0";
                    t = TipoPago.Débito;
                    txtPorcentajeImpuesto_TextChanged(txtPorcentajeImpuesto, new EventArgs());
                    grbCuentas.Visible = true;
                    break;
                //case 4:
                //    QuitarEfectivo();
                //    txtDatos.Visible = lblEDatos.Visible = false;
                //    break;
                case 3:
                    CalcularCambioMixto();
                    btnCredito.Visible = false;
                    this.Size = new Size(682, 390);
                    lblEDatos.Text = "Núm. de tarjeta";
                    lblEFolioTerminal.Text = "Folio terminal";
                    lblESubtotal.Visible = lblSubtotal.Visible = lblECargo.Visible = lblCargo.Visible = true;
                    lblTotal.Top = 189;
                    lblETotal.Top = 189;
                    txtDatos.Visible = lblEDatos.Visible = txtPorcentajeImpuesto.Visible = lblEPorcentajeImpuesto.Visible = lblEFolioTerminal.Visible = txtFolioTerminal.Visible = lblETarjetaMixto.Visible = lblTarjetaMixto.Visible = true;
                    txtEfectivo.Enabled = lblEEfectivo.Enabled = true;
                    txtPorcentajeImpuesto.Text = "0";
                    t = TipoPago.Mixto;
                    txtPorcentajeImpuesto_TextChanged(txtPorcentajeImpuesto, new EventArgs());
                    grbCuentas.Visible = true;
                    break;
                case 4:
                    QuitarEfectivo();
                    btnCredito.Visible = false;
                    this.Size = new Size(682, 390);
                    lblEDatos.Text = "Núm. de tarjeta";
                    lblEFolioTerminal.Text = "Folio de depósito";
                    lblESubtotal.Visible = lblSubtotal.Visible = lblECargo.Visible = lblCargo.Visible = true;
                    lblTotal.Top = 189;
                    lblETotal.Top = 189;
                    lblETarjetaMixto.Visible = lblTarjetaMixto.Visible = txtDatos.Visible = lblEDatos.Visible = txtPorcentajeImpuesto.Visible = lblEPorcentajeImpuesto.Visible = lblEFolioTerminal.Visible = txtFolioTerminal.Visible = true;
                    lblEDatos.Visible = txtDatos.Visible = false;
                    txtPorcentajeImpuesto.Text = "0";
                    t = TipoPago.Deposito;
                    txtPorcentajeImpuesto_TextChanged(txtPorcentajeImpuesto, new EventArgs());
                    grbCuentas.Visible = true;
                    break;
            }
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            if (cboTipoPago.SelectedIndex < 3)
            {
                CalcularCambio();
            }
            else
            {
                CalcularCambioMixto();
            }

        }

        private void txtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.FuncionesGenerales.VerificarEsNumero(ref sender, ref e, false);
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (lblCambio.BackColor == Colores.Exito)
            {
                try
                {
                    btnCobrar.Enabled = false;
                    switch (cboTipoPago.SelectedIndex)
                    {
                        case 0:
                            frm.GuardarVenta(false, t, false);
                            break;
                        case 1:
                        case 2:
                        case 3:
                            if (cboNumCuenta.SelectedIndex < 0)
                            {
                                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes seleccionar una cuenta antes de cobrar la venta.", "Admin CSY");
                                return;
                            }
                            decimal porcentajeImpuesto;
                            decimal.TryParse(txtPorcentajeImpuesto.Text, out porcentajeImpuesto);
                            if (porcentajeImpuesto < 0)
                            {
                                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El porcentaje de impuesto debe ser mayor o igual a 0", "Admin CSY");
                                return;
                            }
                            if (txtDatos.Text.Trim() == "")
                            {
                                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar el número de la tarjeta", "Admin CSY");
                                return;
                            }
                            if (txtFolioTerminal.Text == "")
                            {
                                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar el folio de la terminal de tarjetas", "Admin CSY");
                                return;
                            }
                            frm.GuardarVenta(false, t, false, txtDatos.Text, txtFolioTerminal.Text, total * (porcentajeImpuesto / 100));
                            MovimientoBanco();
                            break;
                        case 4:
                            decimal.TryParse(txtPorcentajeImpuesto.Text, out porcentajeImpuesto);
                            if (txtFolioTerminal.Text == "")
                            {
                                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar el folio del depósito", "Admin CSY");
                                return;
                            }
                            frm.GuardarVenta(false, t, false, "", "", total * (porcentajeImpuesto / 100), txtFolioTerminal.Text);
                            MovimientoBanco();
                            break;

                    }
                    MovimientoCaja();
                    if (FuncionesGenerales.ImprimirTicket(this, "¿Desea imprimir el ticket de ésta venta?"))
                    {
                        try
                        {
                            for (int i = 0; i < Config.cantImprimirTickets; i++)
                            {
                                ImprimirTicket();
                            }
                        }
                        catch (Exception ex)
                        {
                            FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al imprimir el ticket.", Config.shrug, ex);
                        }
                    }
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha guardado los datos de la venta correctamente!", "Admin CSY");
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al guardar los datos de la venta. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al guardar los datos de la venta.", "Admin CSY", ex);
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El efectivo debe ser mayor o igual al total", "Admin CSY");
            }
        }

        private void txtPorcentajeImpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, false);
        }

        private void txtPorcentajeImpuesto_TextChanged(object sender, EventArgs e)
        {
            if (cboTipoPago.SelectedIndex < 3)
            {
                decimal cargo = 0M;
                if (txtPorcentajeImpuesto.Text != "")
                {
                    cargo = (total * (decimal.Parse(txtPorcentajeImpuesto.Text) / 100));
                    totalPorcentaje = total + cargo;
                }
                else
                {
                    totalPorcentaje = total;
                }
                lblCargo.Text = cargo.ToString("C2");
                lblSubtotal.Text = total.ToString("C2");
                lblTotal.Text = totalPorcentaje.ToString("C2");
            }
            else
            {
                CalcularCambioMixto();
            }
        }

        private void txtEfectivo_Enter(object sender, EventArgs e)
        {
            txtEfectivo.SelectAll();
        }

        private void txtEfectivo_Click(object sender, EventArgs e)
        {
            txtEfectivo.SelectAll();
        }

        private void frmCobrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cboNumCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBanco.Text = nombreBancos[cboNumCuenta.SelectedIndex];
            lblBeneficiario.Text = nombreBeneficiarios[cboNumCuenta.SelectedIndex];
        }

        async private void btnCredito_Click(object sender, EventArgs e)
        {
            if (frm.idCliente > 0)
            {
                try
                {
                    Task<decimal> ta = Cliente.LimiteCreditoCliente(frm.idCliente);
                    await ta;
                    if (ta.Result >= total)
                    {
                        if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Deseas mandar ésta venta a pagos?", "Admin CSY") == System.Windows.Forms.DialogResult.Yes)
                        {
                            try
                            {
                                frm.GuardarVenta(false, t, true);
                                Cliente.SumarCreditoCliente(frm.idCliente, decimal.Negate(total));
                                this.Close();
                            }
                            catch (MySqlException ex)
                            {
                                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al guardar la venta a crédito. No se ha podido conectar con la base de datos.", Config.shrug, ex);
                            }
                            catch (Exception ex)
                            {
                                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al guardar la venta a crédito.", Config.shrug, ex);
                            }
                        }
                    }
                    else
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "El limite de crédito del cliente es menor al total de ésta venta.", "Admin CSY");
                    }
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar los datos de crédito del cliente. No se ha podido conectar a la base de datos.", Config.shrug, ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar los datos de crédito del cliente.", Config.shrug, ex);
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "No se puede mandar una venta a pagos sin antes asignar un cliente diferente a público en general", "Admin CSY");
            }
        }
    }
}

namespace GYM.Formularios.POS
{
    partial class frmCobrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobrar));
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblETotal = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.lblEEfectivo = new System.Windows.Forms.Label();
            this.btnCredito = new System.Windows.Forms.Button();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblECambio = new System.Windows.Forms.Label();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.lblETipoPago = new System.Windows.Forms.Label();
            this.lblEPorcentajeImpuesto = new System.Windows.Forms.Label();
            this.txtPorcentajeImpuesto = new System.Windows.Forms.TextBox();
            this.lblEFolioTerminal = new System.Windows.Forms.Label();
            this.txtFolioTerminal = new System.Windows.Forms.TextBox();
            this.lblECargo = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblESubtotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTarjetaMixto = new System.Windows.Forms.Label();
            this.lblETarjetaMixto = new System.Windows.Forms.Label();
            this.cboNumCuenta = new System.Windows.Forms.ComboBox();
            this.lblENumCuenta = new System.Windows.Forms.Label();
            this.lblBeneficiario = new System.Windows.Forms.Label();
            this.lblEBeneficiario = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.lblEBanco = new System.Windows.Forms.Label();
            this.grbCuentas = new System.Windows.Forms.GroupBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.grbCuentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblTotal.Location = new System.Drawing.Point(108, 186);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 23);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "$0.00";
            // 
            // lblETotal
            // 
            this.lblETotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblETotal.AutoSize = true;
            this.lblETotal.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblETotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETotal.Location = new System.Drawing.Point(44, 181);
            this.lblETotal.Name = "lblETotal";
            this.lblETotal.Size = new System.Drawing.Size(58, 28);
            this.lblETotal.TabIndex = 8;
            this.lblETotal.Text = "Total:";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEfectivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtEfectivo.Enabled = false;
            this.txtEfectivo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtEfectivo.Location = new System.Drawing.Point(313, 115);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(125, 27);
            this.txtEfectivo.TabIndex = 11;
            this.txtEfectivo.Text = "0.00";
            this.txtEfectivo.Click += new System.EventHandler(this.txtEfectivo_Click);
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            this.txtEfectivo.Enter += new System.EventHandler(this.txtEfectivo_Enter);
            this.txtEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEfectivo_KeyPress);
            // 
            // lblEEfectivo
            // 
            this.lblEEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEEfectivo.AutoSize = true;
            this.lblEEfectivo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblEEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEEfectivo.Location = new System.Drawing.Point(224, 114);
            this.lblEEfectivo.Name = "lblEEfectivo";
            this.lblEEfectivo.Size = new System.Drawing.Size(85, 28);
            this.lblEEfectivo.TabIndex = 10;
            this.lblEEfectivo.Text = "Efectivo:";
            // 
            // btnCredito
            // 
            this.btnCredito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnCredito.FlatAppearance.BorderSize = 0;
            this.btnCredito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnCredito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredito.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCredito.ForeColor = System.Drawing.Color.White;
            this.btnCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCredito.Location = new System.Drawing.Point(504, 242);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(150, 46);
            this.btnCredito.TabIndex = 15;
            this.btnCredito.Text = "Crédito";
            this.btnCredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCredito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCredito.UseVisualStyleBackColor = false;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // lblCambio
            // 
            this.lblCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCambio.AutoSize = true;
            this.lblCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.lblCambio.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.ForeColor = System.Drawing.Color.White;
            this.lblCambio.Location = new System.Drawing.Point(534, 119);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(55, 23);
            this.lblCambio.TabIndex = 13;
            this.lblCambio.Text = "$0.00";
            // 
            // lblECambio
            // 
            this.lblECambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblECambio.AutoSize = true;
            this.lblECambio.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblECambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECambio.Location = new System.Drawing.Point(444, 114);
            this.lblECambio.Name = "lblECambio";
            this.lblECambio.Size = new System.Drawing.Size(84, 28);
            this.lblECambio.TabIndex = 12;
            this.lblECambio.Text = "Cambio:";
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoPago.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cboTipoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "T Crédito",
            "T Débito",
            "Mixto",
            "Deposito"});
            this.cboTipoPago.Location = new System.Drawing.Point(162, 9);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(220, 31);
            this.cboTipoPago.TabIndex = 1;
            this.cboTipoPago.SelectedIndexChanged += new System.EventHandler(this.cboTipoPago_SelectedIndexChanged);
            // 
            // lblETipoPago
            // 
            this.lblETipoPago.AutoSize = true;
            this.lblETipoPago.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblETipoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETipoPago.Location = new System.Drawing.Point(8, 12);
            this.lblETipoPago.Name = "lblETipoPago";
            this.lblETipoPago.Size = new System.Drawing.Size(148, 25);
            this.lblETipoPago.TabIndex = 0;
            this.lblETipoPago.Text = "Método de pago";
            // 
            // lblEPorcentajeImpuesto
            // 
            this.lblEPorcentajeImpuesto.AutoSize = true;
            this.lblEPorcentajeImpuesto.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblEPorcentajeImpuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEPorcentajeImpuesto.Location = new System.Drawing.Point(8, 54);
            this.lblEPorcentajeImpuesto.Name = "lblEPorcentajeImpuesto";
            this.lblEPorcentajeImpuesto.Size = new System.Drawing.Size(80, 25);
            this.lblEPorcentajeImpuesto.TabIndex = 2;
            this.lblEPorcentajeImpuesto.Text = "% Cargo";
            this.lblEPorcentajeImpuesto.Visible = false;
            // 
            // txtPorcentajeImpuesto
            // 
            this.txtPorcentajeImpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtPorcentajeImpuesto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentajeImpuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtPorcentajeImpuesto.Location = new System.Drawing.Point(12, 79);
            this.txtPorcentajeImpuesto.Name = "txtPorcentajeImpuesto";
            this.txtPorcentajeImpuesto.Size = new System.Drawing.Size(210, 27);
            this.txtPorcentajeImpuesto.TabIndex = 3;
            this.txtPorcentajeImpuesto.Text = "0";
            this.txtPorcentajeImpuesto.Visible = false;
            this.txtPorcentajeImpuesto.TextChanged += new System.EventHandler(this.txtPorcentajeImpuesto_TextChanged);
            this.txtPorcentajeImpuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentajeImpuesto_KeyPress);
            // 
            // lblEFolioTerminal
            // 
            this.lblEFolioTerminal.AutoSize = true;
            this.lblEFolioTerminal.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblEFolioTerminal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFolioTerminal.Location = new System.Drawing.Point(233, 54);
            this.lblEFolioTerminal.Name = "lblEFolioTerminal";
            this.lblEFolioTerminal.Size = new System.Drawing.Size(120, 25);
            this.lblEFolioTerminal.TabIndex = 6;
            this.lblEFolioTerminal.Text = "Folio terminal";
            this.lblEFolioTerminal.Visible = false;
            // 
            // txtFolioTerminal
            // 
            this.txtFolioTerminal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtFolioTerminal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolioTerminal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtFolioTerminal.Location = new System.Drawing.Point(237, 79);
            this.txtFolioTerminal.Name = "txtFolioTerminal";
            this.txtFolioTerminal.Size = new System.Drawing.Size(210, 27);
            this.txtFolioTerminal.TabIndex = 7;
            this.txtFolioTerminal.Visible = false;
            // 
            // lblECargo
            // 
            this.lblECargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblECargo.AutoSize = true;
            this.lblECargo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblECargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECargo.Location = new System.Drawing.Point(12, 147);
            this.lblECargo.Name = "lblECargo";
            this.lblECargo.Size = new System.Drawing.Size(90, 28);
            this.lblECargo.TabIndex = 8;
            this.lblECargo.Text = "% Cargo:";
            // 
            // lblCargo
            // 
            this.lblCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblCargo.Location = new System.Drawing.Point(108, 152);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(55, 23);
            this.lblCargo.TabIndex = 9;
            this.lblCargo.Text = "$0.00";
            // 
            // lblESubtotal
            // 
            this.lblESubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblESubtotal.AutoSize = true;
            this.lblESubtotal.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblESubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblESubtotal.Location = new System.Drawing.Point(11, 114);
            this.lblESubtotal.Name = "lblESubtotal";
            this.lblESubtotal.Size = new System.Drawing.Size(91, 28);
            this.lblESubtotal.TabIndex = 8;
            this.lblESubtotal.Text = "Subtotal:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblSubtotal.Location = new System.Drawing.Point(108, 119);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(55, 23);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "$0.00";
            // 
            // lblTarjetaMixto
            // 
            this.lblTarjetaMixto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarjetaMixto.AutoSize = true;
            this.lblTarjetaMixto.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjetaMixto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblTarjetaMixto.Location = new System.Drawing.Point(309, 154);
            this.lblTarjetaMixto.Name = "lblTarjetaMixto";
            this.lblTarjetaMixto.Size = new System.Drawing.Size(55, 23);
            this.lblTarjetaMixto.TabIndex = 23;
            this.lblTarjetaMixto.Text = "$0.00";
            this.lblTarjetaMixto.Visible = false;
            // 
            // lblETarjetaMixto
            // 
            this.lblETarjetaMixto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblETarjetaMixto.AutoSize = true;
            this.lblETarjetaMixto.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblETarjetaMixto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETarjetaMixto.Location = new System.Drawing.Point(233, 149);
            this.lblETarjetaMixto.Name = "lblETarjetaMixto";
            this.lblETarjetaMixto.Size = new System.Drawing.Size(73, 28);
            this.lblETarjetaMixto.TabIndex = 22;
            this.lblETarjetaMixto.Text = "Tarjeta:";
            this.lblETarjetaMixto.Visible = false;
            // 
            // cboNumCuenta
            // 
            this.cboNumCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cboNumCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNumCuenta.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cboNumCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboNumCuenta.FormattingEnabled = true;
            this.cboNumCuenta.Location = new System.Drawing.Point(9, 39);
            this.cboNumCuenta.Name = "cboNumCuenta";
            this.cboNumCuenta.Size = new System.Drawing.Size(220, 31);
            this.cboNumCuenta.TabIndex = 2;
            this.cboNumCuenta.SelectedIndexChanged += new System.EventHandler(this.cboNumCuenta_SelectedIndexChanged);
            // 
            // lblENumCuenta
            // 
            this.lblENumCuenta.AutoSize = true;
            this.lblENumCuenta.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblENumCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblENumCuenta.Location = new System.Drawing.Point(6, 18);
            this.lblENumCuenta.Name = "lblENumCuenta";
            this.lblENumCuenta.Size = new System.Drawing.Size(113, 20);
            this.lblENumCuenta.TabIndex = 25;
            this.lblENumCuenta.Text = "Núm. de cuenta";
            // 
            // lblBeneficiario
            // 
            this.lblBeneficiario.AutoSize = true;
            this.lblBeneficiario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBeneficiario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblBeneficiario.Location = new System.Drawing.Point(235, 44);
            this.lblBeneficiario.Name = "lblBeneficiario";
            this.lblBeneficiario.Size = new System.Drawing.Size(27, 20);
            this.lblBeneficiario.TabIndex = 26;
            this.lblBeneficiario.Text = "---";
            // 
            // lblEBeneficiario
            // 
            this.lblEBeneficiario.AutoSize = true;
            this.lblEBeneficiario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEBeneficiario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEBeneficiario.Location = new System.Drawing.Point(235, 18);
            this.lblEBeneficiario.Name = "lblEBeneficiario";
            this.lblEBeneficiario.Size = new System.Drawing.Size(88, 20);
            this.lblEBeneficiario.TabIndex = 27;
            this.lblEBeneficiario.Text = "Beneficiario";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblBanco.Location = new System.Drawing.Point(6, 97);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(27, 20);
            this.lblBanco.TabIndex = 28;
            this.lblBanco.Text = "---";
            // 
            // lblEBanco
            // 
            this.lblEBanco.AutoSize = true;
            this.lblEBanco.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEBanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEBanco.Location = new System.Drawing.Point(6, 71);
            this.lblEBanco.Name = "lblEBanco";
            this.lblEBanco.Size = new System.Drawing.Size(50, 20);
            this.lblEBanco.TabIndex = 29;
            this.lblEBanco.Text = "Banco";
            // 
            // grbCuentas
            // 
            this.grbCuentas.Controls.Add(this.lblEBanco);
            this.grbCuentas.Controls.Add(this.lblBanco);
            this.grbCuentas.Controls.Add(this.lblEBeneficiario);
            this.grbCuentas.Controls.Add(this.lblBeneficiario);
            this.grbCuentas.Controls.Add(this.lblENumCuenta);
            this.grbCuentas.Controls.Add(this.cboNumCuenta);
            this.grbCuentas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grbCuentas.Location = new System.Drawing.Point(12, 212);
            this.grbCuentas.Name = "grbCuentas";
            this.grbCuentas.Size = new System.Drawing.Size(486, 127);
            this.grbCuentas.TabIndex = 24;
            this.grbCuentas.TabStop = false;
            this.grbCuentas.Text = "Datos de cuenta";
            this.grbCuentas.Visible = false;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobrar.Location = new System.Drawing.Point(504, 293);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(150, 46);
            this.btnCobrar.TabIndex = 14;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // frmCobrar
            // 
            this.AcceptButton = this.btnCobrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(666, 351);
            this.Controls.Add(this.grbCuentas);
            this.Controls.Add(this.lblTarjetaMixto);
            this.Controls.Add(this.lblETarjetaMixto);
            this.Controls.Add(this.lblEFolioTerminal);
            this.Controls.Add(this.txtFolioTerminal);
            this.Controls.Add(this.lblEPorcentajeImpuesto);
            this.Controls.Add(this.txtPorcentajeImpuesto);
            this.Controls.Add(this.lblETipoPago);
            this.Controls.Add(this.cboTipoPago);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.lblECambio);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.lblEEfectivo);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblESubtotal);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblECargo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblETotal);
            this.Controls.Add(this.btnCobrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobrar venta";
            this.Load += new System.EventHandler(this.frmCobrar_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmCobrar_KeyUp);
            this.grbCuentas.ResumeLayout(false);
            this.grbCuentas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblETotal;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label lblEEfectivo;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblECambio;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.Label lblETipoPago;
        private System.Windows.Forms.Label lblEPorcentajeImpuesto;
        private System.Windows.Forms.TextBox txtPorcentajeImpuesto;
        private System.Windows.Forms.Label lblEFolioTerminal;
        private System.Windows.Forms.TextBox txtFolioTerminal;
        private System.Windows.Forms.Label lblECargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblESubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTarjetaMixto;
        private System.Windows.Forms.Label lblETarjetaMixto;
        private System.Windows.Forms.ComboBox cboNumCuenta;
        private System.Windows.Forms.Label lblENumCuenta;
        private System.Windows.Forms.Label lblBeneficiario;
        private System.Windows.Forms.Label lblEBeneficiario;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Label lblEBanco;
        private System.Windows.Forms.GroupBox grbCuentas;
    }
}
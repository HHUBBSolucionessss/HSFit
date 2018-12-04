namespace GYM.Formularios.Membresia
{
    partial class frmEditarMembresia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarMembresia));
            this.btnQuitarPromo = new System.Windows.Forms.Button();
            this.btnAsignarPromo = new System.Windows.Forms.Button();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.pcbSocio = new System.Windows.Forms.PictureBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFolioTicket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTerminacion = new System.Windows.Forms.TextBox();
            this.cbxTipoPago = new System.Windows.Forms.ComboBox();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.lblEtiquetaFechaFin = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblNombreMiembro = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblEtiquetaDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblEtiquetaFolioRemision = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.lblEtiquetaPrecio = new System.Windows.Forms.Label();
            this.lblEtiquetaFechaInicio = new System.Windows.Forms.Label();
            this.lblEtiquetaTipo = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSocio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitarPromo
            // 
            this.btnQuitarPromo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnQuitarPromo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarPromo.Enabled = false;
            this.btnQuitarPromo.FlatAppearance.BorderSize = 0;
            this.btnQuitarPromo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnQuitarPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarPromo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarPromo.ForeColor = System.Drawing.Color.White;
            this.btnQuitarPromo.Location = new System.Drawing.Point(595, 114);
            this.btnQuitarPromo.Name = "btnQuitarPromo";
            this.btnQuitarPromo.Size = new System.Drawing.Size(150, 30);
            this.btnQuitarPromo.TabIndex = 74;
            this.btnQuitarPromo.Text = "Quitar promoción";
            this.btnQuitarPromo.UseVisualStyleBackColor = false;
            this.btnQuitarPromo.Click += new System.EventHandler(this.btnQuitarPromo_Click);
            // 
            // btnAsignarPromo
            // 
            this.btnAsignarPromo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnAsignarPromo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignarPromo.FlatAppearance.BorderSize = 0;
            this.btnAsignarPromo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnAsignarPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarPromo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarPromo.ForeColor = System.Drawing.Color.White;
            this.btnAsignarPromo.Location = new System.Drawing.Point(427, 113);
            this.btnAsignarPromo.Name = "btnAsignarPromo";
            this.btnAsignarPromo.Size = new System.Drawing.Size(150, 30);
            this.btnAsignarPromo.TabIndex = 73;
            this.btnAsignarPromo.Text = "Asignar promoción";
            this.btnAsignarPromo.UseVisualStyleBackColor = false;
            this.btnAsignarPromo.Click += new System.EventHandler(this.btnAsignarPromo_Click);
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblTarjeta.Location = new System.Drawing.Point(423, 275);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(48, 19);
            this.lblTarjeta.TabIndex = 71;
            this.lblTarjeta.Text = "Tarjeta";
            this.lblTarjeta.Visible = false;
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtTarjeta.Location = new System.Drawing.Point(427, 297);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(125, 26);
            this.txtTarjeta.TabIndex = 72;
            this.txtTarjeta.Visible = false;
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblEfectivo.Location = new System.Drawing.Point(270, 275);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(56, 19);
            this.lblEfectivo.TabIndex = 69;
            this.lblEfectivo.Text = "Efectivo";
            this.lblEfectivo.Visible = false;
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtEfectivo.Location = new System.Drawing.Point(270, 297);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(143, 26);
            this.txtEfectivo.TabIndex = 70;
            this.txtEfectivo.Visible = false;
            // 
            // pcbSocio
            // 
            this.pcbSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pcbSocio.Enabled = false;
            this.pcbSocio.Location = new System.Drawing.Point(22, 24);
            this.pcbSocio.Name = "pcbSocio";
            this.pcbSocio.Size = new System.Drawing.Size(231, 234);
            this.pcbSocio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSocio.TabIndex = 67;
            this.pcbSocio.TabStop = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Location = new System.Drawing.Point(476, 176);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(45, 19);
            this.lblPrecio.TabIndex = 57;
            this.lblPrecio.Text = "$0.00";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label3.Location = new System.Drawing.Point(423, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 62;
            this.label3.Text = "Folio ticket terminal";
            // 
            // txtFolioTicket
            // 
            this.txtFolioTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFolioTicket.Enabled = false;
            this.txtFolioTicket.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtFolioTicket.Location = new System.Drawing.Point(427, 242);
            this.txtFolioTicket.Name = "txtFolioTicket";
            this.txtFolioTicket.Size = new System.Drawing.Size(125, 26);
            this.txtFolioTicket.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label2.Location = new System.Drawing.Point(267, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 60;
            this.label2.Text = "Terminación tarjeta";
            // 
            // txtTerminacion
            // 
            this.txtTerminacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTerminacion.Enabled = false;
            this.txtTerminacion.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtTerminacion.Location = new System.Drawing.Point(271, 242);
            this.txtTerminacion.Name = "txtTerminacion";
            this.txtTerminacion.Size = new System.Drawing.Size(142, 26);
            this.txtTerminacion.TabIndex = 61;
            // 
            // cbxTipoPago
            // 
            this.cbxTipoPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxTipoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cbxTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoPago.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cbxTipoPago.FormattingEnabled = true;
            this.cbxTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Mixto"});
            this.cbxTipoPago.Location = new System.Drawing.Point(271, 114);
            this.cbxTipoPago.Name = "cbxTipoPago";
            this.cbxTipoPago.Size = new System.Drawing.Size(121, 27);
            this.cbxTipoPago.TabIndex = 55;
            this.cbxTipoPago.SelectedIndexChanged += new System.EventHandler(this.cbxTipoPago_SelectedIndexChanged);
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblTipoPago.Location = new System.Drawing.Point(267, 92);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(89, 19);
            this.lblTipoPago.TabIndex = 54;
            this.lblTipoPago.Text = "Tipo de pago";
            // 
            // lblEtiquetaFechaFin
            // 
            this.lblEtiquetaFechaFin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEtiquetaFechaFin.AutoSize = true;
            this.lblEtiquetaFechaFin.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblEtiquetaFechaFin.Location = new System.Drawing.Point(604, 32);
            this.lblEtiquetaFechaFin.Name = "lblEtiquetaFechaFin";
            this.lblEtiquetaFechaFin.Size = new System.Drawing.Size(141, 19);
            this.lblEtiquetaFechaFin.TabIndex = 52;
            this.lblEtiquetaFechaFin.Text = "Fecha de vencimiento";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFechaFin.Location = new System.Drawing.Point(613, 58);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(0, 19);
            this.lblFechaFin.TabIndex = 53;
            // 
            // lblNombreMiembro
            // 
            this.lblNombreMiembro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreMiembro.AutoSize = true;
            this.lblNombreMiembro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMiembro.Location = new System.Drawing.Point(25, 275);
            this.lblNombreMiembro.Name = "lblNombreMiembro";
            this.lblNombreMiembro.Size = new System.Drawing.Size(187, 17);
            this.lblNombreMiembro.TabIndex = 48;
            this.lblNombreMiembro.Text = "Añadir una nueva membresía";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(663, 302);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(105, 40);
            this.btnAceptar.TabIndex = 66;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblEtiquetaDescripcion
            // 
            this.lblEtiquetaDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEtiquetaDescripcion.AutoSize = true;
            this.lblEtiquetaDescripcion.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblEtiquetaDescripcion.Location = new System.Drawing.Point(558, 154);
            this.lblEtiquetaDescripcion.Name = "lblEtiquetaDescripcion";
            this.lblEtiquetaDescripcion.Size = new System.Drawing.Size(79, 19);
            this.lblEtiquetaDescripcion.TabIndex = 64;
            this.lblEtiquetaDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtDescripcion.Location = new System.Drawing.Point(562, 176);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(206, 92);
            this.txtDescripcion.TabIndex = 65;
            // 
            // lblEtiquetaFolioRemision
            // 
            this.lblEtiquetaFolioRemision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEtiquetaFolioRemision.AutoSize = true;
            this.lblEtiquetaFolioRemision.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblEtiquetaFolioRemision.Location = new System.Drawing.Point(270, 154);
            this.lblEtiquetaFolioRemision.Name = "lblEtiquetaFolioRemision";
            this.lblEtiquetaFolioRemision.Size = new System.Drawing.Size(94, 19);
            this.lblEtiquetaFolioRemision.TabIndex = 58;
            this.lblEtiquetaFolioRemision.Text = "Folio remisión";
            // 
            // txtFolio
            // 
            this.txtFolio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFolio.Enabled = false;
            this.txtFolio.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtFolio.Location = new System.Drawing.Point(274, 176);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(139, 26);
            this.txtFolio.TabIndex = 59;
            // 
            // lblEtiquetaPrecio
            // 
            this.lblEtiquetaPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEtiquetaPrecio.AutoSize = true;
            this.lblEtiquetaPrecio.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblEtiquetaPrecio.Location = new System.Drawing.Point(423, 176);
            this.lblEtiquetaPrecio.Name = "lblEtiquetaPrecio";
            this.lblEtiquetaPrecio.Size = new System.Drawing.Size(46, 19);
            this.lblEtiquetaPrecio.TabIndex = 56;
            this.lblEtiquetaPrecio.Text = "Precio";
            // 
            // lblEtiquetaFechaInicio
            // 
            this.lblEtiquetaFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEtiquetaFechaInicio.AutoSize = true;
            this.lblEtiquetaFechaInicio.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblEtiquetaFechaInicio.Location = new System.Drawing.Point(396, 32);
            this.lblEtiquetaFechaInicio.Name = "lblEtiquetaFechaInicio";
            this.lblEtiquetaFechaInicio.Size = new System.Drawing.Size(98, 19);
            this.lblEtiquetaFechaInicio.TabIndex = 51;
            this.lblEtiquetaFechaInicio.Text = "Fecha de inicio";
            // 
            // lblEtiquetaTipo
            // 
            this.lblEtiquetaTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEtiquetaTipo.AutoSize = true;
            this.lblEtiquetaTipo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblEtiquetaTipo.Location = new System.Drawing.Point(270, 32);
            this.lblEtiquetaTipo.Name = "lblEtiquetaTipo";
            this.lblEtiquetaTipo.Size = new System.Drawing.Size(64, 19);
            this.lblEtiquetaTipo.TabIndex = 49;
            this.lblEtiquetaTipo.Text = "Duración";
            // 
            // cbxTipo
            // 
            this.cbxTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Semanal",
            "1 Mes",
            "2 Meses",
            "3 Meses",
            "4 Meses",
            "5 Meses",
            "6 Meses",
            "7 Meses",
            "8 Meses",
            "9 Meses",
            "10 Meses",
            "11 Meses",
            "12 Meses"});
            this.cbxTipo.Location = new System.Drawing.Point(274, 54);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(99, 27);
            this.cbxTipo.TabIndex = 50;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(400, 61);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(195, 20);
            this.dtpFechaInicio.TabIndex = 75;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // frmEditarMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(791, 366);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.btnQuitarPromo);
            this.Controls.Add(this.btnAsignarPromo);
            this.Controls.Add(this.lblTarjeta);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.lblEfectivo);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.pcbSocio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFolioTicket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTerminacion);
            this.Controls.Add(this.cbxTipoPago);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.lblEtiquetaFechaFin);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblNombreMiembro);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblEtiquetaDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblEtiquetaFolioRemision);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.lblEtiquetaPrecio);
            this.Controls.Add(this.lblEtiquetaFechaInicio);
            this.Controls.Add(this.lblEtiquetaTipo);
            this.Controls.Add(this.cbxTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEditarMembresia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renovar membresía";
            this.Load += new System.EventHandler(this.frmEditarMembresia_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmEditarMembresia_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSocio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitarPromo;
        private System.Windows.Forms.Button btnAsignarPromo;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.PictureBox pcbSocio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFolioTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTerminacion;
        private System.Windows.Forms.ComboBox cbxTipoPago;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Label lblEtiquetaFechaFin;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblNombreMiembro;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblEtiquetaDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblEtiquetaFolioRemision;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label lblEtiquetaPrecio;
        private System.Windows.Forms.Label lblEtiquetaFechaInicio;
        private System.Windows.Forms.Label lblEtiquetaTipo;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
    }
}
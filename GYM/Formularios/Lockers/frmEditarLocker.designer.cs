namespace GYM.Formularios
{
    partial class frmEditarLocker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarLocker));
            this.lblNumLocker = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblTerminación = new System.Windows.Forms.Label();
            this.txtTerminación = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblFolioTicket = new System.Windows.Forms.Label();
            this.txtFolioTicket = new System.Windows.Forms.TextBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.lblSocio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumLocker
            // 
            this.lblNumLocker.AutoSize = true;
            this.lblNumLocker.Location = new System.Drawing.Point(12, 15);
            this.lblNumLocker.Name = "lblNumLocker";
            this.lblNumLocker.Size = new System.Drawing.Size(125, 19);
            this.lblNumLocker.TabIndex = 0;
            this.lblNumLocker.Text = "Número de locker: ";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(280, 58);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(82, 19);
            this.lblFechaFin.TabIndex = 7;
            this.lblFechaFin.Text = "Fecha de fin";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(284, 80);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(244, 25);
            this.dtpFechaFin.TabIndex = 8;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(280, 15);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(80, 19);
            this.lblBusqueda.TabIndex = 1;
            this.lblBusqueda.Text = "Asignado a:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(8, 130);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(270, 75);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(4, 108);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 19);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(530, 58);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(89, 19);
            this.lblTipoPago.TabIndex = 9;
            this.lblTipoPago.Text = "Tipo de pago";
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cboTipoPago.Location = new System.Drawing.Point(534, 80);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(244, 25);
            this.cboTipoPago.TabIndex = 10;
            this.cboTipoPago.SelectedIndexChanged += new System.EventHandler(this.cboTipoPago_SelectedIndexChanged);
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(534, 130);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(245, 25);
            this.txtFolio.TabIndex = 14;
            this.txtFolio.LostFocus += new System.EventHandler(this.txtFolio_LostFocus);
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Location = new System.Drawing.Point(530, 108);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(38, 19);
            this.lblFolio.TabIndex = 13;
            this.lblFolio.Text = "Folio";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(280, 108);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 19);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(284, 130);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(245, 25);
            this.txtPrecio.TabIndex = 12;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblTerminación
            // 
            this.lblTerminación.AutoSize = true;
            this.lblTerminación.Location = new System.Drawing.Point(530, 158);
            this.lblTerminación.Name = "lblTerminación";
            this.lblTerminación.Size = new System.Drawing.Size(82, 19);
            this.lblTerminación.TabIndex = 19;
            this.lblTerminación.Text = "Terminación";
            // 
            // txtTerminación
            // 
            this.txtTerminación.Enabled = false;
            this.txtTerminación.Location = new System.Drawing.Point(534, 180);
            this.txtTerminación.Name = "txtTerminación";
            this.txtTerminación.Size = new System.Drawing.Size(245, 25);
            this.txtTerminación.TabIndex = 20;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(673, 284);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 40);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblFolioTicket
            // 
            this.lblFolioTicket.AutoSize = true;
            this.lblFolioTicket.Location = new System.Drawing.Point(280, 158);
            this.lblFolioTicket.Name = "lblFolioTicket";
            this.lblFolioTicket.Size = new System.Drawing.Size(75, 19);
            this.lblFolioTicket.TabIndex = 17;
            this.lblFolioTicket.Text = "Folio ticket";
            // 
            // txtFolioTicket
            // 
            this.txtFolioTicket.Enabled = false;
            this.txtFolioTicket.Location = new System.Drawing.Point(284, 180);
            this.txtFolioTicket.Name = "txtFolioTicket";
            this.txtFolioTicket.Size = new System.Drawing.Size(245, 25);
            this.txtFolioTicket.TabIndex = 18;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(8, 58);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(98, 19);
            this.lblFechaInicio.TabIndex = 7;
            this.lblFechaInicio.Text = "Fecha de inicio";
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Location = new System.Drawing.Point(12, 80);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(245, 25);
            this.dtpFechaIni.TabIndex = 8;
            this.dtpFechaIni.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // lblSocio
            // 
            this.lblSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSocio.AutoSize = true;
            this.lblSocio.Location = new System.Drawing.Point(361, 15);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(116, 19);
            this.lblSocio.TabIndex = 1;
            this.lblSocio.Text = "Nombre del socio";
            // 
            // frmEditarLocker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(795, 336);
            this.Controls.Add(this.lblFolioTicket);
            this.Controls.Add(this.txtFolioTicket);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTerminación);
            this.Controls.Add(this.lblTerminación);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.cboTipoPago);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblSocio);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.dtpFechaIni);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblNumLocker);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEditarLocker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Locker";
            this.Load += new System.EventHandler(this.frmEditarLocker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumLocker;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblTerminación;
        private System.Windows.Forms.TextBox txtTerminación;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblFolioTicket;
        private System.Windows.Forms.TextBox txtFolioTicket;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Label lblSocio;
    }
}
namespace GYM.Formularios.Compras
{
    partial class frmCompras
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetallado = new System.Windows.Forms.Button();
            this.btnNuevaCompra = new System.Windows.Forms.Button();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.grbFechas = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.bgwBusqueda = new System.ComponentModel.BackgroundWorker();
            this.tmrEspera = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.grbFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CFecha,
            this.CUsuario,
            this.CTipoPago,
            this.CTotal});
            this.dgvCompras.Location = new System.Drawing.Point(141, 85);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCompras.RowHeadersVisible = false;
            this.dgvCompras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCompras.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompras.Size = new System.Drawing.Size(720, 284);
            this.dgvCompras.TabIndex = 1;
            this.dgvCompras.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_RowEnter);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // CFecha
            // 
            dataGridViewCellStyle1.Format = "dd \'de\' MMMM \'del\' yyyy hh:mm:ss tt";
            this.CFecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.CFecha.HeaderText = "Fecha de compra";
            this.CFecha.Name = "CFecha";
            this.CFecha.ReadOnly = true;
            this.CFecha.Width = 230;
            // 
            // CUsuario
            // 
            this.CUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUsuario.HeaderText = "Comprador";
            this.CUsuario.Name = "CUsuario";
            this.CUsuario.ReadOnly = true;
            // 
            // CTipoPago
            // 
            this.CTipoPago.HeaderText = "Tipo de pago";
            this.CTipoPago.Name = "CTipoPago";
            this.CTipoPago.ReadOnly = true;
            this.CTipoPago.Width = 120;
            // 
            // CTotal
            // 
            dataGridViewCellStyle2.Format = "C2";
            this.CTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.CTotal.HeaderText = "Total de compra";
            this.CTotal.Name = "CTotal";
            this.CTotal.ReadOnly = true;
            this.CTotal.Width = 120;
            // 
            // btnDetallado
            // 
            this.btnDetallado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnDetallado.FlatAppearance.BorderSize = 0;
            this.btnDetallado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnDetallado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetallado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetallado.ForeColor = System.Drawing.Color.White;
            this.btnDetallado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetallado.Location = new System.Drawing.Point(12, 151);
            this.btnDetallado.Name = "btnDetallado";
            this.btnDetallado.Size = new System.Drawing.Size(120, 60);
            this.btnDetallado.TabIndex = 3;
            this.btnDetallado.Text = "Detalle de\r\ncompra";
            this.btnDetallado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetallado.UseVisualStyleBackColor = false;
            this.btnDetallado.Click += new System.EventHandler(this.btnDetallado_Click);
            // 
            // btnNuevaCompra
            // 
            this.btnNuevaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnNuevaCompra.FlatAppearance.BorderSize = 0;
            this.btnNuevaCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnNuevaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCompra.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaCompra.Location = new System.Drawing.Point(12, 85);
            this.btnNuevaCompra.Name = "btnNuevaCompra";
            this.btnNuevaCompra.Size = new System.Drawing.Size(120, 60);
            this.btnNuevaCompra.TabIndex = 2;
            this.btnNuevaCompra.Text = "Nueva compra";
            this.btnNuevaCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaCompra.UseVisualStyleBackColor = false;
            this.btnNuevaCompra.Click += new System.EventHandler(this.btnNuevaCompra_Click);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaInicio.Location = new System.Drawing.Point(9, 34);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(240, 25);
            this.dtpFechaInicio.TabIndex = 1;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechas_ValueChanged);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFechaInicio.Location = new System.Drawing.Point(6, 16);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(86, 15);
            this.lblFechaInicio.TabIndex = 0;
            this.lblFechaInicio.Text = "Fecha de inicio";
            // 
            // grbFechas
            // 
            this.grbFechas.Controls.Add(this.btnBuscar);
            this.grbFechas.Controls.Add(this.lblFechaFin);
            this.grbFechas.Controls.Add(this.dtpFechaFin);
            this.grbFechas.Controls.Add(this.lblFechaInicio);
            this.grbFechas.Controls.Add(this.dtpFechaInicio);
            this.grbFechas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grbFechas.Location = new System.Drawing.Point(253, 12);
            this.grbFechas.Name = "grbFechas";
            this.grbFechas.Size = new System.Drawing.Size(608, 67);
            this.grbFechas.TabIndex = 0;
            this.grbFechas.TabStop = false;
            this.grbFechas.Text = "Búsqueda por fechas";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(501, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 50);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFechaFin.Location = new System.Drawing.Point(252, 16);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(71, 15);
            this.lblFechaFin.TabIndex = 2;
            this.lblFechaFin.Text = "Fecha de fin";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaFin.Location = new System.Drawing.Point(255, 34);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(240, 25);
            this.dtpFechaFin.TabIndex = 3;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechas_ValueChanged);
            // 
            // bgwBusqueda
            // 
            this.bgwBusqueda.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwBusqueda_DoWork);
            this.bgwBusqueda.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwBusqueda_RunWorkerCompleted);
            // 
            // tmrEspera
            // 
            this.tmrEspera.Interval = 300;
            this.tmrEspera.Tick += new System.EventHandler(this.tmrEspera_Tick);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(873, 381);
            this.Controls.Add(this.grbFechas);
            this.Controls.Add(this.btnDetallado);
            this.Controls.Add(this.btnNuevaCompra);
            this.Controls.Add(this.dgvCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.grbFechas.ResumeLayout(false);
            this.grbFechas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Button btnNuevaCompra;
        private System.Windows.Forms.Button btnDetallado;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.GroupBox grbFechas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.ComponentModel.BackgroundWorker bgwBusqueda;
        private System.Windows.Forms.Timer tmrEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotal;
    }
}
namespace GYM.Formularios.POS
{
    partial class frmPuntoVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuntoVenta));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnReimprimir = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            this.pcbProducto = new System.Windows.Forms.PictureBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblEVendedor = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblECliente = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblEFolio = new System.Windows.Forms.Label();
            this.grbTotales = new System.Windows.Forms.GroupBox();
            this.lblEDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblCantDif = new System.Windows.Forms.Label();
            this.lblECantDif = new System.Windows.Forms.Label();
            this.lblCantTot = new System.Windows.Forms.Label();
            this.lblECantTot = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblETotal = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblEImpuesto = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblESubtotal = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnSocio = new System.Windows.Forms.Button();
            this.bgwImagen = new System.ComponentModel.BackgroundWorker();
            this.cmsProductos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarPaqueteDeÉsteProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProducto)).BeginInit();
            this.grbTotales.SuspendLayout();
            this.cmsProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto,
            this.Nombre,
            this.Cantidad,
            this.Precio});
            this.dgvProductos.Location = new System.Drawing.Point(219, 53);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(721, 343);
            this.dgvProductos.TabIndex = 11;
            this.dgvProductos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_RowEnter);
            this.dgvProductos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProductos_RowsAdded);
            this.dgvProductos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvProductos_RowsRemoved);
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Código Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            this.CodigoProducto.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 120;
            // 
            // Precio
            // 
            dataGridViewCellStyle1.Format = "C2";
            this.Precio.DefaultCellStyle = dataGridViewCellStyle1;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 120;
            // 
            // btnProductos
            // 
            this.btnProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(219, 609);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(200, 60);
            this.btnProductos.TabIndex = 7;
            this.btnProductos.Text = "Productos\r\n(F4)";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Visible = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRecuperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnRecuperar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnRecuperar.FlatAppearance.BorderSize = 0;
            this.btnRecuperar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRecuperar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRecuperar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.ForeColor = System.Drawing.Color.White;
            this.btnRecuperar.Location = new System.Drawing.Point(12, 336);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(200, 60);
            this.btnRecuperar.TabIndex = 5;
            this.btnRecuperar.Text = "Recuperar Venta (F2)";
            this.btnRecuperar.UseVisualStyleBackColor = false;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(11, 264);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 60);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar Ventas (F3)";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnReimprimir
            // 
            this.btnReimprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReimprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnReimprimir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnReimprimir.FlatAppearance.BorderSize = 0;
            this.btnReimprimir.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReimprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnReimprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnReimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReimprimir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReimprimir.ForeColor = System.Drawing.Color.White;
            this.btnReimprimir.Location = new System.Drawing.Point(740, 408);
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.Size = new System.Drawing.Size(200, 60);
            this.btnReimprimir.TabIndex = 7;
            this.btnReimprimir.Text = "Re imprimir \n(F6)";
            this.btnReimprimir.UseVisualStyleBackColor = false;
            this.btnReimprimir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenos.Enabled = false;
            this.btnMenos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnMenos.FlatAppearance.BorderSize = 0;
            this.btnMenos.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMenos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenos.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.btnMenos.Location = new System.Drawing.Point(905, 104);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(35, 35);
            this.btnMenos.TabIndex = 17;
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMas
            // 
            this.btnMas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMas.Enabled = false;
            this.btnMas.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnMas.FlatAppearance.BorderSize = 0;
            this.btnMas.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMas.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.btnMas.Location = new System.Drawing.Point(905, 63);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(35, 35);
            this.btnMas.TabIndex = 16;
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnCobrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCobrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(740, 599);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(200, 70);
            this.btnCobrar.TabIndex = 9;
            this.btnCobrar.Text = "Cobrar\r\n(F6)";
            this.btnCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Visible = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnNueva
            // 
            this.btnNueva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnNueva.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnNueva.FlatAppearance.BorderSize = 0;
            this.btnNueva.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNueva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnNueva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueva.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueva.ForeColor = System.Drawing.Color.White;
            this.btnNueva.Location = new System.Drawing.Point(12, 609);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(200, 60);
            this.btnNueva.TabIndex = 4;
            this.btnNueva.Text = "Nueva Venta (F1)";
            this.btnNueva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNueva.UseVisualStyleBackColor = false;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // pcbProducto
            // 
            this.pcbProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pcbProducto.Enabled = false;
            this.pcbProducto.Location = new System.Drawing.Point(12, 63);
            this.pcbProducto.Name = "pcbProducto";
            this.pcbProducto.Size = new System.Drawing.Size(177, 178);
            this.pcbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbProducto.TabIndex = 38;
            this.pcbProducto.TabStop = false;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblVendedor.Location = new System.Drawing.Point(86, 36);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(0, 25);
            this.lblVendedor.TabIndex = 42;
            this.lblVendedor.Visible = false;
            // 
            // lblEVendedor
            // 
            this.lblEVendedor.AutoSize = true;
            this.lblEVendedor.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblEVendedor.Location = new System.Drawing.Point(6, 36);
            this.lblEVendedor.Name = "lblEVendedor";
            this.lblEVendedor.Size = new System.Drawing.Size(77, 25);
            this.lblEVendedor.TabIndex = 41;
            this.lblEVendedor.Text = "Atiende:";
            this.lblEVendedor.Visible = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCliente.Location = new System.Drawing.Point(86, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 25);
            this.lblCliente.TabIndex = 40;
            this.lblCliente.Visible = false;
            // 
            // lblECliente
            // 
            this.lblECliente.AutoSize = true;
            this.lblECliente.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblECliente.Location = new System.Drawing.Point(12, 9);
            this.lblECliente.Name = "lblECliente";
            this.lblECliente.Size = new System.Drawing.Size(60, 25);
            this.lblECliente.TabIndex = 39;
            this.lblECliente.Text = "Socio:";
            this.lblECliente.Visible = false;
            // 
            // lblFolio
            // 
            this.lblFolio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblFolio.Location = new System.Drawing.Point(779, 9);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(0, 25);
            this.lblFolio.TabIndex = 44;
            this.lblFolio.Visible = false;
            // 
            // lblEFolio
            // 
            this.lblEFolio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEFolio.AutoSize = true;
            this.lblEFolio.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblEFolio.Location = new System.Drawing.Point(652, 9);
            this.lblEFolio.Name = "lblEFolio";
            this.lblEFolio.Size = new System.Drawing.Size(128, 25);
            this.lblEFolio.TabIndex = 43;
            this.lblEFolio.Text = "Folio de venta:";
            this.lblEFolio.Visible = false;
            // 
            // grbTotales
            // 
            this.grbTotales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grbTotales.Controls.Add(this.lblEDescuento);
            this.grbTotales.Controls.Add(this.txtDescuento);
            this.grbTotales.Controls.Add(this.lblCantDif);
            this.grbTotales.Controls.Add(this.lblECantDif);
            this.grbTotales.Controls.Add(this.lblCantTot);
            this.grbTotales.Controls.Add(this.lblECantTot);
            this.grbTotales.Controls.Add(this.lblTotal);
            this.grbTotales.Controls.Add(this.lblETotal);
            this.grbTotales.Controls.Add(this.lblImpuesto);
            this.grbTotales.Controls.Add(this.lblEImpuesto);
            this.grbTotales.Controls.Add(this.lblSubtotal);
            this.grbTotales.Controls.Add(this.lblESubtotal);
            this.grbTotales.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTotales.Location = new System.Drawing.Point(11, 460);
            this.grbTotales.Name = "grbTotales";
            this.grbTotales.Size = new System.Drawing.Size(476, 143);
            this.grbTotales.TabIndex = 46;
            this.grbTotales.TabStop = false;
            this.grbTotales.Text = "Información de venta";
            this.grbTotales.Visible = false;
            // 
            // lblEDescuento
            // 
            this.lblEDescuento.AutoSize = true;
            this.lblEDescuento.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEDescuento.Location = new System.Drawing.Point(220, 14);
            this.lblEDescuento.Name = "lblEDescuento";
            this.lblEDescuento.Size = new System.Drawing.Size(82, 20);
            this.lblEDescuento.TabIndex = 44;
            this.lblEDescuento.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescuento.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtDescuento.Location = new System.Drawing.Point(224, 37);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(153, 27);
            this.txtDescuento.TabIndex = 43;
            this.txtDescuento.Text = "0.00";
            // 
            // lblCantDif
            // 
            this.lblCantDif.AutoSize = true;
            this.lblCantDif.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantDif.Location = new System.Drawing.Point(359, 78);
            this.lblCantDif.Name = "lblCantDif";
            this.lblCantDif.Size = new System.Drawing.Size(19, 21);
            this.lblCantDif.TabIndex = 9;
            this.lblCantDif.Text = "0";
            // 
            // lblECantDif
            // 
            this.lblECantDif.AutoSize = true;
            this.lblECantDif.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblECantDif.Location = new System.Drawing.Point(220, 78);
            this.lblECantDif.Name = "lblECantDif";
            this.lblECantDif.Size = new System.Drawing.Size(147, 21);
            this.lblECantDif.TabIndex = 8;
            this.lblECantDif.Text = "Cant. productos dif.:";
            // 
            // lblCantTot
            // 
            this.lblCantTot.AutoSize = true;
            this.lblCantTot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantTot.Location = new System.Drawing.Point(359, 101);
            this.lblCantTot.Name = "lblCantTot";
            this.lblCantTot.Size = new System.Drawing.Size(19, 21);
            this.lblCantTot.TabIndex = 11;
            this.lblCantTot.Text = "0";
            // 
            // lblECantTot
            // 
            this.lblECantTot.AutoSize = true;
            this.lblECantTot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblECantTot.Location = new System.Drawing.Point(245, 101);
            this.lblECantTot.Name = "lblECantTot";
            this.lblECantTot.Size = new System.Drawing.Size(119, 21);
            this.lblECantTot.TabIndex = 10;
            this.lblECantTot.Text = "Total productos:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(90, 87);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(50, 21);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "$0.00";
            // 
            // lblETotal
            // 
            this.lblETotal.AutoSize = true;
            this.lblETotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblETotal.Location = new System.Drawing.Point(42, 87);
            this.lblETotal.Name = "lblETotal";
            this.lblETotal.Size = new System.Drawing.Size(45, 21);
            this.lblETotal.TabIndex = 6;
            this.lblETotal.Text = "Total:";
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuesto.Location = new System.Drawing.Point(90, 64);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(50, 21);
            this.lblImpuesto.TabIndex = 3;
            this.lblImpuesto.Text = "$0.00";
            // 
            // lblEImpuesto
            // 
            this.lblEImpuesto.AutoSize = true;
            this.lblEImpuesto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEImpuesto.Location = new System.Drawing.Point(14, 64);
            this.lblEImpuesto.Name = "lblEImpuesto";
            this.lblEImpuesto.Size = new System.Drawing.Size(78, 21);
            this.lblEImpuesto.TabIndex = 2;
            this.lblEImpuesto.Text = "Impuesto:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(90, 39);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(50, 21);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "$0.00";
            // 
            // lblESubtotal
            // 
            this.lblESubtotal.AutoSize = true;
            this.lblESubtotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblESubtotal.Location = new System.Drawing.Point(20, 39);
            this.lblESubtotal.Name = "lblESubtotal";
            this.lblESubtotal.Size = new System.Drawing.Size(71, 21);
            this.lblESubtotal.TabIndex = 0;
            this.lblESubtotal.Text = "Subtotal:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBusqueda.Enabled = false;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtBusqueda.Location = new System.Drawing.Point(11, 423);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(476, 31);
            this.txtBusqueda.TabIndex = 45;
            // 
            // btnSocio
            // 
            this.btnSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnSocio.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnSocio.FlatAppearance.BorderSize = 0;
            this.btnSocio.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSocio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSocio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSocio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSocio.ForeColor = System.Drawing.Color.White;
            this.btnSocio.Location = new System.Drawing.Point(425, 609);
            this.btnSocio.Name = "btnSocio";
            this.btnSocio.Size = new System.Drawing.Size(200, 60);
            this.btnSocio.TabIndex = 47;
            this.btnSocio.Text = "Socios (F5)";
            this.btnSocio.UseVisualStyleBackColor = false;
            this.btnSocio.Visible = false;
            // 
            // cmsProductos
            // 
            this.cmsProductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPaqueteDeÉsteProductoToolStripMenuItem});
            this.cmsProductos.Name = "cmsProductos";
            this.cmsProductos.Size = new System.Drawing.Size(260, 26);
            // 
            // agregarPaqueteDeÉsteProductoToolStripMenuItem
            // 
            this.agregarPaqueteDeÉsteProductoToolStripMenuItem.Name = "agregarPaqueteDeÉsteProductoToolStripMenuItem";
            this.agregarPaqueteDeÉsteProductoToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.agregarPaqueteDeÉsteProductoToolStripMenuItem.Text = "Agregar paquetes de éste producto";
            // 
            // frmPuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(952, 681);
            this.Controls.Add(this.btnSocio);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.grbTotales);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.lblEFolio);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lblEVendedor);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblECliente);
            this.Controls.Add(this.pcbProducto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.btnReimprimir);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnNueva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPuntoVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto de venta";
            this.Load += new System.EventHandler(this.frmPuntoVenta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPuntoVenta_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProducto)).EndInit();
            this.grbTotales.ResumeLayout(false);
            this.grbTotales.PerformLayout();
            this.cmsProductos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btnReimprimir;
        private System.Windows.Forms.PictureBox pcbProducto;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblEVendedor;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblECliente;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label lblEFolio;
        private System.Windows.Forms.GroupBox grbTotales;
        private System.Windows.Forms.Label lblEDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblCantDif;
        private System.Windows.Forms.Label lblECantDif;
        private System.Windows.Forms.Label lblCantTot;
        private System.Windows.Forms.Label lblECantTot;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblETotal;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblEImpuesto;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblESubtotal;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnSocio;
        private System.ComponentModel.BackgroundWorker bgwImagen;
        private System.Windows.Forms.ContextMenuStrip cmsProductos;
        private System.Windows.Forms.ToolStripMenuItem agregarPaqueteDeÉsteProductoToolStripMenuItem;
    }
}
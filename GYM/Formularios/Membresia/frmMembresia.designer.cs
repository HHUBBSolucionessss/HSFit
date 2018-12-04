namespace GYM.Formularios.Membresia
{
    partial class frmMembresia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMembresia));
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblInstruccionesBusqueda = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnPendiente = new System.Windows.Forms.Button();
            this.bgwBusqueda = new System.ComponentModel.BackgroundWorker();
            this.tmrEspera = new System.Windows.Forms.Timer(this.components);
            this.lblMActivas = new System.Windows.Forms.Label();
            this.lblMInactivas = new System.Windows.Forms.Label();
            this.lblMPendientes = new System.Windows.Forms.Label();
            this.lblMRechazadas = new System.Windows.Forms.Label();
            this.lblActivas = new System.Windows.Forms.Label();
            this.lblInactivas = new System.Windows.Forms.Label();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.lblRechazadas = new System.Windows.Forms.Label();
            this.lblMSininfo = new System.Windows.Forms.Label();
            this.lblSininfo = new System.Windows.Forms.Label();
            this.btnReimprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AllowUserToDeleteRows = false;
            this.dgvPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPersonas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPersonas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Socio,
            this.Estado,
            this.FechaInicio,
            this.fechaVencimiento,
            this.Genero});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersonas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersonas.Location = new System.Drawing.Point(158, 45);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPersonas.RowHeadersVisible = false;
            this.dgvPersonas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPersonas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(936, 360);
            this.dgvPersonas.TabIndex = 3;
           
           
            this.dgvPersonas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonas_RowEnter);
            // 
            // ID
            // 
            this.ID.HeaderText = "Número Socio";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 150;
            // 
            // Socio
            // 
            this.Socio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Socio.HeaderText = "Nombre y apellido";
            this.Socio.Name = "Socio";
            this.Socio.ReadOnly = true;
            this.Socio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado Membresía";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Estado.Width = 180;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FechaInicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FechaInicio.Width = 170;
            // 
            // fechaVencimiento
            // 
            this.fechaVencimiento.HeaderText = "Fecha Vencimiento";
            this.fechaVencimiento.Name = "fechaVencimiento";
            this.fechaVencimiento.ReadOnly = true;
            this.fechaVencimiento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fechaVencimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fechaVencimiento.Width = 170;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(225, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Administración de membresias";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBusqueda.Location = new System.Drawing.Point(886, 12);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(208, 27);
            this.txtBusqueda.TabIndex = 2;
            this.txtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyDown);
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyUp);
            // 
            // lblInstruccionesBusqueda
            // 
            this.lblInstruccionesBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstruccionesBusqueda.AutoSize = true;
            this.lblInstruccionesBusqueda.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblInstruccionesBusqueda.Location = new System.Drawing.Point(632, 16);
            this.lblInstruccionesBusqueda.Name = "lblInstruccionesBusqueda";
            this.lblInstruccionesBusqueda.Size = new System.Drawing.Size(248, 19);
            this.lblInstruccionesBusqueda.TabIndex = 1;
            this.lblInstruccionesBusqueda.Text = "Buscar por número de socio o nombre ";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(12, 45);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(140, 50);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nueva \r\nmembresía";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(12, 101);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(140, 50);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Renovar \r\nmembresía";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnPendiente
            // 
            this.btnPendiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnPendiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPendiente.FlatAppearance.BorderSize = 0;
            this.btnPendiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnPendiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendiente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendiente.ForeColor = System.Drawing.Color.White;
            this.btnPendiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPendiente.Location = new System.Drawing.Point(12, 213);
            this.btnPendiente.Name = "btnPendiente";
            this.btnPendiente.Size = new System.Drawing.Size(140, 50);
            this.btnPendiente.TabIndex = 6;
            this.btnPendiente.Text = "Actualizar estado a pendiente";
            this.btnPendiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPendiente.UseVisualStyleBackColor = false;
            this.btnPendiente.Click += new System.EventHandler(this.btnPendiente_Click);
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
            // lblMActivas
            // 
            this.lblMActivas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMActivas.AutoSize = true;
            this.lblMActivas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMActivas.Location = new System.Drawing.Point(164, 419);
            this.lblMActivas.Name = "lblMActivas";
            this.lblMActivas.Size = new System.Drawing.Size(54, 17);
            this.lblMActivas.TabIndex = 7;
            this.lblMActivas.Text = "Activas:";
            // 
            // lblMInactivas
            // 
            this.lblMInactivas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMInactivas.AutoSize = true;
            this.lblMInactivas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMInactivas.Location = new System.Drawing.Point(341, 419);
            this.lblMInactivas.Name = "lblMInactivas";
            this.lblMInactivas.Size = new System.Drawing.Size(64, 17);
            this.lblMInactivas.TabIndex = 7;
            this.lblMInactivas.Text = "Inactivas:";
            // 
            // lblMPendientes
            // 
            this.lblMPendientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMPendientes.AutoSize = true;
            this.lblMPendientes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPendientes.Location = new System.Drawing.Point(541, 419);
            this.lblMPendientes.Name = "lblMPendientes";
            this.lblMPendientes.Size = new System.Drawing.Size(82, 17);
            this.lblMPendientes.TabIndex = 7;
            this.lblMPendientes.Text = " Pendientes:";
            // 
            // lblMRechazadas
            // 
            this.lblMRechazadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMRechazadas.AutoSize = true;
            this.lblMRechazadas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRechazadas.Location = new System.Drawing.Point(751, 419);
            this.lblMRechazadas.Name = "lblMRechazadas";
            this.lblMRechazadas.Size = new System.Drawing.Size(81, 17);
            this.lblMRechazadas.TabIndex = 7;
            this.lblMRechazadas.Text = "Rechazadas:";
            // 
            // lblActivas
            // 
            this.lblActivas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblActivas.AutoSize = true;
            this.lblActivas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivas.Location = new System.Drawing.Point(225, 419);
            this.lblActivas.Name = "lblActivas";
            this.lblActivas.Size = new System.Drawing.Size(0, 17);
            this.lblActivas.TabIndex = 7;
            // 
            // lblInactivas
            // 
            this.lblInactivas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInactivas.AutoSize = true;
            this.lblInactivas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactivas.Location = new System.Drawing.Point(412, 419);
            this.lblInactivas.Name = "lblInactivas";
            this.lblInactivas.Size = new System.Drawing.Size(0, 17);
            this.lblInactivas.TabIndex = 7;
            // 
            // lblPendientes
            // 
            this.lblPendientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendientes.Location = new System.Drawing.Point(629, 419);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(0, 17);
            this.lblPendientes.TabIndex = 7;
            // 
            // lblRechazadas
            // 
            this.lblRechazadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRechazadas.AutoSize = true;
            this.lblRechazadas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechazadas.Location = new System.Drawing.Point(839, 419);
            this.lblRechazadas.Name = "lblRechazadas";
            this.lblRechazadas.Size = new System.Drawing.Size(0, 17);
            this.lblRechazadas.TabIndex = 7;
            // 
            // lblMSininfo
            // 
            this.lblMSininfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMSininfo.AutoSize = true;
            this.lblMSininfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSininfo.Location = new System.Drawing.Point(920, 419);
            this.lblMSininfo.Name = "lblMSininfo";
            this.lblMSininfo.Size = new System.Drawing.Size(106, 17);
            this.lblMSininfo.TabIndex = 7;
            this.lblMSininfo.Text = "Sin Información:";
            // 
            // lblSininfo
            // 
            this.lblSininfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSininfo.AutoSize = true;
            this.lblSininfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSininfo.Location = new System.Drawing.Point(1024, 419);
            this.lblSininfo.Name = "lblSininfo";
            this.lblSininfo.Size = new System.Drawing.Size(0, 17);
            this.lblSininfo.TabIndex = 7;
            // 
            // btnReimprimir
            // 
            this.btnReimprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnReimprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReimprimir.FlatAppearance.BorderSize = 0;
            this.btnReimprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnReimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReimprimir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReimprimir.ForeColor = System.Drawing.Color.White;
            this.btnReimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReimprimir.Location = new System.Drawing.Point(12, 157);
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.Size = new System.Drawing.Size(140, 50);
            this.btnReimprimir.TabIndex = 6;
            this.btnReimprimir.Text = "Re imprimir";
            this.btnReimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReimprimir.UseVisualStyleBackColor = false;
            this.btnReimprimir.Click += new System.EventHandler(this.btnReimprimir_Click);
            // 
            // frmMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1106, 447);
            this.Controls.Add(this.lblSininfo);
            this.Controls.Add(this.lblRechazadas);
            this.Controls.Add(this.lblMSininfo);
            this.Controls.Add(this.lblMRechazadas);
            this.Controls.Add(this.lblPendientes);
            this.Controls.Add(this.lblMPendientes);
            this.Controls.Add(this.lblInactivas);
            this.Controls.Add(this.lblMInactivas);
            this.Controls.Add(this.lblActivas);
            this.Controls.Add(this.lblMActivas);
            this.Controls.Add(this.btnReimprimir);
            this.Controls.Add(this.btnPendiente);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblInstruccionesBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvPersonas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMembresia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membresias HS FIT";
            this.Load += new System.EventHandler(this.frmMembresia_Load);
            this.Shown += new System.EventHandler(this.frmMembresia_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblInstruccionesBusqueda;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnPendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.ComponentModel.BackgroundWorker bgwBusqueda;
        private System.Windows.Forms.Timer tmrEspera;
        private System.Windows.Forms.Label lblMActivas;
        private System.Windows.Forms.Label lblMInactivas;
        private System.Windows.Forms.Label lblMPendientes;
        private System.Windows.Forms.Label lblMRechazadas;
        private System.Windows.Forms.Label lblActivas;
        private System.Windows.Forms.Label lblInactivas;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label lblRechazadas;
        private System.Windows.Forms.Label lblMSininfo;
        private System.Windows.Forms.Label lblSininfo;
        private System.Windows.Forms.Button btnReimprimir;
    }
}
namespace GYM.Formularios
{
    partial class frmIngresoSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoSocio));
            this.lblNumSocio = new System.Windows.Forms.Label();
            this.tbxNumSocio = new System.Windows.Forms.TextBox();
            this.btnRegEntrada = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tmrTiempo = new System.Windows.Forms.Timer(this.components);
            this.tmrPromociones = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.btnConfiguración = new System.Windows.Forms.Button();
            this.bgwActualizaSocios = new System.ComponentModel.BackgroundWorker();
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.pcbPromociones = new System.Windows.Forms.PictureBox();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPromociones)).BeginInit();
            this.pnlOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumSocio
            // 
            this.lblNumSocio.AutoSize = true;
            this.lblNumSocio.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSocio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumSocio.Location = new System.Drawing.Point(17, 90);
            this.lblNumSocio.Name = "lblNumSocio";
            this.lblNumSocio.Size = new System.Drawing.Size(388, 25);
            this.lblNumSocio.TabIndex = 3;
            this.lblNumSocio.Text = "Ingresa tu número de socio y presiona enter";
            this.lblNumSocio.Click += new System.EventHandler(this.lblNumSocio_Click);
            // 
            // tbxNumSocio
            // 
            this.tbxNumSocio.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tbxNumSocio.Location = new System.Drawing.Point(22, 135);
            this.tbxNumSocio.MaxLength = 8;
            this.tbxNumSocio.Name = "tbxNumSocio";
            this.tbxNumSocio.Size = new System.Drawing.Size(273, 34);
            this.tbxNumSocio.TabIndex = 4;
            this.tbxNumSocio.TextChanged += new System.EventHandler(this.tbxNumSocio_TextChanged);
            this.tbxNumSocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumSocio_KeyPress);
            // 
            // btnRegEntrada
            // 
            this.btnRegEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnRegEntrada.FlatAppearance.BorderSize = 0;
            this.btnRegEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnRegEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegEntrada.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegEntrada.ForeColor = System.Drawing.Color.White;
            this.btnRegEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegEntrada.Location = new System.Drawing.Point(301, 135);
            this.btnRegEntrada.Name = "btnRegEntrada";
            this.btnRegEntrada.Size = new System.Drawing.Size(73, 34);
            this.btnRegEntrada.TabIndex = 5;
            this.btnRegEntrada.Text = "Aceptar";
            this.btnRegEntrada.UseVisualStyleBackColor = false;
            this.btnRegEntrada.Click += new System.EventHandler(this.btnRegEntrada_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblFecha.Location = new System.Drawing.Point(17, 16);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(154, 32);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha y hora";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // tmrTiempo
            // 
            this.tmrTiempo.Interval = 1000;
            this.tmrTiempo.Tick += new System.EventHandler(this.tmrTiempo_Tick);
            // 
            // tmrPromociones
            // 
            this.tmrPromociones.Interval = 60000;
            this.tmrPromociones.Tick += new System.EventHandler(this.tmrPromociones_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHora.Location = new System.Drawing.Point(491, 16);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(154, 32);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "Fecha y hora";
            // 
            // btnConfiguración
            // 
            this.btnConfiguración.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfiguración.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnConfiguración.FlatAppearance.BorderSize = 0;
            this.btnConfiguración.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnConfiguración.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguración.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguración.ForeColor = System.Drawing.Color.White;
            this.btnConfiguración.Location = new System.Drawing.Point(715, 128);
            this.btnConfiguración.Name = "btnConfiguración";
            this.btnConfiguración.Size = new System.Drawing.Size(154, 41);
            this.btnConfiguración.TabIndex = 2;
            this.btnConfiguración.Text = "Cambiar configuración";
            this.btnConfiguración.UseVisualStyleBackColor = false;
            this.btnConfiguración.Click += new System.EventHandler(this.btnConfiguración_Click);
            // 
            // bgwActualizaSocios
            // 
            this.bgwActualizaSocios.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pnlFondo
            // 
            this.pnlFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFondo.AutoSize = true;
            this.pnlFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlFondo.Controls.Add(this.pcbPromociones);
            this.pnlFondo.Location = new System.Drawing.Point(0, 200);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(884, 311);
            this.pnlFondo.TabIndex = 6;
            // 
            // pcbPromociones
            // 
            this.pcbPromociones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pcbPromociones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbPromociones.Image = global::GYM.Properties.Resources.Fondo;
            this.pcbPromociones.Location = new System.Drawing.Point(0, 0);
            this.pcbPromociones.Margin = new System.Windows.Forms.Padding(5);
            this.pcbPromociones.Name = "pcbPromociones";
            this.pcbPromociones.Size = new System.Drawing.Size(884, 311);
            this.pcbPromociones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPromociones.TabIndex = 5;
            this.pcbPromociones.TabStop = false;
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOpciones.AutoSize = true;
            this.pnlOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlOpciones.Controls.Add(this.lblFecha);
            this.pnlOpciones.Controls.Add(this.lblNumSocio);
            this.pnlOpciones.Controls.Add(this.btnConfiguración);
            this.pnlOpciones.Controls.Add(this.tbxNumSocio);
            this.pnlOpciones.Controls.Add(this.lblHora);
            this.pnlOpciones.Controls.Add(this.btnRegEntrada);
            this.pnlOpciones.Location = new System.Drawing.Point(12, 12);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(872, 182);
            this.pnlOpciones.TabIndex = 7;
            // 
            // frmIngresoSocio
            // 
            this.AcceptButton = this.btnRegEntrada;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmIngresoSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de socios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRegistroEntradas_FormClosed);
            this.Load += new System.EventHandler(this.frmRegistroEntradas_Load);
            this.pnlFondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPromociones)).EndInit();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumSocio;
        private System.Windows.Forms.TextBox tbxNumSocio;
        private System.Windows.Forms.Button btnRegEntrada;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer tmrTiempo;
        private System.Windows.Forms.Timer tmrPromociones;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnConfiguración;
        private System.ComponentModel.BackgroundWorker bgwActualizaSocios;
        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.PictureBox pcbPromociones;
    }
}
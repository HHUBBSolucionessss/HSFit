namespace GYM.Formularios.PuntoDeVenta
{
    partial class frmVisita
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
            this.chbTarjeta = new System.Windows.Forms.CheckBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblEtiquetaFolio = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.lblEtiquetaEfectivo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTarjeta = new System.Windows.Forms.Panel();
            this.txtTerminacion = new System.Windows.Forms.TextBox();
            this.lblFolioTicket = new System.Windows.Forms.Label();
            this.lblTerminacion = new System.Windows.Forms.Label();
            this.txtFolioTicket = new System.Windows.Forms.TextBox();
            this.pnlTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbTarjeta
            // 
            this.chbTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbTarjeta.AutoSize = true;
            this.chbTarjeta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chbTarjeta.Location = new System.Drawing.Point(16, 232);
            this.chbTarjeta.Name = "chbTarjeta";
            this.chbTarjeta.Size = new System.Drawing.Size(145, 25);
            this.chbTarjeta.TabIndex = 27;
            this.chbTarjeta.Text = "Pagar con tarjeta";
            this.chbTarjeta.UseVisualStyleBackColor = true;
            this.chbTarjeta.CheckedChanged += new System.EventHandler(this.chbTarjeta_CheckedChanged);
            // 
            // btnCobrar
            // 
            this.btnCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCobrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnCobrar.FlatAppearance.BorderSize = 2;
            this.btnCobrar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCobrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCobrar.Image = global::GYM.Properties.Resources.ImgAceptar;
            this.btnCobrar.Location = new System.Drawing.Point(372, 228);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(105, 39);
            this.btnCobrar.TabIndex = 28;
            this.btnCobrar.Text = "Aceptar";
            this.btnCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCobrar.UseVisualStyleBackColor = true;
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFolio.Location = new System.Drawing.Point(65, 9);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(82, 21);
            this.lblFolio.TabIndex = 16;
            this.lblFolio.Text = "00000000";
            // 
            // lblEtiquetaFolio
            // 
            this.lblEtiquetaFolio.AutoSize = true;
            this.lblEtiquetaFolio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEtiquetaFolio.Location = new System.Drawing.Point(12, 9);
            this.lblEtiquetaFolio.Name = "lblEtiquetaFolio";
            this.lblEtiquetaFolio.Size = new System.Drawing.Size(47, 21);
            this.lblEtiquetaFolio.TabIndex = 15;
            this.lblEtiquetaFolio.Text = "Folio:";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEfectivo.Location = new System.Drawing.Point(85, 85);
            this.txtEfectivo.MaxLength = 6;
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(149, 29);
            this.txtEfectivo.TabIndex = 21;
            // 
            // lblEtiquetaEfectivo
            // 
            this.lblEtiquetaEfectivo.AutoSize = true;
            this.lblEtiquetaEfectivo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEtiquetaEfectivo.Location = new System.Drawing.Point(12, 88);
            this.lblEtiquetaEfectivo.Name = "lblEtiquetaEfectivo";
            this.lblEtiquetaEfectivo.Size = new System.Drawing.Size(67, 21);
            this.lblEtiquetaEfectivo.TabIndex = 20;
            this.lblEtiquetaEfectivo.Text = "Efectivo:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox1.Location = new System.Drawing.Point(85, 48);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 29);
            this.textBox1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlTarjeta
            // 
            this.pnlTarjeta.Controls.Add(this.txtTerminacion);
            this.pnlTarjeta.Controls.Add(this.lblFolioTicket);
            this.pnlTarjeta.Controls.Add(this.lblTerminacion);
            this.pnlTarjeta.Controls.Add(this.txtFolioTicket);
            this.pnlTarjeta.Location = new System.Drawing.Point(16, 143);
            this.pnlTarjeta.Name = "pnlTarjeta";
            this.pnlTarjeta.Size = new System.Drawing.Size(425, 58);
            this.pnlTarjeta.TabIndex = 31;
            this.pnlTarjeta.Visible = false;
            // 
            // txtTerminacion
            // 
            this.txtTerminacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTerminacion.Location = new System.Drawing.Point(215, 23);
            this.txtTerminacion.MaxLength = 5;
            this.txtTerminacion.Name = "txtTerminacion";
            this.txtTerminacion.Size = new System.Drawing.Size(198, 25);
            this.txtTerminacion.TabIndex = 3;
            // 
            // lblFolioTicket
            // 
            this.lblFolioTicket.AutoSize = true;
            this.lblFolioTicket.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFolioTicket.Location = new System.Drawing.Point(8, 1);
            this.lblFolioTicket.Name = "lblFolioTicket";
            this.lblFolioTicket.Size = new System.Drawing.Size(94, 19);
            this.lblFolioTicket.TabIndex = 0;
            this.lblFolioTicket.Text = "Folio de ticket";
            // 
            // lblTerminacion
            // 
            this.lblTerminacion.AutoSize = true;
            this.lblTerminacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTerminacion.Location = new System.Drawing.Point(210, 1);
            this.lblTerminacion.Name = "lblTerminacion";
            this.lblTerminacion.Size = new System.Drawing.Size(82, 19);
            this.lblTerminacion.TabIndex = 2;
            this.lblTerminacion.Text = "Terminación";
            // 
            // txtFolioTicket
            // 
            this.txtFolioTicket.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFolioTicket.Location = new System.Drawing.Point(12, 23);
            this.txtFolioTicket.Name = "txtFolioTicket";
            this.txtFolioTicket.Size = new System.Drawing.Size(197, 25);
            this.txtFolioTicket.TabIndex = 1;
            // 
            // frmVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 279);
            this.Controls.Add(this.pnlTarjeta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbTarjeta);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.lblEtiquetaFolio);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.lblEtiquetaEfectivo);
            this.Name = "frmVisita";
            this.Text = "Visita";
            this.pnlTarjeta.ResumeLayout(false);
            this.pnlTarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbTarjeta;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label lblEtiquetaFolio;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label lblEtiquetaEfectivo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTarjeta;
        private System.Windows.Forms.TextBox txtTerminacion;
        private System.Windows.Forms.Label lblFolioTicket;
        private System.Windows.Forms.Label lblTerminacion;
        private System.Windows.Forms.TextBox txtFolioTicket;
    }
}
﻿namespace GYM.Formularios.POS
{
    partial class frmCobrar2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobrar2));
            this.lblEtiquetaEfectivo = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.lblEtiquetaTarjeta = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblEtiquetaTotal = new System.Windows.Forms.Label();
            this.lblEtiquetaCambio = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblEtiquetaFolio = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblEtiquetaCantidad = new System.Windows.Forms.Label();
            this.chbTarjeta = new System.Windows.Forms.CheckBox();
            this.lblFolioTicket = new System.Windows.Forms.Label();
            this.txtFolioTicket = new System.Windows.Forms.TextBox();
            this.txtTerminacion = new System.Windows.Forms.TextBox();
            this.lblTerminacion = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.pnlTarjeta = new System.Windows.Forms.Panel();
            this.chbMixto = new System.Windows.Forms.CheckBox();
            this.pnlTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEtiquetaEfectivo
            // 
            this.lblEtiquetaEfectivo.AutoSize = true;
            this.lblEtiquetaEfectivo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEtiquetaEfectivo.Location = new System.Drawing.Point(200, 67);
            this.lblEtiquetaEfectivo.Name = "lblEtiquetaEfectivo";
            this.lblEtiquetaEfectivo.Size = new System.Drawing.Size(67, 21);
            this.lblEtiquetaEfectivo.TabIndex = 6;
            this.lblEtiquetaEfectivo.Text = "Efectivo:";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEfectivo.Location = new System.Drawing.Point(273, 64);
            this.txtEfectivo.MaxLength = 6;
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(116, 29);
            this.txtEfectivo.TabIndex = 7;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            this.txtEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinero_KeyPress);
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Enabled = false;
            this.txtTarjeta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTarjeta.Location = new System.Drawing.Point(274, 108);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(116, 29);
            this.txtTarjeta.TabIndex = 9;
            this.txtTarjeta.TextChanged += new System.EventHandler(this.txtTarjeta_TextChanged);
            this.txtTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinero_KeyPress);
            // 
            // lblEtiquetaTarjeta
            // 
            this.lblEtiquetaTarjeta.AutoSize = true;
            this.lblEtiquetaTarjeta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEtiquetaTarjeta.Location = new System.Drawing.Point(208, 111);
            this.lblEtiquetaTarjeta.Name = "lblEtiquetaTarjeta";
            this.lblEtiquetaTarjeta.Size = new System.Drawing.Size(58, 21);
            this.lblEtiquetaTarjeta.TabIndex = 8;
            this.lblEtiquetaTarjeta.Text = "Tarjeta:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotal.Location = new System.Drawing.Point(277, 23);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 21);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "$0.00";
            // 
            // lblEtiquetaTotal
            // 
            this.lblEtiquetaTotal.AutoSize = true;
            this.lblEtiquetaTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEtiquetaTotal.Location = new System.Drawing.Point(224, 23);
            this.lblEtiquetaTotal.Name = "lblEtiquetaTotal";
            this.lblEtiquetaTotal.Size = new System.Drawing.Size(45, 21);
            this.lblEtiquetaTotal.TabIndex = 4;
            this.lblEtiquetaTotal.Text = "Total:";
            // 
            // lblEtiquetaCambio
            // 
            this.lblEtiquetaCambio.AutoSize = true;
            this.lblEtiquetaCambio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEtiquetaCambio.Location = new System.Drawing.Point(200, 155);
            this.lblEtiquetaCambio.Name = "lblEtiquetaCambio";
            this.lblEtiquetaCambio.Size = new System.Drawing.Size(67, 21);
            this.lblEtiquetaCambio.TabIndex = 10;
            this.lblEtiquetaCambio.Text = "Cambio:";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.BackColor = System.Drawing.Color.IndianRed;
            this.lblCambio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCambio.ForeColor = System.Drawing.Color.White;
            this.lblCambio.Location = new System.Drawing.Point(273, 155);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(49, 21);
            this.lblCambio.TabIndex = 11;
            this.lblCambio.Text = "$0.00";
            // 
            // lblEtiquetaFolio
            // 
            this.lblEtiquetaFolio.AutoSize = true;
            this.lblEtiquetaFolio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEtiquetaFolio.Location = new System.Drawing.Point(7, 23);
            this.lblEtiquetaFolio.Name = "lblEtiquetaFolio";
            this.lblEtiquetaFolio.Size = new System.Drawing.Size(47, 21);
            this.lblEtiquetaFolio.TabIndex = 0;
            this.lblEtiquetaFolio.Text = "Folio:";
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFolio.Location = new System.Drawing.Point(7, 54);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(82, 21);
            this.lblFolio.TabIndex = 1;
            this.lblFolio.Text = "00000000";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCantidad.Location = new System.Drawing.Point(7, 129);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(19, 21);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "0";
            // 
            // lblEtiquetaCantidad
            // 
            this.lblEtiquetaCantidad.AutoSize = true;
            this.lblEtiquetaCantidad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEtiquetaCantidad.Location = new System.Drawing.Point(7, 98);
            this.lblEtiquetaCantidad.Name = "lblEtiquetaCantidad";
            this.lblEtiquetaCantidad.Size = new System.Drawing.Size(148, 21);
            this.lblEtiquetaCantidad.TabIndex = 2;
            this.lblEtiquetaCantidad.Text = "Productos Vendidos";
            // 
            // chbTarjeta
            // 
            this.chbTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbTarjeta.AutoSize = true;
            this.chbTarjeta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chbTarjeta.Location = new System.Drawing.Point(10, 292);
            this.chbTarjeta.Name = "chbTarjeta";
            this.chbTarjeta.Size = new System.Drawing.Size(145, 25);
            this.chbTarjeta.TabIndex = 13;
            this.chbTarjeta.Text = "Pagar con tarjeta";
            this.chbTarjeta.UseVisualStyleBackColor = true;
            this.chbTarjeta.CheckedChanged += new System.EventHandler(this.chbTarjeta_CheckedChanged);
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
            // txtFolioTicket
            // 
            this.txtFolioTicket.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFolioTicket.Location = new System.Drawing.Point(12, 23);
            this.txtFolioTicket.Name = "txtFolioTicket";
            this.txtFolioTicket.Size = new System.Drawing.Size(197, 25);
            this.txtFolioTicket.TabIndex = 1;
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
            this.btnCobrar.Location = new System.Drawing.Point(325, 292);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(97, 44);
            this.btnCobrar.TabIndex = 14;
            this.btnCobrar.Text = "Aceptar";
            this.btnCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // pnlTarjeta
            // 
            this.pnlTarjeta.Controls.Add(this.txtTerminacion);
            this.pnlTarjeta.Controls.Add(this.lblFolioTicket);
            this.pnlTarjeta.Controls.Add(this.lblTerminacion);
            this.pnlTarjeta.Controls.Add(this.txtFolioTicket);
            this.pnlTarjeta.Enabled = false;
            this.pnlTarjeta.Location = new System.Drawing.Point(-3, 190);
            this.pnlTarjeta.Name = "pnlTarjeta";
            this.pnlTarjeta.Size = new System.Drawing.Size(425, 58);
            this.pnlTarjeta.TabIndex = 12;
            // 
            // chbMixto
            // 
            this.chbMixto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbMixto.AutoSize = true;
            this.chbMixto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chbMixto.Location = new System.Drawing.Point(161, 292);
            this.chbMixto.Name = "chbMixto";
            this.chbMixto.Size = new System.Drawing.Size(106, 25);
            this.chbMixto.TabIndex = 15;
            this.chbMixto.Text = "Pago Mixto";
            this.chbMixto.UseVisualStyleBackColor = true;
            this.chbMixto.Visible = false;
            this.chbMixto.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmCobrar
            // 
            this.AcceptButton = this.btnCobrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 348);
            this.Controls.Add(this.chbMixto);
            this.Controls.Add(this.chbTarjeta);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblEtiquetaCantidad);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.lblEtiquetaFolio);
            this.Controls.Add(this.lblEtiquetaCambio);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.lblEtiquetaTarjeta);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.lblEtiquetaEfectivo);
            this.Controls.Add(this.lblEtiquetaTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.pnlTarjeta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobrar Venta";
            this.Load += new System.EventHandler(this.frmCobrar_Load);
            this.pnlTarjeta.ResumeLayout(false);
            this.pnlTarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEtiquetaEfectivo;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label lblEtiquetaTarjeta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblEtiquetaTotal;
        private System.Windows.Forms.Label lblEtiquetaCambio;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblEtiquetaFolio;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblEtiquetaCantidad;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.CheckBox chbTarjeta;
        private System.Windows.Forms.Label lblFolioTicket;
        private System.Windows.Forms.TextBox txtFolioTicket;
        private System.Windows.Forms.TextBox txtTerminacion;
        private System.Windows.Forms.Label lblTerminacion;
        private System.Windows.Forms.Panel pnlTarjeta;
        private System.Windows.Forms.CheckBox chbMixto;
    }
}
namespace GYM.Formularios.Caja
{
    partial class frmAperturaCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAperturaCaja));
            this.lblEtiquetaEfectivoCaja = new System.Windows.Forms.Label();
            this.lblEfectivoCaja = new System.Windows.Forms.Label();
            this.lblEtiquetaAtiende = new System.Windows.Forms.Label();
            this.lblAtiende = new System.Windows.Forms.Label();
            this.lblEtiquetaEfectivoDejar = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblEtiquetaEfectivoTotal = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEtiquetaEfectivoCaja
            // 
            this.lblEtiquetaEfectivoCaja.AutoSize = true;
            this.lblEtiquetaEfectivoCaja.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblEtiquetaEfectivoCaja.Location = new System.Drawing.Point(12, 47);
            this.lblEtiquetaEfectivoCaja.Name = "lblEtiquetaEfectivoCaja";
            this.lblEtiquetaEfectivoCaja.Size = new System.Drawing.Size(150, 28);
            this.lblEtiquetaEfectivoCaja.TabIndex = 2;
            this.lblEtiquetaEfectivoCaja.Text = "Efectivo en caja:";
            // 
            // lblEfectivoCaja
            // 
            this.lblEfectivoCaja.AutoSize = true;
            this.lblEfectivoCaja.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblEfectivoCaja.Location = new System.Drawing.Point(168, 47);
            this.lblEfectivoCaja.Name = "lblEfectivoCaja";
            this.lblEfectivoCaja.Size = new System.Drawing.Size(60, 28);
            this.lblEfectivoCaja.TabIndex = 3;
            this.lblEfectivoCaja.Text = "$0.00";
            // 
            // lblEtiquetaAtiende
            // 
            this.lblEtiquetaAtiende.AutoSize = true;
            this.lblEtiquetaAtiende.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEtiquetaAtiende.Location = new System.Drawing.Point(12, 9);
            this.lblEtiquetaAtiende.Name = "lblEtiquetaAtiende";
            this.lblEtiquetaAtiende.Size = new System.Drawing.Size(64, 20);
            this.lblEtiquetaAtiende.TabIndex = 0;
            this.lblEtiquetaAtiende.Text = "Atiende:";
            // 
            // lblAtiende
            // 
            this.lblAtiende.AutoSize = true;
            this.lblAtiende.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAtiende.Location = new System.Drawing.Point(82, 9);
            this.lblAtiende.Name = "lblAtiende";
            this.lblAtiende.Size = new System.Drawing.Size(60, 20);
            this.lblAtiende.TabIndex = 1;
            this.lblAtiende.Text = "Alguien";
            // 
            // lblEtiquetaEfectivoDejar
            // 
            this.lblEtiquetaEfectivoDejar.AutoSize = true;
            this.lblEtiquetaEfectivoDejar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblEtiquetaEfectivoDejar.Location = new System.Drawing.Point(13, 96);
            this.lblEtiquetaEfectivoDejar.Name = "lblEtiquetaEfectivoDejar";
            this.lblEtiquetaEfectivoDejar.Size = new System.Drawing.Size(149, 28);
            this.lblEtiquetaEfectivoDejar.TabIndex = 4;
            this.lblEtiquetaEfectivoDejar.Text = "Efectivo a dejar:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(173, 145);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 28);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "$0.00";
            // 
            // lblEtiquetaEfectivoTotal
            // 
            this.lblEtiquetaEfectivoTotal.AutoSize = true;
            this.lblEtiquetaEfectivoTotal.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblEtiquetaEfectivoTotal.Location = new System.Drawing.Point(13, 145);
            this.lblEtiquetaEfectivoTotal.Name = "lblEtiquetaEfectivoTotal";
            this.lblEtiquetaEfectivoTotal.Size = new System.Drawing.Size(131, 28);
            this.lblEtiquetaEfectivoTotal.TabIndex = 6;
            this.lblEtiquetaEfectivoTotal.Text = "Efectivo total:";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtEfectivo.Location = new System.Drawing.Point(173, 98);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(170, 31);
            this.txtEfectivo.TabIndex = 5;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            this.txtEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEfectivo_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(117, 213);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 50);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Abrir Turno";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(233, 213);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAperturaCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(355, 275);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.lblEtiquetaEfectivoTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblEtiquetaEfectivoDejar);
            this.Controls.Add(this.lblAtiende);
            this.Controls.Add(this.lblEtiquetaAtiende);
            this.Controls.Add(this.lblEfectivoCaja);
            this.Controls.Add(this.lblEtiquetaEfectivoCaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAperturaCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Apertura de caja";
            this.Load += new System.EventHandler(this.frmAbrirCaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEtiquetaEfectivoCaja;
        private System.Windows.Forms.Label lblEfectivoCaja;
        private System.Windows.Forms.Label lblEtiquetaAtiende;
        private System.Windows.Forms.Label lblAtiende;
        private System.Windows.Forms.Label lblEtiquetaEfectivoDejar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblEtiquetaEfectivoTotal;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
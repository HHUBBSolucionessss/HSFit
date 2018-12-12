﻿namespace GYM.Formularios
{
    partial class frmEditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarUsuario));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.chbContrasena = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlContra = new System.Windows.Forms.Panel();
            this.txtAntiContra = new System.Windows.Forms.TextBox();
            this.lblAntiContra = new System.Windows.Forms.Label();
            this.lblRepContra = new System.Windows.Forms.Label();
            this.txtRepContra = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnHuella = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.pcbImagenUsuario = new System.Windows.Forms.PictureBox();
            this.cbxCamara = new System.Windows.Forms.ComboBox();
            this.btnCamara = new System.Windows.Forms.Button();
            this.pnlContra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagenUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUsuario.Location = new System.Drawing.Point(8, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(140, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Nombre de usuario:";
            // 
            // chbContrasena
            // 
            this.chbContrasena.AutoSize = true;
            this.chbContrasena.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chbContrasena.Location = new System.Drawing.Point(12, 60);
            this.chbContrasena.Name = "chbContrasena";
            this.chbContrasena.Size = new System.Drawing.Size(171, 25);
            this.chbContrasena.TabIndex = 4;
            this.chbContrasena.Text = "Cambiar Contraseña";
            this.chbContrasena.UseVisualStyleBackColor = true;
            this.chbContrasena.CheckedChanged += new System.EventHandler(this.chbContrasena_CheckedChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(341, 351);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 37);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pnlContra
            // 
            this.pnlContra.Controls.Add(this.txtAntiContra);
            this.pnlContra.Controls.Add(this.lblAntiContra);
            this.pnlContra.Controls.Add(this.lblRepContra);
            this.pnlContra.Controls.Add(this.txtRepContra);
            this.pnlContra.Controls.Add(this.txtContra);
            this.pnlContra.Controls.Add(this.lblContra);
            this.pnlContra.Enabled = false;
            this.pnlContra.Location = new System.Drawing.Point(0, 91);
            this.pnlContra.Name = "pnlContra";
            this.pnlContra.Size = new System.Drawing.Size(460, 112);
            this.pnlContra.TabIndex = 5;
            // 
            // txtAntiContra
            // 
            this.txtAntiContra.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAntiContra.Location = new System.Drawing.Point(12, 23);
            this.txtAntiContra.Name = "txtAntiContra";
            this.txtAntiContra.PasswordChar = '•';
            this.txtAntiContra.Size = new System.Drawing.Size(215, 29);
            this.txtAntiContra.TabIndex = 1;
            // 
            // lblAntiContra
            // 
            this.lblAntiContra.AutoSize = true;
            this.lblAntiContra.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAntiContra.Location = new System.Drawing.Point(8, 0);
            this.lblAntiContra.Name = "lblAntiContra";
            this.lblAntiContra.Size = new System.Drawing.Size(142, 20);
            this.lblAntiContra.TabIndex = 0;
            this.lblAntiContra.Text = "Contraseña anterior:";
            // 
            // lblRepContra
            // 
            this.lblRepContra.AutoSize = true;
            this.lblRepContra.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblRepContra.Location = new System.Drawing.Point(229, 55);
            this.lblRepContra.Name = "lblRepContra";
            this.lblRepContra.Size = new System.Drawing.Size(147, 20);
            this.lblRepContra.TabIndex = 4;
            this.lblRepContra.Text = "Repita la contraseña:";
            // 
            // txtRepContra
            // 
            this.txtRepContra.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRepContra.Location = new System.Drawing.Point(233, 78);
            this.txtRepContra.Name = "txtRepContra";
            this.txtRepContra.PasswordChar = '•';
            this.txtRepContra.Size = new System.Drawing.Size(215, 29);
            this.txtRepContra.TabIndex = 5;
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtContra.Location = new System.Drawing.Point(233, 23);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '•';
            this.txtContra.Size = new System.Drawing.Size(215, 29);
            this.txtContra.TabIndex = 3;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblContra.Location = new System.Drawing.Point(229, 0);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(86, 20);
            this.lblContra.TabIndex = 2;
            this.lblContra.Text = "Contraseña:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNombreUsuario.Location = new System.Drawing.Point(12, 32);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre";
            // 
            // btnHuella
            // 
            this.btnHuella.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnHuella.FlatAppearance.BorderSize = 0;
            this.btnHuella.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnHuella.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuella.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuella.ForeColor = System.Drawing.Color.White;
            this.btnHuella.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuella.Location = new System.Drawing.Point(12, 351);
            this.btnHuella.Name = "btnHuella";
            this.btnHuella.Size = new System.Drawing.Size(136, 37);
            this.btnHuella.TabIndex = 9;
            this.btnHuella.Text = "Capturar huella";
            this.btnHuella.UseVisualStyleBackColor = false;
            this.btnHuella.Click += new System.EventHandler(this.btnHuella_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Location = new System.Drawing.Point(154, 279);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(50, 30);
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblInstrucciones.Location = new System.Drawing.Point(151, 209);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(103, 39);
            this.lblInstrucciones.TabIndex = 6;
            this.lblInstrucciones.Text = "Haga clic para\r\ncambiar la imagen \r\nde usuario";
            // 
            // pcbImagenUsuario
            // 
            this.pcbImagenUsuario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pcbImagenUsuario.Location = new System.Drawing.Point(12, 209);
            this.pcbImagenUsuario.Name = "pcbImagenUsuario";
            this.pcbImagenUsuario.Size = new System.Drawing.Size(136, 136);
            this.pcbImagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagenUsuario.TabIndex = 36;
            this.pcbImagenUsuario.TabStop = false;
            this.pcbImagenUsuario.Click += new System.EventHandler(this.pcbImagenUsuario_Click);
            // 
            // cbxCamara
            // 
            this.cbxCamara.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbxCamara.FormattingEnabled = true;
            this.cbxCamara.Location = new System.Drawing.Point(154, 355);
            this.cbxCamara.Name = "cbxCamara";
            this.cbxCamara.Size = new System.Drawing.Size(150, 29);
            this.cbxCamara.TabIndex = 10;
            // 
            // btnCamara
            // 
            this.btnCamara.FlatAppearance.BorderSize = 0;
            this.btnCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamara.Location = new System.Drawing.Point(154, 315);
            this.btnCamara.Name = "btnCamara";
            this.btnCamara.Size = new System.Drawing.Size(50, 30);
            this.btnCamara.TabIndex = 8;
            this.btnCamara.UseVisualStyleBackColor = true;
            this.btnCamara.Click += new System.EventHandler(this.btnCamara_Click);
            // 
            // frmEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 400);
            this.Controls.Add(this.cbxCamara);
            this.Controls.Add(this.btnCamara);
            this.Controls.Add(this.btnHuella);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.pcbImagenUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.pnlContra);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.chbContrasena);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditarUsuario_FormClosed);
            this.Load += new System.EventHandler(this.frmEditarUsuario_Load);
            this.pnlContra.ResumeLayout(false);
            this.pnlContra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagenUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.CheckBox chbContrasena;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel pnlContra;
        private System.Windows.Forms.Label lblRepContra;
        private System.Windows.Forms.TextBox txtRepContra;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtAntiContra;
        private System.Windows.Forms.Label lblAntiContra;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnHuella;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.PictureBox pcbImagenUsuario;
        private System.Windows.Forms.ComboBox cbxCamara;
        private System.Windows.Forms.Button btnCamara;

    }
}
namespace GYM.Formularios
{
    partial class frmConfiguracionGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracionGeneral));
            this.grbVisual = new System.Windows.Forms.GroupBox();
            this.btnPredeterminado = new System.Windows.Forms.Button();
            this.chbLectorHuella = new System.Windows.Forms.CheckBox();
            this.chbRegistro = new System.Windows.Forms.CheckBox();
            this.pcbFondo = new System.Windows.Forms.PictureBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblEtiquetaFondo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grbPromociones = new System.Windows.Forms.GroupBox();
            this.btnQuitarPromo06 = new System.Windows.Forms.Button();
            this.btnQuitarPromo05 = new System.Windows.Forms.Button();
            this.btnQuitarPromo04 = new System.Windows.Forms.Button();
            this.btnQuitarPromo03 = new System.Windows.Forms.Button();
            this.btnQuitarPromo02 = new System.Windows.Forms.Button();
            this.btnQuitarPromo01 = new System.Windows.Forms.Button();
            this.pcbPromocion06 = new System.Windows.Forms.PictureBox();
            this.pcbPromocion04 = new System.Windows.Forms.PictureBox();
            this.pcbPromocion05 = new System.Windows.Forms.PictureBox();
            this.pcbPromocion03 = new System.Windows.Forms.PictureBox();
            this.pcbPromocion02 = new System.Windows.Forms.PictureBox();
            this.pcbPromocion01 = new System.Windows.Forms.PictureBox();
            this.bgwGuardar = new System.ComponentModel.BackgroundWorker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbVisual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFondo)).BeginInit();
            this.grbPromociones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPromocion06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPromocion04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPromocion05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPromocion03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPromocion02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPromocion01)).BeginInit();
            this.SuspendLayout();
            // 
            // grbVisual
            // 
            this.grbVisual.Controls.Add(this.btnPredeterminado);
            this.grbVisual.Controls.Add(this.chbLectorHuella);
            this.grbVisual.Controls.Add(this.chbRegistro);
            this.grbVisual.Controls.Add(this.pcbFondo);
            this.grbVisual.Controls.Add(this.btnQuitar);
            this.grbVisual.Controls.Add(this.lblEtiquetaFondo);
            this.grbVisual.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grbVisual.Location = new System.Drawing.Point(12, 12);
            this.grbVisual.Name = "grbVisual";
            this.grbVisual.Size = new System.Drawing.Size(710, 231);
            this.grbVisual.TabIndex = 0;
            this.grbVisual.TabStop = false;
            this.grbVisual.Text = "Configuración visual";
            this.grbVisual.Enter += new System.EventHandler(this.grbVisual_Enter);
            // 
            // btnPredeterminado
            // 
            this.btnPredeterminado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnPredeterminado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPredeterminado.FlatAppearance.BorderSize = 0;
            this.btnPredeterminado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnPredeterminado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPredeterminado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredeterminado.ForeColor = System.Drawing.Color.White;
            this.btnPredeterminado.Location = new System.Drawing.Point(285, 46);
            this.btnPredeterminado.Name = "btnPredeterminado";
            this.btnPredeterminado.Size = new System.Drawing.Size(120, 50);
            this.btnPredeterminado.TabIndex = 9;
            this.btnPredeterminado.Text = "Predeterminado";
            this.btnPredeterminado.UseVisualStyleBackColor = false;
            this.btnPredeterminado.Click += new System.EventHandler(this.btnPredeterminado_Click);
            // 
            // chbLectorHuella
            // 
            this.chbLectorHuella.AutoSize = true;
            this.chbLectorHuella.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chbLectorHuella.Location = new System.Drawing.Point(452, 160);
            this.chbLectorHuella.Name = "chbLectorHuella";
            this.chbLectorHuella.Size = new System.Drawing.Size(235, 25);
            this.chbLectorHuella.TabIndex = 2;
            this.chbLectorHuella.Text = "Utilizar lector de huella digital";
            this.chbLectorHuella.UseVisualStyleBackColor = true;
            // 
            // chbRegistro
            // 
            this.chbRegistro.AutoSize = true;
            this.chbRegistro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chbRegistro.Location = new System.Drawing.Point(452, 191);
            this.chbRegistro.Name = "chbRegistro";
            this.chbRegistro.Size = new System.Drawing.Size(252, 25);
            this.chbRegistro.TabIndex = 3;
            this.chbRegistro.Text = "Abrir únicamente ingreso socios";
            this.chbRegistro.UseVisualStyleBackColor = true;
            // 
            // pcbFondo
            // 
            this.pcbFondo.BackColor = System.Drawing.Color.Transparent;
            this.pcbFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbFondo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbFondo.Image = global::GYM.Properties.Resources.Fondo;
            this.pcbFondo.Location = new System.Drawing.Point(23, 46);
            this.pcbFondo.Name = "pcbFondo";
            this.pcbFondo.Size = new System.Drawing.Size(256, 152);
            this.pcbFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFondo.TabIndex = 11;
            this.pcbFondo.TabStop = false;
            this.pcbFondo.Click += new System.EventHandler(this.pcbFondo_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.Image = global::GYM.Properties.Resources.Borrar_24;
            this.btnQuitar.Location = new System.Drawing.Point(285, 102);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(50, 50);
            this.btnQuitar.TabIndex = 10;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblEtiquetaFondo
            // 
            this.lblEtiquetaFondo.AutoSize = true;
            this.lblEtiquetaFondo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEtiquetaFondo.Location = new System.Drawing.Point(7, 22);
            this.lblEtiquetaFondo.Name = "lblEtiquetaFondo";
            this.lblEtiquetaFondo.Size = new System.Drawing.Size(131, 21);
            this.lblEtiquetaFondo.TabIndex = 8;
            this.lblEtiquetaFondo.Text = "Imagen de fondo:";
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
            this.btnAceptar.Location = new System.Drawing.Point(525, 599);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 50);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // grbPromociones
            // 
            this.grbPromociones.Controls.Add(this.btnQuitarPromo06);
            this.grbPromociones.Controls.Add(this.btnQuitarPromo05);
            this.grbPromociones.Controls.Add(this.btnQuitarPromo04);
            this.grbPromociones.Controls.Add(this.btnQuitarPromo03);
            this.grbPromociones.Controls.Add(this.btnQuitarPromo02);
            this.grbPromociones.Controls.Add(this.btnQuitarPromo01);
            this.grbPromociones.Controls.Add(this.pcbPromocion06);
            this.grbPromociones.Controls.Add(this.pcbPromocion04);
            this.grbPromociones.Controls.Add(this.pcbPromocion05);
            this.grbPromociones.Controls.Add(this.pcbPromocion03);
            this.grbPromociones.Controls.Add(this.pcbPromocion02);
            this.grbPromociones.Controls.Add(this.pcbPromocion01);
            this.grbPromociones.Location = new System.Drawing.Point(12, 249);
            this.grbPromociones.Name = "grbPromociones";
            this.grbPromociones.Size = new System.Drawing.Size(761, 328);
            this.grbPromociones.TabIndex = 1;
            this.grbPromociones.TabStop = false;
            this.grbPromociones.Text = "Promociones";
            // 
            // btnQuitarPromo06
            // 
            this.btnQuitarPromo06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarPromo06.FlatAppearance.BorderSize = 0;
            this.btnQuitarPromo06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarPromo06.ForeColor = System.Drawing.Color.White;
            this.btnQuitarPromo06.Image = global::GYM.Properties.Resources.Borrar_24;
            this.btnQuitarPromo06.Location = new System.Drawing.Point(513, 294);
            this.btnQuitarPromo06.Name = "btnQuitarPromo06";
            this.btnQuitarPromo06.Size = new System.Drawing.Size(50, 27);
            this.btnQuitarPromo06.TabIndex = 5;
            this.btnQuitarPromo06.UseVisualStyleBackColor = true;
            this.btnQuitarPromo06.Click += new System.EventHandler(this.btnQuitarPromo06_Click);
            // 
            // btnQuitarPromo05
            // 
            this.btnQuitarPromo05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarPromo05.FlatAppearance.BorderSize = 0;
            this.btnQuitarPromo05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarPromo05.ForeColor = System.Drawing.Color.White;
            this.btnQuitarPromo05.Image = global::GYM.Properties.Resources.Borrar_24;
            this.btnQuitarPromo05.Location = new System.Drawing.Point(262, 294);
            this.btnQuitarPromo05.Name = "btnQuitarPromo05";
            this.btnQuitarPromo05.Size = new System.Drawing.Size(50, 27);
            this.btnQuitarPromo05.TabIndex = 4;
            this.btnQuitarPromo05.UseVisualStyleBackColor = true;
            this.btnQuitarPromo05.Click += new System.EventHandler(this.btnQuitarPromo05_Click);
            // 
            // btnQuitarPromo04
            // 
            this.btnQuitarPromo04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarPromo04.FlatAppearance.BorderSize = 0;
            this.btnQuitarPromo04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarPromo04.ForeColor = System.Drawing.Color.White;
            this.btnQuitarPromo04.Image = global::GYM.Properties.Resources.Borrar_24;
            this.btnQuitarPromo04.Location = new System.Drawing.Point(11, 294);
            this.btnQuitarPromo04.Name = "btnQuitarPromo04";
            this.btnQuitarPromo04.Size = new System.Drawing.Size(50, 27);
            this.btnQuitarPromo04.TabIndex = 3;
            this.btnQuitarPromo04.UseVisualStyleBackColor = true;
            this.btnQuitarPromo04.Click += new System.EventHandler(this.btnQuitarPromo04_Click);
            // 
            // btnQuitarPromo03
            // 
            this.btnQuitarPromo03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarPromo03.FlatAppearance.BorderSize = 0;
            this.btnQuitarPromo03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarPromo03.ForeColor = System.Drawing.Color.White;
            this.btnQuitarPromo03.Image = global::GYM.Properties.Resources.Borrar_24;
            this.btnQuitarPromo03.Location = new System.Drawing.Point(513, 140);
            this.btnQuitarPromo03.Name = "btnQuitarPromo03";
            this.btnQuitarPromo03.Size = new System.Drawing.Size(50, 27);
            this.btnQuitarPromo03.TabIndex = 2;
            this.btnQuitarPromo03.UseVisualStyleBackColor = true;
            this.btnQuitarPromo03.Click += new System.EventHandler(this.btnQuitarPromo03_Click);
            // 
            // btnQuitarPromo02
            // 
            this.btnQuitarPromo02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarPromo02.FlatAppearance.BorderSize = 0;
            this.btnQuitarPromo02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarPromo02.ForeColor = System.Drawing.Color.White;
            this.btnQuitarPromo02.Image = global::GYM.Properties.Resources.Borrar_24;
            this.btnQuitarPromo02.Location = new System.Drawing.Point(262, 140);
            this.btnQuitarPromo02.Name = "btnQuitarPromo02";
            this.btnQuitarPromo02.Size = new System.Drawing.Size(50, 27);
            this.btnQuitarPromo02.TabIndex = 1;
            this.btnQuitarPromo02.UseVisualStyleBackColor = true;
            this.btnQuitarPromo02.Click += new System.EventHandler(this.btnQuitarPromo02_Click);
            // 
            // btnQuitarPromo01
            // 
            this.btnQuitarPromo01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarPromo01.FlatAppearance.BorderSize = 0;
            this.btnQuitarPromo01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarPromo01.ForeColor = System.Drawing.Color.White;
            this.btnQuitarPromo01.Image = global::GYM.Properties.Resources.Borrar_24;
            this.btnQuitarPromo01.Location = new System.Drawing.Point(11, 140);
            this.btnQuitarPromo01.Name = "btnQuitarPromo01";
            this.btnQuitarPromo01.Size = new System.Drawing.Size(50, 27);
            this.btnQuitarPromo01.TabIndex = 0;
            this.btnQuitarPromo01.UseVisualStyleBackColor = true;
            this.btnQuitarPromo01.Click += new System.EventHandler(this.btnQuitarPromo01_Click);
            // 
            // pcbPromocion06
            // 
            this.pcbPromocion06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbPromocion06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbPromocion06.Location = new System.Drawing.Point(513, 173);
            this.pcbPromocion06.Name = "pcbPromocion06";
            this.pcbPromocion06.Size = new System.Drawing.Size(236, 115);
            this.pcbPromocion06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPromocion06.TabIndex = 4;
            this.pcbPromocion06.TabStop = false;
            this.pcbPromocion06.Click += new System.EventHandler(this.pcbPromociones_Click);
            // 
            // pcbPromocion04
            // 
            this.pcbPromocion04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbPromocion04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbPromocion04.Location = new System.Drawing.Point(11, 173);
            this.pcbPromocion04.Name = "pcbPromocion04";
            this.pcbPromocion04.Size = new System.Drawing.Size(236, 115);
            this.pcbPromocion04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPromocion04.TabIndex = 3;
            this.pcbPromocion04.TabStop = false;
            this.pcbPromocion04.Click += new System.EventHandler(this.pcbPromociones_Click);
            // 
            // pcbPromocion05
            // 
            this.pcbPromocion05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbPromocion05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbPromocion05.Location = new System.Drawing.Point(262, 173);
            this.pcbPromocion05.Name = "pcbPromocion05";
            this.pcbPromocion05.Size = new System.Drawing.Size(236, 115);
            this.pcbPromocion05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPromocion05.TabIndex = 3;
            this.pcbPromocion05.TabStop = false;
            this.pcbPromocion05.Click += new System.EventHandler(this.pcbPromociones_Click);
            // 
            // pcbPromocion03
            // 
            this.pcbPromocion03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbPromocion03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbPromocion03.Location = new System.Drawing.Point(513, 19);
            this.pcbPromocion03.Name = "pcbPromocion03";
            this.pcbPromocion03.Size = new System.Drawing.Size(236, 115);
            this.pcbPromocion03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPromocion03.TabIndex = 2;
            this.pcbPromocion03.TabStop = false;
            this.pcbPromocion03.Click += new System.EventHandler(this.pcbPromociones_Click);
            // 
            // pcbPromocion02
            // 
            this.pcbPromocion02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbPromocion02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbPromocion02.Location = new System.Drawing.Point(262, 19);
            this.pcbPromocion02.Name = "pcbPromocion02";
            this.pcbPromocion02.Size = new System.Drawing.Size(236, 115);
            this.pcbPromocion02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPromocion02.TabIndex = 1;
            this.pcbPromocion02.TabStop = false;
            this.pcbPromocion02.Click += new System.EventHandler(this.pcbPromociones_Click);
            // 
            // pcbPromocion01
            // 
            this.pcbPromocion01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbPromocion01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbPromocion01.Location = new System.Drawing.Point(11, 19);
            this.pcbPromocion01.Name = "pcbPromocion01";
            this.pcbPromocion01.Size = new System.Drawing.Size(236, 115);
            this.pcbPromocion01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPromocion01.TabIndex = 0;
            this.pcbPromocion01.TabStop = false;
            this.pcbPromocion01.Click += new System.EventHandler(this.pcbPromociones_Click);
            // 
            // bgwGuardar
            // 
            this.bgwGuardar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGuardar_DoWork);
            this.bgwGuardar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwGuardar_RunWorkerCompleted);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(663, 599);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmConfiguracionGeneral
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbPromociones);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grbVisual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 739);
            this.Name = "frmConfiguracionGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración del programa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConfiguracionGeneral_FormClosing);
            this.Load += new System.EventHandler(this.frmConfiguracionGeneral_Load);
            this.grbVisual.ResumeLayout(false);
            this.grbVisual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFondo)).EndInit();
            this.grbPromociones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPromocion06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPromocion04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPromocion05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPromocion03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPromocion02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPromocion01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbVisual;
        private System.Windows.Forms.PictureBox pcbFondo;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblEtiquetaFondo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox grbPromociones;
        private System.Windows.Forms.PictureBox pcbPromocion01;
        private System.Windows.Forms.PictureBox pcbPromocion06;
        private System.Windows.Forms.PictureBox pcbPromocion04;
        private System.Windows.Forms.PictureBox pcbPromocion05;
        private System.Windows.Forms.PictureBox pcbPromocion03;
        private System.Windows.Forms.PictureBox pcbPromocion02;
        private System.Windows.Forms.Button btnPredeterminado;
        private System.Windows.Forms.Button btnQuitarPromo01;
        private System.Windows.Forms.Button btnQuitarPromo06;
        private System.Windows.Forms.Button btnQuitarPromo05;
        private System.Windows.Forms.Button btnQuitarPromo04;
        private System.Windows.Forms.Button btnQuitarPromo03;
        private System.Windows.Forms.Button btnQuitarPromo02;
        private System.ComponentModel.BackgroundWorker bgwGuardar;
        private System.Windows.Forms.CheckBox chbLectorHuella;
        private System.Windows.Forms.CheckBox chbRegistro;
        private System.Windows.Forms.Button btnCancelar;
    }
}
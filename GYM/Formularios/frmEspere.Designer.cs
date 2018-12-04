namespace GYM.Formularios
{
    partial class frmEspere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEspere));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.prbEspere = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(71, 52);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(268, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Espere, guardando la configuración";
            // 
            // prbEspere
            // 
            this.prbEspere.animated = true;
            this.prbEspere.animationIterval = 5;
            this.prbEspere.animationSpeed = 300;
            this.prbEspere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.prbEspere.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prbEspere.BackgroundImage")));
            this.prbEspere.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.prbEspere.ForeColor = System.Drawing.Color.SeaGreen;
            this.prbEspere.LabelVisible = false;
            this.prbEspere.LineProgressThickness = 8;
            this.prbEspere.LineThickness = 5;
            this.prbEspere.Location = new System.Drawing.Point(169, 93);
            this.prbEspere.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.prbEspere.MaxValue = 100;
            this.prbEspere.Name = "prbEspere";
            this.prbEspere.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.prbEspere.ProgressColor = System.Drawing.Color.SeaGreen;
            this.prbEspere.Size = new System.Drawing.Size(69, 69);
            this.prbEspere.TabIndex = 2;
            this.prbEspere.Value = 100;
            // 
            // frmEspere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(422, 203);
            this.ControlBox = false;
            this.Controls.Add(this.prbEspere);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEspere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HS FIT";
            this.Load += new System.EventHandler(this.frmEspere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuCircleProgressbar prbEspere;
    }
}
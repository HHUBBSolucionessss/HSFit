namespace GYM
{
    partial class frmEspera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEspera));
            this.lblMensaje = new System.Windows.Forms.Label();
            this.progressBar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(153, 32);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(81, 21);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Buscando";
            // 
            // progressBar1
            // 
            this.progressBar1.animated = true;
            this.progressBar1.animationIterval = 5;
            this.progressBar1.animationSpeed = 300;
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.progressBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBar1.BackgroundImage")));
            this.progressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.progressBar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.progressBar1.LabelVisible = false;
            this.progressBar1.LineProgressThickness = 8;
            this.progressBar1.LineThickness = 5;
            this.progressBar1.Location = new System.Drawing.Point(157, 79);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.progressBar1.MaxValue = 100;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.progressBar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.progressBar1.Size = new System.Drawing.Size(69, 69);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 10;
            // 
            // frmEspera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(416, 163);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEspera";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búscando";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMensaje;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressBar1;
    }
}
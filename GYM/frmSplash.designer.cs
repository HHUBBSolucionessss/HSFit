namespace GYM
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.lblVersion = new System.Windows.Forms.Label();
            this.bgwCargar = new System.ComponentModel.BackgroundWorker();
            this.lblBETA = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prbProgreso1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblVersion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblVersion.Location = new System.Drawing.Point(371, 108);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(61, 20);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "v 1.0.0.0";
            // 
            // bgwCargar
            // 
            this.bgwCargar.WorkerReportsProgress = true;
            this.bgwCargar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCargar_DoWork);
            this.bgwCargar.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwCargar_ProgressChanged);
            this.bgwCargar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCargar_RunWorkerCompleted);
            // 
            // lblBETA
            // 
            this.lblBETA.AutoSize = true;
            this.lblBETA.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBETA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblBETA.Location = new System.Drawing.Point(375, 18);
            this.lblBETA.Name = "lblBETA";
            this.lblBETA.Size = new System.Drawing.Size(57, 25);
            this.lblBETA.TabIndex = 6;
            this.lblBETA.Text = "BETA";
            this.lblBETA.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GYM.Properties.Resources.Fondo;
            this.pictureBox1.Location = new System.Drawing.Point(94, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // prbProgreso1
            // 
            this.prbProgreso1.animated = true;
            this.prbProgreso1.animationIterval = 10;
            this.prbProgreso1.animationSpeed = 800;
            this.prbProgreso1.BackColor = System.Drawing.Color.White;
            this.prbProgreso1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prbProgreso1.BackgroundImage")));
            this.prbProgreso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.prbProgreso1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.prbProgreso1.LabelVisible = false;
            this.prbProgreso1.LineProgressThickness = 8;
            this.prbProgreso1.LineThickness = 5;
            this.prbProgreso1.Location = new System.Drawing.Point(202, 142);
            this.prbProgreso1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.prbProgreso1.MaxValue = 100;
            this.prbProgreso1.Name = "prbProgreso1";
            this.prbProgreso1.ProgressBackColor = System.Drawing.Color.WhiteSmoke;
            this.prbProgreso1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.prbProgreso1.Size = new System.Drawing.Size(58, 58);
            this.prbProgreso1.TabIndex = 8;
            this.prbProgreso1.Value = 0;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(489, 218);
            this.Controls.Add(this.prbProgreso1);
            this.Controls.Add(this.lblBETA);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.Shown += new System.EventHandler(this.frmSplash_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersion;
        private System.ComponentModel.BackgroundWorker bgwCargar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBETA;
        private Bunifu.Framework.UI.BunifuCircleProgressbar prbProgreso1;
    }
}
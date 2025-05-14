namespace SAE_A21D21_pompiers1
{
    partial class GestionPersonnel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pbIconePers = new System.Windows.Forms.PictureBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.cbCasernes = new System.Windows.Forms.ComboBox();
            this.cbPompiers = new System.Windows.Forms.ComboBox();
            this.lblPompier = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconePers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(342, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 800);
            this.panel1.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DarkRed;
            this.pnlMenu.Controls.Add(this.cbPompiers);
            this.pnlMenu.Controls.Add(this.lblPompier);
            this.pnlMenu.Controls.Add(this.cbCasernes);
            this.pnlMenu.Controls.Add(this.lblCaserne);
            this.pnlMenu.Controls.Add(this.pbIconePers);
            this.pnlMenu.Location = new System.Drawing.Point(12, 11);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(305, 800);
            this.pnlMenu.TabIndex = 2;
            // 
            // pbIconePers
            // 
            this.pbIconePers.Image = global::SAE_A21D21_pompiers1.Properties.Resources.personnel;
            this.pbIconePers.Location = new System.Drawing.Point(103, 15);
            this.pbIconePers.Name = "pbIconePers";
            this.pbIconePers.Size = new System.Drawing.Size(96, 89);
            this.pbIconePers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIconePers.TabIndex = 0;
            this.pbIconePers.TabStop = false;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.BackColor = System.Drawing.Color.Transparent;
            this.lblCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCaserne.Location = new System.Drawing.Point(31, 136);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(197, 25);
            this.lblCaserne.TabIndex = 1;
            this.lblCaserne.Text = "Choisir une caserne :";
            // 
            // cbCasernes
            // 
            this.cbCasernes.FormattingEnabled = true;
            this.cbCasernes.Location = new System.Drawing.Point(35, 166);
            this.cbCasernes.Name = "cbCasernes";
            this.cbCasernes.Size = new System.Drawing.Size(243, 24);
            this.cbCasernes.TabIndex = 2;
            this.cbCasernes.SelectedIndexChanged += new System.EventHandler(this.cbCasernes_SelectedIndexChanged);
            // 
            // cbPompiers
            // 
            this.cbPompiers.FormattingEnabled = true;
            this.cbPompiers.Location = new System.Drawing.Point(35, 258);
            this.cbPompiers.Name = "cbPompiers";
            this.cbPompiers.Size = new System.Drawing.Size(243, 24);
            this.cbPompiers.TabIndex = 4;
            // 
            // lblPompier
            // 
            this.lblPompier.AutoSize = true;
            this.lblPompier.BackColor = System.Drawing.Color.Transparent;
            this.lblPompier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPompier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPompier.Location = new System.Drawing.Point(31, 228);
            this.lblPompier.Name = "lblPompier";
            this.lblPompier.Size = new System.Drawing.Size(186, 25);
            this.lblPompier.TabIndex = 3;
            this.lblPompier.Text = "Choisir un pompier :";
            // 
            // GestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::SAE_A21D21_pompiers1.Properties.Resources.pompier_fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(987, 783);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "GestionPersonnel";
            this.Text = "Gestion du personnel";
            this.Load += new System.EventHandler(this.GestionPersonnel_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconePers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pbIconePers;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.ComboBox cbCasernes;
        private System.Windows.Forms.ComboBox cbPompiers;
        private System.Windows.Forms.Label lblPompier;
    }
}
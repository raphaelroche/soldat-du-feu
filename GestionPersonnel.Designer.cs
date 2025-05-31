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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.cbPompiers = new System.Windows.Forms.ComboBox();
            this.lblPompier = new System.Windows.Forms.Label();
            this.cbCasernes = new System.Windows.Forms.ComboBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.pbIconePers = new System.Windows.Forms.PictureBox();
            this.pnlAffichage = new System.Windows.Forms.Panel();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconePers)).BeginInit();
            this.pnlAffichage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DarkRed;
            this.pnlMenu.Controls.Add(this.cbPompiers);
            this.pnlMenu.Controls.Add(this.lblPompier);
            this.pnlMenu.Controls.Add(this.cbCasernes);
            this.pnlMenu.Controls.Add(this.lblCaserne);
            this.pnlMenu.Controls.Add(this.pbIconePers);
            this.pnlMenu.Location = new System.Drawing.Point(9, 9);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(229, 800);
            this.pnlMenu.TabIndex = 2;
            // 
            // cbPompiers
            // 
            this.cbPompiers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPompiers.FormattingEnabled = true;
            this.cbPompiers.Location = new System.Drawing.Point(26, 210);
            this.cbPompiers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPompiers.Name = "cbPompiers";
            this.cbPompiers.Size = new System.Drawing.Size(183, 21);
            this.cbPompiers.TabIndex = 4;
            this.cbPompiers.SelectedIndexChanged += new System.EventHandler(this.cbPompiers_SelectedIndexChanged);
            // 
            // lblPompier
            // 
            this.lblPompier.AutoSize = true;
            this.lblPompier.BackColor = System.Drawing.Color.Transparent;
            this.lblPompier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPompier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPompier.Location = new System.Drawing.Point(23, 185);
            this.lblPompier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPompier.Name = "lblPompier";
            this.lblPompier.Size = new System.Drawing.Size(148, 20);
            this.lblPompier.TabIndex = 3;
            this.lblPompier.Text = "Choisir un pompier :";
            // 
            // cbCasernes
            // 
            this.cbCasernes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCasernes.FormattingEnabled = true;
            this.cbCasernes.Location = new System.Drawing.Point(26, 135);
            this.cbCasernes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCasernes.Name = "cbCasernes";
            this.cbCasernes.Size = new System.Drawing.Size(183, 21);
            this.cbCasernes.TabIndex = 2;
            this.cbCasernes.SelectedIndexChanged += new System.EventHandler(this.cbCasernes_SelectedIndexChanged);
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.BackColor = System.Drawing.Color.Transparent;
            this.lblCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCaserne.Location = new System.Drawing.Point(23, 110);
            this.lblCaserne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(157, 20);
            this.lblCaserne.TabIndex = 1;
            this.lblCaserne.Text = "Choisir une caserne :";
            // 
            // pbIconePers
            // 
            this.pbIconePers.Image = global::SAE_A21D21_pompiers1.Properties.Resources.personnel;
            this.pbIconePers.Location = new System.Drawing.Point(77, 12);
            this.pbIconePers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbIconePers.Name = "pbIconePers";
            this.pbIconePers.Size = new System.Drawing.Size(72, 72);
            this.pbIconePers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIconePers.TabIndex = 0;
            this.pbIconePers.TabStop = false;
            // 
            // pnlAffichage
            // 
            this.pnlAffichage.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAffichage.Controls.Add(this.btnNouveau);
            this.pnlAffichage.Location = new System.Drawing.Point(256, 10);
            this.pnlAffichage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAffichage.Name = "pnlAffichage";
            this.pnlAffichage.Size = new System.Drawing.Size(630, 800);
            this.pnlAffichage.TabIndex = 0;
            // 
            // btnNouveau
            // 
            this.btnNouveau.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnNouveau.Location = new System.Drawing.Point(19, 11);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(601, 40);
            this.btnNouveau.TabIndex = 0;
            this.btnNouveau.Text = "Recruter un pompier";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // GestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::SAE_A21D21_pompiers1.Properties.Resources.pompier_fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(903, 774);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlAffichage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "GestionPersonnel";
            this.Text = "Gestion du personnel";
            this.Load += new System.EventHandler(this.GestionPersonnel_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconePers)).EndInit();
            this.pnlAffichage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pbIconePers;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.ComboBox cbCasernes;
        private System.Windows.Forms.ComboBox cbPompiers;
        private System.Windows.Forms.Label lblPompier;
        private System.Windows.Forms.Panel pnlAffichage;
        private System.Windows.Forms.Button btnNouveau;
    }
}
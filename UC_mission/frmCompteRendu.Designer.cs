namespace SAE_A21D21_pompiers1
{
    partial class frmCompteRendu
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
            this.txtCompteRendu = new System.Windows.Forms.TextBox();
            this.lblCompteRendu = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCompteRendu
            // 
            this.txtCompteRendu.Location = new System.Drawing.Point(257, 49);
            this.txtCompteRendu.Multiline = true;
            this.txtCompteRendu.Name = "txtCompteRendu";
            this.txtCompteRendu.Size = new System.Drawing.Size(237, 140);
            this.txtCompteRendu.TabIndex = 0;
            // 
            // lblCompteRendu
            // 
            this.lblCompteRendu.AutoSize = true;
            this.lblCompteRendu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCompteRendu.Location = new System.Drawing.Point(28, 94);
            this.lblCompteRendu.Name = "lblCompteRendu";
            this.lblCompteRendu.Size = new System.Drawing.Size(195, 40);
            this.lblCompteRendu.TabIndex = 1;
            this.lblCompteRendu.Text = "Entrez ici un \r\néventuelle compte rendu  :\r\n";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.White;
            this.btnValider.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnValider.Location = new System.Drawing.Point(286, 221);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(91, 37);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.White;
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnnuler.Location = new System.Drawing.Point(383, 221);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(93, 37);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmCompteRendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(524, 277);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblCompteRendu);
            this.Controls.Add(this.txtCompteRendu);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "frmCompteRendu";
            this.Text = "Compte rendu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompteRendu;
        private System.Windows.Forms.Label lblCompteRendu;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
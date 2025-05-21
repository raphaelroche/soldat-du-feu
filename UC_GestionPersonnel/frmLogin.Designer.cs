namespace SAE_A21D21_pompiers1
{
    partial class frmLogin
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAnnuler.Location = new System.Drawing.Point(391, 187);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(102, 30);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click_1);
            // 
            // txtMdp
            // 
            this.txtMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMdp.Location = new System.Drawing.Point(239, 106);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '*';
            this.txtMdp.Size = new System.Drawing.Size(231, 30);
            this.txtMdp.TabIndex = 2;
            this.txtMdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMdp_KeyPress);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtId.Location = new System.Drawing.Point(239, 53);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(231, 30);
            this.txtId.TabIndex = 1;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMdp.Location = new System.Drawing.Point(63, 106);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(146, 25);
            this.lblMdp.TabIndex = 10;
            this.lblMdp.Text = "Mot de passe : ";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblid.Location = new System.Drawing.Point(63, 53);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(111, 25);
            this.lblid.TabIndex = 9;
            this.lblid.Text = "Identifiant : ";
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnValider.Location = new System.Drawing.Point(284, 187);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(101, 30);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click_1);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 254);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnValider);
            this.Name = "frmLogin";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnValider;
    }
}
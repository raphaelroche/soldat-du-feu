namespace SAE_A21D21_pompiers1
{
    partial class FrmCreerPompier
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtBip = new System.Windows.Forms.TextBox();
            this.cboSexe = new System.Windows.Forms.ComboBox();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.lblinfo = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblBip = new System.Windows.Forms.Label();
            this.lblNaissance = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNom.Location = new System.Drawing.Point(204, 89);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 26);
            this.txtNom.TabIndex = 0;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // txtMatricule
            // 
            this.txtMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMatricule.Location = new System.Drawing.Point(204, 181);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(100, 26);
            this.txtMatricule.TabIndex = 2;
            this.txtMatricule.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricule_KeyPress);
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTel.Location = new System.Drawing.Point(204, 210);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 26);
            this.txtTel.TabIndex = 3;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricule_KeyPress);
            // 
            // txtBip
            // 
            this.txtBip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBip.Location = new System.Drawing.Point(204, 251);
            this.txtBip.Name = "txtBip";
            this.txtBip.Size = new System.Drawing.Size(100, 26);
            this.txtBip.TabIndex = 4;
            this.txtBip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricule_KeyPress);
            // 
            // cboSexe
            // 
            this.cboSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboSexe.FormattingEnabled = true;
            this.cboSexe.Location = new System.Drawing.Point(221, 394);
            this.cboSexe.Name = "cboSexe";
            this.cboSexe.Size = new System.Drawing.Size(121, 28);
            this.cboSexe.TabIndex = 6;
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(210, 444);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(121, 28);
            this.cboGrade.TabIndex = 7;
            // 
            // cboCaserne
            // 
            this.cboCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(240, 498);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(121, 28);
            this.cboCaserne.TabIndex = 8;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblinfo.Location = new System.Drawing.Point(148, 21);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(296, 22);
            this.lblinfo.TabIndex = 8;
            this.lblinfo.Text = "INFORMATIONS PERSONNELLES";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNom.Location = new System.Drawing.Point(128, 95);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(54, 20);
            this.lblNom.TabIndex = 9;
            this.lblNom.Text = "Nom : ";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMatricule.Location = new System.Drawing.Point(97, 181);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(85, 20);
            this.lblMatricule.TabIndex = 10;
            this.lblMatricule.Text = "Matricule : ";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTel.Location = new System.Drawing.Point(89, 213);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(96, 20);
            this.lblTel.TabIndex = 11;
            this.lblTel.Text = "Telephone : ";
            // 
            // lblBip
            // 
            this.lblBip.AutoSize = true;
            this.lblBip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBip.Location = new System.Drawing.Point(115, 257);
            this.lblBip.Name = "lblBip";
            this.lblBip.Size = new System.Drawing.Size(44, 20);
            this.lblBip.TabIndex = 12;
            this.lblBip.Text = "Bip : ";
            // 
            // lblNaissance
            // 
            this.lblNaissance.AutoSize = true;
            this.lblNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNaissance.Location = new System.Drawing.Point(54, 319);
            this.lblNaissance.Name = "lblNaissance";
            this.lblNaissance.Size = new System.Drawing.Size(150, 20);
            this.lblNaissance.TabIndex = 13;
            this.lblNaissance.Text = "Date de naissance: ";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSexe.Location = new System.Drawing.Point(106, 402);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(57, 20);
            this.lblSexe.TabIndex = 14;
            this.lblSexe.Text = "Sexe : ";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGrade.Location = new System.Drawing.Point(97, 444);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(66, 20);
            this.lblGrade.TabIndex = 15;
            this.lblGrade.Text = "Grade : ";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCaserne.Location = new System.Drawing.Point(12, 501);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(202, 20);
            this.lblCaserne.TabIndex = 16;
            this.lblCaserne.Text = "Caserne de rattachement : ";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrenom.Location = new System.Drawing.Point(128, 122);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(76, 20);
            this.lblPrenom.TabIndex = 17;
            this.lblPrenom.Text = "Prenom : ";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrenom.Location = new System.Drawing.Point(204, 122);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 26);
            this.txtPrenom.TabIndex = 1;
            this.txtPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // dtpNaissance
            // 
            this.dtpNaissance.CustomFormat = "yyyy-MM-dd";
            this.dtpNaissance.Location = new System.Drawing.Point(210, 319);
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Size = new System.Drawing.Size(200, 23);
            this.dtpNaissance.TabIndex = 5;
            this.dtpNaissance.Value = new System.DateTime(2006, 5, 30, 20, 28, 0, 0);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStatus.Location = new System.Drawing.Point(97, 562);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(68, 20);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Status : ";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(230, 559);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 28);
            this.cboStatus.TabIndex = 9;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(376, 624);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(79, 32);
            this.btnValider.TabIndex = 20;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(473, 624);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(79, 32);
            this.btnQuitter.TabIndex = 21;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FrmCreerPompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 687);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dtpNaissance);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblCaserne);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblSexe);
            this.Controls.Add(this.lblNaissance);
            this.Controls.Add(this.lblBip);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblMatricule);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.cboCaserne);
            this.Controls.Add(this.cboGrade);
            this.Controls.Add(this.cboSexe);
            this.Controls.Add(this.txtBip);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.txtNom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCreerPompier";
            this.Text = "FrmCreerPompier";
            this.Load += new System.EventHandler(this.FrmCreerPompier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtBip;
        private System.Windows.Forms.ComboBox cboSexe;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblBip;
        private System.Windows.Forms.Label lblNaissance;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.DateTimePicker dtpNaissance;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnQuitter;
    }
}
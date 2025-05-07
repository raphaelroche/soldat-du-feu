namespace SAE_A21D21_pompiers1
{
    partial class AjouterMission
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
            this.grpDataGridView = new System.Windows.Forms.GroupBox();
            this.dgvPompiers = new System.Windows.Forms.DataGridView();
            this.dgvEngin = new System.Windows.Forms.DataGridView();
            this.lblEngin = new System.Windows.Forms.Label();
            this.lblPompiers = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblIdMIssion = new System.Windows.Forms.Label();
            this.grpDecision = new System.Windows.Forms.GroupBox();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.cboNatureSinistre = new System.Windows.Forms.ComboBox();
            this.btnEquipe = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblNatureSinistre = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblAddrSinistre = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.grpDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompiers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngin)).BeginInit();
            this.grpDecision.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDataGridView
            // 
            this.grpDataGridView.Controls.Add(this.dgvPompiers);
            this.grpDataGridView.Controls.Add(this.dgvEngin);
            this.grpDataGridView.Controls.Add(this.lblEngin);
            this.grpDataGridView.Controls.Add(this.lblPompiers);
            this.grpDataGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpDataGridView.Location = new System.Drawing.Point(81, 411);
            this.grpDataGridView.Name = "grpDataGridView";
            this.grpDataGridView.Size = new System.Drawing.Size(760, 291);
            this.grpDataGridView.TabIndex = 21;
            this.grpDataGridView.TabStop = false;
            this.grpDataGridView.Text = "Mobilisation des engins et des pompiers";
            // 
            // dgvPompiers
            // 
            this.dgvPompiers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPompiers.Location = new System.Drawing.Point(397, 88);
            this.dgvPompiers.Name = "dgvPompiers";
            this.dgvPompiers.Size = new System.Drawing.Size(332, 183);
            this.dgvPompiers.TabIndex = 4;
            // 
            // dgvEngin
            // 
            this.dgvEngin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEngin.Location = new System.Drawing.Point(22, 88);
            this.dgvEngin.Name = "dgvEngin";
            this.dgvEngin.Size = new System.Drawing.Size(334, 183);
            this.dgvEngin.TabIndex = 3;
            // 
            // lblEngin
            // 
            this.lblEngin.AutoSize = true;
            this.lblEngin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEngin.Location = new System.Drawing.Point(108, 58);
            this.lblEngin.Name = "lblEngin";
            this.lblEngin.Size = new System.Drawing.Size(113, 17);
            this.lblEngin.TabIndex = 2;
            this.lblEngin.Text = "Engins mobilisés";
            // 
            // lblPompiers
            // 
            this.lblPompiers.AutoSize = true;
            this.lblPompiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPompiers.Location = new System.Drawing.Point(483, 49);
            this.lblPompiers.Name = "lblPompiers";
            this.lblPompiers.Size = new System.Drawing.Size(129, 17);
            this.lblPompiers.TabIndex = 1;
            this.lblPompiers.Text = "Pompiers mobilisés";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate.Location = new System.Drawing.Point(415, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(106, 17);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = "Declenchée le :";
            // 
            // lblIdMIssion
            // 
            this.lblIdMIssion.AutoSize = true;
            this.lblIdMIssion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblIdMIssion.Location = new System.Drawing.Point(100, 36);
            this.lblIdMIssion.Name = "lblIdMIssion";
            this.lblIdMIssion.Size = new System.Drawing.Size(85, 17);
            this.lblIdMIssion.TabIndex = 19;
            this.lblIdMIssion.Text = "Mission n° : ";
            // 
            // grpDecision
            // 
            this.grpDecision.Controls.Add(this.cboCaserne);
            this.grpDecision.Controls.Add(this.cboNatureSinistre);
            this.grpDecision.Controls.Add(this.btnEquipe);
            this.grpDecision.Controls.Add(this.btnAnnuler);
            this.grpDecision.Controls.Add(this.lblCaserne);
            this.grpDecision.Controls.Add(this.lblNatureSinistre);
            this.grpDecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpDecision.Location = new System.Drawing.Point(81, 260);
            this.grpDecision.Name = "grpDecision";
            this.grpDecision.Size = new System.Drawing.Size(760, 129);
            this.grpDecision.TabIndex = 18;
            this.grpDecision.TabStop = false;
            this.grpDecision.Text = "Decision du regulateur";
            // 
            // cboCaserne
            // 
            this.cboCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(521, 40);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(208, 24);
            this.cboCaserne.TabIndex = 15;
            // 
            // cboNatureSinistre
            // 
            this.cboNatureSinistre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNatureSinistre.FormattingEnabled = true;
            this.cboNatureSinistre.Location = new System.Drawing.Point(145, 40);
            this.cboNatureSinistre.Name = "cboNatureSinistre";
            this.cboNatureSinistre.Size = new System.Drawing.Size(193, 24);
            this.cboNatureSinistre.TabIndex = 14;
            // 
            // btnEquipe
            // 
            this.btnEquipe.Location = new System.Drawing.Point(589, 90);
            this.btnEquipe.Name = "btnEquipe";
            this.btnEquipe.Size = new System.Drawing.Size(158, 23);
            this.btnEquipe.TabIndex = 13;
            this.btnEquipe.Text = "Constituer l\'equipe";
            this.btnEquipe.UseVisualStyleBackColor = true;
            this.btnEquipe.Click += new System.EventHandler(this.btnEquipe_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(486, 90);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(97, 23);
            this.btnAnnuler.TabIndex = 12;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCaserne.Location = new System.Drawing.Point(367, 43);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(133, 17);
            this.lblCaserne.TabIndex = 11;
            this.lblCaserne.Text = "Caserne a mobiliser";
            // 
            // lblNatureSinistre
            // 
            this.lblNatureSinistre.AutoSize = true;
            this.lblNatureSinistre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNatureSinistre.Location = new System.Drawing.Point(19, 40);
            this.lblNatureSinistre.Name = "lblNatureSinistre";
            this.lblNatureSinistre.Size = new System.Drawing.Size(120, 17);
            this.lblNatureSinistre.TabIndex = 9;
            this.lblNatureSinistre.Text = "Nature du sinistre";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblAddrSinistre);
            this.grpInfo.Controls.Add(this.lblVille);
            this.grpInfo.Controls.Add(this.lblRue);
            this.grpInfo.Controls.Add(this.lblCodePostal);
            this.grpInfo.Controls.Add(this.txtCodePostal);
            this.grpInfo.Controls.Add(this.txtRue);
            this.grpInfo.Controls.Add(this.txtVille);
            this.grpInfo.Controls.Add(this.txtMotif);
            this.grpInfo.Controls.Add(this.lblMotif);
            this.grpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpInfo.Location = new System.Drawing.Point(81, 71);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(760, 183);
            this.grpInfo.TabIndex = 17;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Informations usager";
            // 
            // lblAddrSinistre
            // 
            this.lblAddrSinistre.AutoSize = true;
            this.lblAddrSinistre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddrSinistre.Location = new System.Drawing.Point(539, 19);
            this.lblAddrSinistre.Name = "lblAddrSinistre";
            this.lblAddrSinistre.Size = new System.Drawing.Size(111, 17);
            this.lblAddrSinistre.TabIndex = 8;
            this.lblAddrSinistre.Text = "Adresse Sinistre";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVille.Location = new System.Drawing.Point(356, 122);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(34, 17);
            this.lblVille.TabIndex = 7;
            this.lblVille.Text = "Ville";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRue.Location = new System.Drawing.Point(356, 51);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(34, 17);
            this.lblRue.TabIndex = 6;
            this.lblRue.Text = "Rue";
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCodePostal.Location = new System.Drawing.Point(356, 83);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(84, 17);
            this.lblCodePostal.TabIndex = 5;
            this.lblCodePostal.Text = "Code Postal";
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(450, 83);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(133, 23);
            this.txtCodePostal.TabIndex = 4;
            this.txtCodePostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodePostal_KeyPress);
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(450, 48);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(239, 23);
            this.txtRue.TabIndex = 3;
            this.txtRue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRue_KeyPress);
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(450, 122);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(239, 23);
            this.txtVille.TabIndex = 2;
            this.txtVille.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVille_KeyPress);
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(80, 38);
            this.txtMotif.Multiline = true;
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(184, 107);
            this.txtMotif.TabIndex = 1;
            this.txtMotif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotif_KeyPress);
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMotif.Location = new System.Drawing.Point(19, 38);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(38, 17);
            this.lblMotif.TabIndex = 0;
            this.lblMotif.Text = "Motif";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(758, 723);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(108, 23);
            this.btnFermer.TabIndex = 22;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(604, 723);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(127, 23);
            this.btnValider.TabIndex = 23;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // AjouterMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 805);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.grpDataGridView);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblIdMIssion);
            this.Controls.Add(this.grpDecision);
            this.Controls.Add(this.grpInfo);
            this.Name = "AjouterMission";
            this.Text = "AjouterMission";
            this.Load += new System.EventHandler(this.AjouterMission_Load);
            this.grpDataGridView.ResumeLayout(false);
            this.grpDataGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompiers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngin)).EndInit();
            this.grpDecision.ResumeLayout(false);
            this.grpDecision.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDataGridView;
        private System.Windows.Forms.DataGridView dgvPompiers;
        private System.Windows.Forms.DataGridView dgvEngin;
        private System.Windows.Forms.Label lblEngin;
        private System.Windows.Forms.Label lblPompiers;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblIdMIssion;
        private System.Windows.Forms.GroupBox grpDecision;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.ComboBox cboNatureSinistre;
        private System.Windows.Forms.Button btnEquipe;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblNatureSinistre;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblAddrSinistre;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnValider;
    }
}
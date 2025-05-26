namespace UC_GestionPersonnel
{
    partial class AfficherPompier
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInfo = new System.Windows.Forms.Button();
            this.pnlInformations = new System.Windows.Forms.Panel();
            this.grpInfoCarriere = new System.Windows.Forms.GroupBox();
            this.lstAffectations = new System.Windows.Forms.ListBox();
            this.lstHabilitations = new System.Windows.Forms.ListBox();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.lblAffectations = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHabilitations = new System.Windows.Forms.Label();
            this.lblcaserne = new System.Windows.Forms.Label();
            this.btnMaj = new System.Windows.Forms.Button();
            this.chkConge = new System.Windows.Forms.CheckBox();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNaissance = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblEmbauche = new System.Windows.Forms.Label();
            this.rdbProfessionnel = new System.Windows.Forms.RadioButton();
            this.rdbVolontaire = new System.Windows.Forms.RadioButton();
            this.grpCarriere = new System.Windows.Forms.GroupBox();
            this.lblAbrev = new System.Windows.Forms.Label();
            this.btnChanger = new System.Windows.Forms.Button();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblBip = new System.Windows.Forms.Label();
            this.pbGrade = new System.Windows.Forms.PictureBox();
            this.pnlFichePompier = new System.Windows.Forms.Panel();
            this.pnlInformations.SuspendLayout();
            this.grpInfoCarriere.SuspendLayout();
            this.grpCarriere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrade)).BeginInit();
            this.pnlFichePompier.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(556, 549);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(153, 28);
            this.btnInfo.TabIndex = 12;
            this.btnInfo.Text = "Plus d\'informations";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // pnlInformations
            // 
            this.pnlInformations.Controls.Add(this.grpInfoCarriere);
            this.pnlInformations.Controls.Add(this.btnMaj);
            this.pnlInformations.Controls.Add(this.chkConge);
            this.pnlInformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pnlInformations.Location = new System.Drawing.Point(4, 444);
            this.pnlInformations.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInformations.Name = "pnlInformations";
            this.pnlInformations.Size = new System.Drawing.Size(831, 447);
            this.pnlInformations.TabIndex = 13;
            // 
            // grpInfoCarriere
            // 
            this.grpInfoCarriere.Controls.Add(this.lstAffectations);
            this.grpInfoCarriere.Controls.Add(this.lstHabilitations);
            this.grpInfoCarriere.Controls.Add(this.cboCaserne);
            this.grpInfoCarriere.Controls.Add(this.lblAffectations);
            this.grpInfoCarriere.Controls.Add(this.label3);
            this.grpInfoCarriere.Controls.Add(this.lblHabilitations);
            this.grpInfoCarriere.Controls.Add(this.lblcaserne);
            this.grpInfoCarriere.Location = new System.Drawing.Point(4, 4);
            this.grpInfoCarriere.Margin = new System.Windows.Forms.Padding(4);
            this.grpInfoCarriere.Name = "grpInfoCarriere";
            this.grpInfoCarriere.Padding = new System.Windows.Forms.Padding(4);
            this.grpInfoCarriere.Size = new System.Drawing.Size(823, 377);
            this.grpInfoCarriere.TabIndex = 2;
            this.grpInfoCarriere.TabStop = false;
            this.grpInfoCarriere.Text = "Informations Carriere";
            // 
            // lstAffectations
            // 
            this.lstAffectations.FormattingEnabled = true;
            this.lstAffectations.ItemHeight = 20;
            this.lstAffectations.Location = new System.Drawing.Point(55, 283);
            this.lstAffectations.Margin = new System.Windows.Forms.Padding(4);
            this.lstAffectations.Name = "lstAffectations";
            this.lstAffectations.Size = new System.Drawing.Size(588, 44);
            this.lstAffectations.TabIndex = 6;
            // 
            // lstHabilitations
            // 
            this.lstHabilitations.FormattingEnabled = true;
            this.lstHabilitations.ItemHeight = 20;
            this.lstHabilitations.Location = new System.Drawing.Point(55, 144);
            this.lstHabilitations.Margin = new System.Windows.Forms.Padding(4);
            this.lstHabilitations.Name = "lstHabilitations";
            this.lstHabilitations.Size = new System.Drawing.Size(588, 64);
            this.lstHabilitations.TabIndex = 5;
            // 
            // cboCaserne
            // 
            this.cboCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(293, 58);
            this.cboCaserne.Margin = new System.Windows.Forms.Padding(4);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(349, 28);
            this.cboCaserne.TabIndex = 4;
            this.cboCaserne.SelectedIndexChanged += new System.EventHandler(this.cboCaserne_SelectedIndexChanged_1);
            // 
            // lblAffectations
            // 
            this.lblAffectations.AutoSize = true;
            this.lblAffectations.Location = new System.Drawing.Point(51, 246);
            this.lblAffectations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAffectations.Name = "lblAffectations";
            this.lblAffectations.Size = new System.Drawing.Size(166, 20);
            this.lblAffectations.TabIndex = 3;
            this.lblAffectations.Text = "Affectations passées";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-443, -519);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // lblHabilitations
            // 
            this.lblHabilitations.AutoSize = true;
            this.lblHabilitations.Location = new System.Drawing.Point(51, 105);
            this.lblHabilitations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHabilitations.Name = "lblHabilitations";
            this.lblHabilitations.Size = new System.Drawing.Size(102, 20);
            this.lblHabilitations.TabIndex = 1;
            this.lblHabilitations.Text = "Habilitations";
            // 
            // lblcaserne
            // 
            this.lblcaserne.AutoSize = true;
            this.lblcaserne.Location = new System.Drawing.Point(45, 62);
            this.lblcaserne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcaserne.Name = "lblcaserne";
            this.lblcaserne.Size = new System.Drawing.Size(213, 20);
            this.lblcaserne.TabIndex = 0;
            this.lblcaserne.Text = "Caserne de rattachement : ";
            // 
            // btnMaj
            // 
            this.btnMaj.Location = new System.Drawing.Point(548, 388);
            this.btnMaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaj.Name = "btnMaj";
            this.btnMaj.Size = new System.Drawing.Size(173, 28);
            this.btnMaj.TabIndex = 1;
            this.btnMaj.Text = "Mettre a jour";
            this.btnMaj.UseVisualStyleBackColor = true;
            this.btnMaj.Click += new System.EventHandler(this.btnMaj_Click_1);
            // 
            // chkConge
            // 
            this.chkConge.AutoSize = true;
            this.chkConge.Location = new System.Drawing.Point(100, 388);
            this.chkConge.Margin = new System.Windows.Forms.Padding(4);
            this.chkConge.Name = "chkConge";
            this.chkConge.Size = new System.Drawing.Size(101, 24);
            this.chkConge.TabIndex = 0;
            this.chkConge.Text = "En congé";
            this.chkConge.UseVisualStyleBackColor = true;
            this.chkConge.CheckedChanged += new System.EventHandler(this.chkConge_CheckedChanged_1);
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMatricule.Location = new System.Drawing.Point(351, 33);
            this.lblMatricule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(107, 25);
            this.lblMatricule.TabIndex = 0;
            this.lblMatricule.Text = "Matricule : ";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(40, 39);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(59, 20);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom : ";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(40, 74);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(82, 20);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prenom : ";
            // 
            // lblNaissance
            // 
            this.lblNaissance.AutoSize = true;
            this.lblNaissance.Location = new System.Drawing.Point(40, 106);
            this.lblNaissance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaissance.Name = "lblNaissance";
            this.lblNaissance.Size = new System.Drawing.Size(159, 20);
            this.lblNaissance.TabIndex = 3;
            this.lblNaissance.Text = "Date de naissance :";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(40, 143);
            this.lblSexe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(56, 20);
            this.lblSexe.TabIndex = 4;
            this.lblSexe.Text = "Sexe :";
            // 
            // lblEmbauche
            // 
            this.lblEmbauche.AutoSize = true;
            this.lblEmbauche.Location = new System.Drawing.Point(44, 215);
            this.lblEmbauche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmbauche.Name = "lblEmbauche";
            this.lblEmbauche.Size = new System.Drawing.Size(155, 20);
            this.lblEmbauche.TabIndex = 7;
            this.lblEmbauche.Text = "Date d\'embauche : ";
            // 
            // rdbProfessionnel
            // 
            this.rdbProfessionnel.AutoSize = true;
            this.rdbProfessionnel.Location = new System.Drawing.Point(44, 168);
            this.rdbProfessionnel.Margin = new System.Windows.Forms.Padding(4);
            this.rdbProfessionnel.Name = "rdbProfessionnel";
            this.rdbProfessionnel.Size = new System.Drawing.Size(132, 24);
            this.rdbProfessionnel.TabIndex = 9;
            this.rdbProfessionnel.TabStop = true;
            this.rdbProfessionnel.Text = "Professionnel";
            this.rdbProfessionnel.UseVisualStyleBackColor = true;
            this.rdbProfessionnel.CheckedChanged += new System.EventHandler(this.rdbProfessionnel_CheckedChanged_1);
            // 
            // rdbVolontaire
            // 
            this.rdbVolontaire.AutoSize = true;
            this.rdbVolontaire.Location = new System.Drawing.Point(201, 168);
            this.rdbVolontaire.Margin = new System.Windows.Forms.Padding(4);
            this.rdbVolontaire.Name = "rdbVolontaire";
            this.rdbVolontaire.Size = new System.Drawing.Size(105, 24);
            this.rdbVolontaire.TabIndex = 10;
            this.rdbVolontaire.TabStop = true;
            this.rdbVolontaire.Text = "Volontaire";
            this.rdbVolontaire.UseVisualStyleBackColor = true;
            this.rdbVolontaire.CheckedChanged += new System.EventHandler(this.rdbVolontaire_CheckedChanged_1);
            // 
            // grpCarriere
            // 
            this.grpCarriere.Controls.Add(this.lblAbrev);
            this.grpCarriere.Controls.Add(this.btnChanger);
            this.grpCarriere.Controls.Add(this.cboGrade);
            this.grpCarriere.Controls.Add(this.lblTelephone);
            this.grpCarriere.Controls.Add(this.lblGrade);
            this.grpCarriere.Controls.Add(this.lblBip);
            this.grpCarriere.Location = new System.Drawing.Point(48, 286);
            this.grpCarriere.Margin = new System.Windows.Forms.Padding(4);
            this.grpCarriere.Name = "grpCarriere";
            this.grpCarriere.Padding = new System.Windows.Forms.Padding(4);
            this.grpCarriere.Size = new System.Drawing.Size(656, 128);
            this.grpCarriere.TabIndex = 11;
            this.grpCarriere.TabStop = false;
            this.grpCarriere.Text = "Carriere";
            // 
            // lblAbrev
            // 
            this.lblAbrev.AutoSize = true;
            this.lblAbrev.Location = new System.Drawing.Point(125, 53);
            this.lblAbrev.Name = "lblAbrev";
            this.lblAbrev.Size = new System.Drawing.Size(0, 20);
            this.lblAbrev.TabIndex = 12;
            // 
            // btnChanger
            // 
            this.btnChanger.Location = new System.Drawing.Point(500, 50);
            this.btnChanger.Margin = new System.Windows.Forms.Padding(4);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(100, 28);
            this.btnChanger.TabIndex = 11;
            this.btnChanger.Text = "Changer";
            this.btnChanger.UseVisualStyleBackColor = true;
            this.btnChanger.Click += new System.EventHandler(this.btnChanger_Click_1);
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.Enabled = false;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(196, 50);
            this.cboGrade.Margin = new System.Windows.Forms.Padding(4);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(108, 28);
            this.cboGrade.TabIndex = 10;
            this.cboGrade.SelectedIndexChanged += new System.EventHandler(this.cboGrade_SelectedIndexChanged);
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(48, 95);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(101, 20);
            this.lblTelephone.TabIndex = 6;
            this.lblTelephone.Text = "Telephone : ";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(48, 50);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(70, 20);
            this.lblGrade.TabIndex = 5;
            this.lblGrade.Text = "Grade : ";
            // 
            // lblBip
            // 
            this.lblBip.AutoSize = true;
            this.lblBip.Location = new System.Drawing.Point(496, 95);
            this.lblBip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBip.Name = "lblBip";
            this.lblBip.Size = new System.Drawing.Size(49, 20);
            this.lblBip.TabIndex = 8;
            this.lblBip.Text = "Bip : ";
            // 
            // pbGrade
            // 
            this.pbGrade.Location = new System.Drawing.Point(571, 66);
            this.pbGrade.Margin = new System.Windows.Forms.Padding(4);
            this.pbGrade.Name = "pbGrade";
            this.pbGrade.Size = new System.Drawing.Size(133, 98);
            this.pbGrade.TabIndex = 12;
            this.pbGrade.TabStop = false;
            // 
            // pnlFichePompier
            // 
            this.pnlFichePompier.Controls.Add(this.pbGrade);
            this.pnlFichePompier.Controls.Add(this.grpCarriere);
            this.pnlFichePompier.Controls.Add(this.rdbVolontaire);
            this.pnlFichePompier.Controls.Add(this.rdbProfessionnel);
            this.pnlFichePompier.Controls.Add(this.lblEmbauche);
            this.pnlFichePompier.Controls.Add(this.lblSexe);
            this.pnlFichePompier.Controls.Add(this.lblNaissance);
            this.pnlFichePompier.Controls.Add(this.lblPrenom);
            this.pnlFichePompier.Controls.Add(this.lblNom);
            this.pnlFichePompier.Controls.Add(this.lblMatricule);
            this.pnlFichePompier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pnlFichePompier.Location = new System.Drawing.Point(5, 5);
            this.pnlFichePompier.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFichePompier.Name = "pnlFichePompier";
            this.pnlFichePompier.Size = new System.Drawing.Size(831, 431);
            this.pnlFichePompier.TabIndex = 0;
            this.pnlFichePompier.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFichePompier_Paint);
            // 
            // AfficherPompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlInformations);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.pnlFichePompier);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AfficherPompier";
            this.Size = new System.Drawing.Size(840, 893);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.pnlInformations.ResumeLayout(false);
            this.pnlInformations.PerformLayout();
            this.grpInfoCarriere.ResumeLayout(false);
            this.grpInfoCarriere.PerformLayout();
            this.grpCarriere.ResumeLayout(false);
            this.grpCarriere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrade)).EndInit();
            this.pnlFichePompier.ResumeLayout(false);
            this.pnlFichePompier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel pnlInformations;
        private System.Windows.Forms.GroupBox grpInfoCarriere;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHabilitations;
        private System.Windows.Forms.Label lblcaserne;
        private System.Windows.Forms.Button btnMaj;
        private System.Windows.Forms.CheckBox chkConge;
        private System.Windows.Forms.ListBox lstHabilitations;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.Label lblAffectations;
        private System.Windows.Forms.ListBox lstAffectations;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNaissance;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblEmbauche;
        private System.Windows.Forms.RadioButton rdbProfessionnel;
        private System.Windows.Forms.RadioButton rdbVolontaire;
        private System.Windows.Forms.GroupBox grpCarriere;
        private System.Windows.Forms.Button btnChanger;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblBip;
        private System.Windows.Forms.PictureBox pbGrade;
        private System.Windows.Forms.Panel pnlFichePompier;
        private System.Windows.Forms.Label lblAbrev;
    }
}

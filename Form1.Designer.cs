namespace SAE_A21D21_pompiers
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTableauDeBord = new System.Windows.Forms.Panel();
            this.pnlTrait = new System.Windows.Forms.Panel();
            this.cbEnCours = new System.Windows.Forms.CheckBox();
            this.lblTDB = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblGestionPersonnel = new System.Windows.Forms.Label();
            this.lblEtatEngin = new System.Windows.Forms.Label();
            this.lblAjtMission = new System.Windows.Forms.Label();
            this.lblTabDB = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnGestionPersonnel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEngin = new System.Windows.Forms.Button();
            this.btnTDB = new System.Windows.Forms.Button();
            this.pnlTableauDeBord.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTableauDeBord
            // 
            this.pnlTableauDeBord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTableauDeBord.AutoScroll = true;
            this.pnlTableauDeBord.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTableauDeBord.Controls.Add(this.pnlTrait);
            this.pnlTableauDeBord.Controls.Add(this.cbEnCours);
            this.pnlTableauDeBord.Controls.Add(this.lblTDB);
            this.pnlTableauDeBord.Location = new System.Drawing.Point(346, 12);
            this.pnlTableauDeBord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTableauDeBord.Name = "pnlTableauDeBord";
            this.pnlTableauDeBord.Size = new System.Drawing.Size(1164, 805);
            this.pnlTableauDeBord.TabIndex = 0;
            this.pnlTableauDeBord.Visible = false;
            // 
            // pnlTrait
            // 
            this.pnlTrait.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTrait.Location = new System.Drawing.Point(27, 94);
            this.pnlTrait.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTrait.Name = "pnlTrait";
            this.pnlTrait.Size = new System.Drawing.Size(1110, 17);
            this.pnlTrait.TabIndex = 2;
            this.pnlTrait.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTrait_Paint);
            // 
            // cbEnCours
            // 
            this.cbEnCours.AutoSize = true;
            this.cbEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnCours.Location = new System.Drawing.Point(504, 61);
            this.cbEnCours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEnCours.Name = "cbEnCours";
            this.cbEnCours.Size = new System.Drawing.Size(129, 33);
            this.cbEnCours.TabIndex = 1;
            this.cbEnCours.Text = "En cours";
            this.cbEnCours.UseVisualStyleBackColor = true;
            this.cbEnCours.CheckedChanged += new System.EventHandler(this.cbEnCours_CheckedChanged);
            // 
            // lblTDB
            // 
            this.lblTDB.AutoSize = true;
            this.lblTDB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDB.Location = new System.Drawing.Point(413, 19);
            this.lblTDB.Name = "lblTDB";
            this.lblTDB.Size = new System.Drawing.Size(310, 43);
            this.lblTDB.TabIndex = 0;
            this.lblTDB.Text = "Tableau de bord";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.BackColor = System.Drawing.Color.DarkRed;
            this.pnlMenu.Controls.Add(this.lblGestionPersonnel);
            this.pnlMenu.Controls.Add(this.lblEtatEngin);
            this.pnlMenu.Controls.Add(this.lblAjtMission);
            this.pnlMenu.Controls.Add(this.lblTabDB);
            this.pnlMenu.Controls.Add(this.lblExit);
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnAjouter);
            this.pnlMenu.Controls.Add(this.btnGestionPersonnel);
            this.pnlMenu.Controls.Add(this.button2);
            this.pnlMenu.Controls.Add(this.btnEngin);
            this.pnlMenu.Controls.Add(this.btnTDB);
            this.pnlMenu.Location = new System.Drawing.Point(12, 12);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(328, 805);
            this.pnlMenu.TabIndex = 1;
            // 
            // lblGestionPersonnel
            // 
            this.lblGestionPersonnel.AutoSize = true;
            this.lblGestionPersonnel.BackColor = System.Drawing.Color.Transparent;
            this.lblGestionPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionPersonnel.ForeColor = System.Drawing.Color.White;
            this.lblGestionPersonnel.Location = new System.Drawing.Point(173, 369);
            this.lblGestionPersonnel.Name = "lblGestionPersonnel";
            this.lblGestionPersonnel.Size = new System.Drawing.Size(98, 75);
            this.lblGestionPersonnel.TabIndex = 10;
            this.lblGestionPersonnel.Text = "Gestion\r\ndu\r\npersonnel";
            this.lblGestionPersonnel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEtatEngin
            // 
            this.lblEtatEngin.AutoSize = true;
            this.lblEtatEngin.BackColor = System.Drawing.Color.Transparent;
            this.lblEtatEngin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtatEngin.ForeColor = System.Drawing.Color.White;
            this.lblEtatEngin.Location = new System.Drawing.Point(176, 260);
            this.lblEtatEngin.Name = "lblEtatEngin";
            this.lblEtatEngin.Size = new System.Drawing.Size(92, 75);
            this.lblEtatEngin.TabIndex = 9;
            this.lblEtatEngin.Text = "Voir l\'état\r\ndes\r\nengins";
            this.lblEtatEngin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAjtMission
            // 
            this.lblAjtMission.AutoSize = true;
            this.lblAjtMission.BackColor = System.Drawing.Color.Transparent;
            this.lblAjtMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjtMission.ForeColor = System.Drawing.Color.White;
            this.lblAjtMission.Location = new System.Drawing.Point(166, 162);
            this.lblAjtMission.Name = "lblAjtMission";
            this.lblAjtMission.Size = new System.Drawing.Size(112, 50);
            this.lblAjtMission.TabIndex = 8;
            this.lblAjtMission.Text = "Ajouter une\r\nmission";
            this.lblAjtMission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTabDB
            // 
            this.lblTabDB.AutoSize = true;
            this.lblTabDB.BackColor = System.Drawing.Color.Transparent;
            this.lblTabDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabDB.ForeColor = System.Drawing.Color.White;
            this.lblTabDB.Location = new System.Drawing.Point(144, 70);
            this.lblTabDB.Name = "lblTabDB";
            this.lblTabDB.Size = new System.Drawing.Size(157, 25);
            this.lblTabDB.TabIndex = 7;
            this.lblTabDB.Text = "Tableau de Bord";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(176, 651);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(70, 25);
            this.lblExit.TabIndex = 6;
            this.lblExit.Text = "Quitter";
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(30, 602);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 109);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.Location = new System.Drawing.Point(30, 140);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(109, 109);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnGestionPersonnel
            // 
            this.btnGestionPersonnel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionPersonnel.Location = new System.Drawing.Point(30, 360);
            this.btnGestionPersonnel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestionPersonnel.Name = "btnGestionPersonnel";
            this.btnGestionPersonnel.Size = new System.Drawing.Size(109, 109);
            this.btnGestionPersonnel.TabIndex = 3;
            this.btnGestionPersonnel.UseVisualStyleBackColor = true;
            this.btnGestionPersonnel.Click += new System.EventHandler(this.btnGestionPersonnel_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(30, 470);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 109);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnEngin
            // 
            this.btnEngin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEngin.Location = new System.Drawing.Point(30, 250);
            this.btnEngin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEngin.Name = "btnEngin";
            this.btnEngin.Size = new System.Drawing.Size(109, 109);
            this.btnEngin.TabIndex = 1;
            this.btnEngin.UseVisualStyleBackColor = true;
            this.btnEngin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTDB
            // 
            this.btnTDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTDB.Location = new System.Drawing.Point(30, 30);
            this.btnTDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTDB.Name = "btnTDB";
            this.btnTDB.Size = new System.Drawing.Size(109, 109);
            this.btnTDB.TabIndex = 0;
            this.btnTDB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::SAE_A21D21_pompiers1.Properties.Resources.caserne;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1531, 834);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTableauDeBord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les soldats du feu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTableauDeBord.ResumeLayout(false);
            this.pnlTableauDeBord.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTableauDeBord;
        private System.Windows.Forms.Label lblTDB;
        private System.Windows.Forms.CheckBox cbEnCours;
        private System.Windows.Forms.Panel pnlTrait;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnTDB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnGestionPersonnel;
        private System.Windows.Forms.Button btnEngin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblTabDB;
        private System.Windows.Forms.Label lblAjtMission;
        private System.Windows.Forms.Label lblGestionPersonnel;
        private System.Windows.Forms.Label lblEtatEngin;
    }
}


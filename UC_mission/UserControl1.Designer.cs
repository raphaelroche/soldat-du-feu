namespace UC_mission
{
    partial class Mission
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
            this.lblIDMission = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCloture = new System.Windows.Forms.Button();
            this.btnRapport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDMission
            // 
            this.lblIDMission.AutoSize = true;
            this.lblIDMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDMission.Location = new System.Drawing.Point(140, 24);
            this.lblIDMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDMission.Name = "lblIDMission";
            this.lblIDMission.Size = new System.Drawing.Size(90, 18);
            this.lblIDMission.TabIndex = 2;
            this.lblIDMission.Text = "ID mission : ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(140, 66);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 18);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(297, 24);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(74, 18);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Debut le : ";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.Location = new System.Drawing.Point(501, 24);
            this.lblCaserne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(91, 20);
            this.lblCaserne.TabIndex = 5;
            this.lblCaserne.Text = "Caserne : ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(140, 89);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.MaximumSize = new System.Drawing.Size(488, 81);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(31, 20);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "-->";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblCaserne);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblIDMission);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 135);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UC_mission.Properties.Resources.gyrophare2;
            this.pictureBox1.Location = new System.Drawing.Point(26, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCloture
            // 
            this.btnCloture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloture.Location = new System.Drawing.Point(792, 35);
            this.btnCloture.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloture.Name = "btnCloture";
            this.btnCloture.Size = new System.Drawing.Size(68, 65);
            this.btnCloture.TabIndex = 8;
            this.btnCloture.UseVisualStyleBackColor = true;
            this.btnCloture.Click += new System.EventHandler(this.btnCloture_Click);
            // 
            // btnRapport
            // 
            this.btnRapport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRapport.Location = new System.Drawing.Point(878, 35);
            this.btnRapport.Margin = new System.Windows.Forms.Padding(2);
            this.btnRapport.Name = "btnRapport";
            this.btnRapport.Size = new System.Drawing.Size(68, 65);
            this.btnRapport.TabIndex = 9;
            this.btnRapport.UseVisualStyleBackColor = true;
            this.btnRapport.Click += new System.EventHandler(this.btnRapport_Click);
            // 
            // Mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRapport);
            this.Controls.Add(this.btnCloture);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Mission";
            this.Size = new System.Drawing.Size(980, 140);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIDMission;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloture;
        private System.Windows.Forms.Button btnRapport;
    }
}

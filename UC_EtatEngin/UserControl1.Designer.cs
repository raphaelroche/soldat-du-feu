namespace UC_EtatEngin
{
    partial class UserControl1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMission = new System.Windows.Forms.CheckBox();
            this.cboPanne = new System.Windows.Forms.CheckBox();
            this.pbEngin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEngin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.lblNumero.Location = new System.Drawing.Point(164, 41);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(39, 27);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "N°";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.lblDate.Location = new System.Drawing.Point(243, 95);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(61, 27);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.label4.Location = new System.Drawing.Point(44, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date de réception";
            // 
            // cboMission
            // 
            this.cboMission.AutoSize = true;
            this.cboMission.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboMission.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.cboMission.Location = new System.Drawing.Point(48, 208);
            this.cboMission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMission.Name = "cboMission";
            this.cboMission.Size = new System.Drawing.Size(162, 31);
            this.cboMission.TabIndex = 4;
            this.cboMission.Text = "En mission   ";
            this.cboMission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboMission.UseVisualStyleBackColor = true;
            this.cboMission.Click += new System.EventHandler(this.cboMission_Click);
            // 
            // cboPanne
            // 
            this.cboPanne.AutoSize = true;
            this.cboPanne.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboPanne.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPanne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.cboPanne.Location = new System.Drawing.Point(48, 260);
            this.cboPanne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboPanne.Name = "cboPanne";
            this.cboPanne.Size = new System.Drawing.Size(164, 31);
            this.cboPanne.TabIndex = 5;
            this.cboPanne.Text = "En panne      ";
            this.cboPanne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboPanne.UseVisualStyleBackColor = true;
            // 
            // pbEngin
            // 
            this.pbEngin.Location = new System.Drawing.Point(364, 41);
            this.pbEngin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbEngin.Name = "pbEngin";
            this.pbEngin.Size = new System.Drawing.Size(198, 142);
            this.pbEngin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEngin.TabIndex = 6;
            this.pbEngin.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbEngin);
            this.Controls.Add(this.cboPanne);
            this.Controls.Add(this.cboMission);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(600, 366);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEngin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cboMission;
        private System.Windows.Forms.CheckBox cboPanne;
        private System.Windows.Forms.PictureBox pbEngin;
    }
}

namespace SAE_A21D21_pompiers1
{
    partial class frm_Stats
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
            this.lbl_Global = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCasernes = new System.Windows.Forms.ComboBox();
            this.lblUtilEngin = new System.Windows.Forms.Label();
            this.lblUtilEnginList = new System.Windows.Forms.Label();
            this.lblTempsUtil = new System.Windows.Forms.Label();
            this.lblTempsEnginList = new System.Windows.Forms.Label();
            this.lblNbInter = new System.Windows.Forms.Label();
            this.lblNbInterList = new System.Windows.Forms.Label();
            this.lblTopInter = new System.Windows.Forms.Label();
            this.lblTopInterList = new System.Windows.Forms.Label();
            this.cbHabilitation = new System.Windows.Forms.ComboBox();
            this.lblHabil = new System.Windows.Forms.Label();
            this.lstHabil = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_Global
            // 
            this.lbl_Global.AutoSize = true;
            this.lbl_Global.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Global.Location = new System.Drawing.Point(443, 52);
            this.lbl_Global.Name = "lbl_Global";
            this.lbl_Global.Size = new System.Drawing.Size(236, 29);
            this.lbl_Global.TabIndex = 0;
            this.lbl_Global.Text = "Statistiques globales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Statistiques par caserne";
            // 
            // cbCasernes
            // 
            this.cbCasernes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCasernes.FormattingEnabled = true;
            this.cbCasernes.Location = new System.Drawing.Point(38, 99);
            this.cbCasernes.Name = "cbCasernes";
            this.cbCasernes.Size = new System.Drawing.Size(265, 24);
            this.cbCasernes.TabIndex = 2;
            this.cbCasernes.SelectedIndexChanged += new System.EventHandler(this.cbCasernes_SelectedIndexChanged);
            // 
            // lblUtilEngin
            // 
            this.lblUtilEngin.AutoSize = true;
            this.lblUtilEngin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilEngin.Location = new System.Drawing.Point(34, 144);
            this.lblUtilEngin.Name = "lblUtilEngin";
            this.lblUtilEngin.Size = new System.Drawing.Size(217, 20);
            this.lblUtilEngin.TabIndex = 3;
            this.lblUtilEngin.Text = "Engins les plus utilisés :";
            // 
            // lblUtilEnginList
            // 
            this.lblUtilEnginList.AutoSize = true;
            this.lblUtilEnginList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilEnginList.Location = new System.Drawing.Point(34, 179);
            this.lblUtilEnginList.Name = "lblUtilEnginList";
            this.lblUtilEnginList.Size = new System.Drawing.Size(21, 20);
            this.lblUtilEnginList.TabIndex = 4;
            this.lblUtilEnginList.Text = "...";
            // 
            // lblTempsUtil
            // 
            this.lblTempsUtil.AutoSize = true;
            this.lblTempsUtil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempsUtil.Location = new System.Drawing.Point(34, 341);
            this.lblTempsUtil.Name = "lblTempsUtil";
            this.lblTempsUtil.Size = new System.Drawing.Size(180, 20);
            this.lblTempsUtil.TabIndex = 5;
            this.lblTempsUtil.Text = "Temps d\'utilisation :";
            // 
            // lblTempsEnginList
            // 
            this.lblTempsEnginList.AutoSize = true;
            this.lblTempsEnginList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempsEnginList.Location = new System.Drawing.Point(34, 373);
            this.lblTempsEnginList.Name = "lblTempsEnginList";
            this.lblTempsEnginList.Size = new System.Drawing.Size(21, 20);
            this.lblTempsEnginList.TabIndex = 6;
            this.lblTempsEnginList.Text = "...";
            // 
            // lblNbInter
            // 
            this.lblNbInter.AutoSize = true;
            this.lblNbInter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbInter.Location = new System.Drawing.Point(444, 144);
            this.lblNbInter.Name = "lblNbInter";
            this.lblNbInter.Size = new System.Drawing.Size(307, 20);
            this.lblNbInter.TabIndex = 7;
            this.lblNbInter.Text = "Nombre d\'interventions par sinitre :";
            // 
            // lblNbInterList
            // 
            this.lblNbInterList.AutoSize = true;
            this.lblNbInterList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbInterList.Location = new System.Drawing.Point(444, 179);
            this.lblNbInterList.Name = "lblNbInterList";
            this.lblNbInterList.Size = new System.Drawing.Size(21, 20);
            this.lblNbInterList.TabIndex = 8;
            this.lblNbInterList.Text = "...";
            // 
            // lblTopInter
            // 
            this.lblTopInter.AutoSize = true;
            this.lblTopInter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopInter.Location = new System.Drawing.Point(444, 341);
            this.lblTopInter.Name = "lblTopInter";
            this.lblTopInter.Size = new System.Drawing.Size(240, 20);
            this.lblTopInter.TabIndex = 9;
            this.lblTopInter.Text = "Habilitations les + solicités";
            // 
            // lblTopInterList
            // 
            this.lblTopInterList.AutoSize = true;
            this.lblTopInterList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopInterList.Location = new System.Drawing.Point(444, 373);
            this.lblTopInterList.Name = "lblTopInterList";
            this.lblTopInterList.Size = new System.Drawing.Size(21, 20);
            this.lblTopInterList.TabIndex = 10;
            this.lblTopInterList.Text = "...";
            // 
            // cbHabilitation
            // 
            this.cbHabilitation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHabilitation.FormattingEnabled = true;
            this.cbHabilitation.Location = new System.Drawing.Point(830, 99);
            this.cbHabilitation.Name = "cbHabilitation";
            this.cbHabilitation.Size = new System.Drawing.Size(265, 24);
            this.cbHabilitation.TabIndex = 11;
            this.cbHabilitation.SelectedIndexChanged += new System.EventHandler(this.cbHabilitation_SelectedIndexChanged);
            // 
            // lblHabil
            // 
            this.lblHabil.AutoSize = true;
            this.lblHabil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabil.Location = new System.Drawing.Point(826, 61);
            this.lblHabil.Name = "lblHabil";
            this.lblHabil.Size = new System.Drawing.Size(293, 20);
            this.lblHabil.TabIndex = 12;
            this.lblHabil.Text = "Liste de pompier par habilitation :";
            // 
            // lstHabil
            // 
            this.lstHabil.FormattingEnabled = true;
            this.lstHabil.ItemHeight = 16;
            this.lstHabil.Location = new System.Drawing.Point(830, 144);
            this.lstHabil.Name = "lstHabil";
            this.lstHabil.Size = new System.Drawing.Size(289, 388);
            this.lstHabil.TabIndex = 15;
            // 
            // frm_Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 551);
            this.Controls.Add(this.lstHabil);
            this.Controls.Add(this.lblHabil);
            this.Controls.Add(this.cbHabilitation);
            this.Controls.Add(this.lblTopInterList);
            this.Controls.Add(this.lblTopInter);
            this.Controls.Add(this.lblNbInterList);
            this.Controls.Add(this.lblNbInter);
            this.Controls.Add(this.lblTempsEnginList);
            this.Controls.Add(this.lblTempsUtil);
            this.Controls.Add(this.lblUtilEnginList);
            this.Controls.Add(this.lblUtilEngin);
            this.Controls.Add(this.cbCasernes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Global);
            this.Name = "frm_Stats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.frm_Stats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Global;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCasernes;
        private System.Windows.Forms.Label lblUtilEngin;
        private System.Windows.Forms.Label lblUtilEnginList;
        private System.Windows.Forms.Label lblTempsUtil;
        private System.Windows.Forms.Label lblTempsEnginList;
        private System.Windows.Forms.Label lblNbInter;
        private System.Windows.Forms.Label lblNbInterList;
        private System.Windows.Forms.Label lblTopInter;
        private System.Windows.Forms.Label lblTopInterList;
        private System.Windows.Forms.ComboBox cbHabilitation;
        private System.Windows.Forms.Label lblHabil;
        private System.Windows.Forms.ListBox lstHabil;
    }
}
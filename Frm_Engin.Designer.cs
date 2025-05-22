namespace SAE_A21D21_pompiers1
{
    partial class Frm_Engin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.userControl11 = new UC_EtatEngin.UserControl1();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboCaserne);
            this.panel1.Location = new System.Drawing.Point(308, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 129);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choix de la caserne";
            // 
            // cboCaserne
            // 
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(299, 65);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(486, 24);
            this.cboCaserne.TabIndex = 0;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(308, 205);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(800, 450);
            this.userControl11.TabIndex = 2;
            // 
            // Frm_Engin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAE_A21D21_pompiers1.Properties.Resources.Engins_SDIS04;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1521, 776);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Engin";
            this.Text = "Frm_Engin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCaserne;
        private UC_EtatEngin.UserControl1 userControl11;
    }
}
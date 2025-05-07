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
            this.lblExit = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTDB = new System.Windows.Forms.Button();
            this.pnlTableauDeBord.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTableauDeBord
            // 
            this.pnlTableauDeBord.AutoScroll = true;
            this.pnlTableauDeBord.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTableauDeBord.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTableauDeBord.Controls.Add(this.pnlTrait);
            this.pnlTableauDeBord.Controls.Add(this.cbEnCours);
            this.pnlTableauDeBord.Controls.Add(this.lblTDB);
            this.pnlTableauDeBord.Location = new System.Drawing.Point(333, 12);
            this.pnlTableauDeBord.Name = "pnlTableauDeBord";
            this.pnlTableauDeBord.Size = new System.Drawing.Size(1050, 740);
            this.pnlTableauDeBord.TabIndex = 0;
            this.pnlTableauDeBord.Visible = false;
            // 
            // pnlTrait
            // 
            this.pnlTrait.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTrait.Location = new System.Drawing.Point(32, 100);
            this.pnlTrait.Name = "pnlTrait";
            this.pnlTrait.Size = new System.Drawing.Size(974, 13);
            this.pnlTrait.TabIndex = 2;
            this.pnlTrait.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTrait_Paint);
            // 
            // cbEnCours
            // 
            this.cbEnCours.AutoSize = true;
            this.cbEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnCours.Location = new System.Drawing.Point(460, 61);
            this.cbEnCours.Name = "cbEnCours";
            this.cbEnCours.Size = new System.Drawing.Size(129, 33);
            this.cbEnCours.TabIndex = 1;
            this.cbEnCours.Text = "En cours";
            this.cbEnCours.UseVisualStyleBackColor = true;
            // 
            // lblTDB
            // 
            this.lblTDB.AutoSize = true;
            this.lblTDB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDB.Location = new System.Drawing.Point(373, 20);
            this.lblTDB.Name = "lblTDB";
            this.lblTDB.Size = new System.Drawing.Size(310, 43);
            this.lblTDB.TabIndex = 0;
            this.lblTDB.Text = "Tableau de bord";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Blue;
            this.pnlMenu.Controls.Add(this.lblExit);
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.button4);
            this.pnlMenu.Controls.Add(this.button3);
            this.pnlMenu.Controls.Add(this.button2);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.btnTDB);
            this.pnlMenu.Location = new System.Drawing.Point(12, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(305, 738);
            this.pnlMenu.TabIndex = 1;
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
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(30, 616);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 100);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 100);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 100);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 100);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 100);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnTDB
            // 
            this.btnTDB.Location = new System.Drawing.Point(30, 30);
            this.btnTDB.Name = "btnTDB";
            this.btnTDB.Size = new System.Drawing.Size(109, 100);
            this.btnTDB.TabIndex = 0;
            this.btnTDB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAE_A21D21_pompiers1.Properties.Resources.caserne;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1390, 762);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTableauDeBord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Les soldats du feu";
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblExit;
    }
}


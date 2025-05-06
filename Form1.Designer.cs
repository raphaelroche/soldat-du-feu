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
            this.SuspendLayout();
            // 
            // pnlTableauDeBord
            // 
            this.pnlTableauDeBord.AutoScroll = true;
            this.pnlTableauDeBord.Location = new System.Drawing.Point(333, 12);
            this.pnlTableauDeBord.Name = "pnlTableauDeBord";
            this.pnlTableauDeBord.Size = new System.Drawing.Size(1045, 738);
            this.pnlTableauDeBord.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 762);
            this.Controls.Add(this.pnlTableauDeBord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTableauDeBord;
    }
}


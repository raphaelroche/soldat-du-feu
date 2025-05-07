using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UC_mission;

namespace SAE_A21D21_pompiers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // bloque le redisionnement

            this.ControlBox = true;       // affiche les 3 boutons de la fenêtre windows
            this.MinimizeBox = true;      // active le bouton minimiser
            this.MaximizeBox = false;      // désactive le bouton plein ecran

            pnlMenu.BackColor = Color.FromArgb(200, 0, 0, 255); //change l'opacité du menu

            Image imgHome = Image.FromFile("divers/home.jpg");
            btnTDB.BackgroundImage = new Bitmap(imgHome, new Size(btnTDB.Width, btnTDB.Height)); // redimensionne l'image à la taille du bouton btnTDB
            btnTDB.BackgroundImageLayout = ImageLayout.Stretch;

            Image imgExit = Image.FromFile("divers/exit.jpg");
            btnExit.BackgroundImage = new Bitmap(imgExit, new Size(btnExit.Width, btnExit.Height)); // redimensionne l'image à la taille du bouton btnExit
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLiteConnection cx = Connexion.Connec; //connexion a la base de données
            int y = 110; // position de départ en Y
            int spacing = 10; // espace entre les contrôles

            for (int i = 0; i < 5; i++)
            {
                Mission mission = new Mission(i, "accident", DateTime.Now, $"caserne {i}", "feu déclaré");
                mission.Location = new System.Drawing.Point(50, y);
                pnlTableauDeBord.Controls.Add(mission);

                y += mission.Height + spacing; // décale vers le bas pour la prochaine mission
            }
            pnlTableauDeBord.Show();
        }
        // Méthode pour dessiner un trait dégradé sur n'importe quel panel
        public void DrawGradientLine(Panel panel, Color startColor, Color endColor)
        {
            // Créer un pinceau avec un dégradé linéaire
            using (LinearGradientBrush brush = new LinearGradientBrush(
                    new Point(0, 0),                // Point de départ du dégradé (gauche)
                    new Point(panel.Width, 0),      // Point de fin du dégradé (droite)
                    startColor,                     // Couleur de départ
                    endColor))                      // Couleur de fin
            {
                // Créer un Pen avec le pinceau dégradé
                using (Pen pen = new Pen(brush, 5)) // 5 = épaisseur du trait
                {
                    // Dessiner la ligne horizontale au milieu du panel
                    panel.CreateGraphics().DrawLine(pen, 0, panel.Height / 2, panel.Width, panel.Height / 2);
                }
            }
        }
        private void pnlTrait_Paint(object sender, PaintEventArgs e) //trait dégradé menu tableau de bord
        {
            // Appeler la méthode pour dessiner le dégradé
            DrawGradientLine(pnlTrait, Color.Blue, Color.Red);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

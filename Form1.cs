using SAE_A21D21_pompiers1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        private SQLiteConnection cx;
        
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // bloque le redisionnement

            this.ControlBox = true;       // affiche les 3 boutons de la fenêtre windows
            this.MinimizeBox = true;      // active le bouton minimiser
            this.MaximizeBox = false;      // désactive le bouton plein ecran
            pnlMenu.BackColor = Color.FromArgb(200, 0, 0, 255); //change l'opacité du menu            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cx = Connexion.Connec; //connexion a la base de données

            DataTable dt = cx.GetSchema("Tables");

            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    string sql = "SELECT * FROM " + dr[2].ToString();
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql, cx);
                    da.Fill(MesDatas.DsGlobal, dr[2].ToString());
                }
                catch (SQLiteException err)
                {
                    MessageBox.Show(err.Message);
                }
            }

            Image imgHome = Image.FromFile("divers/home.jpg");
            btnTDB.BackgroundImage = new Bitmap(imgHome, new Size(btnTDB.Width, btnTDB.Height)); // redimensionne l'image à la taille du bouton btnTDB
            btnTDB.BackgroundImageLayout = ImageLayout.Stretch;

            Image imgExit = Image.FromFile("divers/exit.jpg");
            btnExit.BackgroundImage = new Bitmap(imgExit, new Size(btnExit.Width, btnExit.Height)); // redimensionne l'image à la taille du bouton btnExit
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;

            Image imgMission = Image.FromFile("divers/mission.jpg");
            btnAjouter.BackgroundImage = new Bitmap(imgMission, new Size(btnAjouter.Width, btnAjouter.Height)); // redimensionne l'image à la taille du bouton btnExit
            btnAjouter.BackgroundImageLayout = ImageLayout.Stretch;

            afficherMission();
      
        }

        private void afficherMission()
        {
            //remplir le panel avec les missions présentes dans la table
            int y = 110; // position de départ en Y
            int spacing = y + 30; // espace entre les contrôles

            foreach (DataRow drMission in MesDatas.DsGlobal.Tables["Mission"].Rows)
            {
                int id = Convert.ToInt32(drMission["id"]);

                string type = "";
                foreach (DataRow drNatureSinistre in MesDatas.DsGlobal.Tables["NatureSinistre"].Rows)
                {

                    if (Convert.ToInt32(drNatureSinistre["id"]) == Convert.ToInt32(drMission["idNatureSinistre"]))
                        type = drNatureSinistre["libelle"].ToString();
                    
                }

                string dateDepart = drMission["dateHeureDepart"].ToString();
                string dateRetour = drMission["dateHeureRetour"].ToString();


                string caserne = "";
                foreach (DataRow drCaserne in MesDatas.DsGlobal.Tables["Caserne"].Rows)
                {
                    if (Convert.ToInt32(drCaserne["id"]) == Convert.ToInt32(drMission["idCaserne"]))
                    {
                        caserne = drCaserne["nom"].ToString();
                    }
                }

                string adresse = drMission["adresse"].ToString() + " " + drMission["cp"].ToString() + " " + drMission["ville"].ToString();

                string desc = drMission["motifAppel"].ToString();
                string cr = drMission["compteRendu"].ToString();


                Mission mission = new Mission(id, type, dateDepart, dateRetour, caserne, desc, adresse, cr);
                mission.Location = new System.Drawing.Point(50, y);
                y += spacing;
                pnlTableauDeBord.Controls.Add(mission);
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int maxId = 0;
            foreach (DataRow row in MesDatas.DsGlobal.Tables["Mission"].Rows)
            {
                int currentId = Convert.ToInt32(row["id"]);
                if (currentId > maxId)
                    maxId = currentId;
            }
            int id = maxId + 1;
            AjouterMission ajt = new AjouterMission(id, DateTime.Now.ToString());
            if (ajt.ShowDialog() == DialogResult.OK)
            {
                afficherMission();  
            }
        }
    }
}

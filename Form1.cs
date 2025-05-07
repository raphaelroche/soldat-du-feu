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

            // Définition des clés primaires
            DataColumn pkNatureSinistre = MesDatas.DsGlobal.Tables["NatureSinistre"].Columns["id"];
            MesDatas.DsGlobal.Tables["NatureSinistre"].PrimaryKey = new DataColumn[] { pkNatureSinistre };

            DataColumn pkTypeEngin = MesDatas.DsGlobal.Tables["TypeEngin"].Columns["code"];
            MesDatas.DsGlobal.Tables["TypeEngin"].PrimaryKey = new DataColumn[] { pkTypeEngin };

            DataColumn pk1 = MesDatas.DsGlobal.Tables["Necessiter"].Columns["idNatureSinistre"];
            DataColumn pk2 = MesDatas.DsGlobal.Tables["Necessiter"].Columns["codeTypeEngin"];
            MesDatas.DsGlobal.Tables["Necessiter"].PrimaryKey = new DataColumn[] { pk1, pk2 };

            // Définition des contraintes de clé étrangère

            // Clé étrangère de Necessiter vers NatureSinistre
            ForeignKeyConstraint fkNature = new ForeignKeyConstraint(
                "FK_Necessiter_NatureSinistre",
                MesDatas.DsGlobal.Tables["NatureSinistre"].Columns["id"],               // Parent
                MesDatas.DsGlobal.Tables["Necessiter"].Columns["idNatureSinistre"]      // Enfant
            );
            MesDatas.DsGlobal.Tables["Necessiter"].Constraints.Add(fkNature);

            // Clé étrangère de Necessiter vers TypeEngin
            ForeignKeyConstraint fkEngin = new ForeignKeyConstraint(
                "FK_Necessiter_TypeEngin",
                MesDatas.DsGlobal.Tables["TypeEngin"].Columns["code"],                  // Parent
                MesDatas.DsGlobal.Tables["Necessiter"].Columns["codeTypeEngin"]         // Enfant
            );
            MesDatas.DsGlobal.Tables["Necessiter"].Constraints.Add(fkEngin);

            //remplir le panel avec les missions présentes dans la table
            int y = 110; // position de départ en Y
            int spacing = y + 30; // espace entre les contrôles

            foreach (DataRow drMission in MesDatas.DsGlobal.Tables["Mission"].Rows)     
            {
                int id = Convert.ToInt32(drMission["id"]);

                String type = "";
                foreach (DataRow drNatureSinistre in MesDatas.DsGlobal.Tables["NatureSinistre"].Rows)
                {
                    if (Convert.ToInt32(drNatureSinistre["id"])==id)
                    {
                        type = drNatureSinistre["libelle"].ToString();
                    }
                }

                String date = drMission["dateHeureDepart"].ToString();

                String caserne = "";
                foreach (DataRow drCaserne in MesDatas.DsGlobal.Tables["Caserne"].Rows)
                {
                    if (Convert.ToInt32(drCaserne["id"]) == Convert.ToInt32(drMission["idCaserne"]));
                    {
                        caserne = drCaserne["nom"].ToString();
                    }
                }

                String desc = drMission["motifAppel"].ToString();
                Mission mission = new Mission(id, type, date, caserne, desc);
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
    }
}

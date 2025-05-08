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

            Image imgHome = Image.FromFile("divers/home.jpg");
            btnTDB.BackgroundImage = new Bitmap(imgHome, new Size(btnTDB.Width, btnTDB.Height)); // redimensionne l'image à la taille du bouton btnTDB
            btnTDB.BackgroundImageLayout = ImageLayout.Stretch;

            Image imgExit = Image.FromFile("divers/exit.jpg");
            btnExit.BackgroundImage = new Bitmap(imgExit, new Size(btnExit.Width, btnExit.Height)); // redimensionne l'image à la taille du bouton btnExit
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
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

                String type = "";
                foreach (DataRow drNatureSinistre in MesDatas.DsGlobal.Tables["NatureSinistre"].Rows)
                {
                    if (Convert.ToInt32(drNatureSinistre["id"]) == id)
                    {
                        type = drNatureSinistre["libelle"].ToString();
                    }
                }

                String date = drMission["dateHeureDepart"].ToString();

                String caserne = "";
                foreach (DataRow drCaserne in MesDatas.DsGlobal.Tables["Caserne"].Rows)
                {
                    if (Convert.ToInt32(drCaserne["id"]) == Convert.ToInt32(drMission["idCaserne"])) ;
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
        private void chargerMission()
        {
            try
            {
                MesDatas.DsGlobal.Tables["Mission"].Clear();
                string sql = "select * from Mission";
                SQLiteDataAdapter daMission = new SQLiteDataAdapter(sql, cx);
                daMission.Fill(MesDatas.DsGlobal, "Mission");
                
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
           
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
            int id = 5;
            AjouterMission ajt = new AjouterMission(id, DateTime.Now.ToString("dd/MM/yyyy"));
            if (ajt.ShowDialog() == DialogResult.OK)
            {
                SQLiteTransaction majBase = cx.BeginTransaction();

                try
                {
                    chargerMission();
                    // === 1. Mission ===
                    SQLiteDataAdapter daMission = new SQLiteDataAdapter("SELECT * FROM Mission", cx);
                    daMission.SelectCommand.Transaction = majBase;
                    SQLiteCommandBuilder cbMission = new SQLiteCommandBuilder(daMission);
                    daMission.UpdateCommand = cbMission.GetUpdateCommand();
                    daMission.InsertCommand = cbMission.GetInsertCommand();
                    daMission.DeleteCommand = cbMission.GetDeleteCommand();

                    daMission.Update(MesDatas.DsGlobal.Tables["Mission"]);

                    // === 2. Pompier ===
                    SQLiteDataAdapter daPompier = new SQLiteDataAdapter("SELECT * FROM Pompier", cx);
                    daPompier.SelectCommand.Transaction = majBase;
                    SQLiteCommandBuilder cbPompier = new SQLiteCommandBuilder(daPompier);
                    daPompier.UpdateCommand = cbPompier.GetUpdateCommand();
                    daPompier.InsertCommand = cbPompier.GetInsertCommand();
                    daPompier.DeleteCommand = cbPompier.GetDeleteCommand();

                    daPompier.Update(MesDatas.DsGlobal.Tables["Pompier"]);

                    // === 3. Mobiliser ===
                    SQLiteDataAdapter daMobiliser = new SQLiteDataAdapter("SELECT * FROM Mobiliser", cx);
                    daMobiliser.SelectCommand.Transaction = majBase;
                    SQLiteCommandBuilder cbMobiliser = new SQLiteCommandBuilder(daMobiliser);
                    daMobiliser.UpdateCommand = cbMobiliser.GetUpdateCommand();
                    daMobiliser.InsertCommand = cbMobiliser.GetInsertCommand();
                    daMobiliser.DeleteCommand = cbMobiliser.GetDeleteCommand();

                    daMobiliser.Update(MesDatas.DsGlobal.Tables["Mobiliser"]);

                    // === 4. PartirAvec ===
                    SQLiteDataAdapter daPartirAvec = new SQLiteDataAdapter("SELECT * FROM PartirAvec", cx);
                    daPartirAvec.SelectCommand.Transaction = majBase;
                    SQLiteCommandBuilder cbPartirAvec = new SQLiteCommandBuilder(daPartirAvec);
                    daPartirAvec.UpdateCommand = cbPartirAvec.GetUpdateCommand();
                    daPartirAvec.InsertCommand = cbPartirAvec.GetInsertCommand();
                    daPartirAvec.DeleteCommand = cbPartirAvec.GetDeleteCommand();

                    daPartirAvec.Update(MesDatas.DsGlobal.Tables["PartirAvec"]);

                    SQLiteDataAdapter daCaserne = new SQLiteDataAdapter("select * from Caserne", cx);
                    daCaserne.SelectCommand.Transaction = majBase;
                    SQLiteCommandBuilder cbCaserne = new SQLiteCommandBuilder(daCaserne);
                    daCaserne.UpdateCommand = cbCaserne.GetUpdateCommand();
                    daCaserne.InsertCommand = cbCaserne.GetInsertCommand();
                    daCaserne.DeleteCommand = cbCaserne.GetDeleteCommand();

                    daCaserne.Update(MesDatas.DsGlobal.Tables["Caserne"]);

                    SQLiteDataAdapter daNatureSinistre = new SQLiteDataAdapter("select * from NatureSinistre", cx);
                    daNatureSinistre.SelectCommand.Transaction = majBase;
                    SQLiteCommandBuilder cbNatureSinistre = new SQLiteCommandBuilder(daNatureSinistre);
                    daNatureSinistre.UpdateCommand = cbNatureSinistre.GetUpdateCommand();
                    daNatureSinistre.InsertCommand = cbNatureSinistre.GetInsertCommand();
                    daNatureSinistre.DeleteCommand = cbNatureSinistre.GetDeleteCommand();

                    daNatureSinistre.Update(MesDatas.DsGlobal.Tables["NatureSinistre"]);



                    // ✅ Tout s'est bien passé : on valide
                    majBase.Commit();
                    MessageBox.Show("Toutes les données ont été mises à jour avec succès !");
                    //enfin on met a jour les mission dans le dataset en ajoutant la nouvelle et en mettant a jour le panel
                   
                    afficherMission();
                }
                catch (Exception ex)
                {
                    // ❌ Une erreur : on annule tout
                    majBase.Rollback();
                    MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message);
                }

                
                
            }
        }
    }
}

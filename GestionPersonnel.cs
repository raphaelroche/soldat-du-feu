using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAE_A21D21_pompiers;
using UC_GestionPersonnel;

namespace SAE_A21D21_pompiers1
{
    public partial class GestionPersonnel : Form
    {
        private SQLiteConnection cx;

        public GestionPersonnel()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // bloque le redisionnement
        }

        private void GestionPersonnel_Load(object sender, EventArgs e)
        {
            cx = Connexion.Connec; // connexion à la base de données
            pnlMenu.BackColor = Color.FromArgb(200, 139, 0, 0); // couleur du menu avec opacité

            try
            {
                // Charger les casernes
                string sqlCaserne = "SELECT * FROM Caserne";
                SQLiteCommand comCaserne = new SQLiteCommand(sqlCaserne, cx);
                SQLiteDataReader drCaserne = comCaserne.ExecuteReader();

                while (drCaserne.Read())
                {
                    cbCasernes.Items.Add(drCaserne["nom"].ToString());
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur lors du chargement des données :\n" + err.Message);
            }

        }

        private void cbCasernes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear le cb
            cbPompiers.Items.Clear();

            // Charger les pompiers
            string sqlPompiers = "SELECT * FROM Pompier p JOIN Affectation a ON p.matricule = a.matriculePompier " +
                "WHERE a.idCaserne = " + (cbCasernes.SelectedIndex + 1);
            SQLiteCommand comPompiers = new SQLiteCommand(sqlPompiers, cx);
            SQLiteDataReader drPompiers = comPompiers.ExecuteReader();

            while (drPompiers.Read())
            {
                cbPompiers.Items.Add(drPompiers["prenom"].ToString() + " " + drPompiers["nom"].ToString());
            }
            drPompiers.Close();
        }

        private void cbPompiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Charger les pompiers
            string sqlPompiers = "SELECT * FROM Pompier";
            SQLiteCommand comPompiers = new SQLiteCommand(sqlPompiers, cx);
            SQLiteDataReader drPompiers = comPompiers.ExecuteReader();


            if (cbPompiers.SelectedIndex != -1)
            {

                


                string sqlPompier = "SELECT * FROM Pompier WHERE prenom ='" + cbPompiers.SelectedItem.ToString().Split(' ')[0] + "'" +
                    "AND nom = '" + cbPompiers.SelectedItem.ToString().Split(' ')[1] + "';";
                    SQLiteCommand comPompier = new SQLiteCommand(sqlPompier, cx);
                    SQLiteDataReader drPompier = comPompier.ExecuteReader();

                



                AfficherPompier afficherPompier = null; // Initialisation de la variable
                    while (drPompier.Read())
                    {

                        string sqlGrade = "SELECT g.chaine FROM Grade g JOIN Pompier p ON g.code = p.codeGrade WHERE matricule = " + drPompier["matricule"];

                        SQLiteCommand comGrade = new SQLiteCommand(sqlGrade, cx);
                        int chaineGrade = Convert.ToInt32(comGrade.ExecuteScalar());

                        afficherPompier = new AfficherPompier(Convert.ToInt32(drPompier["matricule"]), cbCasernes.SelectedItem.ToString(), drPompier["nom"].ToString(), drPompier["prenom"].ToString(), drPompier["sexe"].ToString(), drPompier["dateNaissance"].ToString(), drPompier["type"].ToString(), drPompier["dateEmbauche"].ToString(), 13-chaineGrade, drPompier["portable"].ToString(), drPompier["bip"].ToString(), Convert.ToInt32(drPompier["enConge"]) ,cx);
                    }
                    if (afficherPompier != null) // Vérification que la variable a été assignée
                    {

                        afficherPompier.Location = new Point(10, 50); // Positionner le contrôle  
                        afficherPompier.Visible = true; // S'assurer qu'il est visible  
                        this.pnlAffichage.Controls.Add(afficherPompier);
                        afficherPompier.BringToFront();
                    }
                drPompiers.Close();
            }
        }
    }
}

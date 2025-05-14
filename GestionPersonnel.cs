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

            // Charger les pompiers
            string sqlPompiers = "SELECT * FROM Pompier WHERE ";
            SQLiteCommand comPompiers = new SQLiteCommand(sqlPompiers, cx);
            SQLiteDataReader drPompiers = comPompiers.ExecuteReader();

            while (drPompiers.Read())
            {
                cbPompiers.Items.Add(drPompiers["prenom"].ToString() + " " + drPompiers["nom"].ToString());
            }
            drPompiers.Close();
        }
    }
}

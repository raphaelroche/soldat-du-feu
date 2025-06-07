using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_A21D21_pompiers1
{
    public partial class frm_Stats : Form
    {
        private SQLiteConnection cx;
        public frm_Stats(SQLiteConnection cx)
        {
            InitializeComponent();
            this.cx = cx;
        }

        private void frm_Stats_Load(object sender, EventArgs e)
        {
            //chargement cb casernes
            try
            {
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

            //chargement cb pompiers
            try
            {
                string sqlHabil = "SELECT libelle FROM Habilitation";
                SQLiteCommand comHabil = new SQLiteCommand(sqlHabil, cx);
                SQLiteDataReader drHabil = comHabil.ExecuteReader();

                while (drHabil.Read())
                {
                    cbHabilitation.Items.Add(drHabil["libelle"].ToString());
                }

                drHabil.Close();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur lors du chargement des données :\n" + err.Message);
            }

            // Nombre d’interventions par type de sinistre (toutes casernes)  
            try
            {
                string sqlNbInterventionsParTypeSinistre =
                "SELECT " +
                "    ns.libelle AS type_sinistre, " +
                "    COUNT(*) AS nb_interventions " +
                "FROM Mission m " +
                "JOIN NatureSinistre ns ON m.idNatureSinistre = ns.id " +
                "GROUP BY m.idNatureSinistre " +
                "ORDER BY nb_interventions DESC;";
                SQLiteCommand comNbInterventionsParTypeSinistre = new SQLiteCommand(sqlNbInterventionsParTypeSinistre, cx);
                SQLiteDataReader drNbInterventionsParTypeSinistre = comNbInterventionsParTypeSinistre.ExecuteReader();

                lblNbInterList.Text = "";

                while (drNbInterventionsParTypeSinistre.Read())
                {
                    lblNbInterList.Text += drNbInterventionsParTypeSinistre["type_sinistre"].ToString() + " : " + drNbInterventionsParTypeSinistre["nb_interventions"].ToString() + "\n";
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur lors du chargement des données :\n" + err.Message);
            }

            // 3 habilitations les plus sollicitées
            try
            {
                string sqlTopInter =
                    "SELECT " +
                    "    h.libelle, " +
                    "    COUNT(*) AS nb_utilisations " +
                    "FROM Mobiliser mo " +
                    "JOIN Habilitation h ON mo.idHabilitation = h.id " +
                    "GROUP BY mo.idHabilitation " +
                    "ORDER BY nb_utilisations DESC " +
                    "LIMIT 3;";

                SQLiteCommand comTopInter = new SQLiteCommand(sqlTopInter, cx);
                SQLiteDataReader drTopInter = comTopInter.ExecuteReader();

                lblTopInterList.Text = "";

                while (drTopInter.Read())
                {
                    lblTopInterList.Text +=  drTopInter[0] + " : " + drTopInter[1] + " utilisations\n";
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur lors du chargement des données :\n" + err.Message);
            }


        }

        private void cbCasernes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //engins les plus utilisés
            try
            {
                string sqlUtilEngin = "SELECT e.codeTypeEngin, e.numero, COUNT(*) AS nb_utilisations " +
                "FROM PartirAvec pa JOIN Engin e ON pa.idCaserne = e.idCaserne " +
                "AND pa.codeTypeEngin = e.codeTypeEngin " +
                "AND pa.numeroEngin = e.numero WHERE pa.idCaserne = " + (cbCasernes.SelectedIndex + 1) + " " +
                "GROUP BY e.codeTypeEngin, e.numero ORDER BY nb_utilisations DESC;";

                SQLiteCommand comUtilEngin = new SQLiteCommand(sqlUtilEngin, cx);

                SQLiteDataReader drUtilEngin = comUtilEngin.ExecuteReader();

                lblUtilEnginList.Text = ""; 

                while (drUtilEngin.Read())
                {
                    lblUtilEnginList.Text += drUtilEngin["codeTypeEngin"].ToString() + " n°" + drUtilEngin["numero"].ToString() + " utilisé " + drUtilEngin[2] + " fois.\n";
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur lors du chargement des données :\n" + err.Message);
            }


            //nombre d'heures des engins
            try
            {
                string sqlTempsEngin = "SELECT e.codeTypeEngin, e.numero, ROUND(SUM((JULIANDAY(m.dateHeureRetour) - JULIANDAY(m.dateHeureDepart)) * 24), 1)\r\n AS heures_utilisation " +
                    "FROM PartirAvec pa " +
                    "JOIN Engin e ON pa.idCaserne = e.idCaserne AND pa.codeTypeEngin = e.codeTypeEngin AND pa.numeroEngin = e.numero " +
                    "JOIN Mission m ON pa.idMission = m.id " +
                    "WHERE pa.idCaserne = " + (cbCasernes.SelectedIndex + 1) + " " + 
                    "GROUP BY e.codeTypeEngin, e.numero " +
                    "ORDER BY heures_utilisation DESC ";
                SQLiteCommand comTempsEngin = new SQLiteCommand(sqlTempsEngin, cx);

                SQLiteDataReader drTempsEngin = comTempsEngin.ExecuteReader();

                lblTempsEnginList.Text = "";

                while (drTempsEngin.Read())
                {
                    lblTempsEnginList.Text += drTempsEngin["codeTypeEngin"].ToString() + " n°" + drTempsEngin["numero"].ToString() + " utilisé " + drTempsEngin["heures_utilisation"].ToString() + " heures.\n";
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur lors du chargement des données :\n" + err.Message);
            }
        }

        private void cbHabilitation_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Liste des pompiers par habilitation (y compris habilitations sans pompier)
            try
            {
                int idHabil = cbHabilitation.SelectedIndex + 1;
                string sqlPompHabil =
                    "SELECT p.nom, p.prenom " +
                    "FROM Passer pa " +
                    "JOIN Pompier p ON pa.matriculePompier = p.matricule " +
                    "WHERE pa.idHabilitation = " + idHabil + " " +
                    "ORDER BY p.nom, p.prenom;";


                SQLiteCommand comPompHabil = new SQLiteCommand(sqlPompHabil, cx);

                SQLiteDataReader drPompHabil = comPompHabil.ExecuteReader();

                lstHabil.Items.Clear();

                while (drPompHabil.Read())
                {
                    lstHabil.Items.Add(drPompHabil[0] + " " + drPompHabil[1]);
                }

                drPompHabil.Close();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur lors du chargement des données :\n" + err.Message);
            }
        }
    }
}

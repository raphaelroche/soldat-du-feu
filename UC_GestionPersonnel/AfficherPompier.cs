using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Data.SqlClient;
using SAE_A21D21_pompiers1;

namespace UC_GestionPersonnel
{
    public partial class AfficherPompier : UserControl
    {
        private SQLiteConnection cx;
        private string nom = "";
        private int matricule;
        private string prenom = "";
        private string caserne = "";
        private string sexe = "";
        private string dateNaissance = "";
        private string status = "V";
        private string dateEmbauche = "";
        private int grade;
        private string telephone = "";
        private string bip = "";
        private int enconge;

        private bool changerCaserne;
        private int encongebase;



        public AfficherPompier()
        {
            InitializeComponent();

        }

        public AfficherPompier(int matricule, string caserne, string nom, string prenom, string sexe, string datenaissance, string status, string dateembauche, int grade, string telephone, string bip, int enconge, SQLiteConnection cx)
        {
            InitializeComponent();
            this.cx = cx;
            this.matricule = matricule;
            this.prenom = prenom;
            this.nom = nom;
            this.caserne = caserne;
            this.sexe = sexe;
            this.dateNaissance = datenaissance;
            this.status = status;
            this.dateEmbauche = dateembauche;
            this.grade = grade;
            this.telephone = telephone;
            this.bip = bip;
            this.enconge = enconge;
            this.encongebase = enconge;

            this.changerCaserne = false;


        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            pnlInformations.Visible = false;
            lblMatricule.Text = "Matricule : " + matricule.ToString();
            lblNom.Text = "Nom : " + nom;
            lblPrenom.Text = "Prenom : " + prenom;
            lblSexe.Text = "Sexe : " + sexe;
            lblNaissance.Text = "Date de naissance : " + dateNaissance;
            if (this.status != "v")
            {
                rdbProfessionnel.Checked = true;
                rdbVolontaire.Checked = false;
            }
            else
            {
                rdbVolontaire.Checked = true;
                rdbProfessionnel.Checked = false;
            }
            lblEmbauche.Text = "Date d'embauche : " + dateEmbauche;
            cboGrade.SelectedItem = grade;
            lblTelephone.Text = "Tel : " + telephone;
            lblBip.Text = "Bip : " + bip;
            if (enconge == 0)
            {
                chkConge.Checked = false;
            }
            else
            {
                chkConge.Checked = true;
            }


            string sql = "select libelle from Grade";
            string sql3 = "select code from Grade where chaine = '" + this.grade.ToString() + "'";
            try
            {
                SQLiteCommand a = new SQLiteCommand(sql3, this.cx);
                try
                {
                    object result = a.ExecuteScalar();
                    if (result != null)
                    {
                        string code = result.ToString();
                        lblAbrev.Text = code;
                    }
                    else
                    {
                        lblAbrev.Text = "Code non trouvé";
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Erreur lors de l'exécution de la commande SQL : " + ex.Message);
                }

                SQLiteCommand com = new SQLiteCommand(sql, this.cx);
                SQLiteDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cboGrade.Items.Add(dr.GetString(0));
                }

                cboGrade.SelectedIndex = this.grade;




            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }

            pbGrade.ImageLocation = @"ImagesGrades/" + lblAbrev.Text + ".png";

        }

        private void chargerlstHabilitation()
        {
            string sql3 = "select h.libelle from Pompier p  join Passer pa on p.matricule = pa.matriculePompier join Habilitation h on pa.idHabilitation = h.id where upper(p.nom) = '" + this.nom.ToUpper() + "'";
            SQLiteCommand co = new SQLiteCommand(sql3, this.cx);
            SQLiteDataReader d = co.ExecuteReader();
            while (d.Read())
            {
                lstHabilitations.Items.Add(d.GetString(0));
            }
        }

        private void chargerAffectation()
        {

            string sql4 = "select c.nom from Caserne c join Affectation a  on c.id = a.idCaserne where a.matriculePompier = " + this.matricule;
            SQLiteCommand comm = new SQLiteCommand(sql4, this.cx);
            SQLiteDataReader da = comm.ExecuteReader();
            lstAffectations.Items.Clear();
            while (da.Read())
            {
                lstAffectations.Items.Add(da.GetString(0));
            }

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            pnlInformations.Visible = true;
            btnInfo.Visible = false;

            string sql = "select nom from Caserne";
            string sql2 = "select id from Caserne where nom = '" + this.caserne + "'";

            try
            {
                SQLiteCommand com = new SQLiteCommand(sql, this.cx);
                SQLiteDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cboCaserne.Items.Add(dr.GetString(0));
                }

                SQLiteCommand c = new SQLiteCommand(sql2, this.cx);
                int caserne = Convert.ToInt32(c.ExecuteScalar());
                cboCaserne.SelectedIndex = caserne - 1;


                chargerlstHabilitation();
                chargerAffectation();


            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnlFichePompier_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

            string sql = "select code from Grade where libelle = '" + cboGrade.SelectedItem + "'";
            try
            {

                SQLiteCommand a = new SQLiteCommand(sql, this.cx);
                string code = a.ExecuteScalar().ToString();
                lblAbrev.Text = code;


            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            pbGrade.ImageLocation = @"ImagesGrades/" + lblAbrev.Text + ".png";
        }




        private void btnChanger_Click_1(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin(this.cx);
            if (log.ShowDialog() == DialogResult.OK)
            {
                SQLiteTransaction changerGrade = cx.BeginTransaction();
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cx;
                com.CommandType = CommandType.Text;
                com.Transaction = changerGrade;

                try
                {
                    com.CommandText = "update Pompier set codeGrade = '" + lblAbrev.Text + "' where matricule = " + matricule;
                    com.ExecuteNonQuery();
                    changerGrade.Commit();
                    MessageBox.Show("modifications efectuées !");
                }
                catch (SQLiteException ex)
                {
                    changerGrade.Rollback();
                    MessageBox.Show("erreur, modification non-effectuées !");
                }
            }
            else
            {
                MessageBox.Show("vous n'avez pas le droit de modifié ce champs !");
            }

        }

        private void btnMaj_Click_1(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin(this.cx);
            if (log.ShowDialog() == DialogResult.OK)
            {
                SQLiteTransaction changerInfoPopmier = cx.BeginTransaction();
                SQLiteCommand com = new SQLiteCommand();
                com.Connection = cx;
                com.CommandType = CommandType.Text;
                com.Transaction = changerInfoPopmier;
                try
                {
                    com.CommandText = "update Affectation set dateFin = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' where matriculePompier = " + this.matricule + " and dateFin is null";
                    com.ExecuteNonQuery();

                    com.CommandText = "insert into Affectation (matriculePompier, dateA, dateFin, idCaserne) values (" + this.matricule + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "', NULL, " + (cboCaserne.SelectedIndex + 1) + ")";
                    com.ExecuteNonQuery();




                    if (enconge != encongebase)
                    {
                        com.CommandText = "update Pompier set enConge = " + enconge + " where matricule = " + this.matricule;
                        com.ExecuteNonQuery();
                    }

                    changerInfoPopmier.Commit();
                    MessageBox.Show("Modifications effectuées !");
                    chargerAffectation();

                }
                catch (SQLiteException ex)
                {
                    changerInfoPopmier.Rollback();
                    MessageBox.Show("Erreur, modification non-effectuée !");

                }
            }
            else
            {
                MessageBox.Show("Vous n'avez pas le droit de modifier ce champ !");
            }

        }

        private void chkConge_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkConge.Checked)
            {
                enconge = 1;
            }
            else
            {
                enconge = 0;
            }
        }

        private void cboCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.changerCaserne = true;
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SAE_A21D21_pompiers1
{
    public partial class FrmCreerPompier : Form
    {
        private SQLiteConnection cx;
        public FrmCreerPompier(SQLiteConnection cx)
        {
            InitializeComponent();
            this.cx = cx;
        }

        private void FrmCreerPompier_Load(object sender, EventArgs e)
        {
            string sql = "select nom from Caserne";
            string sql2 = "select libelle from Grade";
             try
             {
                SQLiteCommand com = new SQLiteCommand(sql, this.cx);
                SQLiteDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cboCaserne.Items.Add(dr.GetString(0));
                }

                SQLiteCommand c = new SQLiteCommand(sql2, this.cx);
                SQLiteDataReader dr2 = c.ExecuteReader();
                while (dr2.Read())
                {
                    cboGrade.Items.Add(dr2.GetString(0));
                }
            }
            catch (SQLiteException ex) 
            {
                MessageBox.Show(ex.Message);
            }

            cboSexe.Items.Add("Homme");
            cboSexe.Items.Add("Femme");

            cboStatus.Items.Add("Professionnel");
            cboStatus.Items.Add("Volontaire");
        }

     
        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)) {
                e.Handled = false;
            }
        }

        private void txtMatricule_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
          
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (cboCaserne.SelectedIndex != -1 && cboGrade.SelectedIndex != -1 && cboSexe.SelectedIndex != -1 && cboStatus.SelectedIndex != -1 && txtMatricule.Text != String.Empty && txtNom.Text != String.Empty && txtPrenom.Text != String.Empty && txtTel.Text != String.Empty) 
            {
                frmLogin log = new frmLogin(cx);
                if(log.ShowDialog() == DialogResult.OK)
                {
                    SQLiteTransaction ajtPompier = cx.BeginTransaction();
                    SQLiteCommand com = new SQLiteCommand();
                    com.Connection = cx;
                    com.CommandType = CommandType.Text;
                    com.Transaction = ajtPompier;

                    string prenom = txtPrenom.Text;
                    string nom = txtNom.Text;
                    int matricule = Convert.ToInt32(txtMatricule.Text);
                    string sexe;
                    string status;
                    string dateNaissance = dtpNaissance.Text;
                    string portable = txtTel.Text;
                   
                    string codeGrade = "";
                    string sql = "select code from grade where libelle = '" + cboGrade.SelectedItem + "'";
                    string datEmbauche = DateTime.Now.ToString("yyyy-MM-dd");
                    int idCaserne = cboCaserne.SelectedIndex + 1;

                    try
                    {
                        SQLiteCommand c = new SQLiteCommand(sql, this.cx);
                        string code = c.ExecuteScalar().ToString();
                        codeGrade = code;

                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    sexe = cboSexe.SelectedIndex == 0 ? "m" : "f";
                    status = cboStatus.SelectedIndex == 0 ? "p" : "v";


                    try
                    {
                        com.CommandText = "insert into Pompier (matricule, nom, prenom, sexe, dateNaissance, type, portable, bip, enMission, enConge, codeGrade, dateEmbauche)" +
                           $"values ({matricule},'{nom}','{prenom}','{sexe}','{dateNaissance}','{status}','{portable}',{matricule},0,0,'{codeGrade}','{datEmbauche}')";
                        com.ExecuteNonQuery();

                        com.CommandText = "insert into Affectation (matriculePompier, dateA, dateFin, idCaserne) values" +
                            $"({matricule}, '{datEmbauche}', NULL,{idCaserne})";
                        com.ExecuteNonQuery();

                        ajtPompier.Commit();
                        this.DialogResult = DialogResult.OK;



                    }
                    catch (SQLiteException ex)
                    {
                        ajtPompier.Rollback();
                        MessageBox.Show("Ce matricule est deja attribué ! Veulliez en rentrer un nouveau.","pompier deja existant",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas l'autorisation d'ajouter un pompier !");
                }
               



                
            }
            else
            {
                MessageBox.Show("Tout les champs doivent etre rempi ! ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

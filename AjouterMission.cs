using SAE_A21D21_pompiers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UC_mission;

namespace SAE_A21D21_pompiers1
{
    public partial class AjouterMission : Form
    {
        private int numeroMission;
        private string date;
        private DataTable dtSinistres;
        private DataTable dtCasernes;
        private DataTable dtTypeEngin;
        private DataTable dtNecessiter;
        private DataTable dtMission;
        private DataTable dtPartirAvec;
        private DataTable dtMobiliser;
        private DataTable dtPasser;
        private DataTable dtAffectation;
        private DataTable dtPompier;
        private DataTable dtNatureSinistre;
        private DataTable dtEngin;


        public AjouterMission(int numeroMission, string date)
        {
            InitializeComponent();

            this.numeroMission = numeroMission;
            this.date = date;
        }



        private void AjouterMission_Load(object sender, EventArgs e)
        {
            grpDataGridView.Visible = false;
            lblIdMIssion.Text = "Mission numéro : " + numeroMission;
            lblDate.Text = "Déclenchée le : " + date;

            dtSinistres = MesDatas.DsGlobal.Tables["NatureSinistre"];
            

            cboNatureSinistre.DataSource = dtSinistres;
            cboNatureSinistre.DisplayMember = "libelle"; 
            cboNatureSinistre.ValueMember = "id";


            dtCasernes = MesDatas.DsGlobal.Tables["Caserne"];
            
            cboCaserne.DataSource = dtCasernes;
            cboCaserne.DisplayMember = "nom";
            cboCaserne.ValueMember = "id";

            cboNatureSinistre.SelectedIndex = -1;
            cboCaserne.SelectedIndex = -1;




        }


        public string getRue()
        {
            return txtRue.Text; 
        }
        public string getCodePostal()
        {

         return txtCodePostal.Text; 
        }
        public string getMotif()
        {
            return txtMotif.Text;
        }
        public string getVille()
        {
            return txtVille.Text;
        }
        public string getNature()
        {
            return cboNatureSinistre.SelectedValue.ToString();
        }
        public string getCaserne()
        {
            return cboCaserne.SelectedValue.ToString();
        }

        private void txtRue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || (char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
        }

        private void txtCodePostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || (char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
        }

        private void txtVille_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || (char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
        }

        private void txtMotif_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || (char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }

        }

       
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtCodePostal.Text = string.Empty;
            txtVille.Text = string.Empty;
            txtMotif.Text = string.Empty;
            txtRue.Text = string.Empty;
            cboCaserne.SelectedIndex = -1;
            cboNatureSinistre.SelectedIndex = -1;
            grpDataGridView.Visible = false;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            DataRow nouvelleMission = dtMission.NewRow();
            nouvelleMission["motifAppel"] = txtMotif.Text;
            nouvelleMission["adresse"] = txtRue.Text;
            nouvelleMission["cp"] = txtCodePostal.Text;
            nouvelleMission["ville"] = txtVille.Text;
            nouvelleMission["dateHeureDepart"] = date;
            nouvelleMission["id"] = numeroMission;
            dtMission.Rows.Add(nouvelleMission);

            

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnEquipe_Click(object sender, EventArgs e)
        {
            if(txtCodePostal.Text != string.Empty && txtMotif.Text!=string.Empty && txtRue.Text!=string.Empty && txtVille.Text!=string.Empty && cboCaserne.SelectedIndex!=-1 && cboNatureSinistre.SelectedIndex!=-1)
            {
                grpDataGridView.Visible = true;
                dtNecessiter = MesDatas.DsGlobal.Tables["Necessiter"];
                dtTypeEngin = MesDatas.DsGlobal.Tables["TypeEngin"];

                //Premier DataGridView
                int idNatureSinistre = Convert.ToInt32(cboNatureSinistre.SelectedValue);

                
                DataRow[] lignesNecessiter = dtNecessiter.Select("idNatureSinistre = " + idNatureSinistre);

               
                DataTable dtEnginsFiltres = dtTypeEngin.Clone();

                foreach (DataRow rowNecessiter in lignesNecessiter)
                {
                    string codeTypeEngin = rowNecessiter["codeTypeEngin"].ToString();

                    DataRow[] lignesEngin = dtTypeEngin.Select("code = '" + codeTypeEngin + "'");

                    foreach (DataRow engin in lignesEngin)
                    {
                        dtEnginsFiltres.ImportRow(engin);
                    }
                }
                dgvEngin.DataSource = dtEnginsFiltres;
                foreach (DataGridViewColumn col in dgvEngin.Columns)
                {
                    Console.WriteLine(col.Name);
                }


                //Second datagridview
                dtMission = MesDatas.DsGlobal.Tables["Mission"];
                dtPartirAvec = MesDatas.DsGlobal.Tables["PartirAvec"];
                dtMobiliser = MesDatas.DsGlobal.Tables["Mobiliser"];
                dtPasser = MesDatas.DsGlobal.Tables["Passer"];
                dtAffectation = MesDatas.DsGlobal.Tables["Affectation"];
                dtPompier = MesDatas.DsGlobal.Tables["Pompier"];
                dtNatureSinistre = MesDatas.DsGlobal.Tables["NatureSinistre"];
                dtEngin = MesDatas.DsGlobal.Tables["Engin"];

                int totalPompiersRequis = 0;
                foreach (DataGridViewRow row in dgvEngin.Rows)
                {
                    if (row.Cells["equipage"].Value != DBNull.Value)
                    {
                        totalPompiersRequis += Convert.ToInt32(row.Cells["equipage"].Value);
                    }
                }
                int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);
                DataRow[] affectations = dtAffectation.Select($"idCaserne = {idCaserne}");

                List<DataRow> pompiersDisponibles = new List<DataRow>();

                foreach (DataRow aff in affectations)
                {
                    int matricule = Convert.ToInt32(aff["matriculePompier"]);
                    DataRow[] pompier = dtPompier.Select($"matricule = {matricule} AND enMission = 0 AND enConge = 0");
                    if (pompier.Length > 0)
                        pompiersDisponibles.Add(pompier[0]);
                }
                DataTable dtPompiersAffectes = new DataTable();
                dtPompiersAffectes.Columns.Add("Matricule", typeof(int));
                dtPompiersAffectes.Columns.Add("Nom", typeof(string));
                dtPompiersAffectes.Columns.Add("Prenom", typeof(string));
                dtPompiersAffectes.Columns.Add("Grade", typeof(string));

                for (int i = 0; i < Math.Min(totalPompiersRequis, pompiersDisponibles.Count); i++)
                {
                    DataRow p = pompiersDisponibles[i];
                    dtPompiersAffectes.Rows.Add(p["matricule"], p["nom"], p["prenom"], p["codeGrade"]);
                }

                dgvPompiers.DataSource = dtPompiersAffectes;


            }

        }
    }
}

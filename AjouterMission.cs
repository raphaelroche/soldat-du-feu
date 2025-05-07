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
        private DateTime date;
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


        public AjouterMission(int numeroMission, DateTime date)
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

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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

                


            }

        }
    }
}

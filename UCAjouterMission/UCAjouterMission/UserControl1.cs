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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UCAjouterMission
{
    public partial class UCMissionCreation : UserControl
    {
        private int numeroMission;
        private DataSet ds;
        private DateTime date;
        private BindingSource bsSinistre;
        private BindingSource bsCaserne;
        public UCMissionCreation(DataSet ds, int numeroMission, DateTime date)
        {
            InitializeComponent();
            this.ds = ds;
            this.numeroMission = numeroMission;
            this.date = date;
        }
       

        private void UCMissionCreation_Load(object sender, EventArgs e)
        {
            grpDataGridView.Visible = false;
            lblIdMIssion.Text = "Mission numéro : " + numeroMission;
            lblDate.Text = "Déclenchée le : " + date;
            DataRelation relNatureNecessiter = new DataRelation(
            "relNatureNecessiter",
            ds.Tables["NatureSinistre"].Columns["id"],             // Clé primaire de NatureSinistre
            ds.Tables["Necessiter"].Columns["idNatureSinistre"]    // Clé étrangère de Necessiter
            );
            ds.Relations.Add(relNatureNecessiter);

            DataRelation relNecessiterEngin = new DataRelation(
            "relNecessiterEngin",
            ds.Tables["Necessiter"].Columns["codeTypeEngin"],      // Clé étrangère de Necessiter
            ds.Tables["TypeEngin"].Columns["code"]                 // Clé primaire de TypeEngin
            );
            ds.Relations.Add(relNecessiterEngin);

            bsSinistre = new BindingSource();
            bsSinistre.DataSource = ds;
            bsSinistre.DataMember = "NatureSinistre";
            cboNatureSinistre.DataSource = bsSinistre;
            cboNatureSinistre.DisplayMember = "libelle";
            cboNatureSinistre.ValueMember = "id";


            //remplissage de cboCaserne et dgvPompier
            bsCaserne = new BindingSource();
            bsCaserne.DataSource = ds;
            bsCaserne.DataMember = "Caserne";

            cboCaserne.DataSource = bsCaserne;
            cboCaserne.DisplayMember = "nom";
            cboCaserne.ValueMember = "id";

            ds.Relations.Add("relCaserneMission",
                ds.Tables["Caserne"].Columns["id"],
                ds.Tables["Mission"].Columns["idCaserne"]);

            ds.Relations.Add("relMissionMobiliser",
                ds.Tables["Mission"].Columns["id"],
                ds.Tables["Mobiliser"].Columns["idMission"]);

            ds.Relations.Add("relMobiliserPompier",
                ds.Tables["Mobiliser"].Columns["matriculePompier"],
                ds.Tables["Pompier"].Columns["matricule"]);

            ds.Relations.Add("relMobiliserHabilitation",
                ds.Tables["Mobiliser"].Columns["idHabilitation"],
                ds.Tables["Habilitation"].Columns["id"]);

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
            cboCaserne.SelectedIndex =-1;
            cboNatureSinistre.SelectedIndex =-1;
            grpDataGridView.Visible = false;
        }

        private void btnEquipe_Click(object sender, EventArgs e)
        {
            grpDataGridView.Visible = true;

            BindingSource bsNecessiter = new BindingSource();
            bsNecessiter.DataSource = bsSinistre;
            bsNecessiter.DataMember = "relNatureNecessiter";

            // Source liée à TypeEngin à partir de Necessiter
            BindingSource bsEngin = new BindingSource();
            bsEngin.DataSource = bsNecessiter;
            bsEngin.DataMember = "relNecessiterEngin";

            // Affichage des engins dans le DataGridView
            dgvEngin.DataSource = bsEngin;



            // 1. Caserne → Mission
            BindingSource bsMission = new BindingSource();
            bsMission.DataSource = bsCaserne;
            bsMission.DataMember = "relCaserneMission";

            // 2. Mission → Mobiliser
            BindingSource bsMobiliser = new BindingSource();
            bsMobiliser.DataSource = bsMission;
            bsMobiliser.DataMember = "relMissionMobiliser";

            // 3. Mobiliser → Pompier
            BindingSource bsPompier = new BindingSource();
            bsPompier.DataSource = bsMobiliser;
            bsPompier.DataMember = "relMobiliserPompier";

            // 4. Affecter au DataGridView
            dgvPompiers.DataSource = bsPompier;

        }
    }
}

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
        private int[] idHabilitation;


        public AjouterMission(int numeroMission, string date)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle; // bloque le redisionnement




            this.numeroMission = numeroMission;
            this.date = date;
            dtMission = MesDatas.DsGlobal.Tables["Mission"];
            dtPartirAvec = MesDatas.DsGlobal.Tables["PartirAvec"];
            dtMobiliser = MesDatas.DsGlobal.Tables["Mobiliser"];
            dtPasser = MesDatas.DsGlobal.Tables["Passer"];
            dtAffectation = MesDatas.DsGlobal.Tables["Affectation"];
            dtPompier = MesDatas.DsGlobal.Tables["Pompier"];
            dtNatureSinistre = MesDatas.DsGlobal.Tables["NatureSinistre"];
            dtEngin = MesDatas.DsGlobal.Tables["Engin"];
        }



        private void AjouterMission_Load(object sender, EventArgs e)
        {
            grpDataGridView.Visible = false;
            lblIdMIssion.Text = "Mission numéro : " + numeroMission +
                "        " +
                "Déclenchée le : " + date.Split(' ')[0] + " à " + date.Split(' ')[1];

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
            if (char.IsLetter(e.KeyChar) || (char.IsControl(e.KeyChar)) || (e.KeyChar == ' ') || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtCodePostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || (char.IsControl(e.KeyChar)) || (e.KeyChar == ' '))
            {
                e.Handled = false;
            }
        }

        private void txtVille_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || (char.IsControl(e.KeyChar)) || (e.KeyChar == ' '))
            {
                e.Handled = false;
            }
        }

        private void txtMotif_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || (char.IsControl(e.KeyChar)) || (e.KeyChar == ' '))
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
            nouvelleMission["idCaserne"] = Convert.ToInt32(cboCaserne.SelectedValue);
            nouvelleMission["idNatureSinistre"] = Convert.ToInt32(cboNatureSinistre.SelectedValue);
            nouvelleMission["terminee"] = 0;
            dtMission.Rows.Add(nouvelleMission);



            int i = 0;
            //mettre les pompiers en mission dans le dataset
            foreach (DataGridViewRow row in dgvPompiers.Rows)
            {
                if (row.Cells["Matricule"].Value != null)
                {
                    int matricule = Convert.ToInt32(row.Cells["Matricule"].Value);
                    DataRow[] pompierRow = dtPompier.Select($"matricule = {matricule}");
                    if (pompierRow.Length > 0)
                    {
                        pompierRow[0]["enMission"] = 1;
                    }
                    DataRow nouveauMobiliser = dtMobiliser.NewRow();
                    nouveauMobiliser["matriculePompier"] = matricule;
                    nouveauMobiliser["idMission"] = numeroMission;
                    nouveauMobiliser["idHabilitation"] = idHabilitation[i];
                }
                i++;
            }

            //metre les engins en mission dans le dataset
            foreach (DataGridViewRow row in dgvEngin.Rows)
            {
                if (row.Cells["numero"].Value != null &&
                    row.Cells["idCaserne"].Value != null &&
                    row.Cells["codeTypeEngin"].Value != null)
                {
                    string numero = row.Cells["numero"].Value.ToString();
                    string codeCaserne = row.Cells["idCaserne"].Value.ToString();
                    string codeTypeEngin = row.Cells["codeTypeEngin"].Value.ToString();

                    DataRow[] enginRows = dtEngin.Select(
                        $"numero = '{numero}' AND idCaserne = '{codeCaserne}' AND codeTypeEngin = '{codeTypeEngin}'"
                    );

                    foreach (DataRow engin in enginRows)
                    {
                        engin["enMission"] = 1;
                    }
                }
            }





            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnEquipe_Click(object sender, EventArgs e)
        {
            if (txtCodePostal.Text != string.Empty && txtMotif.Text != string.Empty && txtRue.Text != string.Empty && txtVille.Text != string.Empty && cboCaserne.SelectedIndex != -1 && cboNatureSinistre.SelectedIndex != -1)
            {
                grpDataGridView.Visible = true;
                dtNecessiter = MesDatas.DsGlobal.Tables["Necessiter"];
                dtTypeEngin = MesDatas.DsGlobal.Tables["TypeEngin"];

                List<(string codeTypeEngin, int nombre)> enginsNecessaires = new List<(string, int)>();

                // 1. Récupération des valeurs depuis les ComboBox
                int idNatureSinistre = Convert.ToInt32(cboNatureSinistre.SelectedValue);
                int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);


                // 2. Recherche des engins nécessaires pour ce type de sinistre
                foreach (DataRow row in MesDatas.DsGlobal.Tables["Necessiter"].Select("idNatureSinistre = " + idNatureSinistre))
                {
                    string type = row["codeTypeEngin"].ToString();
                    int nb = Convert.ToInt32(row["nombre"]);

                    DataRow[] enginsDispoDansCaserne = MesDatas.DsGlobal.Tables["Engin"].Select(
                        $"codeTypeEngin = '{type}' AND idCaserne = {idCaserne} AND enMission = 0 AND enPanne = 0"
                    );

                    if (enginsDispoDansCaserne.Length >= nb)
                    {
                        enginsNecessaires.Add((type, nb));
                    }
                }

                // 3. Affichage dans le DataGridView des engins
                dgvEngin.Rows.Clear();
                if (dgvEngin.Columns.Count == 0)
                {
                    dgvEngin.Columns.Add("codetypeEngin", "Type d'engin");
                    dgvEngin.Columns.Add("nombre", "Quantité");
                    dgvEngin.Columns.Add("equipage", "Équipage requis");
                    dgvEngin.Columns.Add("numero", "id");
                    dgvEngin.Columns.Add("idcaserne", "Caserne");
                }

                foreach ((string type, int nb) in enginsNecessaires)
                {
                    // Récupérer l’équipage depuis la table TypeEngin
                    int equipage = 0;
                    DataRow[] typeEnginRow = MesDatas.DsGlobal.Tables["TypeEngin"]
                        .Select($"code = '{type}'");
                    if (typeEnginRow.Length > 0)
                    {
                        equipage = Convert.ToInt32(typeEnginRow[0]["equipage"]);
                    }

                    DataRow[] enginsDispoDansCaserne = MesDatas.DsGlobal.Tables["Engin"].Select(
                        $"codeTypeEngin = '{type}' AND idCaserne = {idCaserne} AND enMission = 0 AND enPanne = 0"
                    );

                    // On ne garde que le nombre demandé
                    for (int i = 0; i < nb && i < enginsDispoDansCaserne.Length; i++)
                    {
                        DataRow engin = enginsDispoDansCaserne[i];
                        string codeTypeEngin = engin["codeTypeEngin"].ToString();
                        int numero = Convert.ToInt32(engin["numero"]);
                        int idCaserneEngin = Convert.ToInt32(engin["idCaserne"]);

                        dgvEngin.Rows.Add(codeTypeEngin, 1, equipage, numero, idCaserneEngin);
                    }
                }

                // 4. Affichage des pompiers
                dgvPompiers.Rows.Clear();
                if (dgvPompiers.Columns.Count == 0)
                {
                    dgvPompiers.Columns.Add("matricule", "Matricule");
                    dgvPompiers.Columns.Add("nom", "Nom");
                    dgvPompiers.Columns.Add("prenom", "Prénom");
                    dgvPompiers.Columns.Add("pourEngin", "Type Engin");
                }

                int i = 0;
                foreach ((string typeEngin, int nombre) in enginsNecessaires)
                {
                    IEnumerable<int> habilitations = MesDatas.DsGlobal.Tables["Embarquer"]
                        .Select($"codeTypeEngin = '{typeEngin}'")
                        .Select(row => Convert.ToInt32(row["idHabilitation"]))
                        .Distinct();

                    List<DataRow> pompiersEligibles = new List<DataRow>();

                    foreach (int idHab in habilitations)
                    {
                        DataRow[] rowsPasser = MesDatas.DsGlobal.Tables["Passer"]
                            .Select($"idHabilitation = {idHab}");
                        

                        foreach (DataRow passerRow in rowsPasser)
                        {
                            int matricule = Convert.ToInt32(passerRow["matriculePompier"]);
                            DataRow pompier = MesDatas.DsGlobal.Tables["Pompier"]
                                .Select($"matricule = {matricule}")
                                .FirstOrDefault();

                            DataRow affectation = MesDatas.DsGlobal.Tables["Affectation"]
                                .Select($"matriculePompier = {matricule} and idCaserne = {idCaserne}")
                                .FirstOrDefault();
                            if (affectation != null)
                            {
                                bool enMission = Convert.ToInt32(pompier["enMission"]) == 1;
                                bool enConge = Convert.ToInt32(pompier["enConge"]) == 1;


                                if (!enMission && !enConge)
                                {
                                    if (!pompiersEligibles.Contains(pompier))
                                        pompiersEligibles.Add(pompier);
                                    idHabilitation[i]= idHab;
                                    i++;
                                }
                            }
                        }
                    }

                    // Récupérer nombre d’équipiers requis pour cet engin
                    int equipage = 0;
                    DataRow[] rowType = MesDatas.DsGlobal.Tables["TypeEngin"].Select($"code = '{typeEngin}'");
                    if (rowType.Length > 0)
                    {
                        equipage = Convert.ToInt32(rowType[0]["equipage"]);
                    }

                    // nombre total de pompiers à prendre = nombre d'engins * équipage
                    int totalPompiers = equipage * nombre;

                    List<DataRow> selection = pompiersEligibles.Take(totalPompiers).ToList();

                    foreach (DataRow p in selection)
                    {
                        dgvPompiers.Rows.Add(p["matricule"], p["nom"], p["prenom"], typeEngin);
                    }
                }
            }
        }
    }
}

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
        private DataTable dtPompier;
        private DataTable dtNatureSinistre;
        private DataTable dtEngin;
        private int[] idHabilitation;
        private int[] idHabi;


        public AjouterMission(int numeroMission, string date)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle; // bloque le redisionnement




            this.numeroMission = numeroMission;
            this.date = date;
            dtMission = MesDatas.DsGlobal.Tables["Mission"];
            dtPartirAvec = MesDatas.DsGlobal.Tables["PartirAvec"];
            dtMobiliser = MesDatas.DsGlobal.Tables["Mobiliser"];
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

            idHabilitation = new int[100];


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
            if (dgvPompiers.Rows.Count == 0)
            {
                MessageBox.Show("Aucun Pompier n'est disponible pour cette mission, veuillez chosir une autre caserne", "caserne vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(dgvEngin.Rows.Count == 0)
            {
                MessageBox.Show("Aucun Engin n'est disponible pour cette mission, tout les engins de ce type soint en mission ou en panne !", "Engin Indisponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow nouvelleMission = dtMission.NewRow();
            nouvelleMission["motifAppel"] = txtMotif.Text;
            nouvelleMission["adresse"] = txtRue.Text;
            nouvelleMission["cp"] = txtCodePostal.Text;
            nouvelleMission["ville"] = txtVille.Text;
            nouvelleMission["dateHeureDepart"] = date;
            nouvelleMission["id"] = numeroMission;
            nouvelleMission["idCaserne"] = Convert.ToInt32(cboCaserne.SelectedIndex + 1);
            nouvelleMission["idNatureSinistre"] = Convert.ToInt32(cboNatureSinistre.SelectedIndex + 1);
            nouvelleMission["terminee"] = 0;
            dtMission.Rows.Add(nouvelleMission);



            int i = 0;
            //mettre les pompiers en mission dans le dataset
            HashSet<int> matriculesDejaAjoutes = new HashSet<int>();

            foreach (DataGridViewRow row in dgvPompiers.Rows)
            {
                if (row.Cells["Matricule"].Value != null)
                {
                    int matricule = Convert.ToInt32(row.Cells["Matricule"].Value);

                    if (!matriculesDejaAjoutes.Contains(matricule))
                    {
                        // Marquer le pompier comme étant en mission
                        DataRow[] pompierRow = dtPompier.Select($"matricule = {matricule}");
                        if (pompierRow.Length > 0)
                        {
                            pompierRow[0]["enMission"] = 1;
                        }

                        // Ajouter dans dtMobiliser
                        DataRow nouveauMobiliser = dtMobiliser.NewRow();
                        nouveauMobiliser["matriculePompier"] = matricule;
                        nouveauMobiliser["idMission"] = numeroMission;
                        nouveauMobiliser["idHabilitation"] = idHabi[i];
                        dtMobiliser.Rows.Add(nouveauMobiliser);

                        matriculesDejaAjoutes.Add(matricule);
                        i++;
                    }
                }
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
                    DataRow nouveauPartirAvec = dtPartirAvec.NewRow();
                    nouveauPartirAvec["idCaserne"] = Convert.ToInt32(cboCaserne.SelectedIndex + 1);
                    nouveauPartirAvec["codeTypeEngin"] = codeTypeEngin;
                    nouveauPartirAvec["numeroEngin"] = numero;
                    nouveauPartirAvec["idMission"] = numeroMission;
                    nouveauPartirAvec["reparationsEventuelles"] = DBNull.Value;
                    dtPartirAvec.Rows.Add(nouveauPartirAvec);
                }
            }





            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private List<DataRow> TrouverEnginsAUtiliser(string type, int nb, int idCaserne)
        {
            DataRow[] tousEnginsDispo = MesDatas.DsGlobal.Tables["Engin"].Select(
                $"codeTypeEngin = '{type}' AND enMission = 0 AND enPanne = 0"
            );

            List<DataRow> enginsDansCaserne = tousEnginsDispo
                .Where(f => Convert.ToInt32(f["idCaserne"]) == idCaserne)
                .ToList();

            List<DataRow> enginsHorsCaserne = tousEnginsDispo
                .Where(f => Convert.ToInt32(f["idCaserne"]) != idCaserne)
                .ToList();

            List<DataRow> enginsAUtiliser = new List<DataRow>();
            enginsAUtiliser.AddRange(enginsDansCaserne.Take(nb));

            if (enginsAUtiliser.Count < nb)
            {
                enginsAUtiliser.AddRange(enginsHorsCaserne.Take(nb - enginsAUtiliser.Count));
            }

            return enginsAUtiliser;
        }

        private void btnEquipe_Click(object sender, EventArgs e)
        {
            if (txtCodePostal.Text != string.Empty && txtMotif.Text != string.Empty && txtRue.Text != string.Empty && txtVille.Text != string.Empty && cboCaserne.SelectedIndex != -1 && cboNatureSinistre.SelectedIndex != -1)
            {
                grpDataGridView.Visible = true;
                dtNecessiter = MesDatas.DsGlobal.Tables["Necessiter"];
                dtTypeEngin = MesDatas.DsGlobal.Tables["TypeEngin"];

                List<(string codeTypeEngin, int nombre)> enginsNecessaires = new List<(string, int)>();

                int idNatureSinistre = Convert.ToInt32(cboNatureSinistre.SelectedValue);
                int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);

                // identifier les engins nécessaires
                foreach (DataRow row in dtNecessiter.Select("idNatureSinistre = " + idNatureSinistre))
                {
                    string type = row["codeTypeEngin"].ToString();
                    int nb = Convert.ToInt32(row["nombre"]);
                    var enginsAUtiliser = TrouverEnginsAUtiliser(type, nb, idCaserne);

                    if (enginsAUtiliser.Count == nb)
                    {
                        enginsNecessaires.Add((type, nb));
                    }
                }

                // 2. Affichage dans dgvEngin
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
                    int equipage = 0;
                    DataRow[] typeEnginRow = dtTypeEngin.Select($"code = '{type}'");
                    if (typeEnginRow.Length > 0)
                    {
                        equipage = Convert.ToInt32(typeEnginRow[0]["equipage"]);
                    }

                    var enginsAUtiliser = TrouverEnginsAUtiliser(type, nb, idCaserne);

                    foreach (DataRow engin in enginsAUtiliser)
                    {
                        string codeTypeEngin = engin["codeTypeEngin"].ToString();
                        int numero = Convert.ToInt32(engin["numero"]);
                        int idCaserneEngin = Convert.ToInt32(engin["idCaserne"]);
                        dgvEngin.Rows.Add(codeTypeEngin, 1, equipage, numero, idCaserneEngin);
                    }
                }
            

                // 3. Affichage des pompiers
                dgvPompiers.Rows.Clear();
                if (dgvPompiers.Columns.Count == 0)
                {
                    dgvPompiers.Columns.Add("matricule", "Matricule");
                    dgvPompiers.Columns.Add("nom", "Nom");
                    dgvPompiers.Columns.Add("prenom", "Prénom");
                    dgvPompiers.Columns.Add("pourEngin", "Type Engin");
                }

                int i = 0;
                idHabi = new int[20];
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

                            if (affectation != null && pompier != null)
                            {
                                bool enMission = Convert.ToInt32(pompier["enMission"]) == 1;
                                bool enConge = Convert.ToInt32(pompier["enConge"]) == 1;

                                if (!enMission && !enConge && !pompiersEligibles.Contains(pompier))
                                {
                                    pompiersEligibles.Add(pompier);
                                    idHabilitation[i] = idHab;
                                    i++;
                                }
                            }
                        }
                    }

                    int equipage = 0;
                    DataRow[] rowType = dtTypeEngin.Select($"code = '{typeEngin}'");
                    if (rowType.Length > 0)
                    {
                        equipage = Convert.ToInt32(rowType[0]["equipage"]);
                    }

                    int totalPompiers = equipage * nombre;
                    List<DataRow> selection = pompiersEligibles.Take(totalPompiers).ToList();

                    for (int j = 0; j < selection.Count; j++)
                    {
                        idHabi[j] = idHabilitation[j];
                    }

                    foreach (DataRow p in selection)
                    {
                        dgvPompiers.Rows.Add(p["matricule"], p["nom"], p["prenom"], typeEngin);
                    }
                }
            }
        }
    }
}

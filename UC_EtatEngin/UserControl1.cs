using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_EtatEngin
{
    public partial class UserControl1 : UserControl
    {
        DataSet ds;

        public DataSet Ds { get => ds; set => ds = value; }

        public UserControl1()
        {
            InitializeComponent();
        }
        public void AfficherEngin(DataRow engin)
        {
            // Récupération des champs
            int idCaserne = Convert.ToInt32(engin["idCaserne"]);
            string typeEngin = engin["codeTypeEngin"].ToString(); // ou "code" si c'est le nom de la colonne
            int numeroOrdre = Convert.ToInt32(engin["numero"]);

            // Construction de l'affichage : exemple 1-BRS-2
            lblNumero.Text = $"{idCaserne}-{typeEngin}-{numeroOrdre}";

            // Autres champs
            lblDate.Text = Convert.ToDateTime(engin["dateReception"]).ToString("yyyy-MM-dd");
            cboMission.Checked = Convert.ToBoolean(engin["enMission"]);
            cboPanne.Checked = Convert.ToBoolean(engin["enPanne"]);

            //Images
            //MessageBox.Show("divers/" + typeEngin + ".png");
            pbEngin.Image = Image.FromFile("ImagesEngins/" + typeEngin.ToLower() + ".jpg");
        }


        public void Clear()
        {
            lblNumero.Text = "";
            lblDate.Text = "";
            cboMission.Checked = false;
            cboPanne.Checked = false;
            // Vider l’image si tu en as une
        }

        private void cboMission_Click(object sender, EventArgs e)
        {
            ((CheckBox)sender).Checked = !((CheckBox)sender).Checked;
        }

        private void cboPanne_Click(object sender, EventArgs e)
        {
            ((CheckBox)sender).Checked = !((CheckBox)sender).Checked;
        }
    }
}
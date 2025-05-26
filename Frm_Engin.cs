using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAE_A21D21_pompiers;
using UC_EtatEngin;

namespace SAE_A21D21_pompiers1
{
    public partial class Frm_Engin : Form
    {
        private List<DataRow> enginsFiltres;
        private int indexEnginCourant = 0;
        public Frm_Engin()
        {
            InitializeComponent();
            UC_etatengin.Ds = MesDatas.DsGlobal;
        }

        private void Frm_Engin_Load_1(object sender, EventArgs e)
        {
            DataTable dtCaserne = MesDatas.DsGlobal.Tables["Caserne"];

            cboCaserne.DataSource = dtCaserne;
            cboCaserne.DisplayMember = "nom"; // Ce qui est affiché
            cboCaserne.ValueMember = "id";
        }

        private void cboCaserne_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboCaserne.SelectedItem == null) return;

            var drv = cboCaserne.SelectedItem as DataRowView;
            if (drv == null) return;

            int idCaserne = Convert.ToInt32(drv["id"]);

            DataTable dtEngins = MesDatas.DsGlobal.Tables["Engin"];

            enginsFiltres = dtEngins.AsEnumerable()
                                    .Where(row => Convert.ToInt32(row["idCaserne"]) == idCaserne)
                                    .ToList();

            indexEnginCourant = 0;

            if (enginsFiltres.Count > 0)
            {
                AfficherEngin(enginsFiltres[indexEnginCourant]);
            }
            else
            {
                UC_etatengin.Clear();
            }
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            if (enginsFiltres.Count > 0)
            {
                indexEnginCourant = 0;
                AfficherEngin(enginsFiltres[indexEnginCourant]);
            }
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            if (enginsFiltres.Count > 0)
            {
                indexEnginCourant = enginsFiltres.Count - 1;
                AfficherEngin(enginsFiltres[indexEnginCourant]);
            }
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (enginsFiltres.Count > 0 && indexEnginCourant < enginsFiltres.Count - 1)
            {
                indexEnginCourant++;
                AfficherEngin(enginsFiltres[indexEnginCourant]);
            }
        }

        private void btnDerriere_Click(object sender, EventArgs e)
        {
            if (enginsFiltres.Count > 0 && indexEnginCourant > 0)
            {
                indexEnginCourant--;
                AfficherEngin(enginsFiltres[indexEnginCourant]);
            }
        }
        private void AfficherEngin(DataRow engin)
        {
            UC_etatengin.AfficherEngin(engin);
        }
    }
}
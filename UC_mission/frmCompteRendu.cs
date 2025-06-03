using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_A21D21_pompiers1
{
    public partial class frmCompteRendu : Form
    {
        public frmCompteRendu()
        {
            InitializeComponent();
        }


        private void btnValider_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public string getCompteRendu()
        {
            return txtCompteRendu.Text;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

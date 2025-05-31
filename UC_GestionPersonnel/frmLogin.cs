using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_A21D21_pompiers1
{
    public partial class frmLogin : Form
    {
        private SQLiteConnection cx;
        public frmLogin(SQLiteConnection cx)
        {
            InitializeComponent();
            this.cx = cx;

        }

        private void btnValider_Click_1(object sender, EventArgs e)
        {
            string sqlmdp = "select mdp from Admin where login ='" + txtId.Text + "'";
            string mdp = "";
            try
            {
                SQLiteCommand c = new SQLiteCommand(sqlmdp, cx);
                object result = c.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("identifiant incorrect");
                    txtMdp.Text = string.Empty;
                    txtId.Text = string.Empty;
                }
                else
                {
                    mdp = result.ToString();
                    if (mdp == txtMdp.Text)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("mot de passe incorrect");
                        txtMdp.Text = string.Empty;
                        txtId.Text = string.Empty;
                    }
                }
               
             

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
                txtMdp.Text = string.Empty;
                txtId.Text = string.Empty;
            }
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnValider_Click_1(sender, e);
            }
        }
    }
}
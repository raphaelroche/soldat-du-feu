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
            Application.Exit();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (cboCaserne.SelectedIndex != -1 && cboGrade.SelectedIndex != -1 && cboSexe.SelectedIndex != -1 && cboStatus.SelectedIndex != -1 && txtBip.Text != String.Empty && txtMatricule.Text != String.Empty && txtNom.Text != String.Empty && txtPrenom.Text != String.Empty && txtTel.Text != String.Empty) 
            { 
            
            }
        }
    }
}

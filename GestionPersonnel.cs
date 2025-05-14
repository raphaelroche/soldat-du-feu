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
    public partial class GestionPersonnel : Form
    {
        public GestionPersonnel()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // bloque le redisionnement
        }

        private void GestionPersonnel_Load(object sender, EventArgs e)
        {
            pnlMenu.BackColor = Color.FromArgb(200, 139, 0, 0); //change l'opacité du menu            
        }
    }
}

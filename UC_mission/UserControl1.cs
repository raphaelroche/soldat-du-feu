using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_mission
{
    public partial class Mission : UserControl
    {
    public Mission(int idMission, string type, String date, string caserne, string desc)
        {
            InitializeComponent();
            lblIDMission.Text = "Mission n°" + idMission;
            lblDate.Text = "Date : " + date;
            lblCaserne.Text = "Caserne : " + caserne;
            lblType.Text = type;
            lblDescription.Text = "--> " + desc;

            //images des boutons
            Image imgClose = UC_mission.Properties.Resources.close;
            btnCloture.BackgroundImage = new Bitmap(imgClose, new Size(btnCloture.Width, btnCloture.Height)); // redimensionne l'image à la taille du bouton btnCloture
            btnCloture.BackgroundImageLayout = ImageLayout.Stretch;

            //images des boutons
            Image imgRapport = UC_mission.Properties.Resources.rapport;
            btnRapport.BackgroundImage = new Bitmap(imgRapport, new Size(btnRapport.Width, btnRapport.Height)); // redimensionne l'image à la taille du bouton btnCloture
            btnRapport.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnRapport_Click(object sender, EventArgs e)
        {

        }
    }
}

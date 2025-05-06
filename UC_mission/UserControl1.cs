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
    public Mission(int idMission, string type, string date, string caserne, string desc)
        {
            InitializeComponent();
            lblIDMission.Text = "Mission n°" + idMission;
            lblDate.Text = "Date : " + date;
            lblCaserne.Text = "Caserne : " + caserne;
            lblType.Text = type;
            lblDescription.Text = "--> " + desc;
            this.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UC_mission;

namespace SAE_A21D21_pompiers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLiteConnection cx = Connexion.Connec; //connexion a la base de données
            int y = 50; // position de départ en Y
            int spacing = 10; // espace entre les contrôles

            for (int i = 0; i < 5; i++)
            {
                Mission mission = new Mission(i, "accident", "02/03/2025", $"caserne {i}", "feu déclaré");
                mission.Location = new System.Drawing.Point(50, y);
                pnlTableauDeBord.Controls.Add(mission);

                y += mission.Height + spacing; // décale vers le bas pour la prochaine mission
            }

        }
    }
}

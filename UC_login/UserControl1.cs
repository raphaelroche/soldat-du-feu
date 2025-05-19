using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_login
{
    public partial class UserControl1: UserControl
    {
        SQLiteConnection cx;
        public UserControl1(SQLiteConnection cx)
        {
            InitializeComponent();
            this.cx = cx;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string sqllogin1 = "select login from Admin where id  = 1";
            SQLiteCommand a = new SQLiteCommand(sqllogin1, this.cx);
            string login1 = a.ExecuteScalar().ToString();


            string sqllogin2 = "select login from Admin where id = 2";
            SQLiteCommand c = new SQLiteCommand(sqllogin2, this.cx);
            string login2 = c.ExecuteScalar().ToString();

            string sqlmdp1 = "select mdp from Admin where id = 1";
            SQLiteCommand com = new SQLiteCommand(sqlmdp1, this.cx);
            string mdp1 = com.ExecuteScalar().ToString();

            string sqlmdp2 = "select mdp from Admin where id = 2";
            SQLiteCommand comm = new SQLiteCommand(sqlmdp2, this.cx);
            string mdp2 = comm.ExecuteScalar().ToString();


        }
    }
}

using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallCenter
{
    public partial class AdminPanelUI : MetroForm
    {
        public AdminPanelUI()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            UserList UL = new UserList();
            UL.ShowDialog();
            this.Close();


        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AssignProject ap = new AssignProject();
            ap.ShowDialog();
            this.Close();
        }

        private void tileViewProfile_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            ViewProfileUI rr = new ViewProfileUI();
            rr.ShowDialog();
            this.Close();
        }

        private void tileLogout_MouseClick(object sender, MouseEventArgs e)
        {
            LoginUI.userlogged = "";
            this.Hide();
            LoginUI login = new LoginUI();
            login.ShowDialog();
            this.Close();
        }

        private void tileChat_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Chat ch = new Chat();
            ch.ShowDialog();
            this.Close();
        }

        private void tileRecorded_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Recorded_Conversations ss = new Recorded_Conversations();
            ss.ShowDialog();
            this.Close();
        }

        private void metroTile4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            View_Report vr = new View_Report();
            vr.ShowDialog();
            this.Close();
        }
    }
}

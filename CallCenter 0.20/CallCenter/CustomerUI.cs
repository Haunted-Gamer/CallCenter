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
    public partial class CustomerUI : MetroForm
    {
        public CustomerUI()
        {
            InitializeComponent();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            ADDPROJECT add = new ADDPROJECT();
            add.ShowDialog();
            this.Close();
        }

        private void tileViewProfile_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            ViewProfileUI rr = new ViewProfileUI();
            rr.ShowDialog();
            this.Close();
        }

        private void metroTile4_MouseClick(object sender, MouseEventArgs e)
        {
            LoginUI.userlogged = "";
            this.Hide();
           LoginUI login = new LoginUI();
            login.ShowDialog();
            this.Close();
        }

        private void metroTile3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            ViewProjectUI vw = new ViewProjectUI();
            vw.ShowDialog();

            this.Close();
        }
    }
}

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
    public partial class EmployeeUI : MetroForm 
    {
        public EmployeeUI()
        {
            InitializeComponent();
        }

        private void metroTile2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Chat chatchat = new Chat();
            chatchat.ShowDialog();
            this.Close();

        }

        private void metroTile4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            RecordUI rr = new RecordUI();
            rr.ShowDialog();
            this.Close();
        }

        private void metroTile1_MouseClick(object sender, MouseEventArgs e)
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
    }
}

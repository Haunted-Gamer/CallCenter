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
    public partial class Registration : MetroForm
    {      public static int priority = 0;
        public Registration()
        {
            InitializeComponent();
        }

        private void metroButton1_MouseClick(object sender, MouseEventArgs e)
        {
            String var = metroComboBox1.Text;
            if (var == "Admin")
            {
                priority = 1;
                metroTextBox1.Visible = true;
                metroButton3.Visible = true;
            }
            else if (var == "Employee" || var == "Customer")
            {
                if (var == "Employee") { priority = 2; }
                else priority = 3;

                this.Hide();
                
                RegistrationUI frm = new RegistrationUI();
                frm.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("PLEASE SELECT A TYPE");


        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            string admincheck= metroTextBox1.Text;
            if (admincheck == "007")
            {
                this.Hide();
                
                RegistrationUI frm = new RegistrationUI();
                frm.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Invalid PASSWORD!");

        }

        private void metroTextBox1_MouseHover(object sender, EventArgs e)
        {
            metroTextBox1.Text = "";
        }

        private void metroTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            metroTextBox1.Text = "";
        }
    }
}

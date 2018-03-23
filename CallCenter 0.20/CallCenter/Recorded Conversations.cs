using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace CallCenter
{
    public partial class Recorded_Conversations : MetroForm
    {
        public Recorded_Conversations()
        {
            InitializeComponent();
        }

        private void Recorded_Conversations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet10.RECORDS' table. You can move, or remove it, as needed.
            this.rECORDSTableAdapter.Fill(this.database1DataSet10.RECORDS);

        }

        private void Back_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AdminPanelUI ui = new AdminPanelUI();
            ui.ShowDialog();
            this.Close();
        }
    }
}

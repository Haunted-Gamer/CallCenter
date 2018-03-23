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
    public partial class ViewProjectUI : MetroForm
    {
        String sad = LoginUI.userlogged;
        public ViewProjectUI()
        {
            InitializeComponent();
        }

        private void ViewProjectUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet9.PROS' table. You can move, or remove it, as needed.
            this.pROSTableAdapter.Fill(this.database1DataSet9.PROS);
            // TODO: This line of code loads data into the 'database1DataSet8.PROS' table. You can move, or remove it, as needed.
           // this.pROSTableAdapter.Fill(this.database1DataSet8.PROS);
            // TODO: This line of code loads data into the 'database1DataSet8.PROS' table. You can move, or remove it, as needed.
            //this.pROSTableAdapter.Fill(this.database1DataSet8.PROS);

        }

        


        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

      

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pROSTableAdapter.FillBy(this.database1DataSet9.PROS, sadToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

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
    public partial class View_Report : MetroForm
    {
        DataClasses1DataContext dbz = new DataClasses1DataContext();
        public View_Report()
        {
            int count = (from p in dbz.users
             where p.UNAME == p.UNAME
             select p).Count();
            int count1 = (from p in dbz.users
                         where p.UPRI == 2
                         select p).Count();
            int count2 = (from p in dbz.users
                          where p.UPRI == 3
                          select p).Count();
            String count3 = Convert.ToString(dbz.RECORDs.Sum(x => x.Duration));

            int count4 = dbz.PROs.Max(u => u.pid);



            InitializeComponent();
            metroLabel9.Text = Convert.ToString(count);
            metroLabel10.Text = Convert.ToString(count1);
            metroLabel11.Text = Convert.ToString(count2);
            metroLabel8.Text = Convert.ToString(count3);
            metroLabel7.Text = Convert.ToString(count4);
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void View_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet11.PROS' table. You can move, or remove it, as needed.
            this.pROSTableAdapter.Fill(this.database1DataSet11.PROS);

        }

        private void metroButton1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AdminPanelUI asd = new AdminPanelUI();
            asd.ShowDialog();
            this.Close();
        }
    }
}

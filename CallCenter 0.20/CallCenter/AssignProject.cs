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
    public partial class AssignProject : MetroForm
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public AssignProject()
        {
            InitializeComponent();
        }

        private void AssignProject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet7.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.database1DataSet7.users);
            // TODO: This line of code loads data into the 'database1DataSet6.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.database1DataSet6.users);
            // TODO: This line of code loads data into the 'database1DataSet5.PROS' table. You can move, or remove it, as needed.
            this.pROSTableAdapter.Fill(this.database1DataSet5.PROS);
            // TODO: This line of code loads data into the 'database1DataSet5.PROS' table. You can move, or remove it, as needed.
            this.pROSTableAdapter.Fill(this.database1DataSet5.PROS);

        }

        private void buttonBack_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AdminPanelUI adm = new AdminPanelUI();
            adm.ShowDialog();
            this.Close();
        }

        private void buttonAssign_MouseClick(object sender, MouseEventArgs e)
        {
            String das = comboBox2.Text;
            
            String sad = comboBox2.Text;
            
             var query =
             from ord in dc.users
             where ord.UNAME == sad
             select ord;

            foreach (user ord in query)
            {
                ord.Vacancy = 1;
            }

            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ssad) { MessageBox.Show(ssad.ToString()); }
           
            var querys =
            from ords in dc.PROs
            where Convert.ToString(ords.pname) == das
            select ords;
            foreach (PRO ords in querys) 
            {
                ords.pstatus = 1;
            
            
            }
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception er) { MessageBox.Show(er.ToString()); }

            
        }
    }
}

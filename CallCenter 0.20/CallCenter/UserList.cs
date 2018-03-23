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
    public partial class UserList : MetroForm
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'database1DataSet2.users' table. You can move, or remove it, as needed.
this.usersTableAdapter.Fill(this.database1DataSet2.users);
        
        }

        private void buttonBack_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AdminPanelUI ad = new AdminPanelUI();
            ad.ShowDialog();
            this.Close();
        }
    }
}

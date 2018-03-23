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
    public partial class ViewProfileUI : MetroForm
    {    DataClasses1DataContext dbprofile = new DataClasses1DataContext();

        public ViewProfileUI()
        {
            
            InitializeComponent();

             var dataSet1 = from p1 in dbprofile.users
                     where p1.UNAME.Contains(LoginUI.userlogged)
                     select p1.NAME;

             labelName.Text = dataSet1.First();

           // MessageBox.Show(dataSet1.First());
            labelUserName.Text = LoginUI.userlogged;

            var dataSet2 = from p2 in dbprofile.users
                     where p2.UNAME.Contains(LoginUI.userlogged)
                     select p2.GENDER;
            labelGender.Text=dataSet2.First();

            var dataSet3 = from p3 in dbprofile.users
                     where p3.UNAME.Contains(LoginUI.userlogged)
                     select p3.MSTAT;
            labelMaritalStaus.Text=dataSet3.First();

            var dataSet4 = from p4 in dbprofile.users
                     where p4.UNAME.Contains(LoginUI.userlogged)
                     select p4.EMAIL;
            labelEmail.Text=dataSet4.First();

            var dataSet5 = from p5 in dbprofile.users
                     where p5.UNAME.Contains(LoginUI.userlogged)
                     select p5.DOB;
            
            DateTime dt = Convert.ToDateTime(dataSet5.First().ToString());
            
            labelDOB.Text =  dt.ToLongDateString();
            

            var dataSet6 = from p6 in dbprofile.users
                     where p6.UNAME.Contains(LoginUI.userlogged)
                     select p6.COMPN ;
            labelCompnayName.Text=dataSet6.First();
            
        }
        

         public void metroLabel11_Click(object sender, EventArgs e)
        {
        
        }

         private void buttonBack_MouseClick(object sender, MouseEventArgs e)
         {
             var q1 = from p in dbprofile.users
                      where p.UNAME.Contains(LoginUI.userlogged)
                      select p.UPRI;


             if (q1.First() == 1)
             {
                 this.Hide();
                 AdminPanelUI adm = new AdminPanelUI();
                 adm.ShowDialog();
                 this.Close();
                 
             }
             else if (q1.First() == 2)
             {
                 this.Hide();
                 EmployeeUI adms = new EmployeeUI();
                 adms.ShowDialog();
                 this.Close();
                 
             }
             else if (q1.First() == 3)
             {
                 this.Hide();
                 CustomerUI adms = new CustomerUI();
                 adms.ShowDialog();
                 this.Close();
                
             }
         } 

    }
}

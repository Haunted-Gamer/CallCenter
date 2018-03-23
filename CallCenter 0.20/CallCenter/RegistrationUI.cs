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
using System.Diagnostics;
namespace CallCenter
{
    public partial class RegistrationUI : MetroForm
    {   
        DataClasses1DataContext xp = new DataClasses1DataContext();
        public RegistrationUI()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

      

        private void metroButton1_MouseClick(object sender, MouseEventArgs e)
        {
            String name = metroTextBox1.Text;
            String UserName = metroTextBox3.Text;
            String pass = metroTextBox4.Text;
            String Gender = metroComboBox1.Text;
            String MStat = metroComboBox2.Text;
            
           

           
            //else MessageBox.Show("MARRITAL STATUS NOT CHOSEN");
            DateTime dt = Convert.ToDateTime(metroDateTime1.Text);
            String email = metroTextBox2.Text;
            String company = metroTextBox5.Text;

            if (metroTextBox1.Text !="" || metroComboBox1.Text == "MALE" || metroComboBox1.Text == "FEMALE" || metroComboBox2.Text == "SINGLE" || metroComboBox2.Text == "MARRIED")
            {

                user news = new user { 
                UNAME = UserName,
                UPWD = pass,
                UPRI =  Registration.priority,
                NAME = name,
                GENDER = Gender,
                MSTAT=MStat,
                DOB=dt,
                EMAIL=email,
                COMPN=company
                };
                xp.users.InsertOnSubmit(news);
                try
                {
                    Registration.priority = 0;
                    xp.SubmitChanges();
                    MessageBox.Show("Registration Complete");
                    this.Hide();
                    LoginUI login = new LoginUI();
                    login.ShowDialog();
                    this.Close();
                }
                catch (Exception re)
                {
                    
                    Debug.WriteLine(re);
                    // Make some adjustments.
                    // ...
                    // Try again.
                    xp.SubmitChanges();
                }
            }
            else MessageBox.Show("Something Missing");

            //xp.users.InsertOnSubmit(UserName,pass,1,name,Gender,MStat,dt,email,company);
        }

        private void metroButton2_MouseClick(object sender, MouseEventArgs e)
        {
            Registration.priority = 0;
            this.Hide();
            LoginUI login = new LoginUI();
            login.ShowDialog();
            this.Close();
        }
    }
}

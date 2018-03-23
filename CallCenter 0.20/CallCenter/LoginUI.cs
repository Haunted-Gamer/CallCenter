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
using System.Data.Linq.SqlClient;
using System.Net.Mail;

namespace CallCenter
{
    public partial class LoginUI : MetroForm
    {
        private bool checkloginsuccess = false;
        public static String userlogged = "";
        DataClasses1DataContext d = new DataClasses1DataContext();
     
        public LoginUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_MouseClick(object sender, MouseEventArgs e)
        {
            String username = metroTextBox1.Text;
            String password = metroTextBox2.Text;
            var all = from data in d.users select data;
            foreach (var result in all) {
                if (result.UNAME == username && result.UPWD == password && result.UPRI == 1)
                {
                    userlogged = username;
                    checkloginsuccess = true;
                    this.Hide();
                    AdminPanelUI frms = new AdminPanelUI();
                    frms.ShowDialog();
                    this.Close();
                }

                else if (result.UNAME == username && result.UPWD == password && result.UPRI == 2)
                {
                    userlogged = username;
                    checkloginsuccess = true;
                    this.Hide();
                    EmployeeUI frmss = new EmployeeUI();
                    frmss.ShowDialog();
                    this.Close();
                    
                }
                else if (result.UNAME == username && result.UPWD == password && result.UPRI == 3)
                {
                    userlogged = username;
                    checkloginsuccess = true;
                    this.Hide();
                    CustomerUI frmsss = new CustomerUI();
                    frmsss.ShowDialog();
                    this.Close();
                }
                
            }
            if (checkloginsuccess == false) {
                MessageBox.Show("USERNAME-PASSWORD NOT MATCHED!");
            }
        }

        private void metroButton2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Registration tango = new Registration();
            tango.ShowDialog();
            this.Close();
        }

        private void metroButton3_MouseClick(object sender, MouseEventArgs e)
        {    String emailed = metroTextBox3.Text;
           String pass="1";
            var all = from data in d.users select data;    
            foreach (var result in all) {
                if (result.EMAIL==emailed)
                {pass= result.UPWD;
                }
            }
            if (pass == "1") { goto there; }
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("call38578@gmail.com"); // enter email here 
                mail.To.Add(emailed);
                mail.Subject = "Call Center PassWord";
                mail.Body = pass;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("call38578@gmail.com", "123123123four"); // enter username password here
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            there:
            pass="1";
        }

        private void metroLink1_MouseClick(object sender, MouseEventArgs e)
        {
            metroButton3.Enabled = true;
            metroTextBox3.Enabled = true;
        }
    }
}

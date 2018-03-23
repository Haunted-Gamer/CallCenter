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
    public partial class ADDPROJECT : MetroForm
    {
        DataClasses1DataContext pp = new DataClasses1DataContext();
        public ADDPROJECT()
        {
            InitializeComponent();
            labelUserName.Text = LoginUI.userlogged;
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            CustomerUI sf = new CustomerUI();
            sf.ShowDialog();
            this.Close();
        }

        private void metroButton2_MouseClick(object sender, MouseEventArgs e)
        {
            string paname = textBoxProjectName.Text;
           
            
              int  time = Convert.ToInt32(textBoxProjectTime.Text);
            
            
            PRO news = new PRO
            {   
               puser  = LoginUI.userlogged,
               ptime = time,
                pname = paname,
                pstatus=0
            };
            pp.PROs.InsertOnSubmit(news);

            try
            {
                
                pp.SubmitChanges();
                MessageBox.Show("Add Done");
                textBoxProjectName.Text = "";
                textBoxProjectTime.Text = "";
               
            }
            catch (Exception re)
            {

                //Debug.WriteLine(re);
                MessageBox.Show(re.ToString());
          
            }


        }
    }
}

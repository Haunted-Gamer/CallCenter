using MetroFramework.Forms;
using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.IO;
namespace CallCenter
{
    public partial class RecordUI : MetroForm
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        int i = 0;
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);  
        public RecordUI()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            String me = LoginUI.userlogged;
            
            var query =
            from ssd in db.users
            where ssd.UNAME == me
            select ssd;

            foreach (user ssd in query)
            {
                if (ssd.Vacancy == 0) 
                {
                    MessageBox.Show("YOU ARE NOT VACANT");
                    goto NOPE;
                }
            }


            var dealercontacts = from t1 in db.users
                                 join t2 in db.PROs on t1.UNAME equals t2.puser
                                 select new { t2.pid }; 
          



            //DateTime dt = new DateTime();
            String time = DateTime.Now.ToString("h-mm");
            String date = DateTime.Today.ToString("dd-MM-yy");
            String user = LoginUI.userlogged;
            int intIdt = db.RECORDs.Max(u => u.RecordID)+1;
            String CurDir = Directory.GetCurrentDirectory();
            String path = "d:\\\\" + intIdt.ToString()+"_"+user+"_"+time+"_"+date+".wav";
            String Command ="save "+"recsound "+path;

            MessageBox.Show("Done");
            timer1.Stop();
            timer1.Enabled = false;
            record(Command, "", 0, 0);
            record("close recsound", "", 0, 0);
            metroLabel1.Text = "0";

            RECORD NEW = new RECORD
            {
                RecordID = intIdt,
                User = user,
                PATH = path,
                Duration = i/60
            };
            db.RECORDs.InsertOnSubmit(NEW);
            try {
                db.SubmitChanges();
            }
            
            catch (Exception er) {
                MessageBox.Show("DATABASE ERROR");
            
            }

            NOPE:
            i = 0;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            String me = LoginUI.userlogged;

            var query =
            from ssd in db.users
            where ssd.UNAME == me
            select ssd;

            foreach (user ssd in query)
            {
                if (ssd.Vacancy == 0)
                {
                    MessageBox.Show("YOU ARE NOT VACANT");
                    goto NOE;
                }
            }

           
          
            timer1.Enabled = true;
            timer1.Start();
            record("open new Type waveaudio Alias recsound", "", 0, 0);
            record("record recsound", "", 0, 0);
        NOE:
            i = 0;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            i++;
            metroLabel1.Text = Convert.ToString(i);
        }

        private void buttonBack_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            EmployeeUI epm = new EmployeeUI();
            epm.ShowDialog();
            this.Close();
        }
    }
}

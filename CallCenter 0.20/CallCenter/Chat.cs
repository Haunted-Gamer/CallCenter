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
using System.Net;
using System.Net.Sockets;
namespace CallCenter
{
    public partial class Chat : MetroForm
    {
        DataClasses1DataContext dbc = new DataClasses1DataContext();
        Socket skt;
        EndPoint epLocal, epRemote;
        string name = LoginUI.userlogged;
        public Chat()
        {
            InitializeComponent();
            skt = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            skt.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
           // listMessage.CheckForIllegalCrossThreadCalls = false;
            ListBox.CheckForIllegalCrossThreadCalls = false;
            textLocalIP.Text = GetLocalIP();
            textFriendIP.Text = GetLocalIP();
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach(IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIP.Text), Convert.ToInt32(textLocalPort.Text));
                skt.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(textFriendIP.Text), Convert.ToInt32(textFriendPort.Text));
                skt.Connect(epRemote);

                byte[] buffer = new byte[1500];
                skt.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                buttonStart.Text = "Connected";
                buttonStart.Enabled = false;
                buttonSend.Enabled = true;
                listMessage.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        
    }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(name +": "+textMessage.Text);

                skt.Send(msg);

                listMessage.Items.Add("You: "+textMessage.Text);
                textMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MessageCallBack( IAsyncResult aResult)
        {
            try
            {
                int size = skt.EndReceiveFrom(aResult, ref epRemote);
                if(size > 0)
                {
                    byte[] receiveDate = new byte[1464];
                    receiveDate = (byte[])aResult.AsyncState;
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receiveMessage = eEncoding.GetString(receiveDate);
                    listMessage.Items.Add(receiveMessage);
                }
                byte[] buffer = new byte[1500];
                skt.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void metroButton1_MouseClick(object sender, MouseEventArgs e)
        {
            var q1 = from p in dbc.users
                     where p.UNAME.Contains(LoginUI.userlogged)
                     select p.UPRI;

            
                if (q1.First() == 1)
                {
                    this.Hide();
                    AdminPanelUI adm = new AdminPanelUI();
                    adm.ShowDialog();
                    this.Close();
                    //break;
                }
                else if (q1.First() == 2)
                {
                    this.Hide();
                    EmployeeUI adms = new EmployeeUI();
                    adms.ShowDialog();
                    this.Close();
                 //   break;
                }
       


            
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JustTalk.Serversite;
using JustTalk.Clientsite;
using System.Threading;

namespace JustTalk
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateHost_Click(object sender, EventArgs e)
        {
            createHost();
        }

        private void ConnectRemoteHost_Click(object sender, EventArgs e)
        {
            InformationContainer.nickname = NickName.Text;
            //InformationContainer.selfIP = IPAddress.Text;
            //ClientForm cf = new ClientForm();
            //cf.ShowDialog();
            SocketClient sc = new SocketClient();
            sc.ConfirmConnectionEvent += new SocketClient.ConfirmConnection(ConnectAction);
            ConnectHost(sc);
        }
        

        public void ConnectAction(bool b) {
            if (b)
            {
                createHost();
            }
            else {
                MessageBox.Show("Connection failed!\nChecking the remote IP address please.");
            }
        }

        private void ConnectHost(SocketClient sc) {
            ConnectRemoteHost.Invoke((MethodInvoker)delegate {
                sc.StartClient(IPAddress.Text);
            });
        }
        private void createHost()
        {
            InformationContainer.nickname = NickName.Text;
            HostForm hf = new HostForm();
            hf.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

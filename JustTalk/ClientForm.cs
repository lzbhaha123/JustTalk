using JustTalk.Clientsite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustTalk
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }
        /*
        private void ClientForm_Load(object sender, EventArgs e)
        {
            NicknameLabel.Text += InformationContainer.nickname;
        }

        private void SentButton_Click(object sender, EventArgs e)
        {
            Thread clientThread = new Thread(new ThreadStart(SentMessage));
            clientThread.IsBackground = true;
            clientThread.Start();
        }

        private void SentMessage()
        {
            SentButton.Invoke((MethodInvoker)delegate {
                //SocketClient.StartClient(InformationContainer.remoteIP, MessageInput.Text);
                dialogRichBox.Text += InformationContainer.nickname + ": "+MessageInput.Text + "\n";
                MessageInput.Text = "";

            });



        }*/
    }
}

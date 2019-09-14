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
using JustTalk.Clientsite;
using JustTalk.Serversite;
namespace JustTalk
{
    public partial class HostForm : Form
    {
        public HostForm()
        {
            InitializeComponent();
        }
        Thread hostThread;
        private void HostForm_Load(object sender, EventArgs e)
        {
            NicknameLabel.Text += InformationContainer.nickname;
            hostThread = new Thread(new ThreadStart(createHost));
            hostThread.IsBackground = true;
            hostThread.Start();

        }
        private void createHost()
        {
            SocketObserver so = new SocketObserver();
            so.SetControl(dialogRichBox, IPAddressTextBox);
            so.StartListening();
        }

        private void SentButton_Click(object sender, EventArgs e)
        {
            dialogRichBox.Text += InformationContainer.nickname + ": " + MessageInput.Text + "\n";
            
            Thread clientThread = new Thread(new ThreadStart(SentMessage));
            clientThread.IsBackground = true;
            clientThread.Start(); 
        }

        private void SentMessage()
        {
            for (int i = 0; i < InformationContainer.IPAddresses.Count; i++)
            {
                Console.WriteLine(InformationContainer.IPAddresses[i]);

                SentButton.Invoke((MethodInvoker)delegate {
                    SocketClient sc = new SocketClient();
                    sc.StartClient(InformationContainer.IPAddresses[i],  MessageInput.Text);
                    
                });
            }
            MessageInput.Invoke((MethodInvoker)delegate {
                MessageInput.Text = "";
            });
            
            /*
            SentButton.Invoke((MethodInvoker)delegate {
                SocketClient.StartClient(InformationContainer.selfIP, MessageInput.Text);
            });
            */
        }

    }
}

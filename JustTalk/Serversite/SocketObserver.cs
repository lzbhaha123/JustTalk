using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace JustTalk.Serversite
{
    public class StateReader { 
        public Socket workSocket = null;
        public const int BufferSize = 1024; 
        public byte[] buffer = new byte[BufferSize];  
        public StringBuilder sb = new StringBuilder();
        public int totalReceivedBuffer = 0;
    }
    public class SocketObserver
    {
        private TextBox IpLabel;
        private RichTextBox richTextBox;
        public ManualResetEvent allDone = new ManualResetEvent(false);
        public void SetControl(RichTextBox rtb,TextBox ipLabel) {
            richTextBox = rtb;
            IpLabel = ipLabel;
        }
        public void StartListening() {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);
            IpLabel.Invoke((MethodInvoker)delegate
            {
                string[] IPparts = ipAddress.ToString().Split('%');
                IpLabel.Text = IPparts[0];
                InformationContainer.selfIP = IPparts[0];
            });
            Socket observer = new Socket(ipAddress.AddressFamily,SocketType.Stream,ProtocolType.Tcp);

            try {
                observer.Bind(localEndPoint);
                observer.Listen(100);
                while (true) {
                    allDone.Reset();
                    Console.WriteLine("Waiting for a connection...");
                    observer.BeginAccept(new AsyncCallback(AcceptCallback),observer);
                    
                    allDone.WaitOne();
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();
        }
        public void AcceptCallback(IAsyncResult ar) {
            allDone.Set();
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            

            StateReader stateReader = new StateReader();
            stateReader.workSocket = handler;
            stateReader.totalReceivedBuffer = handler.Available;
            //Console.WriteLine(stateReader.totalReceivedBuffer+"");
            handler.BeginReceive(stateReader.buffer, 0, StateReader.BufferSize-stateReader.totalReceivedBuffer,0, new AsyncCallback(ReadCallback), stateReader);
        }
        public void ReadCallback(IAsyncResult ar) {
            

            string content = String.Empty;

            StateReader stateReader = (StateReader) ar.AsyncState;
            Socket handler = stateReader.workSocket;

            int bytesRead = handler.EndReceive(ar);
            
            if (bytesRead > 0) {
                stateReader.sb.Append(Encoding.ASCII.GetString(stateReader.buffer, 0, bytesRead));
                content = stateReader.sb.ToString();
                
                if (content.IndexOf("<EOF>") > -1|| content.IndexOf("<IPIF>") > -1)
                { 
                    Console.WriteLine("Read {0} bytes from socket. \n Data : {1}",
                        content.Length, content);
                    //richTextBox.Text=content;
                    richTextBox.Invoke((MethodInvoker)delegate
                    {
                        if (content.IndexOf("<IPIF>") == -1)
                        {
                            richTextBox.Text += content.Replace("<EOF>", "\n");
                        }
                        else {
                            InformationContainer.PushIPAddressesIntoLoop(content.Replace("<IPIF>", ""));
                        }
                    });
                    // Echo the data back to the client.  
                    Send(handler, content);
                }
                else
                {
                    handler.BeginReceive(stateReader.buffer, 0, StateReader.BufferSize, 0,
                    new AsyncCallback(ReadCallback), stateReader);
                }
            }
        }

        public void Send(Socket handler, String data)
        {
            
            // Convert the string data to byte data using ASCII encoding.  
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.  
            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.  
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


    }
}

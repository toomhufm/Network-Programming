using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
namespace UDP_Client_Server
{
    public partial class Client : Form
    {
        UdpClient client;
        IPEndPoint endPoint;
        int cPort, sPort;
        Thread thr;
        public Client()
        {
            InitializeComponent();
            serverIP.Text = "127.0.0.1";
            serverPort.Text = "9000";
            clientPort.Text = "1234";
        }


        private void sendBox_Click(object sender, EventArgs e)
        {
            try
            {
                // SEND MESSAGE 
                string msg = $"{DateTime.Now.ToString()} {Environment.NewLine}Client sent: {textBox.Text} {Environment.NewLine}";
                byte[] buffer = Encoding.UTF8.GetBytes(msg);
                client.Send(buffer, buffer.Length, Dns.GetHostName() ,sPort);
                textBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR");
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cPort = int.Parse(clientPort.Text);
                sPort = int.Parse(serverPort.Text);
                client = new UdpClient(cPort);
                endPoint = new IPEndPoint(IPAddress.Any, 0);
                messageBox.AppendText($"Connect to server at port {sPort} {Environment.NewLine} Client at port {cPort} {Environment.NewLine}");
                thr = new Thread(Explore);
                thr.Start();
                connectBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR");
            }
        }

        private void Log(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate { messageBox.AppendText($"{msg}  {Environment.NewLine}"); });
            this.BeginInvoke(invoker);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "Client has gone offline\n";
                byte[] buffer = Encoding.UTF8.GetBytes(msg);
                client.Send(buffer, buffer.Length, endPoint);
                Log("Disconnected\n");
                thr.Abort();
                client.Close();
                connectBtn.Enabled=true;
            }
            catch (ThreadAbortException)
            {
                Thread.ResetAbort();
            }
        }

        private void Explore()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = client.Receive(ref endPoint);
                    string msg = Encoding.UTF8.GetString(buffer);
                    Log(msg);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
        }
    }
}

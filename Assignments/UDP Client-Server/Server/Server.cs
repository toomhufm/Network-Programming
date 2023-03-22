using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
namespace Server
{
    public partial class Server : Form
    {
        UdpClient server;
        IPEndPoint endPoint;
        int port;
        Thread thr;
        public Server()
        {
            InitializeComponent();
            serverPort.Text = "9000";
        }


        private void listenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                port = int.Parse(serverPort.Text);
                server = new UdpClient(port);
                endPoint = new IPEndPoint(IPAddress.Any, 0);
                Log($"Listening on port {port}");
                thr = new Thread(StartServer);
                thr.Start();
                listenBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void Log(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate { messageBox.AppendText($"{msg}  {Environment.NewLine}"); });
            this.BeginInvoke(invoker);
        }

        private void StartServer()
        {
            try
            {
                while (true)
                {
                    // RECEIVED MESSAGE
                    byte[] buffer = server.Receive(ref endPoint);
                    string msg = Encoding.UTF8.GetString(buffer);
                    Log(msg);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void sendBox_Click(object sender, EventArgs e)
        {
            try
            {
                // SEND MESSAGE 
                string msg = $"{DateTime.Now.ToString()} {Environment.NewLine}Server sent: {textBox.Text} {Environment.NewLine}";
                byte[] buffer = Encoding.UTF8.GetBytes(msg);
                server.Send(buffer, buffer.Length, endPoint);
                textBox.Clear();
            }
            catch (ThreadAbortException)
            {
                Thread.ResetAbort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Log("Disconnected\n");
                string msg = "Server has gone offline\n";
                byte[] buffer = Encoding.UTF8.GetBytes(msg);
                server.Send(buffer,buffer.Length, endPoint);
                thr.Abort();
                server.Close();
                listenBtn.Enabled = true;
            }
            catch(ThreadAbortException)
            {
                Thread.ResetAbort();
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }
    }
}

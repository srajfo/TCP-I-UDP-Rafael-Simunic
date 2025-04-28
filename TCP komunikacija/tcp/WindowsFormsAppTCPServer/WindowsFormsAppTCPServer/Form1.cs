using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTCPServer
{
    public partial class Form1 : Form
    {
        TcpListener server;
        Thread serverThread;
        bool isServerRunning = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void bTStartServer_Click(object sender, EventArgs e)
        {
            if (!isServerRunning)
            {
                serverThread = new Thread(StartServer);
                serverThread.IsBackground = true;
                serverThread.Start();
                isServerRunning = true;

                lblStatus.Text = "Running";
                lblStatus.ForeColor = Color.LimeGreen;
                bTStartServer.Enabled = false;
            }
        }
        private void StartServer()
        {
            try
            {
                server = new TcpListener(IPAddress.Parse("127.0.0.1"), 11000);
                server.Start();
                Invoke(new Action(() => listBox1.Items.Add("startani server ")));

                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Invoke(new Action(() => listBox1.Items.Add("poruka: " + message)));

                   
                    byte[] response = Encoding.UTF8.GetBytes("dobivena poruka");
                    stream.Write(response, 0, response.Length);

                    client.Close();
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() => MessageBox.Show(ex.Message)));
            }
        }
    }
}
